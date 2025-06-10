using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmGestionDesPompiers;
using SAE_POMPIER_A21;

namespace SEAA21_Form4
{
    public partial class frmGestionDesPompiers : Form
    {
        bool chargementDonnees = false;
        bool changementCaserne = false;
        bool changementGrade = false;
        bool changementConge = false;
        bool enConge = false;
        string matriculePompier = "";

        public frmGestionDesPompiers()
        {
            InitializeComponent();
            this.ShowInTaskbar = false; // ⚠️ Obligatoire
            this.FormClosing += (s, e) =>
            {
                e.Cancel = true;  // Empêche la fermeture
                this.Hide();      // Cache à la place
            };
            this.WindowState = FormWindowState.Maximized;

            btnConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMoins.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;

            btnConnexion.FlatStyle = FlatStyle.Flat;
            btnConnexion.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 253, 255);

            btnMoins.FlatStyle = FlatStyle.Flat;
            btnMoins.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 253, 255);

            btnNouveau.FlatStyle = FlatStyle.Flat;
            btnNouveau.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 253, 255);

            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 253, 255);
        }

        private void frmGestionDesPompiers_Load(object sender, EventArgs e)
        {
            //fill combos


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
                cmbChoixCaserne.Items.Add(reader.GetString(0));
                cmbCaserneRattachement.Items.Add(reader.GetString(0));
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
                cmbGrade.Items.Add(reader.GetString(0));
            }
        }

        private void cmbChoixCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPompier.Items.Clear();

            string requete = @"SELECT p.nom FROM Pompier p JOIN Affectation a ON a.matriculePompier = p.matricule JOIN Caserne c ON c.id = a.idCaserne WHERE c.nom = @nomCaserne AND a.dateFin IS NULL;";

            using (SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec))
            {
                cmd.Parameters.AddWithValue("@nomCaserne", cmbChoixCaserne.Text);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nomPompier = reader.GetString(0);
                        cmbPompier.Items.Add(nomPompier);
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbPompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirLabel();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            grpInformationPlus.Visible = true;
            btnPlus.Visible = false;
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            grpInformationPlus.Visible = false;
            btnPlus.Visible = true;
        }

        private void RemplirLabel()
        {
            viderLabel();
            string requete = "SELECT * FROM Pompier WHERE nom = '" + cmbPompier.Text + "';";
            SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            lblMatricule.Text += " " + reader.GetInt32(0).ToString();
            matriculePompier = reader.GetInt32(0).ToString();
            lblNom.Text += " " + reader.GetString(1);
            lblPrenom.Text += " " + reader.GetString(2);
            if (reader.GetString(3) == "m")
            {
                lblSexe.Text += " " + "Homme";
            }
            else if (reader.GetString(3) == "f")
            {
                lblSexe.Text += " " + "Femme";
            }
            else
            {
                lblSexe.Text += " " + "Autre";
            }
            lblDateDeNaissance.Text += " " + reader.GetString(4);
            if (reader.GetString(5) == "p")
            {
                rdbPro.Checked = true;
            }
            else
            {
                rdbVolontaire.Checked = true;
            }
            if (!reader.IsDBNull(6))
                lblTel.Text += " " + reader.GetValue(6).ToString();
            else
                lblTel.Text += " N/A";
            if (!reader.IsDBNull(7))
                lblBIP.Text += " " + reader.GetInt32(7).ToString();
            else
                lblBIP.Text += " N/A";
            if (reader.GetInt32(9) == 1)
            {
                chkConge.Checked = true;
                enConge = true;
            }
            else
            {
                chkConge.Checked = false;
                enConge = false;
            }
            lblGrade.Text += " " + reader.GetString(10);
            lblGrade2.Text += " " + reader.GetString(10);
            lblDateEmbauche.Text += " " + reader.GetDateTime(11).ToString("dd/MM/yyyy").ToString();
            lblRattachement.Text += " " + cmbChoixCaserne.Text;
            if (reader.GetString(10) == "ADJ")
            {
                pctGrade.Image = Properties.Resources.ADJ;
            }
            else if (reader.GetString(10) == "ADC")
            {
                pctGrade.Image = Properties.Resources.ADC;
            }
            else if (reader.GetString(10) == "CCH")
            {
                pctGrade.Image = Properties.Resources.CCH;
            }
            else if (reader.GetString(10) == "CDT")
            {
                pctGrade.Image = Properties.Resources.CDT;
            }
            else if (reader.GetString(10) == "CPL")
            {
                pctGrade.Image = Properties.Resources.CPL;
            }
            else if (reader.GetString(10) == "SAP")
            {
                pctGrade.Image = Properties.Resources.SAP;
            }
            else if (reader.GetString(10) == "CNE")
            {
                pctGrade.Image = Properties.Resources.CNE;
            }
            else if (reader.GetString(10) == "COL")
            {
                pctGrade.Image = Properties.Resources.COL;
            }
            else if (reader.GetString(10) == "CPL")
            {
                pctGrade.Image = Properties.Resources.CPL;
            }
            else if (reader.GetString(10) == "LCL")
            {
                pctGrade.Image = Properties.Resources.LCL;
            }
            else if (reader.GetString(10) == "LTN")
            {
                pctGrade.Image = Properties.Resources.LTN;
            }
            else if (reader.GetString(10) == "SAP1")
            {
                pctGrade.Image = Properties.Resources.SAP1;
            }
            else if (reader.GetString(10) == "SCH")
            {
                pctGrade.Image = Properties.Resources.SCH;
            }
            else if (reader.GetString(10) == "SGT")
            {
                pctGrade.Image = Properties.Resources.SGT;
            }
            cmbCaserneRattachement.Text = cmbChoixCaserne.Text;
            cmbGrade.Text = reader.GetString(10);
            //nb habilitation
            requete = "SELECT COUNT(*) FROM Passer WHERE matriculePompier = '" + matriculePompier + "';";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            reader = cmd.ExecuteReader();
            reader.Read();
            int nbHabilitation = reader.GetInt32(0);
            requete = "SELECT p.dateObtention, h.libelle FROM Habilitation h JOIN Passer p ON h.id = p.idHabilitation WHERE p.matriculePompier = '" + matriculePompier + "';";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            reader = cmd.ExecuteReader();
            for (int i = 0; i < nbHabilitation; i++)
            {
                if (reader.Read())
                {
                    string dateObtention = reader.GetString(0).Substring(0, 10); // On prend les 10 premiers caractères pour la date
                    string libelleHabilitation = reader.GetString(1);
                    lstbHabilitations.Items.Add(dateObtention + " - " + libelleHabilitation);
                }
            }
            //nb affectation
            requete = "SELECT COUNT(*) FROM Affectation WHERE matriculePompier = '" + matriculePompier + "';";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            reader = cmd.ExecuteReader();
            reader.Read();
            int nbAffectation = reader.GetInt32(0);
            requete = "SELECT a.dateA, c.nom FROM Affectation a JOIN Caserne c ON c.id = a.idCaserne WHERE a.matriculePompier = '" + matriculePompier + "';";
            cmd = new SQLiteCommand(requete, Connexion.Connec);
            reader = cmd.ExecuteReader();
            for (int i = 0; i < nbAffectation; i++)
            {
                if (reader.Read())
                {
                    string dateAffectation = reader.GetString(0).Substring(0, 10);
                    string nomCaserne = reader.GetString(1);
                    lstbAffectations.Items.Add(dateAffectation + " - " + nomCaserne);
                }
            }
            chargementDonnees = false;
        }

        private void passerEnAdmin()
        {
            btnPlus.Visible = true;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            FormMDP formMDP = new FormMDP();
            formMDP.ShowDialog();
            if (formMDP.DialogResult == DialogResult.OK)
            {
                if ((formMDP.Nom == "vrichard" && formMDP.Mdp == "mdpVero") || (formMDP.Nom == "hlhelguen" && formMDP.Mdp == "mdpHerve"))
                {
                    passerEnAdmin();
                    MessageBox.Show("Connexion réussie !");
                }
                else
                {
                    MessageBox.Show("Identifiants incorrects.");
                }
            }
            else
            {
                MessageBox.Show("Connexion annulée.");
            }
        }

        private void cmbCaserneRattachement_Leave(object sender, EventArgs e)
        {
            if ("Rattachement :  " + cmbCaserneRattachement.Text != lblRattachement.Text )
            {
                MessageBox.Show("Le rattachement a été modifié.");
                changementCaserne = true;
            }
        }

        private void cmbGrade_Leave(object sender, EventArgs e)
        {
            if ("Grade :  " + cmbGrade.Text != lblGrade.Text)
            {
                MessageBox.Show("Le grade a été modifié.");
                changementCaserne = true;
            }
        }

        private void chkConge_Click(object sender, EventArgs e)
        {
            if (!chargementDonnees && !string.IsNullOrEmpty(matriculePompier))
            {
                int valeurConge = chkConge.Checked ? 1 : 0;

                string requete = "UPDATE Pompier SET enConge = @conge WHERE matricule = @matricule";
                using (SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@conge", valeurConge);
                    cmd.Parameters.AddWithValue("@matricule", matriculePompier);

                    try
                    {
                        if (Connexion.Connec.State != ConnectionState.Open)
                            Connexion.Connec.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("État de congé mis à jour avec succès.");
                            enConge = chkConge.Checked;
                            RemplirLabel();
                        }
                        else
                        {
                            MessageBox.Show("Aucune ligne mise à jour. Vérifiez le matricule.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un pompier et une caserne.");
            }
        }

        private void chkConge_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passerEnAdmin();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cmbCaserneRattachement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chargementDonnees && !string.IsNullOrEmpty(matriculePompier))
            {
                int idNouvelleCaserne = cmbCaserneRattachement.SelectedIndex + 1;
                if (!chargementDonnees && !string.IsNullOrEmpty(matriculePompier))
                {

                    // Vérifie s'il y a déjà une affectation active
                    string verifRequete = "SELECT idCaserne FROM Affectation WHERE matriculePompier = @matricule AND dateFin IS NULL";
                    using (SQLiteCommand verifCmd = new SQLiteCommand(verifRequete, Connexion.Connec))
                    {
                        verifCmd.Parameters.AddWithValue("@matricule", matriculePompier);
                        object result = verifCmd.ExecuteScalar();

                        if (result != null)
                        {
                            int idAncienneCaserne = Convert.ToInt32(result);

                            // Si la caserne n’a pas changé, ne rien faire
                            if (idAncienneCaserne == idNouvelleCaserne)
                            {
                                MessageBox.Show("Le pompier est déjà affecté à cette caserne.");
                                return;
                            }

                            // Clôture de l'ancienne affectation
                            string clotureRequete = "UPDATE Affectation SET dateFin = @dateFin WHERE matriculePompier = @matricule AND dateFin IS NULL";
                            using (SQLiteCommand clotureCmd = new SQLiteCommand(clotureRequete, Connexion.Connec))
                            {
                                clotureCmd.Parameters.AddWithValue("@dateFin", DateTime.Today.ToString("yyyy-MM-dd"));
                                clotureCmd.Parameters.AddWithValue("@matricule", matriculePompier);
                                clotureCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Insertion de la nouvelle affectation
                    string requete = "INSERT INTO Affectation (matriculePompier, dateA, dateFin, idCaserne) VALUES (@matricule, @dateA, NULL, @idCaserne)";
                    using (SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matriculePompier);
                        cmd.Parameters.AddWithValue("@dateA", DateTime.Today.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@idCaserne", idNouvelleCaserne);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Nouvelle affectation enregistrée !");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ce pompier a déjà était muté aujourd'hui");
                        }
                    }
                }
                cmbChoixCaserne.Text = cmbCaserneRattachement.Text;
                lstbAffectations.Items.Clear();
                RemplirLabel();
            }
            else if (!chargementDonnees)
            {
                MessageBox.Show("Veuillez sélectionner un pompier et une caserne.");
            }
        }

        private void viderLabel()
        {
            chargementDonnees = true;
            lblMatricule.Text = "Matricule : ";
            lblNom.Text = "Nom : ";
            lblPrenom.Text = "Prénom : ";
            lblSexe.Text = "Sexe : ";
            lblDateDeNaissance.Text = "Date de naissance : ";
            lblTel.Text = "Téléphone : ";
            lblBIP.Text = "BIP : ";
            lblGrade.Text = "Grade : ";
            lblGrade2.Text = "Grade : ";
            lblDateEmbauche.Text = "Date d'embauche : ";
            lblRattachement.Text = "Rattachement : ";
            lstbAffectations.Items.Clear();
            lstbHabilitations.Items.Clear();
        }

        private void cmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chargementDonnees && !string.IsNullOrEmpty(matriculePompier))
            {
                string nouveauGrade = cmbGrade.Text;
                // Vérification si le grade a changé
                if (lblGrade.Text != "Grade : " + nouveauGrade)
                {
                    string requete = "UPDATE Pompier SET codeGrade = @grade WHERE matricule = @matricule";
                    using (SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec))
                    {
                        cmd.Parameters.AddWithValue("@grade", nouveauGrade);
                        cmd.Parameters.AddWithValue("@matricule", matriculePompier);
                        try
                        {
                            if (Connexion.Connec.State != ConnectionState.Open)
                                Connexion.Connec.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Grade mis à jour avec succès.");
                                RemplirLabel();
                            }
                            else
                            {
                                MessageBox.Show("Aucune ligne mise à jour. Vérifiez le matricule.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
                        }
                    }
                }
            }
            else if (!chargementDonnees)
            {
                MessageBox.Show("Veuillez sélectionner un pompier et une caserne.");
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            //Appel de la fenêtre de création d'un nouveau pompier
            CreerNouveauPompier formCreerNouveauPompier = new CreerNouveauPompier();
            formCreerNouveauPompier.ShowDialog();
            if (formCreerNouveauPompier.DialogResult == DialogResult.OK)
            {
                // Si le pompier a été créé avec succès, on peut mettre à jour la liste des pompiers
                cmbChoixCaserne_SelectedIndexChanged(sender, e);
                MessageBox.Show("Nouveau pompier créé avec succès !");
            }
        }
    }
}
