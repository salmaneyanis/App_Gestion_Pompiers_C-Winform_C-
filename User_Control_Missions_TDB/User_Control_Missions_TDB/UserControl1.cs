using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.IO;

namespace User_Control_Missions_TDB
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(Missions_UC), "Images/target.ico")]
    public partial class Missions_UC: UserControl
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );

        public void SetButtonIcons()
        {
            btn_close.Image = ResizeImage(Resource1.cross, btn_close.Width - 10, btn_close.Height - 10);
            btn_close.ImageAlign = ContentAlignment.MiddleCenter;
            btn_close.BackgroundImageLayout = ImageLayout.Zoom;

            btn_pdf.Image = ResizeImage(Resource1.pdf, btn_pdf.Width - 10, btn_pdf.Height - 10);
            btn_pdf.ImageAlign = ContentAlignment.MiddleCenter;
            btn_pdf.BackgroundImageLayout = ImageLayout.Zoom;
        }

        // Méthode pour redimensionner l'image
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap resized = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return resized;
        }

        public Missions_UC()
        {
            InitializeComponent();
            SetRoundedRegion(20); // 20 = rayon d’arrondi, ajustez selon vos besoins
            this.BackColor = Color.White;
            this.Padding = new Padding(10);
            this.Margin = new Padding(10);
            panel_1.BorderStyle = BorderStyle.None;
            panel_1.BackColor = Color.White;
            CustomizeButton(btn_close);
            CustomizeButton(btn_pdf);
            panel_1.Paint += PanelMain_Paint;
            SetButtonIcons();
        }

        public Missions_UC(int id, string date_depart, string date_retour, string motif, string adresse, string cp, string ville, int terminee, string compteRendu, int natureSinistre,string sinistre, string caserne)
        {
            InitializeComponent();
            SetRoundedRegion(20); // 20 = rayon d’arrondi, ajustez selon vos besoins
            this.BackColor = Color.White;
            this.Padding = new Padding(10);
            this.Margin = new Padding(10);
            panel_1.BorderStyle = BorderStyle.None;
            panel_1.BackColor = Color.White;

            CustomizeButton(btn_close);
            CustomizeButton(btn_pdf);
            panel_1.Paint += PanelMain_Paint;

            SetButtonIcons();

            if (cp != null)
            {
                if (adresse == null)
                {
                    lblAdresse.Text = cp + " " + ville;
                }
                else
                {
                    lblAdresse.Text = adresse + " " + cp + " " + ville;
                }
            }
            else
            {
                if (adresse == null)
                {
                    lblAdresse.Text = ville;
                }
                else
                {
                    lblAdresse.Text = adresse + " " + ville;
                }
            }
            lblCaserne.Text = caserne;
            if (date_retour != null)
            {
                lblDate.Text = date_depart + " - " + date_retour;
            }
            else
            {
                lblDate.Text = date_depart + " - ";

            }

            lblMissionId.Text = id.ToString();
            lblSinistre.Text = sinistre;
            lblDescription.Text = motif;

            if (terminee == 0)
            {
                picBox.Image = Image.FromFile("Images/valid.png");
            }

            }


        private void CustomizeButton(Button button)
        {
            button.BackColor = Color.WhiteSmoke;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Arial", 9, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.Width = 50;
            button.Height = 50;
            button.Cursor = Cursors.Hand;
            button.Region = new Region(GetRoundedRectanglePath(button.ClientRectangle, 15));
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Top, radius, radius, 280, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20;
            int borderThickness = 2;
            Color borderColor = Color.Gray;

            // Smoothing pour un rendu propre
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Dessiner la bordure arrondie
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(panel_1.Width - cornerRadius - 1, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(panel_1.Width - cornerRadius - 1, panel_1.Height - cornerRadius - 1, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, panel_1.Height - cornerRadius - 1, cornerRadius, cornerRadius, 90, 90);
                path.CloseAllFigures();

                using (Pen pen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        public string MissionId
        {
            get => lblMissionId.Text;
            set => lblMissionId.Text = $"ID: {value}";
        }

        public string Description
        {
            get => lblSinistre.Text;
            set => lblSinistre.Text = value;
        }

        public string Date
        {
            get => lblDate.Text;
            set => lblDate.Text = $"Date: {value}";
        }

        public string Caserne
        {
            get => lblCaserne.Text;
            set => lblCaserne.Text = $"Caserne: {value}";
        }

        public string Sinistre
        {
            get => lblSinistre.Text;
            set => lblSinistre.Text = value;
        }
        public string Adresse
        {
            get => lblAdresse.Text;
            set => lblAdresse.Text = value;
        }
        public Image Picture
        {
            get => picBox.BackgroundImage;
            set
            {
                picBox.BackgroundImage = value;
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetRoundedRegion(int radius)
        {
            using (GraphicsPath path = GetRoundedRectanglePath(this.ClientRectangle, radius))
            {
                this.Region = new Region(path);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedRegion(20); // même rayon que précédemment
        }

        private void lblAdresse_Click(object sender, EventArgs e)
        {

        }

        private void panel_1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
