using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SAE_POMPIER_A21;

namespace Volet3
{
    public partial class Form1 : Form
    {
        private DataTable dtEngins = new DataTable();
        private PictureBox pictureBoxEngin = null;
        private PictureBox picMissionStatus = null;
        private PictureBox picPanneStatus = null;
        private BindingSource bsEngins = new BindingSource();
        private string imageFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IMAGES");
        private SQLiteConnection cx = Connexion.Connec;
        private DataSet ds = MesDatas.DsGlobal;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;


            try
            {
                this.cx = Connexion.Connec;
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            InitializeStatusPictureBoxes();
            init_cboCaserne();
            init_engin();
        }

        private void InitializeStatusPictureBoxes()
        {
            // PictureBox pour le statut Mission
            picMissionStatus = new PictureBox
            {
                Name = "picMissionStatus",
                Size = new Size(40, 40),
                Location = new Point(label7.Right + 5, label7.Top - 12),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None
            };
            this.Controls.Add(picMissionStatus);

            // PictureBox pour le statut Panne
            picPanneStatus = new PictureBox
            {
                Name = "picPanneStatus",
                Size = new Size(40, 40),
                Location = new Point(label6.Right, label6.Top - 12),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None
            };
            this.Controls.Add(picPanneStatus);
        }

        private void init_cboCaserne()
        {
            string sql = "SELECT id, nom FROM Caserne";
            DataTable dtCasernes = new DataTable();

            try
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, this.cx))
                {
                    adapter.Fill(dtCasernes);
                }

                DataRow newRow = dtCasernes.NewRow();
                newRow["id"] = -1;
                newRow["nom"] = "Choisir caserne";
                dtCasernes.Rows.InsertAt(newRow, 0);

                cboCaserne.DataSource = dtCasernes;
                cboCaserne.DisplayMember = "nom";
                cboCaserne.ValueMember = "id";
                cboCaserne.SelectedIndex = 0;
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors du chargement des casernes : " + err.Message);
            }
        }


        private void init_engin()
        {
            string sql = "SELECT Engin.*, Caserne.nom as nomCaserne FROM Engin " +
                         "JOIN Caserne ON Engin.idCaserne = Caserne.id";

            try
            {
                dtEngins.Clear(); // Important si on recharge plusieurs fois
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, this.cx))
                {
                    adapter.Fill(dtEngins);
                }

                // Colonne calculée (ajouter uniquement si elle n'existe pas déjà)
                if (!dtEngins.Columns.Contains("DisplayText"))
                {
                    dtEngins.Columns.Add("DisplayText", typeof(string),
                        "idCaserne + '-' + codeTypeEngin + '-' + numero");
                }

                bsEngins.DataSource = dtEngins;

                // Bindings
                label3.DataBindings.Clear();
                label3.DataBindings.Add("Text", bsEngins, "DisplayText");

                label5.DataBindings.Clear();
                label5.DataBindings.Add(new Binding("Text", bsEngins, "dateReception",
                    true, DataSourceUpdateMode.Never, "", "dd/MM/yyyy"));

                bsEngins.PositionChanged += BsEngins_PositionChanged;

                if (bsEngins.Count > 0)
                {
                    BsEngins_PositionChanged(bsEngins, EventArgs.Empty);
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors du chargement des engins : " + err.Message);
            }
        }


        private void BsEngins_PositionChanged(object sender, EventArgs e)
        {
            if (bsEngins.Current is DataRowView drv)
            {
                // Mise à jour de l'image de l'engin
                UpdateEnginImage(drv["codeTypeEngin"].ToString());

                // Mise à jour des statuts
                UpdateStatusImages(
                    Convert.ToBoolean(drv["EnMission"]),
                    Convert.ToBoolean(drv["EnPanne"]));
            }
        }

        private void UpdateEnginImage(string codeTypeEngin)
        {
            // Nettoyer l'image existante
            if (pictureBoxEngin != null)
            {
                pictureBoxEngin.Image?.Dispose();
                pictureBoxEngin.Dispose();
            }

            // Créer un nouveau PictureBox
            pictureBoxEngin = new PictureBox
            {
                Size = new Size(300, 200),
                Location = new Point(547, 95),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None
            };
            this.Controls.Add(pictureBoxEngin);

            // Charger l'image correspondante
            try
            {
                string[] imageFiles = Directory.GetFiles(imageFolderPath, codeTypeEngin + ".*");
                if (imageFiles.Length > 0)
                {
                    using (var bmpTemp = new Bitmap(imageFiles[0]))
                    {
                        pictureBoxEngin.Image = new Bitmap(bmpTemp);
                    }
                }
                else
                {
                    MessageBox.Show("Image non trouvée pour : " + codeTypeEngin);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de l'image : " + ex.Message);
            }
        }

        private void UpdateStatusImages(bool enMission, bool enPanne)
        {
            UpdateStatusImage(picMissionStatus, enMission);
            UpdateStatusImage(picPanneStatus, enPanne);
        }

        private void UpdateStatusImage(PictureBox pictureBox, bool status)
        {
            string imagePath = Path.Combine(imageFolderPath, status ? "green.png" : "rouge.png");

            if (File.Exists(imagePath))
            {
                pictureBox.Image?.Dispose();
                pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedValue == null || !int.TryParse(cboCaserne.SelectedValue.ToString(), out int idcas))
                return;

            bsEngins.Filter = $"idCaserne = {idcas}";

            if (bsEngins.Count == 0)
            {
                label3.Text = "Aucun engin trouvé.";
                ClearEnginImage();
            }
            else
            {
                bsEngins.MoveFirst();
            }
        }

        private void ClearEnginImage()
        {
            if (pictureBoxEngin != null)
            {
                pictureBoxEngin.Image?.Dispose();
                pictureBoxEngin.Dispose();
                pictureBoxEngin = null;
            }
        }

        // Gestion des boutons de navigation
        private void button3_Click(object sender, EventArgs e) => bsEngins.MoveFirst();
        private void button4_Click(object sender, EventArgs e) => bsEngins.MoveLast();

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (bsEngins.Position > 0)
                bsEngins.MovePrevious();
            else
                MessageBox.Show("Vous êtes déjà au premier engin.");
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (bsEngins.Position < bsEngins.Count - 1)
                bsEngins.MoveNext();
            else
                MessageBox.Show("Vous êtes déjà au dernier engin.");
        }

        private void label6_Click(object sender, EventArgs e) { }

        
    }
}