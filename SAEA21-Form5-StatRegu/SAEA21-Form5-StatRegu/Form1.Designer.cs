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
            this.cmbSelectionStat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbStat = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSelectionCaserne = new System.Windows.Forms.GroupBox();
            this.rdbCaserne4 = new System.Windows.Forms.RadioButton();
            this.rdbCaserne3 = new System.Windows.Forms.RadioButton();
            this.rdbCaserne2 = new System.Windows.Forms.RadioButton();
            this.rdbCaserne1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpbStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpSelectionCaserne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelectionStat
            // 
            this.cmbSelectionStat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbSelectionStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSelectionStat.FormattingEnabled = true;
            this.cmbSelectionStat.Location = new System.Drawing.Point(11, 83);
            this.cmbSelectionStat.Name = "cmbSelectionStat";
            this.cmbSelectionStat.Size = new System.Drawing.Size(436, 33);
            this.cmbSelectionStat.TabIndex = 0;
            this.cmbSelectionStat.Text = "Sélectionner une statistique";
            this.cmbSelectionStat.SelectedIndexChanged += new System.EventHandler(this.cmbSelectionStat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veuillez séléctionner une statistique";
            // 
            // grpbStat
            // 
            this.grpbStat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpbStat.Controls.Add(this.pictureBox1);
            this.grpbStat.Controls.Add(this.grpSelectionCaserne);
            this.grpbStat.Controls.Add(this.cmbSelectionStat);
            this.grpbStat.Controls.Add(this.label1);
            this.grpbStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbStat.Location = new System.Drawing.Point(12, 12);
            this.grpbStat.Name = "grpbStat";
            this.grpbStat.Size = new System.Drawing.Size(469, 796);
            this.grpbStat.TabIndex = 2;
            this.grpbStat.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAEA21_Form5_StatRegu.Properties.Resources.StatistiqueImage;
            this.pictureBox1.Location = new System.Drawing.Point(11, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // grpSelectionCaserne
            // 
            this.grpSelectionCaserne.Controls.Add(this.rdbCaserne4);
            this.grpSelectionCaserne.Controls.Add(this.rdbCaserne3);
            this.grpSelectionCaserne.Controls.Add(this.rdbCaserne2);
            this.grpSelectionCaserne.Controls.Add(this.rdbCaserne1);
            this.grpSelectionCaserne.Location = new System.Drawing.Point(11, 123);
            this.grpSelectionCaserne.Name = "grpSelectionCaserne";
            this.grpSelectionCaserne.Size = new System.Drawing.Size(436, 183);
            this.grpSelectionCaserne.TabIndex = 2;
            this.grpSelectionCaserne.TabStop = false;
            // 
            // rdbCaserne4
            // 
            this.rdbCaserne4.AutoSize = true;
            this.rdbCaserne4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbCaserne4.Location = new System.Drawing.Point(7, 131);
            this.rdbCaserne4.Name = "rdbCaserne4";
            this.rdbCaserne4.Size = new System.Drawing.Size(136, 29);
            this.rdbCaserne4.TabIndex = 3;
            this.rdbCaserne4.TabStop = true;
            this.rdbCaserne4.Text = "Caserne 4";
            this.rdbCaserne4.UseVisualStyleBackColor = true;
            this.rdbCaserne4.CheckedChanged += new System.EventHandler(this.rdbCaserne4_CheckedChanged);
            // 
            // rdbCaserne3
            // 
            this.rdbCaserne3.AutoSize = true;
            this.rdbCaserne3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbCaserne3.Location = new System.Drawing.Point(7, 96);
            this.rdbCaserne3.Name = "rdbCaserne3";
            this.rdbCaserne3.Size = new System.Drawing.Size(136, 29);
            this.rdbCaserne3.TabIndex = 2;
            this.rdbCaserne3.TabStop = true;
            this.rdbCaserne3.Text = "Caserne 3";
            this.rdbCaserne3.UseVisualStyleBackColor = true;
            this.rdbCaserne3.CheckedChanged += new System.EventHandler(this.rdbCaserne3_CheckedChanged);
            // 
            // rdbCaserne2
            // 
            this.rdbCaserne2.AutoSize = true;
            this.rdbCaserne2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbCaserne2.Location = new System.Drawing.Point(7, 61);
            this.rdbCaserne2.Name = "rdbCaserne2";
            this.rdbCaserne2.Size = new System.Drawing.Size(136, 29);
            this.rdbCaserne2.TabIndex = 1;
            this.rdbCaserne2.TabStop = true;
            this.rdbCaserne2.Text = "Caserne 2";
            this.rdbCaserne2.UseVisualStyleBackColor = true;
            this.rdbCaserne2.CheckedChanged += new System.EventHandler(this.rdbCaserne2_CheckedChanged);
            // 
            // rdbCaserne1
            // 
            this.rdbCaserne1.AutoSize = true;
            this.rdbCaserne1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbCaserne1.Location = new System.Drawing.Point(7, 26);
            this.rdbCaserne1.Name = "rdbCaserne1";
            this.rdbCaserne1.Size = new System.Drawing.Size(136, 29);
            this.rdbCaserne1.TabIndex = 0;
            this.rdbCaserne1.TabStop = true;
            this.rdbCaserne1.Text = "Caserne 1";
            this.rdbCaserne1.UseVisualStyleBackColor = true;
            this.rdbCaserne1.CheckedChanged += new System.EventHandler(this.rdbCaserne1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 751);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1531, 820);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpbStat);
            this.Name = "FrmStatistiques";
            this.Text = "Statistiques pour le régulateur";
            this.Load += new System.EventHandler(this.FrmStatistiques_Load);
            this.grpbStat.ResumeLayout(false);
            this.grpbStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpSelectionCaserne.ResumeLayout(false);
            this.grpSelectionCaserne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectionStat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbStat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpSelectionCaserne;
        private System.Windows.Forms.RadioButton rdbCaserne3;
        private System.Windows.Forms.RadioButton rdbCaserne2;
        private System.Windows.Forms.RadioButton rdbCaserne1;
        private System.Windows.Forms.RadioButton rdbCaserne4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

