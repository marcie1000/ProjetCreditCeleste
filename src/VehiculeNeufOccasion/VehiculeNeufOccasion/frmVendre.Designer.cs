
namespace VehiculeNeufOccasion
{
    partial class frmVendre
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnVendre = new System.Windows.Forms.Button();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.txtPrixSouhaite = new System.Windows.Forms.TextBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.txtKilometrage = new System.Windows.Forms.TextBox();
            this.txtCarburant = new System.Windows.Forms.TextBox();
            this.txtPuissance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 497);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Puissance (ch)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Carburant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 368);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kilométrage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Année";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Prix voulu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Modèle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Marque";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(1090, 700);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(103, 34);
            this.btnRetour.TabIndex = 24;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // btnVendre
            // 
            this.btnVendre.Location = new System.Drawing.Point(534, 520);
            this.btnVendre.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendre.Name = "btnVendre";
            this.btnVendre.Size = new System.Drawing.Size(120, 52);
            this.btnVendre.TabIndex = 23;
            this.btnVendre.Text = "VENDRE";
            this.btnVendre.UseVisualStyleBackColor = true;
            this.btnVendre.Click += new System.EventHandler(this.btnVendre_Click);
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(173, 152);
            this.txtMarque.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(136, 29);
            this.txtMarque.TabIndex = 32;
            this.txtMarque.TextChanged += new System.EventHandler(this.txtMarque_TextChanged);
            // 
            // txtModele
            // 
            this.txtModele.Location = new System.Drawing.Point(533, 152);
            this.txtModele.Margin = new System.Windows.Forms.Padding(4);
            this.txtModele.Name = "txtModele";
            this.txtModele.Size = new System.Drawing.Size(136, 29);
            this.txtModele.TabIndex = 33;
            this.txtModele.TextChanged += new System.EventHandler(this.txtModele_TextChanged);
            // 
            // txtPrixSouhaite
            // 
            this.txtPrixSouhaite.Location = new System.Drawing.Point(173, 272);
            this.txtPrixSouhaite.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixSouhaite.Name = "txtPrixSouhaite";
            this.txtPrixSouhaite.Size = new System.Drawing.Size(136, 29);
            this.txtPrixSouhaite.TabIndex = 34;
            this.txtPrixSouhaite.TextChanged += new System.EventHandler(this.txtPrixSouhaite_TextChanged);
            // 
            // txtAnnee
            // 
            this.txtAnnee.Location = new System.Drawing.Point(533, 272);
            this.txtAnnee.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(136, 29);
            this.txtAnnee.TabIndex = 35;
            this.txtAnnee.TextChanged += new System.EventHandler(this.txtAnnee_TextChanged);
            // 
            // txtKilometrage
            // 
            this.txtKilometrage.Location = new System.Drawing.Point(173, 398);
            this.txtKilometrage.Margin = new System.Windows.Forms.Padding(4);
            this.txtKilometrage.Name = "txtKilometrage";
            this.txtKilometrage.Size = new System.Drawing.Size(136, 29);
            this.txtKilometrage.TabIndex = 36;
            this.txtKilometrage.TextChanged += new System.EventHandler(this.txtKilometrage_TextChanged);
            // 
            // txtCarburant
            // 
            this.txtCarburant.Location = new System.Drawing.Point(533, 398);
            this.txtCarburant.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarburant.Name = "txtCarburant";
            this.txtCarburant.Size = new System.Drawing.Size(136, 29);
            this.txtCarburant.TabIndex = 37;
            this.txtCarburant.TextChanged += new System.EventHandler(this.txtCarburant_TextChanged);
            // 
            // txtPuissance
            // 
            this.txtPuissance.Location = new System.Drawing.Point(173, 531);
            this.txtPuissance.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuissance.Name = "txtPuissance";
            this.txtPuissance.Size = new System.Drawing.Size(136, 29);
            this.txtPuissance.TabIndex = 38;
            this.txtPuissance.TextChanged += new System.EventHandler(this.txtPuissance_TextChanged);
            // 
            // frmVendre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 818);
            this.Controls.Add(this.txtPuissance);
            this.Controls.Add(this.txtCarburant);
            this.Controls.Add(this.txtKilometrage);
            this.Controls.Add(this.txtAnnee);
            this.Controls.Add(this.txtPrixSouhaite);
            this.Controls.Add(this.txtModele);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnVendre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVendre";
            this.Text = "Revendre un véhicule";
            this.Load += new System.EventHandler(this.frmVendre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnVendre;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.TextBox txtModele;
        private System.Windows.Forms.TextBox txtPrixSouhaite;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtKilometrage;
        private System.Windows.Forms.TextBox txtCarburant;
        private System.Windows.Forms.TextBox txtPuissance;
    }
}