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
        public UserControl2()
        {
            InitializeComponent();
            int iconSize = Math.Min(btn_dash.Height - 8, 32);
            btn_dash.Image = new Bitmap(Resource1.home, new Size(iconSize, iconSize));
            btn_dash.Padding = new Padding(8, 0, 8, 0);
            btn_dash.FlatStyle  = FlatStyle.Flat;

            btn_engins.Image = new Bitmap(btn_engins.Image, new Size(iconSize, iconSize));
            btn_engins.Padding = new Padding(8, 0, 8, 0);
            btn_engins.FlatStyle = FlatStyle.Flat;

            btn_missions.Image = new Bitmap(btn_missions.Image, new Size(iconSize, iconSize));
            btn_missions.Padding = new Padding(8, 0, 8, 0);
            btn_missions.FlatStyle = FlatStyle.Flat;

            
            btn_personnel.Padding = new Padding(8, 0, 8, 0);
            btn_personnel.FlatStyle = FlatStyle.Flat;
            btn_personnel.Image = new Bitmap(btn_personnel.Image, new Size(iconSize, iconSize));

            btn_quitter.Image = new Bitmap(btn_quitter.Image, new Size(iconSize, iconSize));
            btn_quitter.Padding = new Padding(8, 0, 8, 0);
            btn_quitter.FlatStyle = FlatStyle.Flat;

            btn_stats.Image = new Bitmap(btn_stats.Image, new Size(iconSize, iconSize));
            btn_stats.Padding = new Padding(8, 0, 8, 0);
            btn_stats.FlatStyle = FlatStyle.Flat;

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {

        }

        private void btn_personnel_Click(object sender, EventArgs e)
        {

        }
    }
}  
