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
using SAE_POMPIER_A21;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.IO.Image;
using iText.Layout.Element;
using iText.IO.Font.Constants;
using iText.Kernel.Font;




namespace User_Control_Missions_TDB
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(Missions_UC), "Images/target.ico")]
    public partial class Missions_UC: UserControl
    {
        private int idMission;
        public event EventHandler<int> CloturerMissionDemande;

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
            btn_close.Image = ResizeImage(Resource1.folder, btn_close.Width - 10, btn_close.Height - 10);
            btn_close.ImageAlign = ContentAlignment.MiddleCenter;
            btn_close.BackgroundImageLayout = ImageLayout.Zoom;

            btn_pdf.Image = ResizeImage(Resource1.pdf, btn_pdf.Width - 10, btn_pdf.Height - 10);
            btn_pdf.ImageAlign = ContentAlignment.MiddleCenter;
            btn_pdf.BackgroundImageLayout = ImageLayout.Zoom;
        }

        // Méthode pour redimensionner l'image
        private System.Drawing.Image ResizeImage(System.Drawing.Image img, int width, int height)
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
            SetRoundedRegion(20); // 20 = rayon d’arrondi
            this.BackColor = Color.White;
            this.Padding = new Padding(10);
            this.Margin = new Padding(10);
            panel_1.BorderStyle = BorderStyle.None;
            panel_1.BackColor = Color.White;
            CustomizeButton(btn_close);
            CustomizeButton(btn_pdf);
            panel_1.Paint += PanelMain_Paint;
            SetButtonIcons();

            btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_pdf.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        public Missions_UC(int id, string date_depart, string date_retour, string motif, string adresse, string cp, string ville, int terminee, string compteRendu, int natureSinistre, string sinistre, string caserne)
        {
            InitializeComponent();
            this.idMission = id;
            SetRoundedRegion(20);
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
                lblDate.Text = "Du " + date_depart + "\n au " + date_retour;
            }
            else
            {
                lblDate.Text = "Du " + date_depart + "\n - ";

            }

            lblMissionId.Text = "Mission n° " + id.ToString();
            lblSinistre.Text = sinistre;
            lblDescription.Text = "->" + " " + motif;

            if (terminee == 1)
            {
                btn_close.Visible = false;
                pnl_bordure.BackColor = Color.Green;
            }
            switch (natureSinistre)
            {
                case 1:
                    picBox.BackgroundImage = ResizeImage(Resource1.urgent, picBox.Width, picBox.Height);
                    break;
                case 2:
                    picBox.BackgroundImage = ResizeImage(Resource1.voiture, picBox.Width, picBox.Height);
                    break;
                case 3:
                    picBox.BackgroundImage = ResizeImage(Resource1.incendie, picBox.Width, picBox.Height);
                    break;
                case 4:
                    picBox.BackgroundImage = ResizeImage(Resource1.industrielle, picBox.Width, picBox.Height);
                    break;
                case 5:
                    picBox.BackgroundImage = ResizeImage(Resource1.foret, picBox.Width, picBox.Height);
                    break;
                case 6:
                    picBox.BackgroundImage = ResizeImage(Resource1.faune, picBox.Width, picBox.Height);
                    break;
                case 7:
                    picBox.BackgroundImage = ResizeImage(Resource1.plan, picBox.Width, picBox.Height);
                    break;
                case 8:
                    picBox.BackgroundImage = ResizeImage(Resource1.mer, picBox.Width, picBox.Height);
                    break;
                case 9:
                    picBox.BackgroundImage = ResizeImage(Resource1.eboulement, picBox.Width, picBox.Height);
                    break;
                case 10:
                    picBox.BackgroundImage = ResizeImage(Resource1.non_urgent, picBox.Width, picBox.Height);
                    break;
            }
        }


        private void CustomizeButton(Button button)
        {
            button.BackColor = Color.WhiteSmoke;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Arial", 9, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.Width = 65;
            button.Height = 65;
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
            set => lblCaserne.Text = $"{value}";
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

        public DataSet MonDataSet { get; set; }
        public System.Drawing.Image Picture
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

        private void lblCaserne_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void pnl_bordure_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSinistre_Click(object sender, EventArgs e)
        {

        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            MesDatas.ChargerMobiliser();
            MesDatas.ChargerPompier();
            MesDatas.ChargerPartirAvec();
            MesDatas.ChargerMissions();
            MesDatas.ChargerHabilitations();
            MesDatas.ChargerEngins();
            MesDatas.ChargerETypeEngins();
            GenererPDFMission(idMission);
        }

        public void GenererPDFMission(int idMission)
        {
            string downloadPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")) ? "Downloads" : "Téléchargements"
            );

            string nomFichier = Path.Combine(downloadPath, $"Mission_{idMission}.pdf");

            using (PdfWriter writer = new PdfWriter(nomFichier))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document document = new Document(pdf))
            {
                // --- POLICES ---
                PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                PdfFont fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont fontItalic = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_OBLIQUE);

                // --- LOGO ---
                using (MemoryStream ms = new MemoryStream())
                {
                    Resource1.FIGER.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ImageData imageData = ImageDataFactory.Create(ms.ToArray());
                    var logo = new iText.Layout.Element.Image(imageData).ScaleToFit(100, 100);
                    document.Add(logo);
                }

                // --- DONNÉES MISSION ---
                var dtMission = MesDatas.DsGlobal.Tables["Mission"];
                if (dtMission == null)
                {
                    MessageBox.Show("La table 'Mission' est introuvable.");
                    return;
                }

                var mission = dtMission.Select($"id = {idMission}").FirstOrDefault();
                if (mission == null)
                {
                    MessageBox.Show("Mission introuvable.");
                    return;
                }

                // Titre principal
                document.Add(new Paragraph($"Rapport de la mission n°{idMission}").SetFont(fontBold).SetFontSize(20).SetMarginBottom(10));
                document.Add(new Paragraph($"Départ : {mission["dateHeureDepart"]}").SetFont(fontNormal));
                document.Add(new Paragraph($"Retour : {(mission["dateHeureRetour"] == DBNull.Value ? "En cours" : mission["dateHeureRetour"])}").SetFont(fontNormal));
                document.Add(new Paragraph($"Motif : {mission["motifAppel"]}").SetFont(fontNormal));
                document.Add(new Paragraph($"Adresse : {mission["adresse"]}, {mission["cp"]} {mission["ville"]}").SetFont(fontNormal));
                document.Add(new Paragraph($"Compte-rendu : {mission["compteRendu"]}").SetFont(fontNormal));
                document.Add(new Paragraph("------------------------------------------------------------------------------------"));
                document.Add(new Paragraph("\n"));

                // --- POMPIERS MOBILISÉS ---
                var dtMobiliser = MesDatas.DsGlobal.Tables["Mobiliser"];
                var dtPompiers = MesDatas.DsGlobal.Tables["Pompier"];
                var dtHabilitations = MesDatas.DsGlobal.Tables["Habilitation"];

                document.Add(new Paragraph("Pompiers mobilisés :").SetFont(fontBold).SetFontSize(15));

                var mobilises = dtMobiliser?.Select($"idMission = {idMission}");
                if (mobilises != null)
                {
                    foreach (var row in mobilises)
                    {
                        var pompier = dtPompiers?.Select($"matricule = {row["matriculePompier"]}").FirstOrDefault();
                        if (pompier != null)
                        {
                            string grade = pompier["codeGrade"].ToString();
                            string nomPrenom = $"{pompier["nom"]} {pompier["prenom"]}";
                            string matricule = pompier["matricule"].ToString();
                            string idHab = row["idHabilitation"].ToString();

                            var habilitation = dtHabilitations?.Select($"id = {idHab}").FirstOrDefault();
                            string nomHabilitation = habilitation != null ? habilitation["libelle"].ToString() : $"Habilitation {idHab}";

                            Paragraph pompierParagraph = new Paragraph()
                                .Add($"- {grade} {nomPrenom} (Matricule: {matricule}) - ")
                                .Add(new Text(nomHabilitation).SetFont(fontItalic));
                            document.Add(pompierParagraph);
                        }
                    }
                }
                document.Add(new Paragraph("------------------------------------------------------------------------------------"));
                document.Add(new Paragraph("\n"));

                // --- ENGIN(S) MOBILISÉ(S) + RÉPARATIONS ---
                var partirAvec = MesDatas.DsGlobal.Tables["PartirAvec"]?.Select($"idMission = {idMission}");
                var dtTypes = MesDatas.DsGlobal.Tables["TypeEngin"];

                document.Add(new Paragraph("Engins mobilisés :").SetFont(fontBold).SetFontSize(15));

                if (partirAvec != null)
                {
                    foreach (var row in partirAvec)
                    {
                        string numero = row["numeroEngin"].ToString();
                        string codeType = row["codeTypeEngin"].ToString();

                        // Nom du type d'engin
                        var type = dtTypes?.Select($"code = '{codeType}'").FirstOrDefault();
                        string nomType = type != null ? type["nom"].ToString() : $"Type {codeType}";

                        string reparations = row["reparationsEventuelles"] == DBNull.Value || string.IsNullOrWhiteSpace(row["reparationsEventuelles"].ToString())
                            ? "(pas de réparations prévues)"
                            : row["reparationsEventuelles"].ToString();

                        Paragraph enginParagraph = new Paragraph()
                            .Add("Engin ")
                            .Add(new Text(codeType).SetFont(fontBold))
                            .Add(" n°")
                            .Add(new Text(numero).SetFont(fontNormal))
                            .Add(" - ")
                            .Add(new Text(nomType).SetFont(fontBold))
                            .Add(" - Réparations éventuelles : ")
                            .Add(new Text(reparations).SetFont(fontItalic));

                        document.Add(enginParagraph);
                    }
                }

                // --- FIN ---
                document.Add(new Paragraph($"\n\n\nPDF généré le {DateTime.Now:G}").SetFont(fontItalic));

                MessageBox.Show($"PDF généré : {nomFichier}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            CloturerMissionDemande?.Invoke(this, idMission);
        }
    }
}
