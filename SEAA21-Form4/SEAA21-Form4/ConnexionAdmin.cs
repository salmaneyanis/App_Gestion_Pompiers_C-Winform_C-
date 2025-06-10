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

            btnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            btnValider.Cursor = System.Windows.Forms.Cursors.Hand;

            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 253, 255);

            btnValider.FlatStyle = FlatStyle.Flat;
            btnValider.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 253, 255);
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
