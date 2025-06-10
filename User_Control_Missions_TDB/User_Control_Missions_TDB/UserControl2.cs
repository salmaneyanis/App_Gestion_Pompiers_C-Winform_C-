using SAE_POMPIER_A21;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Control_Missions_TDB
{
    public partial class UserControl2 : UserControl
    {
        private Dictionary<string, Form> _formulaires = new Dictionary<string, Form>();

        public UserControl2()
        {   
            InitializeComponent();
            flp.AutoSize = true;
            int iconSize = Math.Min(btn_dash.Height - 8, 32);
            btn_dash.Image = new Bitmap(Resource1.home, new Size(iconSize, iconSize));
            btn_dash.Padding = new Padding(8, 0, 8, 0);
            btn_dash.FlatStyle  = FlatStyle.Flat;
            btn_dash.FlatAppearance.MouseOverBackColor = Color.FromArgb(184, 222, 239);
            btn_dash.Cursor = System.Windows.Forms.Cursors.Hand;

            btn_engins.Image = new Bitmap(btn_engins.Image, new Size(iconSize, iconSize));
            btn_engins.Padding = new Padding(8, 0, 8, 0);
            btn_engins.FlatStyle = FlatStyle.Flat;
            btn_engins.FlatAppearance.MouseOverBackColor = Color.FromArgb(184, 222, 239);
            btn_engins.Cursor = System.Windows.Forms.Cursors.Hand;

            btn_missions.Image = new Bitmap(btn_missions.Image, new Size(iconSize, iconSize));
            btn_missions.Padding = new Padding(8, 0, 8, 0);
            btn_missions.FlatStyle = FlatStyle.Flat;
            btn_missions.FlatAppearance.MouseOverBackColor = Color.FromArgb(184, 222, 239);
            btn_missions.Cursor = System.Windows.Forms.Cursors.Hand;


            btn_personnel.Padding = new Padding(8, 0, 8, 0);
            btn_personnel.FlatStyle = FlatStyle.Flat;
            btn_personnel.Image = new Bitmap(btn_personnel.Image, new Size(iconSize, iconSize));
            btn_personnel.FlatAppearance.MouseOverBackColor = Color.FromArgb(184, 222, 239);
            btn_personnel.Cursor = System.Windows.Forms.Cursors.Hand;

            btn_quitter.Image = new Bitmap(btn_quitter.Image, new Size(iconSize, iconSize));
            btn_quitter.Padding = new Padding(8, 0, 8, 0);
            btn_quitter.FlatStyle = FlatStyle.Flat;
            btn_quitter.FlatAppearance.MouseOverBackColor = Color.FromArgb(184, 222, 239);
            btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;

            btn_stats.Image = new Bitmap(btn_stats.Image, new Size(iconSize, iconSize));
            btn_stats.Padding = new Padding(8, 0, 8, 0);
            btn_stats.FlatStyle = FlatStyle.Flat;
            btn_stats.FlatAppearance.MouseOverBackColor = Color.FromArgb(184, 222, 239);
            btn_stats.Cursor = System.Windows.Forms.Cursors.Hand;

            btn_dash.FlatAppearance.MouseDownBackColor = Color.FromArgb(144, 243, 255);
            btn_engins.FlatAppearance.MouseDownBackColor = Color.FromArgb(144, 243, 255);
            btn_missions.FlatAppearance.MouseDownBackColor = Color.FromArgb(144, 243, 255);
            btn_personnel.FlatAppearance.MouseDownBackColor = Color.FromArgb(144, 243, 255);
            btn_quitter.FlatAppearance.MouseDownBackColor = Color.FromArgb(144, 243, 255);
            btn_stats.FlatAppearance.MouseDownBackColor = Color.FromArgb(144, 243, 255);
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_personnel_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm();
            if (parentForm != null)
            {
                NavigationManager.AfficherFormulaire(
                    "personnel",
                    () => new SEAA21_Form4.frmGestionDesPompiers(),
                    parentForm
                );
            }
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm();
            if (parentForm != null)
            {
                NavigationManager.AfficherFormulaire(
                    "dash",
                    () => new SAE_POMPIER_A21.Gestion(),
                    parentForm
                );
            }
        }

        private void btn_engins_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm();
            if (parentForm != null)
            {
                NavigationManager.AfficherFormulaire(
                    "engins",
                    () => new Volet3.Form1(),
                    parentForm
                );
            }
        }

        private void btn_missions_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm();
            if (parentForm != null)
            {
                NavigationManager.AfficherFormulaire(
                    "missions",
                    () => new CreationMission.Form1(),
                    parentForm
                );
            }
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm();
            if (parentForm != null)
            {
                NavigationManager.AfficherFormulaire(
                    "stats",
                    () => new SAEA21_Form5_StatRegu.FrmStatistiques(),
                    parentForm
                );
            }
        }
    }
}
