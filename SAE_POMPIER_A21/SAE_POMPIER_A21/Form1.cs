using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using User_Control_Missions_TDB;

namespace SAE_POMPIER_A21
{
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
            this.IsMdiContainer = false; // ⚠️ Doit être false
            this.ShowInTaskbar = true;   // Seul le main form reste dans la barre des tâches
            var maConnexion = Connexion.Connec;
            this.WindowState = FormWindowState.Maximized;
            chk_encours.Appearance = Appearance.Button;
            chk_encours.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            chk_encours.TextAlign = ContentAlignment.MiddleCenter;
            chk_encours.FlatStyle = FlatStyle.Flat;
            chk_encours.FlatAppearance.BorderSize = 2;
            chk_encours.FlatAppearance.BorderColor = Color.DimGray;
            chk_encours.BackColor = Color.WhiteSmoke;
            chk_encours.Size = new Size(120, 50);
            chk_encours.AutoSize = false;

            Color couleurNormale = Color.WhiteSmoke;
            Color couleurHover = Color.FromArgb(184, 222, 239);
            Color couleurPressed = Color.FromArgb(144, 243, 255);

            chk_encours.Cursor = System.Windows.Forms.Cursors.Hand;

            // Modifie les événements existants pour tenir compte de l'état Checked
            chk_encours.MouseEnter += (s, e) => {
                chk_encours.BackColor = couleurPressed;
            };
            chk_encours.MouseDown += (s, e) =>
            { 
                chk_encours.BackColor = couleurPressed;
            };
            chk_encours.MouseUp += (s, e) =>
            {
                chk_encours.BackColor = couleurPressed;
            };

