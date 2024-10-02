
namespace CreditCeleste
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
            this.txtPuissance = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtNumImmat = new System.Windows.Forms.TextBox();
            this.txtNouvVhc = new System.Windows.Forms.TextBox();
            this.gpbAgeVehicule = new System.Windows.Forms.GroupBox();
            this.rdbOccasion5ouPlus = new System.Windows.Forms.RadioButton();
            this.rdbOccasion3a5 = new System.Windows.Forms.RadioButton();
            this.rdbOccasionMoins3 = new System.Windows.Forms.RadioButton();
            this.rdbNeuf = new System.Windows.Forms.RadioButton();
            this.cmdEnregistre = new System.Windows.Forms.Button();
            this.cmdIntroduction = new System.Windows.Forms.Button();
            this.cmdValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp1ereImmat = new System.Windows.Forms.DateTimePicker();
            this.gpbAgeVehicule.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPuissance
            // 
            this.txtPuissance.Location = new System.Drawing.Point(827, 273);
            this.txtPuissance.Name = "txtPuissance";
            this.txtPuissance.Size = new System.Drawing.Size(117, 22);
            this.txtPuissance.TabIndex = 1;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(642, 273);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(129, 22);
            this.txtNumSerie.TabIndex = 2;
            // 
            // txtNumImmat
            // 
            this.txtNumImmat.Location = new System.Drawing.Point(378, 273);
            this.txtNumImmat.Name = "txtNumImmat";
            this.txtNumImmat.Size = new System.Drawing.Size(156, 22);
            this.txtNumImmat.TabIndex = 3;
            // 
            // txtNouvVhc
            // 
            this.txtNouvVhc.Location = new System.Drawing.Point(71, 92);
            this.txtNouvVhc.Name = "txtNouvVhc";
            this.txtNouvVhc.Size = new System.Drawing.Size(183, 22);
            this.txtNouvVhc.TabIndex = 4;
            // 
            // gpbAgeVehicule
            // 
            this.gpbAgeVehicule.Controls.Add(this.rdbOccasion5ouPlus);
            this.gpbAgeVehicule.Controls.Add(this.rdbOccasion3a5);
            this.gpbAgeVehicule.Controls.Add(this.rdbOccasionMoins3);
            this.gpbAgeVehicule.Controls.Add(this.rdbNeuf);
            this.gpbAgeVehicule.Location = new System.Drawing.Point(358, 56);
            this.gpbAgeVehicule.Name = "gpbAgeVehicule";
            this.gpbAgeVehicule.Size = new System.Drawing.Size(200, 167);
            this.gpbAgeVehicule.TabIndex = 15;
            this.gpbAgeVehicule.TabStop = false;
            this.gpbAgeVehicule.Text = "Âge du véhicule";
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
            // cmdEnregistre
            // 
            this.cmdEnregistre.Location = new System.Drawing.Point(71, 384);
            this.cmdEnregistre.Name = "cmdEnregistre";
            this.cmdEnregistre.Size = new System.Drawing.Size(137, 40);
            this.cmdEnregistre.TabIndex = 16;
            this.cmdEnregistre.Text = "Enregistrer";
            this.cmdEnregistre.UseVisualStyleBackColor = true;
            this.cmdEnregistre.Click += new System.EventHandler(this.cmdEnregistre_Click);
            // 
            // cmdIntroduction
            // 
            this.cmdIntroduction.Location = new System.Drawing.Point(431, 384);
            this.cmdIntroduction.Name = "cmdIntroduction";
            this.cmdIntroduction.Size = new System.Drawing.Size(137, 40);
            this.cmdIntroduction.TabIndex = 17;
            this.cmdIntroduction.Text = "Introduction";
            this.cmdIntroduction.UseVisualStyleBackColor = true;
            this.cmdIntroduction.Click += new System.EventHandler(this.cmdIntroduction_Click);
            // 
            // cmdValider
            // 
            this.cmdValider.Location = new System.Drawing.Point(596, 384);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(137, 40);
            this.cmdValider.TabIndex = 18;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "MON NOUVEAU VÉHICULE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(824, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Puissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Numéro de série";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Numéro Immatriculation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Date de 1ère immatriculation";
            // 
            // dtp1ereImmat
            // 
            this.dtp1ereImmat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1ereImmat.Location = new System.Drawing.Point(71, 273);
            this.dtp1ereImmat.Name = "dtp1ereImmat";
            this.dtp1ereImmat.Size = new System.Drawing.Size(200, 22);
            this.dtp1ereImmat.TabIndex = 24;
            // 
            // frmVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 572);
            this.Controls.Add(this.dtp1ereImmat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.cmdIntroduction);
            this.Controls.Add(this.cmdEnregistre);
            this.Controls.Add(this.gpbAgeVehicule);
            this.Controls.Add(this.txtNouvVhc);
            this.Controls.Add(this.txtNumImmat);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.txtPuissance);
            this.Name = "frmVoiture";
            this.Text = "Voiture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVoiture_FormClosing);
            this.Load += new System.EventHandler(this.frmVoiture_Load);
            this.gpbAgeVehicule.ResumeLayout(false);
            this.gpbAgeVehicule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPuissance;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtNumImmat;
        private System.Windows.Forms.TextBox txtNouvVhc;
        private System.Windows.Forms.GroupBox gpbAgeVehicule;
        private System.Windows.Forms.RadioButton rdbOccasion5ouPlus;
        private System.Windows.Forms.RadioButton rdbOccasion3a5;
        private System.Windows.Forms.RadioButton rdbOccasionMoins3;
        private System.Windows.Forms.RadioButton rdbNeuf;
        private System.Windows.Forms.Button cmdEnregistre;
        private System.Windows.Forms.Button cmdIntroduction;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp1ereImmat;
    }
}