namespace User_Control_Missions_TDB
{
    partial class Missions_UC
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_1 = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblSinistre = new System.Windows.Forms.Label();
            this.lblMissionId = new System.Windows.Forms.Label();
            this.pnl_bordure = new System.Windows.Forms.Panel();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_1.Controls.Add(this.picBox);
            this.panel_1.Controls.Add(this.lblDescription);
            this.panel_1.Controls.Add(this.lblCaserne);
            this.panel_1.Controls.Add(this.lblDate);
            this.panel_1.Controls.Add(this.lblAdresse);
            this.panel_1.Controls.Add(this.lblSinistre);
            this.panel_1.Controls.Add(this.lblMissionId);
            this.panel_1.Location = new System.Drawing.Point(3, 3);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(460, 289);
            this.panel_1.TabIndex = 0;
            this.panel_1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_1_Paint);
            // 
            // picBox
            // 
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox.Location = new System.Drawing.Point(13, 11);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(82, 82);
            this.picBox.TabIndex = 6;
            this.picBox.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(10, 117);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(434, 33);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "label1";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lblCaserne
            // 
            this.lblCaserne.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(13, 254);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(290, 24);
            this.lblCaserne.TabIndex = 4;
            this.lblCaserne.Text = "label1";
            this.lblCaserne.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblCaserne.Click += new System.EventHandler(this.lblCaserne_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDate.Location = new System.Drawing.Point(300, 206);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(144, 72);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblAdresse
            // 
            this.lblAdresse.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(12, 173);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(337, 33);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "label1";
            this.lblAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAdresse.Click += new System.EventHandler(this.lblAdresse_Click);
            // 
            // lblSinistre
            // 
            this.lblSinistre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinistre.Location = new System.Drawing.Point(101, 44);
            this.lblSinistre.Name = "lblSinistre";
            this.lblSinistre.Size = new System.Drawing.Size(250, 27);
            this.lblSinistre.TabIndex = 1;
            this.lblSinistre.Text = "label1";
            this.lblSinistre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSinistre.Click += new System.EventHandler(this.lblSinistre_Click);
            // 
            // lblMissionId
            // 
            this.lblMissionId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissionId.Location = new System.Drawing.Point(316, 11);
            this.lblMissionId.Name = "lblMissionId";
            this.lblMissionId.Size = new System.Drawing.Size(128, 24);
            this.lblMissionId.TabIndex = 0;
            this.lblMissionId.Text = "label1";
            this.lblMissionId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnl_bordure
            // 
            this.pnl_bordure.BackColor = System.Drawing.Color.Red;
            this.pnl_bordure.Location = new System.Drawing.Point(90, 311);
            this.pnl_bordure.Name = "pnl_bordure";
            this.pnl_bordure.Size = new System.Drawing.Size(284, 10);
            this.pnl_bordure.TabIndex = 7;
            this.pnl_bordure.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_bordure_Paint);
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pdf.Location = new System.Drawing.Point(487, 35);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(85, 85);
            this.btn_pdf.TabIndex = 1;
            this.btn_pdf.UseVisualStyleBackColor = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Location = new System.Drawing.Point(487, 176);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(85, 85);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Missions_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pnl_bordure);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.panel_1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Missions_UC";
            this.Size = new System.Drawing.Size(588, 324);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Label lblMissionId;
        private System.Windows.Forms.Label lblSinistre;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel pnl_bordure;
    }
}
