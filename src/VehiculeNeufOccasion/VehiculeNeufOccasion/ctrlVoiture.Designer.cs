
namespace VehiculeNeufOccasion
{
    partial class ctrlVoiture
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
            this.txtPuissance = new System.Windows.Forms.TextBox();
            this.txtCarburant = new System.Windows.Forms.TextBox();
            this.txtKilometrage = new System.Windows.Forms.TextBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCtrlVoiture = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPuissance
            // 
            this.txtPuissance.Location = new System.Drawing.Point(497, 255);
            this.txtPuissance.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuissance.Name = "txtPuissance";
            this.txtPuissance.Size = new System.Drawing.Size(136, 29);
            this.txtPuissance.TabIndex = 68;
            // 
            // txtCarburant
            // 
            this.txtCarburant.Location = new System.Drawing.Point(273, 255);
            this.txtCarburant.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarburant.Name = "txtCarburant";
            this.txtCarburant.Size = new System.Drawing.Size(136, 29);
            this.txtCarburant.TabIndex = 67;
            // 
            // txtKilometrage
            // 
            this.txtKilometrage.Location = new System.Drawing.Point(56, 255);
            this.txtKilometrage.Margin = new System.Windows.Forms.Padding(4);
            this.txtKilometrage.Name = "txtKilometrage";
            this.txtKilometrage.Size = new System.Drawing.Size(136, 29);
            this.txtKilometrage.TabIndex = 66;
            // 
            // txtAnnee
            // 
            this.txtAnnee.Location = new System.Drawing.Point(496, 133);
            this.txtAnnee.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(136, 29);
            this.txtAnnee.TabIndex = 65;
            // 
            // txtModele
            // 
            this.txtModele.Location = new System.Drawing.Point(273, 133);
            this.txtModele.Margin = new System.Windows.Forms.Padding(4);
            this.txtModele.Name = "txtModele";
            this.txtModele.Size = new System.Drawing.Size(136, 29);
            this.txtModele.TabIndex = 63;
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(56, 133);
            this.txtMarque.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(136, 29);
            this.txtMarque.TabIndex = 62;
            this.txtMarque.TextChanged += new System.EventHandler(this.txtMarque_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 61;
            this.label7.Text = "Puissance (ch)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Carburant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "Kilométrage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Année";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Modèle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Marque";
            // 
            // lblCtrlVoiture
            // 
            this.lblCtrlVoiture.AutoSize = true;
            this.lblCtrlVoiture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtrlVoiture.Location = new System.Drawing.Point(51, 44);
            this.lblCtrlVoiture.Name = "lblCtrlVoiture";
            this.lblCtrlVoiture.Size = new System.Drawing.Size(94, 25);
            this.lblCtrlVoiture.TabIndex = 69;
            this.lblCtrlVoiture.Text = "Voiture :";
            this.lblCtrlVoiture.Click += new System.EventHandler(this.lblCtrlVoiture_Click);
            // 
            // ctrlVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCtrlVoiture);
            this.Controls.Add(this.txtPuissance);
            this.Controls.Add(this.txtCarburant);
            this.Controls.Add(this.txtKilometrage);
            this.Controls.Add(this.txtAnnee);
            this.Controls.Add(this.txtModele);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ctrlVoiture";
            this.Size = new System.Drawing.Size(690, 321);
            this.Load += new System.EventHandler(this.ctrlVoiture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPuissance;
        private System.Windows.Forms.TextBox txtCarburant;
        private System.Windows.Forms.TextBox txtKilometrage;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtModele;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCtrlVoiture;
    }
}
