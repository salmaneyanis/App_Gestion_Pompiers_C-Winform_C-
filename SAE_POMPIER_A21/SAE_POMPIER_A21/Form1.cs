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
            var maConnexion = Connexion.Connec;
            this.WindowState = FormWindowState.Maximized;

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

               uc.Margin = new Padding(40, 20, 40, 20); // Espace vertical entre les UserControls
                // Ajoute au FlowLayoutPanel  
                flp_uc.Controls.Add(uc);
            }
        }
    }
}
