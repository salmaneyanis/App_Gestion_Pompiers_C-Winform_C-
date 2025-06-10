namespace SEAA21_Form4
{
    partial class frmGestionDesPompiers
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSelectCasernePompier = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.cmbPompier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbChoixCaserne = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpInformations = new System.Windows.Forms.GroupBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.pctGrade = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBIP = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.rdbPro = new System.Windows.Forms.RadioButton();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.lblDateDeNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.grpInformationPlus = new System.Windows.Forms.GroupBox();
            this.chkConge = new System.Windows.Forms.CheckBox();
            this.lblGrade2 = new System.Windows.Forms.Label();
            this.btnMoins = new System.Windows.Forms.Button();
            this.lstbAffectations = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lstbHabilitations = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCaserneRattachement = new System.Windows.Forms.ComboBox();
            this.lblRattachement = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.grpSelectCasernePompier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctGrade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpInformationPlus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelectCasernePompier
            // 
            this.grpSelectCasernePompier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            this.grpSelectCasernePompier.Controls.Add(this.button2);
            this.grpSelectCasernePompier.Controls.Add(this.btnNouveau);
            this.grpSelectCasernePompier.Controls.Add(this.cmbPompier);
            this.grpSelectCasernePompier.Controls.Add(this.label2);
            this.grpSelectCasernePompier.Controls.Add(this.cmbChoixCaserne);
            this.grpSelectCasernePompier.Controls.Add(this.label1);
            this.grpSelectCasernePompier.Controls.Add(this.pictureBox1);
            this.grpSelectCasernePompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpSelectCasernePompier.Location = new System.Drawing.Point(10, 9);
            this.grpSelectCasernePompier.Name = "grpSelectCasernePompier";
            this.grpSelectCasernePompier.Size = new System.Drawing.Size(420, 1035);
            this.grpSelectCasernePompier.TabIndex = 0;
            this.grpSelectCasernePompier.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 981);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackgroundImage = global::SEAA21_Form4.Properties.Resources.AjouterPompier;
            this.btnNouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNouveau.Location = new System.Drawing.Point(110, 700);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(200, 200);
            this.btnNouveau.TabIndex = 5;
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // cmbPompier
            // 
            this.cmbPompier.FormattingEnabled = true;
            this.cmbPompier.Location = new System.Drawing.Point(30, 325);
            this.cmbPompier.Name = "cmbPompier";
            this.cmbPompier.Size = new System.Drawing.Size(365, 37);
            this.cmbPompier.TabIndex = 4;
            this.cmbPompier.SelectedIndexChanged += new System.EventHandler(this.cmbPompier_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(30, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Veuillez séléctionner un pompier :";
            // 
            // cmbChoixCaserne
            // 
            this.cmbChoixCaserne.FormattingEnabled = true;
            this.cmbChoixCaserne.Location = new System.Drawing.Point(30, 211);
            this.cmbChoixCaserne.Name = "cmbChoixCaserne";
            this.cmbChoixCaserne.Size = new System.Drawing.Size(365, 37);
            this.cmbChoixCaserne.TabIndex = 2;
            this.cmbChoixCaserne.SelectedIndexChanged += new System.EventHandler(this.cmbChoixCaserne_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(30, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veuillez séléctionner la caserne :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SEAA21_Form4.Properties.Resources.Personne;
            this.pictureBox1.Location = new System.Drawing.Point(160, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpInformations
            // 
            this.grpInformations.Controls.Add(this.btnConnexion);
            this.grpInformations.Controls.Add(this.pctGrade);
            this.grpInformations.Controls.Add(this.groupBox1);
            this.grpInformations.Controls.Add(this.lblDateEmbauche);
            this.grpInformations.Controls.Add(this.rdbPro);
            this.grpInformations.Controls.Add(this.rdbVolontaire);
            this.grpInformations.Controls.Add(this.lblDateDeNaissance);
            this.grpInformations.Controls.Add(this.lblSexe);
            this.grpInformations.Controls.Add(this.lblPrenom);
            this.grpInformations.Controls.Add(this.lblNom);
            this.grpInformations.Controls.Add(this.lblMatricule);
            this.grpInformations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpInformations.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformations.Location = new System.Drawing.Point(436, 9);
            this.grpInformations.Name = "grpInformations";
            this.grpInformations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpInformations.Size = new System.Drawing.Size(1169, 411);
            this.grpInformations.TabIndex = 1;
            this.grpInformations.TabStop = false;
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.Gold;
            this.btnConnexion.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.Brown;
            this.btnConnexion.Location = new System.Drawing.Point(953, 31);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(205, 68);
            this.btnConnexion.TabIndex = 11;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // pctGrade
            // 
            this.pctGrade.Image = global::SEAA21_Form4.Properties.Resources.SAP;
            this.pctGrade.Location = new System.Drawing.Point(714, 38);
            this.pctGrade.Name = "pctGrade";
            this.pctGrade.Size = new System.Drawing.Size(200, 200);
            this.pctGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGrade.TabIndex = 9;
            this.pctGrade.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBIP);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.lblGrade);
            this.groupBox1.Location = new System.Drawing.Point(6, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1156, 122);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrière";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblBIP
            // 
            this.lblBIP.AutoSize = true;
            this.lblBIP.Location = new System.Drawing.Point(257, 71);
            this.lblBIP.Name = "lblBIP";
            this.lblBIP.Size = new System.Drawing.Size(63, 32);
            this.lblBIP.TabIndex = 11;
            this.lblBIP.Text = "BIP :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(486, 71);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(137, 32);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "Téléphone :";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(6, 71);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(92, 32);
            this.lblGrade.TabIndex = 9;
            this.lblGrade.Text = "Grade :";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Location = new System.Drawing.Point(6, 196);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(191, 32);
            this.lblDateEmbauche.TabIndex = 7;
            this.lblDateEmbauche.Text = "Date embauche :";
            // 
            // rdbPro
            // 
            this.rdbPro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdbPro.AutoSize = true;
            this.rdbPro.Enabled = false;
            this.rdbPro.Location = new System.Drawing.Point(497, 192);
            this.rdbPro.Name = "rdbPro";
            this.rdbPro.Size = new System.Drawing.Size(181, 36);
            this.rdbPro.TabIndex = 6;
            this.rdbPro.TabStop = true;
            this.rdbPro.Text = "Professionnel";
            this.rdbPro.UseVisualStyleBackColor = true;
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdbVolontaire.AutoCheck = false;
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Enabled = false;
            this.rdbVolontaire.Location = new System.Drawing.Point(497, 238);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(149, 36);
            this.rdbVolontaire.TabIndex = 5;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // lblDateDeNaissance
            // 
            this.lblDateDeNaissance.AutoSize = true;
            this.lblDateDeNaissance.Location = new System.Drawing.Point(263, 109);
            this.lblDateDeNaissance.Name = "lblDateDeNaissance";
            this.lblDateDeNaissance.Size = new System.Drawing.Size(216, 32);
            this.lblDateDeNaissance.TabIndex = 4;
            this.lblDateDeNaissance.Text = "Date de naissance :";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(6, 109);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(75, 32);
            this.lblSexe.TabIndex = 3;
            this.lblSexe.Text = "Sexe :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(263, 31);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(109, 32);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 31);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(79, 32);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // lblMatricule
            // 
            this.lblMatricule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(489, 31);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(137, 32);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule X";
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(672, 117);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(486, 40);
            this.cmbGrade.TabIndex = 13;
            this.cmbGrade.SelectedIndexChanged += new System.EventHandler(this.cmbGrade_SelectedIndexChanged);
            this.cmbGrade.Leave += new System.EventHandler(this.cmbGrade_Leave);
            // 
            // grpInformationPlus
            // 
            this.grpInformationPlus.Controls.Add(this.chkConge);
            this.grpInformationPlus.Controls.Add(this.lblGrade2);
            this.grpInformationPlus.Controls.Add(this.cmbGrade);
            this.grpInformationPlus.Controls.Add(this.btnMoins);
            this.grpInformationPlus.Controls.Add(this.lstbAffectations);
            this.grpInformationPlus.Controls.Add(this.label15);
            this.grpInformationPlus.Controls.Add(this.lstbHabilitations);
            this.grpInformationPlus.Controls.Add(this.label14);
            this.grpInformationPlus.Controls.Add(this.cmbCaserneRattachement);
            this.grpInformationPlus.Controls.Add(this.lblRattachement);
            this.grpInformationPlus.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformationPlus.Location = new System.Drawing.Point(436, 475);
            this.grpInformationPlus.Name = "grpInformationPlus";
            this.grpInformationPlus.Size = new System.Drawing.Size(1169, 569);
            this.grpInformationPlus.TabIndex = 2;
            this.grpInformationPlus.TabStop = false;
            this.grpInformationPlus.Text = "Informations Carrière";
            this.grpInformationPlus.Visible = false;
            // 
            // chkConge
            // 
            this.chkConge.AutoSize = true;
            this.chkConge.Location = new System.Drawing.Point(1017, 202);
            this.chkConge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkConge.Name = "chkConge";
            this.chkConge.Size = new System.Drawing.Size(137, 36);
            this.chkConge.TabIndex = 22;
            this.chkConge.Text = "En congé";
            this.chkConge.UseVisualStyleBackColor = true;
            this.chkConge.CheckedChanged += new System.EventHandler(this.chkConge_CheckedChanged);
            this.chkConge.Click += new System.EventHandler(this.chkConge_Click);
            // 
            // lblGrade2
            // 
            this.lblGrade2.AutoSize = true;
            this.lblGrade2.Location = new System.Drawing.Point(6, 91);
            this.lblGrade2.Name = "lblGrade2";
            this.lblGrade2.Size = new System.Drawing.Size(92, 32);
            this.lblGrade2.TabIndex = 21;
            this.lblGrade2.Text = "Grade :";
            // 
            // btnMoins
            // 
            this.btnMoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            this.btnMoins.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.btnMoins.Location = new System.Drawing.Point(879, 508);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(279, 50);
            this.btnMoins.TabIndex = 20;
            this.btnMoins.Text = "Moins d\'informations";
            this.btnMoins.UseVisualStyleBackColor = false;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // lstbAffectations
            // 
            this.lstbAffectations.FormattingEnabled = true;
            this.lstbAffectations.ItemHeight = 32;
            this.lstbAffectations.Location = new System.Drawing.Point(12, 371);
            this.lstbAffectations.Name = "lstbAffectations";
            this.lstbAffectations.Size = new System.Drawing.Size(787, 164);
            this.lstbAffectations.Sorted = true;
            this.lstbAffectations.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 336);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(228, 32);
            this.label15.TabIndex = 17;
            this.label15.Text = "Affectations passées";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // lstbHabilitations
            // 
            this.lstbHabilitations.FormattingEnabled = true;
            this.lstbHabilitations.ItemHeight = 32;
            this.lstbHabilitations.Location = new System.Drawing.Point(12, 169);
            this.lstbHabilitations.Name = "lstbHabilitations";
            this.lstbHabilitations.Size = new System.Drawing.Size(787, 164);
            this.lstbHabilitations.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 32);
            this.label14.TabIndex = 15;
            this.label14.Text = "Habilitations";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // cmbCaserneRattachement
            // 
            this.cmbCaserneRattachement.FormattingEnabled = true;
            this.cmbCaserneRattachement.Location = new System.Drawing.Point(672, 58);
            this.cmbCaserneRattachement.Name = "cmbCaserneRattachement";
            this.cmbCaserneRattachement.Size = new System.Drawing.Size(486, 40);
            this.cmbCaserneRattachement.TabIndex = 14;
            this.cmbCaserneRattachement.SelectedIndexChanged += new System.EventHandler(this.cmbCaserneRattachement_SelectedIndexChanged);
            this.cmbCaserneRattachement.Leave += new System.EventHandler(this.cmbCaserneRattachement_Leave);
            // 
            // lblRattachement
            // 
            this.lblRattachement.AutoSize = true;
            this.lblRattachement.Location = new System.Drawing.Point(6, 48);
            this.lblRattachement.Name = "lblRattachement";
            this.lblRattachement.Size = new System.Drawing.Size(289, 32);
            this.lblRattachement.TabIndex = 14;
            this.lblRattachement.Text = "Caserne de rattachement :";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            this.btnPlus.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.btnPlus.Location = new System.Drawing.Point(1319, 426);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(275, 50);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "Plus d\'informations";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Visible = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // frmGestionDesPompiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 1061);
            this.Controls.Add(this.grpInformationPlus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.grpInformations);
            this.Controls.Add(this.grpSelectCasernePompier);
            this.Name = "frmGestionDesPompiers";
            this.Text = "Gestion Des Pompiers";
            this.Load += new System.EventHandler(this.frmGestionDesPompiers_Load);
            this.grpSelectCasernePompier.ResumeLayout(false);
            this.grpSelectCasernePompier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpInformations.ResumeLayout(false);
            this.grpInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctGrade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpInformationPlus.ResumeLayout(false);
            this.grpInformationPlus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelectCasernePompier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.ComboBox cmbPompier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbChoixCaserne;
        private System.Windows.Forms.GroupBox grpInformations;
        private System.Windows.Forms.GroupBox grpInformationPlus;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.RadioButton rdbPro;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.Label lblDateDeNaissance;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblBIP;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.PictureBox pctGrade;
        private System.Windows.Forms.ComboBox cmbCaserneRattachement;
        private System.Windows.Forms.Label lblRattachement;
        private System.Windows.Forms.ListBox lstbHabilitations;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lstbAffectations;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblGrade2;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.CheckBox chkConge;
        private System.Windows.Forms.Button button2;
    }
}

