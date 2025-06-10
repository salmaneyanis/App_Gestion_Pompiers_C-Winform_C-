using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmGestionDesPompiers;
using SAE_POMPIER_A21;

namespace SEAA21_Form4
{
    public partial class CreerNouveauPompier : Form
    {
        public CreerNouveauPompier()
        {
            InitializeComponent();

            btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            btnValider.Cursor = System.Windows.Forms.Cursors.Hand;

            btnValider.FlatStyle = FlatStyle.Flat;
            btnValider.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 253, 255);

            btnAnnuler.FlatStyle = FlatStyle.Flat;
            btnAnnuler.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 253, 255);
        }

        private void CreerNouveauPompier_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Homme");
            comboBox1.Items.Add("Femme");
            comboBox1.Items.Add("Autre");

            string requete = "SELECT COUNT(*) FROM Caserne";
            SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int nbCaserne = reader.GetInt32(0);

            for (int i = 0; i < nbCaserne; i++)
            {
                requete = "SELECT Nom FROM Caserne WHERE ID = " + (i + 1);
                cmd = new SQLiteCommand(requete, Connexion.Connec);
                reader = cmd.ExecuteReader();
                reader.Read();
                comboBox3.Items.Add(reader.GetString(0));
            }

            requete = "SELECT COUNT(*) FROM Grade";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            reader = cmd.ExecuteReader();
            reader.Read();
            int nbGrade = reader.GetInt32(0);

            for (int i = 0; i < nbGrade; i++)
            {
                requete = "SELECT code FROM Grade WHERE chaine = '" + (i + 1) + "'";
                cmd = new SQLiteCommand(requete, Connexion.Connec);
                reader = cmd.ExecuteReader();
                reader.Read();
                comboBox2.Items.Add(reader.GetString(0));
            }
        
            //Remplir Date
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Le nom ne peut pas être vide.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Le prénom ne peut pas être vide.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Le matricule ne peut pas être vide.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un sexe.");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("La date de naissance ne peut pas être vide.");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Le nom ne peut pas être vide.");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Le prénom ne peut pas être vide.");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Le matricule ne peut pas être vide.");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un sexe.");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("La date de naissance ne peut pas être vide.");
            }
            else if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un grade.");
            }
            else if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner une caserne.");
            }
            else
            {
                string matricule = textBox3.Text.Trim();
                string nom = textBox1.Text.Trim();
                string prenom = textBox2.Text.Trim();
                string sexe = comboBox1.SelectedItem.ToString();
                string dateNaissance = textBox6.Text.Trim();
                string codeGrade = comboBox2.SelectedItem.ToString();
                string nomCaserne = comboBox3.SelectedItem.ToString();
                string type = "v";
                string dateEmbauche = DateTime.Today.ToString("yyyy-MM-dd");
                int enMission = 0;
                int enConge = 0;
                string portable = null;
                object bip = DBNull.Value;

                // Sécurisation date
                DateTime dtNaiss;
                if (!DateTime.TryParse(dateNaissance, out dtNaiss))
                {
                    MessageBox.Show("La date de naissance est invalide.");
                    return;
                }
                dateNaissance = dtNaiss.ToString("yyyy-MM-dd");

                // Vérifie si matricule déjà utilisé
                string verif = "SELECT COUNT(*) FROM Pompier WHERE matricule = @matricule";
                using (var cmd = new SQLiteCommand(verif, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Ce matricule est déjà utilisé.");
                        return;
                    }
                }

                // Récupération ID caserne
                int idCaserne;
                string getIDCaserne = "SELECT ID FROM Caserne WHERE Nom = @nom";
                using (var cmd = new SQLiteCommand(getIDCaserne, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@nom", nomCaserne);
                    idCaserne = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Insertion Pompier
                string insert = @"INSERT INTO Pompier (matricule, nom, prenom, sexe, dateNaissance, type, portable, bip, enMission, enConge, codeGrade, dateEmbauche)
                  VALUES (@mat, @nom, @prenom, @sexe, @dateNaiss, @type, @portable, @bip, @enMission, @enConge, @grade, @dateEmb)";
                using (var cmd = new SQLiteCommand(insert, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@mat", matricule);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@sexe", sexe);
                    cmd.Parameters.AddWithValue("@dateNaiss", dateNaissance);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@portable", (object)portable ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@bip", bip);
                    cmd.Parameters.AddWithValue("@enMission", enMission);
                    cmd.Parameters.AddWithValue("@enConge", enConge);
                    cmd.Parameters.AddWithValue("@grade", codeGrade);
                    cmd.Parameters.AddWithValue("@dateEmb", dateEmbauche);
                    cmd.ExecuteNonQuery();
                }

                // Insertion Affectation
                string dateA = DateTime.Today.ToString("yyyy-MM-dd");
                string verifAffect = "SELECT COUNT(*) FROM Affectation WHERE matriculePompier = @mat AND dateA = @dateA";
                using (var cmd = new SQLiteCommand(verifAffect, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@mat", matricule);
                    cmd.Parameters.AddWithValue("@dateA", dateA);
                    int countAffect = Convert.ToInt32(cmd.ExecuteScalar());
                    if (countAffect > 0)
                    {
                        MessageBox.Show("Ce pompier a déjà une affectation aujourd’hui.");
                        return;
                    }
                }

                string insertAffect = @"INSERT INTO Affectation (matriculePompier, idCaserne, dateA)
                        VALUES (@mat, @idCaserne, @dateA)";
                using (var cmd = new SQLiteCommand(insertAffect, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@mat", matricule);
                    cmd.Parameters.AddWithValue("@idCaserne", idCaserne);
                    cmd.Parameters.AddWithValue("@dateA", dateA);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Pompier et affectation enregistrés !");
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // Fermer le formulaire sans enregistrer
            this.Close();
        }
    }
}
