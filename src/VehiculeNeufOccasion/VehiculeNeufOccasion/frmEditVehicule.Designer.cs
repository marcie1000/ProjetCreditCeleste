namespace VehiculeNeufOccasion
{
    partial class frmEditVehicule
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
            this.groupBoxInformations = new System.Windows.Forms.GroupBox();
            this.cbxMarque = new System.Windows.Forms.ComboBox();
            this.cbxModele = new System.Windows.Forms.ComboBox();
            this.cbxCarburant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numAnnee = new System.Windows.Forms.NumericUpDown();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxEtat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numKilometrage = new System.Windows.Forms.NumericUpDown();
            this.numPrix = new System.Windows.Forms.NumericUpDown();
            this.numPuissance = new System.Windows.Forms.NumericUpDown();
            this.lblTitre = new System.Windows.Forms.Label();
            this.groupBoxInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKilometrage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPuissance)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInformations
            // 
            this.groupBoxInformations.Controls.Add(this.numPuissance);
            this.groupBoxInformations.Controls.Add(this.numPrix);
            this.groupBoxInformations.Controls.Add(this.numKilometrage);
            this.groupBoxInformations.Controls.Add(this.cbxEtat);
            this.groupBoxInformations.Controls.Add(this.label9);
            this.groupBoxInformations.Controls.Add(this.txtCouleur);
            this.groupBoxInformations.Controls.Add(this.label8);
            this.groupBoxInformations.Controls.Add(this.numAnnee);
            this.groupBoxInformations.Controls.Add(this.cbxMarque);
            this.groupBoxInformations.Controls.Add(this.cbxModele);
            this.groupBoxInformations.Controls.Add(this.cbxCarburant);
            this.groupBoxInformations.Controls.Add(this.label1);
            this.groupBoxInformations.Controls.Add(this.label2);
            this.groupBoxInformations.Controls.Add(this.label3);
            this.groupBoxInformations.Controls.Add(this.label7);
            this.groupBoxInformations.Controls.Add(this.label4);
            this.groupBoxInformations.Controls.Add(this.label6);
            this.groupBoxInformations.Controls.Add(this.label5);
            this.groupBoxInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformations.Location = new System.Drawing.Point(205, 55);
            this.groupBoxInformations.Name = "groupBoxInformations";
            this.groupBoxInformations.Size = new System.Drawing.Size(529, 437);
            this.groupBoxInformations.TabIndex = 23;
            this.groupBoxInformations.TabStop = false;
            this.groupBoxInformations.Text = "Informations du véhicule";
            // 
            // cbxMarque
            // 
            this.cbxMarque.AutoCompleteCustomSource.AddRange(new string[] {
            "Abarth  ",
            "Acura  ",
            "Alfa Romeo  ",
            "Alpine  ",
            "Aston Martin  ",
            "Audi  ",
            "Bentley  ",
            "BMW  ",
            "Bugatti  ",
            "Buick  ",
            "Cadillac  ",
            "Caterham  ",
            "Chevrolet  ",
            "Chrysler  ",
            "Citroën  ",
            "Dacia  ",
            "Daewoo  ",
            "Daihatsu  ",
            "Dodge  ",
            "Ferrari  ",
            "Fiat  ",
            "Fisker  ",
            "Ford  ",
            "GMC  ",
            "Genesis  ",
            "Honda  ",
            "Hummer  ",
            "Hyundai  ",
            "Infiniti  ",
            "Isuzu  ",
            "Jaguar  ",
            "Jeep  ",
            "Kia  ",
            "Koenigsegg  ",
            "Lamborghini  ",
            "Lancia  ",
            "Land Rover  ",
            "Lexus  ",
            "Lincoln  ",
            "Lotus  ",
            "Maserati  ",
            "Mazda  ",
            "McLaren  ",
            "Mercedes-Benz  ",
            "Mini  ",
            "Mitsubishi  ",
            "Nissan  ",
            "Opel  ",
            "Pagani  ",
            "Peugeot  ",
            "Polestar  ",
            "Porsche  ",
            "RAM  ",
            "Renault  ",
            "Rolls-Royce  ",
            "Saab  ",
            "Seat  ",
            "Škoda  ",
            "Smart  ",
            "SsangYong  ",
            "Subaru  ",
            "Suzuki  ",
            "Tesla  ",
            "Toyota  ",
            "Volkswagen  ",
            "Volvo  "});
            this.cbxMarque.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cbxMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarque.FormattingEnabled = true;
            this.cbxMarque.Location = new System.Drawing.Point(18, 55);
            this.cbxMarque.Name = "cbxMarque";
            this.cbxMarque.Size = new System.Drawing.Size(201, 28);
            this.cbxMarque.TabIndex = 0;
            this.cbxMarque.SelectedIndexChanged += new System.EventHandler(this.cbxMarque_SelectedIndexChanged);
            // 
            // cbxModele
            // 
            this.cbxModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxModele.FormattingEnabled = true;
            this.cbxModele.Location = new System.Drawing.Point(279, 54);
            this.cbxModele.Name = "cbxModele";
            this.cbxModele.Size = new System.Drawing.Size(216, 28);
            this.cbxModele.TabIndex = 1;
            // 
            // cbxCarburant
            // 
            this.cbxCarburant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCarburant.FormattingEnabled = true;
            this.cbxCarburant.Location = new System.Drawing.Point(279, 219);
            this.cbxCarburant.Name = "cbxCarburant";
            this.cbxCarburant.Size = new System.Drawing.Size(216, 28);
            this.cbxCarburant.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modèle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estimation du prix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Puissance (ch)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Année";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Carburant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kilométrage";
            // 
            // numAnnee
            // 
            this.numAnnee.Location = new System.Drawing.Point(283, 138);
            this.numAnnee.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numAnnee.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numAnnee.Name = "numAnnee";
            this.numAnnee.Size = new System.Drawing.Size(212, 27);
            this.numAnnee.TabIndex = 19;
            this.numAnnee.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(382, 517);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(168, 50);
            this.btnValider.TabIndex = 24;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtCouleur
            // 
            this.txtCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCouleur.Location = new System.Drawing.Point(279, 306);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(201, 27);
            this.txtCouleur.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(279, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Couleur";
            // 
            // cbxEtat
            // 
            this.cbxEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEtat.FormattingEnabled = true;
            this.cbxEtat.Location = new System.Drawing.Point(18, 383);
            this.cbxEtat.Name = "cbxEtat";
            this.cbxEtat.Size = new System.Drawing.Size(216, 28);
            this.cbxEtat.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Etat";
            // 
            // numKilometrage
            // 
            this.numKilometrage.Location = new System.Drawing.Point(18, 223);
            this.numKilometrage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numKilometrage.Name = "numKilometrage";
            this.numKilometrage.Size = new System.Drawing.Size(201, 27);
            this.numKilometrage.TabIndex = 24;
            this.numKilometrage.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numPrix
            // 
            this.numPrix.Location = new System.Drawing.Point(22, 139);
            this.numPrix.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrix.Name = "numPrix";
            this.numPrix.Size = new System.Drawing.Size(201, 27);
            this.numPrix.TabIndex = 25;
            // 
            // numPuissance
            // 
            this.numPuissance.Location = new System.Drawing.Point(18, 309);
            this.numPuissance.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPuissance.Name = "numPuissance";
            this.numPuissance.Size = new System.Drawing.Size(201, 27);
            this.numPuissance.TabIndex = 26;
            this.numPuissance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(389, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(178, 25);
            this.lblTitre.TabIndex = 25;
            this.lblTitre.Text = "Ajouter un véhicule";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmEditVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 596);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.groupBoxInformations);
            this.Name = "frmEditVehicule";
            this.Text = "frmEditVehicule";
            this.Load += new System.EventHandler(this.frmEditVehicule_Load);
            this.groupBoxInformations.ResumeLayout(false);
            this.groupBoxInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKilometrage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPuissance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformations;
        private System.Windows.Forms.ComboBox cbxMarque;
        private System.Windows.Forms.ComboBox cbxModele;
        private System.Windows.Forms.ComboBox cbxCarburant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numAnnee;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxEtat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numKilometrage;
        private System.Windows.Forms.NumericUpDown numPrix;
        private System.Windows.Forms.NumericUpDown numPuissance;
        private System.Windows.Forms.Label lblTitre;
    }
}