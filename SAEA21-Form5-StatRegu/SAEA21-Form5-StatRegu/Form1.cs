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
        }

        private void DeselectCaserne()
        {
            grpSelectionCaserne.Visible = false;
            rdbCaserne1.Checked = false;
            rdbCaserne2.Checked = false;
            rdbCaserne3.Checked = false;
            rdbCaserne4.Checked = false;
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
    }
}
