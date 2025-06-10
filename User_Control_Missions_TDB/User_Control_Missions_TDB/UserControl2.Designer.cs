namespace User_Control_Missions_TDB
{
    partial class UserControl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_dash = new System.Windows.Forms.Button();
            this.btn_missions = new System.Windows.Forms.Button();
            this.btn_engins = new System.Windows.Forms.Button();
            this.btn_personnel = new System.Windows.Forms.Button();
            this.btn_stats = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.flp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp.CausesValidation = false;
            this.flp.Controls.Add(this.btn_dash);
            this.flp.Controls.Add(this.btn_missions);
            this.flp.Controls.Add(this.btn_engins);
            this.flp.Controls.Add(this.btn_personnel);
            this.flp.Controls.Add(this.btn_stats);
            this.flp.Controls.Add(this.pic);
            this.flp.Controls.Add(this.btn_quitter);
            this.flp.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp.Location = new System.Drawing.Point(0, 0);
            this.flp.Margin = new System.Windows.Forms.Padding(0);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(227, 1000);
            this.flp.TabIndex = 8;
            // 
            // btn_dash
            // 
            this.btn_dash.AutoEllipsis = true;
            this.btn_dash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.btn_dash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dash.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dash.Image = global::User_Control_Missions_TDB.Resource1.home;
            this.btn_dash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dash.Location = new System.Drawing.Point(0, 0);
            this.btn_dash.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dash.Name = "btn_dash";
            this.btn_dash.Size = new System.Drawing.Size(225, 105);
            this.btn_dash.TabIndex = 2;
            this.btn_dash.Text = "Tableau de bord";
            this.btn_dash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dash.UseVisualStyleBackColor = false;
            this.btn_dash.Click += new System.EventHandler(this.btn_dash_Click);
            // 
            // btn_missions
            // 
            this.btn_missions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.btn_missions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_missions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_missions.Image = ((System.Drawing.Image)(resources.GetObject("btn_missions.Image")));
            this.btn_missions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_missions.Location = new System.Drawing.Point(0, 105);
            this.btn_missions.Margin = new System.Windows.Forms.Padding(0);
            this.btn_missions.Name = "btn_missions";
            this.btn_missions.Size = new System.Drawing.Size(225, 105);
            this.btn_missions.TabIndex = 3;
            this.btn_missions.Text = "Nouvelle mission";
            this.btn_missions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_missions.UseVisualStyleBackColor = false;
            this.btn_missions.Click += new System.EventHandler(this.btn_missions_Click);
            // 
            // btn_engins
            // 
            this.btn_engins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.btn_engins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_engins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_engins.Image = ((System.Drawing.Image)(resources.GetObject("btn_engins.Image")));
            this.btn_engins.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_engins.Location = new System.Drawing.Point(0, 210);
            this.btn_engins.Margin = new System.Windows.Forms.Padding(0);
            this.btn_engins.Name = "btn_engins";
            this.btn_engins.Size = new System.Drawing.Size(225, 105);
            this.btn_engins.TabIndex = 4;
            this.btn_engins.Text = "Gestion engins";
            this.btn_engins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_engins.UseVisualStyleBackColor = false;
            this.btn_engins.Click += new System.EventHandler(this.btn_engins_Click);
            // 
            // btn_personnel
            // 
            this.btn_personnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.btn_personnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_personnel.Image = ((System.Drawing.Image)(resources.GetObject("btn_personnel.Image")));
            this.btn_personnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personnel.Location = new System.Drawing.Point(0, 315);
            this.btn_personnel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_personnel.Name = "btn_personnel";
            this.btn_personnel.Size = new System.Drawing.Size(225, 105);
            this.btn_personnel.TabIndex = 5;
            this.btn_personnel.Text = "Gestion personnel";
            this.btn_personnel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_personnel.UseVisualStyleBackColor = false;
            this.btn_personnel.Click += new System.EventHandler(this.btn_personnel_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.btn_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stats.Image = global::User_Control_Missions_TDB.Resource1.stats;
            this.btn_stats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stats.Location = new System.Drawing.Point(0, 420);
            this.btn_stats.Margin = new System.Windows.Forms.Padding(0);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(225, 105);
            this.btn_stats.TabIndex = 6;
            this.btn_stats.Text = "Statistiques";
            this.btn_stats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_stats.UseVisualStyleBackColor = false;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Black;
            this.pic.BackgroundImage = global::User_Control_Missions_TDB.Resource1.FIGER;
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic.Location = new System.Drawing.Point(0, 525);
            this.pic.Margin = new System.Windows.Forms.Padding(0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(226, 352);
            this.pic.TabIndex = 10;
            this.pic.TabStop = false;
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitter.Image = global::User_Control_Missions_TDB.Resource1.leave;
            this.btn_quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quitter.Location = new System.Drawing.Point(0, 877);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(0);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(225, 122);
            this.btn_quitter.TabIndex = 7;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(227, 1000);
            this.flp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_personnel;
        private System.Windows.Forms.Button btn_engins;
        private System.Windows.Forms.Button btn_missions;
        private System.Windows.Forms.Button btn_dash;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.PictureBox pic;
    }
}
