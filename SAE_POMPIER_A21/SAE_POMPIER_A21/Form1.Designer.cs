namespace SAE_POMPIER_A21
{
    partial class Gestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.flp_uc = new System.Windows.Forms.FlowLayoutPanel();
            this.userControl21 = new User_Control_Missions_TDB.UserControl2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(842, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des missions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flp_uc
            // 
            this.flp_uc.AutoScroll = true;
            this.flp_uc.BackColor = System.Drawing.Color.White;
            this.flp_uc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_uc.Location = new System.Drawing.Point(381, 104);
            this.flp_uc.Margin = new System.Windows.Forms.Padding(10);
            this.flp_uc.Name = "flp_uc";
            this.flp_uc.Padding = new System.Windows.Forms.Padding(20);
            this.flp_uc.Size = new System.Drawing.Size(1481, 825);
            this.flp_uc.TabIndex = 1;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(0, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(227, 1009);
            this.userControl21.TabIndex = 2;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1924, 962);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.flp_uc);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Gestion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp_uc;
        private User_Control_Missions_TDB.UserControl2 userControl21;
    }
}

