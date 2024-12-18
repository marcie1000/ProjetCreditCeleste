
namespace VehiculeNeufOccasion
{
    partial class frmLouer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnLouer = new System.Windows.Forms.Button();
            this.lblDureeContrat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlVoiture1 = new VehiculeNeufOccasion.ctrlVoiture();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(1063, 717);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(103, 34);
            this.btnRetour.TabIndex = 40;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // btnLouer
            // 
            this.btnLouer.Location = new System.Drawing.Point(507, 537);
            this.btnLouer.Margin = new System.Windows.Forms.Padding(4);
            this.btnLouer.Name = "btnLouer";
            this.btnLouer.Size = new System.Drawing.Size(120, 52);
            this.btnLouer.TabIndex = 39;
            this.btnLouer.Text = "LOUER";
            this.btnLouer.UseVisualStyleBackColor = true;
            // 
            // lblDureeContrat
            // 
            this.lblDureeContrat.AutoSize = true;
            this.lblDureeContrat.Location = new System.Drawing.Point(906, 147);
            this.lblDureeContrat.Name = "lblDureeContrat";
            this.lblDureeContrat.Size = new System.Drawing.Size(156, 25);
            this.lblDureeContrat.TabIndex = 55;
            this.lblDureeContrat.Text = "Durée du contrat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(912, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "label3";
            // 
            // ctrlVoiture1
            // 
            this.ctrlVoiture1.Annee = "";
            this.ctrlVoiture1.Carburant = "";
            this.ctrlVoiture1.Kilometrage = "";
            this.ctrlVoiture1.Location = new System.Drawing.Point(50, 55);
            this.ctrlVoiture1.Marque = "";
            this.ctrlVoiture1.Name = "ctrlVoiture1";
            this.ctrlVoiture1.Puissance = "";
            this.ctrlVoiture1.Size = new System.Drawing.Size(690, 321);
            this.ctrlVoiture1.TabIndex = 57;
            this.ctrlVoiture1.Load += new System.EventHandler(this.ctrlVoiture1_Load);
            // 
            // frmLouer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 788);
            this.Controls.Add(this.ctrlVoiture1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDureeContrat);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnLouer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLouer";
            this.Text = "Louer un véhicule";
            this.Load += new System.EventHandler(this.frmLouer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnLouer;
        private System.Windows.Forms.Label lblDureeContrat;
        private System.Windows.Forms.Label label3;
        private ctrlVoiture ctrlVoiture1;
    }
}