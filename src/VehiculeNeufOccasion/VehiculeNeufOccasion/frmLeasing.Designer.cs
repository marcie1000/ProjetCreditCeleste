namespace VehiculeNeufOccasion
{
    partial class frmLeasing
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb12;
        private System.Windows.Forms.RadioButton rb24;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnRetour;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.rb24 = new System.Windows.Forms.RadioButton();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(30, 30);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(120, 21);
            this.rb6.TabIndex = 0;
            this.rb6.TabStop = true;
            this.rb6.Text = "6 mois (leasing)";
            this.rb6.UseVisualStyleBackColor = true;
            this.rb6.CheckedChanged += new System.EventHandler(this.LeaseOption_CheckedChanged);
            // 
            // rb12
            // 
            this.rb12.AutoSize = true;
            this.rb12.Location = new System.Drawing.Point(170, 30);
            this.rb12.Name = "rb12";
            this.rb12.Size = new System.Drawing.Size(129, 21);
            this.rb12.TabIndex = 1;
            this.rb12.TabStop = true;
            this.rb12.Text = "12 mois (leasing)";
            this.rb12.UseVisualStyleBackColor = true;
            this.rb12.CheckedChanged += new System.EventHandler(this.LeaseOption_CheckedChanged);
            // 
            // rb24
            // 
            this.rb24.AutoSize = true;
            this.rb24.Location = new System.Drawing.Point(320, 30);
            this.rb24.Name = "rb24";
            this.rb24.Size = new System.Drawing.Size(129, 21);
            this.rb24.TabIndex = 2;
            this.rb24.TabStop = true;
            this.rb24.Text = "24 mois (leasing)";
            this.rb24.UseVisualStyleBackColor = true;
            this.rb24.CheckedChanged += new System.EventHandler(this.LeaseOption_CheckedChanged);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(30, 70);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(0, 17);
            this.lblDetails.TabIndex = 3;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(320, 180);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(120, 40);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(30, 180);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(120, 40);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "< Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // frmLeasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 241);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.rb24);
            this.Controls.Add(this.rb12);
            this.Controls.Add(this.rb6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLeasing";
            this.Text = "Proposition de leasing";
            this.Load += new System.EventHandler(this.frmLeasing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
