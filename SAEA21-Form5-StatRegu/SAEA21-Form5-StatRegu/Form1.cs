using System;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Windows.Forms;
using SAE_POMPIER_A21;

namespace SAEA21_Form5_StatRegu
{
    public partial class FrmStatistiques : Form
    {
        public FrmStatistiques()
        {
            InitializeComponent();
            this.ShowInTaskbar = false; // ⚠️ Obligatoire
            this.FormClosing += (s, e) =>
            {
                e.Cancel = true;  // Empêche la fermeture
                this.Hide();      // Cache à la place
            };
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmStatistiques_Load(object sender, EventArgs e)
        {
            // On remplit cmbSelectionStat avec les statistiques disponibles
            cmbSelectionStat.Items.Add("Engins les plus utilisés");
            cmbSelectionStat.Items.Add("Cumul d’utilisation engins en heure");
            cmbSelectionStat.Items.Add("Nombre d'interventions par type de sinistre");
            cmbSelectionStat.Items.Add("Habilitations les plus sollicitées");
            cmbSelectionStat.Items.Add("Liste des pompiers par habilitation");

            DeselectCaserne();



        }

        private void cmbSelectionStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On vide le dataGridView avant de charger une nouvelle statistique
            dataGridView1.DataSource = null;
            DeselectCaserne();

            switch (cmbSelectionStat.SelectedIndex)
            {
                case 0:
                    SelectCaserne();
                    break;

                case 1:
                    SelectCaserne();
                    break;
                case 2:
                    DeselectCaserne();
                    ChargerNbInterventions();
                    break;
                case 3:
                    DeselectCaserne();
                    ChargerHabilitations();
                    break;
                case 4:
                    DeselectCaserne();
                    ChargerListePompiers();
                    break;
                default:
                    break;
            }
        }

        private void SelectCaserne()
        {
            grpSelectionCaserne.Visible = true;
            GenererRadioButtonsCaserne();
        }

        private void DeselectCaserne()
        {
            grpSelectionCaserne.Visible = false;
        }

        private void ChargerEnginsLesPlusUtilises(int x)
        {
            try
            {
                string requete = "SELECT Te.nom, p.numeroEngin, COUNT(*) AS nombre_utilisations FROM PartirAvec p JOIN TypeEngin Te ON Te.code = p.codeTypeEngin WHERE p.idCaserne = " + x.ToString() + " GROUP BY p.numeroEngin ORDER BY nombre_utilisations DESC;";

                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerCumulUtilisationEngins(int x)
        {
            try
            {
                string requete = "SELECT Te.nom, p.numeroEngin, ROUND(SUM(julianday(M.dateHeureRetour) - julianday(M.dateHeureDepart)), 3) * 24 AS nbHeureUtilisation FROM PartirAvec p JOIN TypeEngin Te ON Te.code = p.codeTypeEngin JOIN Mission m ON m.id = p.idMission WHERE p.idCaserne = " + x.ToString() + " GROUP BY p.numeroEngin ORDER BY nbHeureUtilisation DESC;";

                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerNbInterventions()
        {
            try
            {
                string requete = "SELECT NS.libelle AS type_sinistre, COUNT(*) AS nombre_interventions " +
                                "FROM Mission M " +
                                "JOIN NatureSinistre NS ON M.idNatureSinistre = NS.id " +
                                "GROUP BY NS.libelle " +
                                "ORDER BY nombre_interventions DESC";

                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerHabilitations()
        {
            try
            {
                string requete = "SELECT H.libelle, COUNT(*) AS nombre_utilisations " +
                    "FROM Mobiliser MO " +
                    "JOIN Habilitation H ON MO.idHabilitation = H.id " +
                    "GROUP BY H.libelle " +
                    "ORDER BY nombre_utilisations DESC;";

                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerListePompiers()
        {
            try
            {
                string requete = "SELECT H.libelle, P.nom, P.prenom FROM Habilitation H LEFT JOIN Passer PA ON H.id = PA.idHabilitation LEFT JOIN Pompier P ON PA.matriculePompier = P.matricule ORDER BY H.libelle, P.nom, P.prenom;";

                SQLiteDataAdapter da = new SQLiteDataAdapter(requete, Connexion.Connec);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void rdbCaserne1_CheckedChanged(object sender, EventArgs e)
        {
            ChargerCaserne(1);
        }

        private void rdbCaserne2_CheckedChanged(object sender, EventArgs e)
        {
            ChargerCaserne(2);
        }

        private void rdbCaserne3_CheckedChanged(object sender, EventArgs e)
        {
            ChargerCaserne(3);
        }

        private void rdbCaserne4_CheckedChanged(object sender, EventArgs e)
        {
            ChargerCaserne(4);
        }

        private void ChargerCaserne(int x)
        {
            if (cmbSelectionStat.SelectedIndex == 0)
            {
                ChargerEnginsLesPlusUtilises(x);
            }
            else if (cmbSelectionStat.SelectedIndex == 1)
            {
                ChargerCumulUtilisationEngins(x);
            }
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void GenererRadioButtonsCaserne()
        {
            grpSelectionCaserne.Controls.Clear(); // Supprimer les anciens RadioButtons

            string requete = "SELECT id, nom FROM Caserne ORDER BY id";
            SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);

            int top = 20; // Position Y de départ
            int margin = 25; // Espace entre chaque RadioButton

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string nom = dr.GetString(1);

                    RadioButton rdb = new RadioButton();
                    rdb.Text = nom;
                    rdb.Tag = id;
                    rdb.Left = 10;      // Position X
                    rdb.Top = top;      // Position Y
                    rdb.AutoSize = true;
                    rdb.CheckedChanged += Rdb_CheckedChanged;

                    grpSelectionCaserne.Controls.Add(rdb);

                    top += margin; // Incrémente la position Y pour le suivant
                }
            }
        }


        private void Rdb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            if (rdb != null && rdb.Checked)
            {
                int idCaserne = (int)rdb.Tag;
                ChargerCaserne(idCaserne);
            }
        }
    }
}
