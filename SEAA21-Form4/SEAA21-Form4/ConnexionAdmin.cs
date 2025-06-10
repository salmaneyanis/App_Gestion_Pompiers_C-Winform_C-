using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEAA21_Form4
{
    public partial class FormMDP : Form
    {

        private string nom;
        private string mdp;

        public FormMDP()
        {
            InitializeComponent();
        }

        public string Nom { get => nom; }
        public string Mdp { get => mdp; }

        private void FormMDP_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.mdp = txtMdp.Text;
            this.nom = txtNom.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
