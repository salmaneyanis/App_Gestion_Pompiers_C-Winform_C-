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

namespace SAE_POMPIER_A21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var maConnexion = Connexion.Connec;
            this.WindowState = FormWindowState.Maximized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
