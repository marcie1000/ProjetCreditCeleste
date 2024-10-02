
namespace CreditCeleste
{
    partial class frmIntroduction
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
            this.cboCiv = new System.Windows.Forms.ComboBox();
            this.cboVendeur = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNouvVhc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAncVhc = new System.Windows.Forms.TextBox();
            this.gpbAgeV = new System.Windows.Forms.GroupBox();
            this.rdbOccasion5ouPlus = new System.Windows.Forms.RadioButton();
            this.rdbOccasion3a5 = new System.Windows.Forms.RadioButton();
            this.rdbOccasionMoins3 = new System.Windows.Forms.RadioButton();
            this.rdbNeuf = new System.Windows.Forms.RadioButton();
            this.cmdEnregistrer = new System.Windows.Forms.Button();
            this.cmdVoiture = new System.Windows.Forms.Button();
            this.cmdValider = new System.Windows.Forms.Button();
            this.lblNomVendeur = new System.Windows.Forms.Label();
            this.gpbAgeV.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCiv
            // 
            this.cboCiv.FormattingEnabled = true;
            this.cboCiv.Items.AddRange(new object[] {
            "Mme",
            "Mlle",
            "M."});
            this.cboCiv.Location = new System.Drawing.Point(56, 42);
            this.cboCiv.Name = "cboCiv";
            this.cboCiv.Size = new System.Drawing.Size(214, 24);
            this.cboCiv.TabIndex = 0;
            // 
            // cboVendeur
            // 
            this.cboVendeur.FormattingEnabled = true;
            this.cboVendeur.Location = new System.Drawing.Point(56, 222);
            this.cboVendeur.Name = "cboVendeur";
            this.cboVendeur.Size = new System.Drawing.Size(214, 24);
            this.cboVendeur.TabIndex = 3;
            this.cboVendeur.SelectedIndexChanged += new System.EventHandler(this.cboVendeur_SelectedIndexChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(56, 102);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(214, 22);
            this.txtNom.TabIndex = 4;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(56, 160);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(214, 22);
            this.txtPrenom.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Je m\'appelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vendeur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mon Nouveau Véhicule";
            // 
            // txtNouvVhc
            // 
            this.txtNouvVhc.Location = new System.Drawing.Point(329, 95);
            this.txtNouvVhc.Name = "txtNouvVhc";
            this.txtNouvVhc.Size = new System.Drawing.Size(121, 22);
            this.txtNouvVhc.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mon Ancien Véhicule";
            // 
            // txtAncVhc
            // 
            this.txtAncVhc.Location = new System.Drawing.Point(572, 75);
            this.txtAncVhc.Name = "txtAncVhc";
            this.txtAncVhc.Size = new System.Drawing.Size(121, 22);
            this.txtAncVhc.TabIndex = 12;
            // 
            // gpbAgeV
            // 
            this.gpbAgeV.Controls.Add(this.rdbOccasion5ouPlus);
            this.gpbAgeV.Controls.Add(this.rdbOccasion3a5);
            this.gpbAgeV.Controls.Add(this.rdbOccasionMoins3);
            this.gpbAgeV.Controls.Add(this.rdbNeuf);
            this.gpbAgeV.Location = new System.Drawing.Point(329, 160);
            this.gpbAgeV.Name = "gpbAgeV";
            this.gpbAgeV.Size = new System.Drawing.Size(200, 167);
            this.gpbAgeV.TabIndex = 14;
            this.gpbAgeV.TabStop = false;
            this.gpbAgeV.Text = "Âge du véhicule";
            // 
            // rdbOccasion5ouPlus
            // 
            this.rdbOccasion5ouPlus.AutoSize = true;
            this.rdbOccasion5ouPlus.Location = new System.Drawing.Point(20, 117);
            this.rdbOccasion5ouPlus.Name = "rdbOccasion5ouPlus";
            this.rdbOccasion5ouPlus.Size = new System.Drawing.Size(177, 21);
            this.rdbOccasion5ouPlus.TabIndex = 3;
            this.rdbOccasion5ouPlus.TabStop = true;
            this.rdbOccasion5ouPlus.Text = "Occasion 5 ans ou plus";
            this.rdbOccasion5ouPlus.UseVisualStyleBackColor = true;
            // 
            // rdbOccasion3a5
            // 
            this.rdbOccasion3a5.AutoSize = true;
            this.rdbOccasion3a5.Location = new System.Drawing.Point(20, 90);
            this.rdbOccasion3a5.Name = "rdbOccasion3a5";
            this.rdbOccasion3a5.Size = new System.Drawing.Size(171, 21);
            this.rdbOccasion3a5.TabIndex = 2;
            this.rdbOccasion3a5.TabStop = true;
            this.rdbOccasion3a5.Text = "Occasion de 3 à 5 ans";
            this.rdbOccasion3a5.UseVisualStyleBackColor = true;
            // 
            // rdbOccasionMoins3
            // 
            this.rdbOccasionMoins3.AutoSize = true;
            this.rdbOccasionMoins3.Location = new System.Drawing.Point(20, 63);
            this.rdbOccasionMoins3.Name = "rdbOccasionMoins3";
            this.rdbOccasionMoins3.Size = new System.Drawing.Size(156, 21);
            this.rdbOccasionMoins3.TabIndex = 1;
            this.rdbOccasionMoins3.TabStop = true;
            this.rdbOccasionMoins3.Text = "Occasion - de 3 ans";
            this.rdbOccasionMoins3.UseVisualStyleBackColor = true;
            // 
            // rdbNeuf
            // 
            this.rdbNeuf.AutoSize = true;
            this.rdbNeuf.Location = new System.Drawing.Point(20, 36);
            this.rdbNeuf.Name = "rdbNeuf";
            this.rdbNeuf.Size = new System.Drawing.Size(59, 21);
            this.rdbNeuf.TabIndex = 0;
            this.rdbNeuf.TabStop = true;
            this.rdbNeuf.Text = "Neuf";
            this.rdbNeuf.UseVisualStyleBackColor = true;
            // 
            // cmdEnregistrer
            // 
            this.cmdEnregistrer.Location = new System.Drawing.Point(40, 369);
            this.cmdEnregistrer.Name = "cmdEnregistrer";
            this.cmdEnregistrer.Size = new System.Drawing.Size(134, 41);
            this.cmdEnregistrer.TabIndex = 15;
            this.cmdEnregistrer.Text = "Enregistrer";
            this.cmdEnregistrer.UseVisualStyleBackColor = true;
            this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
            // 
            // cmdVoiture
            // 
            this.cmdVoiture.Location = new System.Drawing.Point(233, 369);
            this.cmdVoiture.Name = "cmdVoiture";
            this.cmdVoiture.Size = new System.Drawing.Size(134, 41);
            this.cmdVoiture.TabIndex = 16;
            this.cmdVoiture.Text = "Voiture";
            this.cmdVoiture.UseVisualStyleBackColor = true;
            this.cmdVoiture.Click += new System.EventHandler(this.cmdVoiture_Click);
            // 
            // cmdValider
            // 
            this.cmdValider.Location = new System.Drawing.Point(579, 369);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(134, 41);
            this.cmdValider.TabIndex = 17;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            // 
            // lblNomVendeur
            // 
            this.lblNomVendeur.AutoSize = true;
            this.lblNomVendeur.Location = new System.Drawing.Point(572, 19);
            this.lblNomVendeur.Name = "lblNomVendeur";
            this.lblNomVendeur.Size = new System.Drawing.Size(29, 17);
            this.lblNomVendeur.TabIndex = 18;
            this.lblNomVendeur.Text = "vvv";
            // 
            // frmIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 454);
            this.Controls.Add(this.lblNomVendeur);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.cmdVoiture);
            this.Controls.Add(this.cmdEnregistrer);
            this.Controls.Add(this.gpbAgeV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAncVhc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNouvVhc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.cboVendeur);
            this.Controls.Add(this.cboCiv);
            this.Name = "frmIntroduction";
            this.Text = "Introduction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIntroduction_FormClosing);
            this.Load += new System.EventHandler(this.frmIntroduction_Load);
            this.VisibleChanged += new System.EventHandler(this.frmIntroduction_VisibleChanged);
            this.gpbAgeV.ResumeLayout(false);
            this.gpbAgeV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCiv;
        private System.Windows.Forms.ComboBox cboVendeur;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNouvVhc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAncVhc;
        private System.Windows.Forms.GroupBox gpbAgeV;
        private System.Windows.Forms.RadioButton rdbOccasion5ouPlus;
        private System.Windows.Forms.RadioButton rdbOccasion3a5;
        private System.Windows.Forms.RadioButton rdbOccasionMoins3;
        private System.Windows.Forms.RadioButton rdbNeuf;
        private System.Windows.Forms.Button cmdEnregistrer;
        private System.Windows.Forms.Button cmdVoiture;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Label lblNomVendeur;
    }
}