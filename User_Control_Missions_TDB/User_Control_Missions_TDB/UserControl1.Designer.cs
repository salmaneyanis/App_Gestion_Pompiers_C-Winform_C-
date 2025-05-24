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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblSinistre = new System.Windows.Forms.Label();
            this.lblMissionId = new System.Windows.Forms.Label();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
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
            this.panel_1.Size = new System.Drawing.Size(364, 223);
            this.panel_1.TabIndex = 0;
            this.panel_1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_1_Paint);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(89, 95);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(44, 16);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "label1";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(32, 191);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(44, 16);
            this.lblCaserne.TabIndex = 4;
            this.lblCaserne.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(272, 154);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label1";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(89, 154);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(44, 16);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "label1";
            this.lblAdresse.Click += new System.EventHandler(this.lblAdresse_Click);
            // 
            // lblSinistre
            // 
            this.lblSinistre.AutoSize = true;
            this.lblSinistre.Location = new System.Drawing.Point(89, 32);
            this.lblSinistre.Name = "lblSinistre";
            this.lblSinistre.Size = new System.Drawing.Size(44, 16);
            this.lblSinistre.TabIndex = 1;
            this.lblSinistre.Text = "label1";
            // 
            // lblMissionId
            // 
            this.lblMissionId.AutoSize = true;
            this.lblMissionId.Location = new System.Drawing.Point(272, 12);
            this.lblMissionId.Name = "lblMissionId";
            this.lblMissionId.Size = new System.Drawing.Size(44, 16);
            this.lblMissionId.TabIndex = 0;
            this.lblMissionId.Text = "label1";
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pdf.Location = new System.Drawing.Point(384, 24);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(50, 50);
            this.btn_pdf.TabIndex = 1;
            this.btn_pdf.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Location = new System.Drawing.Point(384, 140);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // picBox
            // 
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox.Location = new System.Drawing.Point(13, 21);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(63, 50);
            this.picBox.TabIndex = 6;
            this.picBox.TabStop = false;
            // 
            // Missions_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.panel_1);
            this.Name = "Missions_UC";
            this.Size = new System.Drawing.Size(452, 228);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
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
    }
}
