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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionDesPompiers));
            this.grpSelectCasernePompier = new System.Windows.Forms.GroupBox();
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
            this.userControl21 = new User_Control_Missions_TDB.UserControl2();
            this.label3 = new System.Windows.Forms.Label();
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
            this.grpSelectCasernePompier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(30)))), ((int)(((byte)(228)))));
            this.grpSelectCasernePompier.Controls.Add(this.btnNouveau);
            this.grpSelectCasernePompier.Controls.Add(this.cmbPompier);
            this.grpSelectCasernePompier.Controls.Add(this.label2);
            this.grpSelectCasernePompier.Controls.Add(this.cmbChoixCaserne);
            this.grpSelectCasernePompier.Controls.Add(this.label1);
            this.grpSelectCasernePompier.Controls.Add(this.pictureBox1);
            this.grpSelectCasernePompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpSelectCasernePompier.Location = new System.Drawing.Point(233, 106);
            this.grpSelectCasernePompier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSelectCasernePompier.Name = "grpSelectCasernePompier";
            this.grpSelectCasernePompier.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSelectCasernePompier.Size = new System.Drawing.Size(373, 947);
            this.grpSelectCasernePompier.TabIndex = 0;
            this.grpSelectCasernePompier.TabStop = false;
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackgroundImage = global::SEAA21_Form4.Properties.Resources.AjouterPompier;
            this.btnNouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNouveau.Location = new System.Drawing.Point(98, 560);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(178, 160);
            this.btnNouveau.TabIndex = 5;
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // cmbPompier
            // 
            this.cmbPompier.FormattingEnabled = true;
            this.cmbPompier.Location = new System.Drawing.Point(27, 260);
            this.cmbPompier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPompier.Name = "cmbPompier";
            this.cmbPompier.Size = new System.Drawing.Size(325, 33);
            this.cmbPompier.TabIndex = 4;
            this.cmbPompier.SelectedIndexChanged += new System.EventHandler(this.cmbPompier_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Veuillez séléctionner un pompier :";
            // 
            // cmbChoixCaserne
            // 
            this.cmbChoixCaserne.FormattingEnabled = true;
            this.cmbChoixCaserne.Location = new System.Drawing.Point(27, 169);
            this.cmbChoixCaserne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChoixCaserne.Name = "cmbChoixCaserne";
            this.cmbChoixCaserne.Size = new System.Drawing.Size(325, 33);
            this.cmbChoixCaserne.TabIndex = 2;
            this.cmbChoixCaserne.SelectedIndexChanged += new System.EventHandler(this.cmbChoixCaserne_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veuillez séléctionner la caserne :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SEAA21_Form4.Properties.Resources.Personne;
            this.pictureBox1.Location = new System.Drawing.Point(142, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 80);
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
            this.grpInformations.Location = new System.Drawing.Point(612, 106);
            this.grpInformations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformations.Name = "grpInformations";
            this.grpInformations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpInformations.Size = new System.Drawing.Size(1300, 329);
            this.grpInformations.TabIndex = 1;
            this.grpInformations.TabStop = false;
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(237)))), ((int)(((byte)(198)))));
            this.btnConnexion.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.Black;
            this.btnConnexion.Location = new System.Drawing.Point(1111, 25);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(182, 54);
            this.btnConnexion.TabIndex = 11;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // pctGrade
            // 
            this.pctGrade.Image = global::SEAA21_Form4.Properties.Resources.SAP;
            this.pctGrade.Location = new System.Drawing.Point(817, 32);
            this.pctGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctGrade.Name = "pctGrade";
            this.pctGrade.Size = new System.Drawing.Size(178, 160);
            this.pctGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGrade.TabIndex = 9;
            this.pctGrade.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBIP);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.lblGrade);
            this.groupBox1.Location = new System.Drawing.Point(5, 224);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1289, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrière";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblBIP
            // 
            this.lblBIP.AutoSize = true;
            this.lblBIP.Location = new System.Drawing.Point(228, 57);
            this.lblBIP.Name = "lblBIP";
            this.lblBIP.Size = new System.Drawing.Size(54, 27);
            this.lblBIP.TabIndex = 11;
            this.lblBIP.Text = "BIP :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(432, 57);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(117, 27);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "Téléphone :";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(5, 57);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(77, 27);
            this.lblGrade.TabIndex = 9;
            this.lblGrade.Text = "Grade :";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Location = new System.Drawing.Point(5, 157);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(163, 27);
            this.lblDateEmbauche.TabIndex = 7;
            this.lblDateEmbauche.Text = "Date embauche :";
            // 
            // rdbPro
            // 
            this.rdbPro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdbPro.AutoSize = true;
            this.rdbPro.Enabled = false;
            this.rdbPro.Location = new System.Drawing.Point(442, 154);
            this.rdbPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbPro.Name = "rdbPro";
            this.rdbPro.Size = new System.Drawing.Size(156, 31);
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
            this.rdbVolontaire.Location = new System.Drawing.Point(442, 190);
            this.rdbVolontaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(128, 31);
            this.rdbVolontaire.TabIndex = 5;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // lblDateDeNaissance
            // 
            this.lblDateDeNaissance.AutoSize = true;
            this.lblDateDeNaissance.Location = new System.Drawing.Point(234, 87);
            this.lblDateDeNaissance.Name = "lblDateDeNaissance";
            this.lblDateDeNaissance.Size = new System.Drawing.Size(184, 27);
            this.lblDateDeNaissance.TabIndex = 4;
            this.lblDateDeNaissance.Text = "Date de naissance :";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(5, 87);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(62, 27);
            this.lblSexe.TabIndex = 3;
            this.lblSexe.Text = "Sexe :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(234, 25);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(93, 27);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(5, 25);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(68, 27);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // lblMatricule
            // 
            this.lblMatricule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(566, 25);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(116, 27);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule X";
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(597, 95);
            this.cmbGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(432, 35);
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
            this.grpInformationPlus.Location = new System.Drawing.Point(612, 479);
            this.grpInformationPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformationPlus.Name = "grpInformationPlus";
            this.grpInformationPlus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformationPlus.Size = new System.Drawing.Size(1300, 574);
            this.grpInformationPlus.TabIndex = 2;
            this.grpInformationPlus.TabStop = false;
            this.grpInformationPlus.Text = "Informations Carrière";
            this.grpInformationPlus.Visible = false;
            // 
            // chkConge
            // 
            this.chkConge.AutoSize = true;
            this.chkConge.Location = new System.Drawing.Point(1056, 46);
            this.chkConge.Margin = new System.Windows.Forms.Padding(4);
            this.chkConge.Name = "chkConge";
            this.chkConge.Size = new System.Drawing.Size(116, 31);
            this.chkConge.TabIndex = 22;
            this.chkConge.Text = "En congé";
            this.chkConge.UseVisualStyleBackColor = true;
            this.chkConge.CheckedChanged += new System.EventHandler(this.chkConge_CheckedChanged);
            this.chkConge.Click += new System.EventHandler(this.chkConge_Click);
            // 
            // lblGrade2
            // 
            this.lblGrade2.AutoSize = true;
            this.lblGrade2.Location = new System.Drawing.Point(5, 73);
            this.lblGrade2.Name = "lblGrade2";
            this.lblGrade2.Size = new System.Drawing.Size(77, 27);
            this.lblGrade2.TabIndex = 21;
            this.lblGrade2.Text = "Grade :";
            // 
            // btnMoins
            // 
            this.btnMoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(240)))), ((int)(((byte)(227)))));
            this.btnMoins.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoins.ForeColor = System.Drawing.Color.Black;
            this.btnMoins.Location = new System.Drawing.Point(1045, 496);
            this.btnMoins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(248, 40);
            this.btnMoins.TabIndex = 20;
            this.btnMoins.Text = "Moins d\'informations";
            this.btnMoins.UseVisualStyleBackColor = false;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // lstbAffectations
            // 
            this.lstbAffectations.FormattingEnabled = true;
            this.lstbAffectations.ItemHeight = 27;
            this.lstbAffectations.Location = new System.Drawing.Point(6, 397);
            this.lstbAffectations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbAffectations.Name = "lstbAffectations";
            this.lstbAffectations.Size = new System.Drawing.Size(700, 139);
            this.lstbAffectations.Sorted = true;
            this.lstbAffectations.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(0, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 27);
            this.label15.TabIndex = 17;
            this.label15.Text = "Affectations passées";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // lstbHabilitations
            // 
            this.lstbHabilitations.FormattingEnabled = true;
            this.lstbHabilitations.ItemHeight = 27;
            this.lstbHabilitations.Location = new System.Drawing.Point(6, 166);
            this.lstbHabilitations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbHabilitations.Name = "lstbHabilitations";
            this.lstbHabilitations.Size = new System.Drawing.Size(700, 139);
            this.lstbHabilitations.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 27);
            this.label14.TabIndex = 15;
            this.label14.Text = "Habilitations";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // cmbCaserneRattachement
            // 
            this.cmbCaserneRattachement.FormattingEnabled = true;
            this.cmbCaserneRattachement.Location = new System.Drawing.Point(597, 46);
            this.cmbCaserneRattachement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCaserneRattachement.Name = "cmbCaserneRattachement";
            this.cmbCaserneRattachement.Size = new System.Drawing.Size(432, 35);
            this.cmbCaserneRattachement.TabIndex = 14;
            this.cmbCaserneRattachement.SelectedIndexChanged += new System.EventHandler(this.cmbCaserneRattachement_SelectedIndexChanged);
            this.cmbCaserneRattachement.Leave += new System.EventHandler(this.cmbCaserneRattachement_Leave);
            // 
            // lblRattachement
            // 
            this.lblRattachement.AutoSize = true;
            this.lblRattachement.Location = new System.Drawing.Point(5, 38);
            this.lblRattachement.Name = "lblRattachement";
            this.lblRattachement.Size = new System.Drawing.Size(246, 27);
            this.lblRattachement.TabIndex = 14;
            this.lblRattachement.Text = "Caserne de rattachement :";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(240)))), ((int)(((byte)(227)))));
            this.btnPlus.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.Black;
            this.btnPlus.Location = new System.Drawing.Point(1668, 439);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(244, 40);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "Plus d\'informations";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Visible = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(0, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(227, 1000);
            this.userControl21.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 34.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(641, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(885, 71);
            this.label3.TabIndex = 21;
            this.label3.Text = "Visualisation des pompiers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGestionDesPompiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1924, 962);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.grpInformationPlus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.grpInformations);
            this.Controls.Add(this.grpSelectCasernePompier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.PerformLayout();

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
        private User_Control_Missions_TDB.UserControl2 userControl21;
        private System.Windows.Forms.Label label3;
    }
}

