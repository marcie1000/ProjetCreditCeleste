
namespace VehiculeNeufOccasion
{
    partial class frmVoiture
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPuissance = new System.Windows.Forms.ComboBox();
            this.cbxCarburant = new System.Windows.Forms.ComboBox();
            this.cbxKilometrage = new System.Windows.Forms.ComboBox();
            this.cbxAnnee = new System.Windows.Forms.ComboBox();
            this.cbxModele = new System.Windows.Forms.ComboBox();
            this.cbxMarque = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Puissance (ch)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Carburant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Kilométrage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Année";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Modèle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Marque";
            // 
            // cbxPuissance
            // 
            this.cbxPuissance.FormattingEnabled = true;
            this.cbxPuissance.Location = new System.Drawing.Point(73, 304);
            this.cbxPuissance.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPuissance.Name = "cbxPuissance";
            this.cbxPuissance.Size = new System.Drawing.Size(165, 32);
            this.cbxPuissance.TabIndex = 22;
            this.cbxPuissance.SelectedIndexChanged += new System.EventHandler(this.cbxPuissance_SelectedIndexChanged);
            // 
            // cbxCarburant
            // 
            this.cbxCarburant.FormattingEnabled = true;
            this.cbxCarburant.Location = new System.Drawing.Point(269, 203);
            this.cbxCarburant.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCarburant.Name = "cbxCarburant";
            this.cbxCarburant.Size = new System.Drawing.Size(165, 32);
            this.cbxCarburant.TabIndex = 21;
            this.cbxCarburant.SelectedIndexChanged += new System.EventHandler(this.cbxCarburant_SelectedIndexChanged);
            // 
            // cbxKilometrage
            // 
            this.cbxKilometrage.FormattingEnabled = true;
            this.cbxKilometrage.Location = new System.Drawing.Point(269, 304);
            this.cbxKilometrage.Margin = new System.Windows.Forms.Padding(4);
            this.cbxKilometrage.Name = "cbxKilometrage";
            this.cbxKilometrage.Size = new System.Drawing.Size(165, 32);
            this.cbxKilometrage.TabIndex = 20;
            this.cbxKilometrage.SelectedIndexChanged += new System.EventHandler(this.cbxKilometrage_SelectedIndexChanged);
            // 
            // cbxAnnee
            // 
            this.cbxAnnee.FormattingEnabled = true;
            this.cbxAnnee.Location = new System.Drawing.Point(73, 203);
            this.cbxAnnee.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAnnee.Name = "cbxAnnee";
            this.cbxAnnee.Size = new System.Drawing.Size(165, 32);
            this.cbxAnnee.TabIndex = 19;
            this.cbxAnnee.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cbxModele
            // 
            this.cbxModele.FormattingEnabled = true;
            this.cbxModele.Location = new System.Drawing.Point(269, 104);
            this.cbxModele.Margin = new System.Windows.Forms.Padding(4);
            this.cbxModele.Name = "cbxModele";
            this.cbxModele.Size = new System.Drawing.Size(165, 32);
            this.cbxModele.TabIndex = 17;
            this.cbxModele.SelectedIndexChanged += new System.EventHandler(this.cbxModele_SelectedIndexChanged);
            // 
            // cbxMarque
            // 
            this.cbxMarque.FormattingEnabled = true;
            this.cbxMarque.Location = new System.Drawing.Point(73, 104);
            this.cbxMarque.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMarque.Name = "cbxMarque";
            this.cbxMarque.Size = new System.Drawing.Size(165, 32);
            this.cbxMarque.TabIndex = 16;
            this.cbxMarque.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 1148);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPuissance);
            this.Controls.Add(this.cbxCarburant);
            this.Controls.Add(this.cbxKilometrage);
            this.Controls.Add(this.cbxAnnee);
            this.Controls.Add(this.cbxModele);
            this.Controls.Add(this.cbxMarque);
            this.Name = "frmVoiture";
            this.Text = "frmVoiture";
            this.Load += new System.EventHandler(this.frmVoiture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPuissance;
        private System.Windows.Forms.ComboBox cbxCarburant;
        private System.Windows.Forms.ComboBox cbxKilometrage;
        private System.Windows.Forms.ComboBox cbxAnnee;
        private System.Windows.Forms.ComboBox cbxModele;
        private System.Windows.Forms.ComboBox cbxMarque;
    }
}