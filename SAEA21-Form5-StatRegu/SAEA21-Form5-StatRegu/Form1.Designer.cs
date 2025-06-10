namespace SAEA21_Form5_StatRegu
{
    partial class FrmStatistiques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistiques));
            this.cmbSelectionStat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbStat = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSelectionCaserne = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userControl21 = new User_Control_Missions_TDB.UserControl2();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelectionStat
            // 
            this.cmbSelectionStat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbSelectionStat.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectionStat.FormattingEnabled = true;
            this.cmbSelectionStat.Location = new System.Drawing.Point(11, 171);
            this.cmbSelectionStat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSelectionStat.Name = "cmbSelectionStat";
            this.cmbSelectionStat.Size = new System.Drawing.Size(388, 31);
            this.cmbSelectionStat.TabIndex = 0;
            this.cmbSelectionStat.Text = "Sélectionner une statistique";
            this.cmbSelectionStat.SelectedIndexChanged += new System.EventHandler(this.cmbSelectionStat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veuillez séléctionner une statistique";
            // 
            // grpbStat
            // 
            this.grpbStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.grpbStat.Controls.Add(this.pictureBox1);
            this.grpbStat.Controls.Add(this.grpSelectionCaserne);
            this.grpbStat.Controls.Add(this.cmbSelectionStat);
            this.grpbStat.Controls.Add(this.label1);
            this.grpbStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbStat.Location = new System.Drawing.Point(283, -16);
            this.grpbStat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbStat.Name = "grpbStat";
            this.grpbStat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbStat.Size = new System.Drawing.Size(417, 979);
            this.grpbStat.TabIndex = 2;
            this.grpbStat.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAEA21_Form5_StatRegu.Properties.Resources.StatistiqueImage;
            this.pictureBox1.Location = new System.Drawing.Point(11, 450);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // grpSelectionCaserne
            // 
            this.grpSelectionCaserne.Location = new System.Drawing.Point(11, 203);
            this.grpSelectionCaserne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSelectionCaserne.Name = "grpSelectionCaserne";
            this.grpSelectionCaserne.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSelectionCaserne.Size = new System.Drawing.Size(388, 243);
            this.grpSelectionCaserne.TabIndex = 2;
            this.grpSelectionCaserne.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(811, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 813);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(0, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(227, 1000);
            this.userControl21.TabIndex = 4;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 34.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(770, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1009, 71);
            this.label2.TabIndex = 14;
            this.label2.Text = "Visualisation des statistiques";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1924, 962);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpbStat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmStatistiques";
            this.Text = "Statistiques pour le régulateur";
            this.Load += new System.EventHandler(this.FrmStatistiques_Load);
            this.grpbStat.ResumeLayout(false);
            this.grpbStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectionStat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbStat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpSelectionCaserne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private User_Control_Missions_TDB.UserControl2 userControl21;
        private System.Windows.Forms.Label label2;
    }
}