            chk_encours.MouseLeave += (s, e) => {
                if (!chk_encours.Checked)
                    chk_encours.BackColor = couleurNormale;
                else
                    chk_encours.BackColor = couleurPressed; // Si coché, reste en couleur pressed
            };

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Charger_FLpanel(sender, e);
        }

        private void missions_UC1_Load(object sender, EventArgs e)
        {

        }

        private void missions_UC1_Load_1(object sender, EventArgs e)
        {

        }

        private void missions_UC2_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }

        private void Charger_FLpanel(object sender, EventArgs e)
        {
            // Efface le FlowLayoutPanel avant de le remplir
            flp_uc.Controls.Clear();

            int id = 0;
            string date_depart = string.Empty;
            string date_retour = string.Empty;
            string motif = string.Empty;
            string adresse = string.Empty;
            string cp = string.Empty;
            string ville = string.Empty;
            int terminee = 0;
            string compteRendu = string.Empty;
            string sinistre = string.Empty;
            string caserne = "test_caser";
            int idcaserne = 0;

            MesDatas.ChargerMissions();

            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];

            foreach (DataRow row in dtMissions.Rows)
            {
                id = Convert.ToInt32(row["ID"]);
                date_depart = row["dateHeureDepart"].ToString();
                date_retour = row["dateHeureRetour"].ToString();
                motif = row["motifAppel"].ToString();
                adresse = row["adresse"].ToString();
                cp = row["cp"].ToString();
                ville = row["ville"].ToString();
                terminee = Convert.ToInt32(row["terminee"]);
                compteRendu = row["compteRendu"].ToString();
                int natureSinistre = Convert.ToInt32(row["idNatureSinistre"]);
                int idCaserne = Convert.ToInt32(row["idCaserne"]);

                MesDatas.ChargerSinistre();
                DataTable dtNatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"];
                foreach (DataRow sinistreRow in dtNatureSinistre.Rows)
                {
                    if (natureSinistre == Convert.ToInt32(sinistreRow["id"]))
                    {
                        sinistre = sinistreRow["libelle"].ToString();
                        break;
                    }
                    else
                    {
                        sinistre = "Non défini";
                    }
                }

                MesDatas.ChargerCaserne();
                DataTable dtCaserne = MesDatas.DsGlobal.Tables["Caserne"];
                foreach (DataRow caserneRow in dtCaserne.Rows)
                {
                    if (idCaserne == Convert.ToInt32(caserneRow["id"]))
                    {
                        caserne = caserneRow["nom"].ToString();
                        break;
                    }
                    else
                    {
                        caserne = "Non défini";
                    }
                }

                // Crée une instance du UserControl
                Missions_UC uc = new Missions_UC(id, date_depart, date_retour, motif, adresse, cp, ville, terminee, compteRendu, natureSinistre, sinistre, caserne);
                uc.CloturerMissionDemande += CloturerMission;


                uc.Margin = new Padding(40, 20, 40, 20); // Espace vertical entre les UserControls
                // Ajoute au FlowLayoutPanel  
                flp_uc.Controls.Add(uc);
            }
        }

        private void Charger_FLpanel_enCours(object sender, EventArgs e)
        {
            // Efface le FlowLayoutPanel avant de le remplir
            flp_uc.Controls.Clear();

            MesDatas.ChargerMissions();

            DataTable dtMissions = MesDatas.DsGlobal.Tables["Mission"];

            // Filtre uniquement les missions terminées
            DataRow[] missionsTerminees = dtMissions.Select("terminee = 0");

            foreach (DataRow row in missionsTerminees)
            {
                int id = Convert.ToInt32(row["ID"]);
                string date_depart = row["dateHeureDepart"].ToString();
                string date_retour = row["dateHeureRetour"].ToString();
                string motif = row["motifAppel"].ToString();
                string adresse = row["adresse"].ToString();
                string cp = row["cp"].ToString();
                string ville = row["ville"].ToString();
                int terminee = Convert.ToInt32(row["terminee"]);
                string compteRendu = row["compteRendu"].ToString();
                int natureSinistre = Convert.ToInt32(row["idNatureSinistre"]);
                int idCaserne = Convert.ToInt32(row["idCaserne"]);
                string sinistre = "Non défini";
                string caserne = "Non défini";

                MesDatas.ChargerSinistre();
                DataTable dtNatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"];
                foreach (DataRow sinistreRow in dtNatureSinistre.Rows)
                {
                    if (natureSinistre == Convert.ToInt32(sinistreRow["id"]))
                    {
                        sinistre = sinistreRow["libelle"].ToString();
                        break;
                    }
                }

                MesDatas.ChargerCaserne();
                DataTable dtCaserne = MesDatas.DsGlobal.Tables["Caserne"];
                foreach (DataRow caserneRow in dtCaserne.Rows)
                {
                    if (idCaserne == Convert.ToInt32(caserneRow["id"]))
                    {
                        caserne = caserneRow["nom"].ToString();
                        break;
                    }
                }

                // Crée une instance du UserControl
                Missions_UC uc = new Missions_UC(id, date_depart, date_retour, motif, adresse, cp, ville, terminee, compteRendu, natureSinistre, sinistre, caserne);
                uc.CloturerMissionDemande += CloturerMission;
                uc.Margin = new Padding(40, 20, 40, 20);
                flp_uc.Controls.Add(uc);
            }
        }


        private void CloturerMission(object sender, int idMission)
        {
            // Récupération de la mission
            DataRow mission = MesDatas.DsGlobal.Tables["Mission"].Select($"id = {idMission}").FirstOrDefault();
            if (mission == null)
            {
                MessageBox.Show("Mission introuvable.");
                return;
            }

            // Demande du compte-rendu
            string compteRendu = ShowInputDialog("Entrez un compte-rendu :", "Clôture de la mission", mission["compteRendu"].ToString());
            if (string.IsNullOrWhiteSpace(compteRendu)) compteRendu = null;

            // 1. Mise à jour de la mission
            using (var cmd = new SQLiteCommand("UPDATE Mission SET dateHeureRetour = @retour, compteRendu = @compte, terminee = 1 WHERE id = @id", Connexion.Connec))
            {
                cmd.Parameters.AddWithValue("@retour", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                cmd.Parameters.AddWithValue("@compte", compteRendu);
                cmd.Parameters.AddWithValue("@id", idMission);
                cmd.ExecuteNonQuery();
            }

            // 2. Mise à jour des engins et réparations éventuelles
            MesDatas.ChargerPartirAvec();
            foreach (DataRow row in MesDatas.DsGlobal.Tables["PartirAvec"].Select($"idMission = {idMission}"))
            {
                string code = row["codeTypeEngin"].ToString();
                int numero = Convert.ToInt32(row["numeroEngin"]);

                string reparations = ShowInputDialog(
                    $"Réparations pour Engin {code} n°{numero} :",
                    "Réparations éventuelles",
                    row["reparationsEventuelles"]?.ToString() ?? ""
                );
                if (string.IsNullOrWhiteSpace(reparations)) reparations = null;

                using (var cmd = new SQLiteCommand("UPDATE Engin SET enMission = 0 WHERE codeTypeEngin = @code AND numero = @num", Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@num", numero);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SQLiteCommand("UPDATE PartirAvec SET reparationsEventuelles = @rep WHERE idMission = @id AND codeTypeEngin = @code AND numeroEngin = @num", Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@rep", reparations);
                    cmd.Parameters.AddWithValue("@id", idMission);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@num", numero);
                    cmd.ExecuteNonQuery();
                }
            }

            // 3. Mise à jour des pompiers
            MesDatas.ChargerMobiliser();
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Mobiliser"].Select($"idMission = {idMission}"))
            {
                string matricule = row["matriculePompier"].ToString();
                using (var cmd = new SQLiteCommand("UPDATE Pompier SET enMission = 0 WHERE matricule = @matricule", Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    cmd.ExecuteNonQuery();
                }
            }

            // 4. Rechargement de l’affichage
            flp_uc.Controls.Clear();
            Charger_FLpanel(this, EventArgs.Empty);
            chk_encours.Checked = false; // Réinitialise l'état de la case à cocher
            MessageBox.Show("Mission clôturée avec succès !");
        }


        private string ShowInputDialog(string text, string caption, string defaultValue = "")
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 10, Top = 20, Text = text, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 10, Top = 50, Width = 360, Text = defaultValue };
            Button confirmation = new Button() { Text = "OK", Left = 290, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : defaultValue;
        }

        private void chk_encours_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_encours.Checked)
            {
                Charger_FLpanel_enCours(sender, e);
            }
            else
            {
                flp_uc.Controls.Clear();
                Charger_FLpanel(sender, e);
            }
        }


    }
}
