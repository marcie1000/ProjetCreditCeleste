
namespace VehiculeNeufOccasion
{
    partial class frmAcheter
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
            this.cbxMarque = new System.Windows.Forms.ComboBox();
            this.cbxModele = new System.Windows.Forms.ComboBox();
            this.cbxAnnee = new System.Windows.Forms.ComboBox();
            this.cbxCarburant = new System.Windows.Forms.ComboBox();
            this.cmdAfficher = new System.Windows.Forms.Button();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxPrix = new System.Windows.Forms.TextBox();
            this.txtBxKilometrage = new System.Windows.Forms.TextBox();
            this.txtBxPuissance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxMarque
            // 
            this.cbxMarque.FormattingEnabled = true;
            this.cbxMarque.Location = new System.Drawing.Point(115, 95);
            this.cbxMarque.Name = "cbxMarque";
            this.cbxMarque.Size = new System.Drawing.Size(121, 24);
            this.cbxMarque.TabIndex = 0;
            // 
            // cbxModele
            // 
            this.cbxModele.FormattingEnabled = true;
            this.cbxModele.Location = new System.Drawing.Point(376, 94);
            this.cbxModele.Name = "cbxModele";
            this.cbxModele.Size = new System.Drawing.Size(121, 24);
            this.cbxModele.TabIndex = 1;
            // 
            // cbxAnnee
            // 
            this.cbxAnnee.FormattingEnabled = true;
            this.cbxAnnee.Location = new System.Drawing.Point(376, 175);
            this.cbxAnnee.Name = "cbxAnnee";
            this.cbxAnnee.Size = new System.Drawing.Size(121, 24);
            this.cbxAnnee.TabIndex = 3;
            // 
            // cbxCarburant
            // 
            this.cbxCarburant.FormattingEnabled = true;
            this.cbxCarburant.Location = new System.Drawing.Point(376, 259);
            this.cbxCarburant.Name = "cbxCarburant";
            this.cbxCarburant.Size = new System.Drawing.Size(121, 24);
            this.cbxCarburant.TabIndex = 5;
            // 
            // cmdAfficher
            // 
            this.cmdAfficher.Location = new System.Drawing.Point(376, 349);
            this.cmdAfficher.Name = "cmdAfficher";
            this.cmdAfficher.Size = new System.Drawing.Size(75, 23);
            this.cmdAfficher.TabIndex = 7;
            this.cmdAfficher.Text = "Afficher";
            this.cmdAfficher.UseVisualStyleBackColor = true;
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(671, 405);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 8;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modèle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prix max..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Année";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kilométrage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Carburant";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Puissance (ch)";
            // 
            // txtBxPrix
            // 
            this.txtBxPrix.Location = new System.Drawing.Point(115, 176);
            this.txtBxPrix.Name = "txtBxPrix";
            this.txtBxPrix.Size = new System.Drawing.Size(100, 22);
            this.txtBxPrix.TabIndex = 16;
            // 
            // txtBxKilometrage
            // 
            this.txtBxKilometrage.Location = new System.Drawing.Point(115, 260);
            this.txtBxKilometrage.Name = "txtBxKilometrage";
            this.txtBxKilometrage.Size = new System.Drawing.Size(100, 22);
            this.txtBxKilometrage.TabIndex = 17;
            // 
            // txtBxPuissance
            // 
            this.txtBxPuissance.Location = new System.Drawing.Point(115, 346);
            this.txtBxPuissance.Name = "txtBxPuissance";
            this.txtBxPuissance.Size = new System.Drawing.Size(100, 22);
            this.txtBxPuissance.TabIndex = 18;
            // 
            // frmAcheter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxPuissance);
            this.Controls.Add(this.txtBxKilometrage);
            this.Controls.Add(this.txtBxPrix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.cmdAfficher);
            this.Controls.Add(this.cbxCarburant);
            this.Controls.Add(this.cbxAnnee);
            this.Controls.Add(this.cbxModele);
            this.Controls.Add(this.cbxMarque);
            this.Name = "frmAcheter";
            this.Text = "Acheter un véhicule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMarque;
        private System.Windows.Forms.ComboBox cbxModele;
        private System.Windows.Forms.ComboBox cbxAnnee;
        private System.Windows.Forms.ComboBox cbxCarburant;
        private System.Windows.Forms.Button cmdAfficher;
        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxPrix;
        private System.Windows.Forms.TextBox txtBxKilometrage;
        private System.Windows.Forms.TextBox txtBxPuissance;
    }
}