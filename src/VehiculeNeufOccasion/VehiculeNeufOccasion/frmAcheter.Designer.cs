
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
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.rdbNeRachetePas = new System.Windows.Forms.RadioButton();
            this.rdbRachat = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.groupBoxInformations = new System.Windows.Forms.GroupBox();
            this.groupBoxChoix.SuspendLayout();
            this.groupBoxInformations.SuspendLayout();
            this.SuspendLayout();
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
            this.cbxMarque.Location = new System.Drawing.Point(25, 82);
            this.cbxMarque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxMarque.Name = "cbxMarque";
            this.cbxMarque.Size = new System.Drawing.Size(165, 37);
            this.cbxMarque.TabIndex = 0;
            this.cbxMarque.SelectedIndexChanged += new System.EventHandler(this.cbxMarque_SelectedIndexChanged);
            // 
            // cbxModele
            // 
            this.cbxModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxModele.FormattingEnabled = true;
            this.cbxModele.Location = new System.Drawing.Point(384, 81);
            this.cbxModele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxModele.Name = "cbxModele";
            this.cbxModele.Size = new System.Drawing.Size(165, 37);
            this.cbxModele.TabIndex = 1;
            // 
            // cbxAnnee
            // 
            this.cbxAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnnee.FormattingEnabled = true;
            this.cbxAnnee.Location = new System.Drawing.Point(384, 202);
            this.cbxAnnee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxAnnee.Name = "cbxAnnee";
            this.cbxAnnee.Size = new System.Drawing.Size(165, 37);
            this.cbxAnnee.TabIndex = 3;
            // 
            // cbxCarburant
            // 
            this.cbxCarburant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCarburant.FormattingEnabled = true;
            this.cbxCarburant.Location = new System.Drawing.Point(384, 328);
            this.cbxCarburant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCarburant.Name = "cbxCarburant";
            this.cbxCarburant.Size = new System.Drawing.Size(165, 37);
            this.cbxCarburant.TabIndex = 5;
            // 
            // cmdRetour
            // 
            this.cmdRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRetour.Location = new System.Drawing.Point(792, 738);
            this.cmdRetour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(258, 74);
            this.cmdRetour.TabIndex = 8;
            this.cmdRetour.Text = "< Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modèle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estimation du prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Année";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kilométrage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Carburant";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 429);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Puissance (ch)";
            // 
            // txtBxPrix
            // 
            this.txtBxPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPrix.Location = new System.Drawing.Point(25, 204);
            this.txtBxPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxPrix.Name = "txtBxPrix";
            this.txtBxPrix.Size = new System.Drawing.Size(165, 34);
            this.txtBxPrix.TabIndex = 16;
            // 
            // txtBxKilometrage
            // 
            this.txtBxKilometrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxKilometrage.Location = new System.Drawing.Point(25, 330);
            this.txtBxKilometrage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxKilometrage.Name = "txtBxKilometrage";
            this.txtBxKilometrage.Size = new System.Drawing.Size(165, 34);
            this.txtBxKilometrage.TabIndex = 17;
            // 
            // txtBxPuissance
            // 
            this.txtBxPuissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPuissance.Location = new System.Drawing.Point(25, 459);
            this.txtBxPuissance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxPuissance.Name = "txtBxPuissance";
            this.txtBxPuissance.Size = new System.Drawing.Size(165, 34);
            this.txtBxPuissance.TabIndex = 18;
            // 
            // groupBoxChoix
            // 
            this.groupBoxChoix.Controls.Add(this.rdbNeRachetePas);
            this.groupBoxChoix.Controls.Add(this.rdbRachat);
            this.groupBoxChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChoix.Location = new System.Drawing.Point(18, 69);
            this.groupBoxChoix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxChoix.Name = "groupBoxChoix";
            this.groupBoxChoix.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxChoix.Size = new System.Drawing.Size(1328, 98);
            this.groupBoxChoix.TabIndex = 20;
            this.groupBoxChoix.TabStop = false;
            this.groupBoxChoix.Text = "Choix";
            // 
            // rdbNeRachetePas
            // 
            this.rdbNeRachetePas.AutoSize = true;
            this.rdbNeRachetePas.Location = new System.Drawing.Point(725, 39);
            this.rdbNeRachetePas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNeRachetePas.Name = "rdbNeRachetePas";
            this.rdbNeRachetePas.Size = new System.Drawing.Size(581, 33);
            this.rdbNeRachetePas.TabIndex = 1;
            this.rdbNeRachetePas.TabStop = true;
            this.rdbNeRachetePas.Text = "La concession ne rachète PAS le véhicule du client\r\n";
            this.rdbNeRachetePas.UseVisualStyleBackColor = true;
            this.rdbNeRachetePas.CheckedChanged += new System.EventHandler(this.rdbNeRachetePas_CheckedChanged);
            // 
            // rdbRachat
            // 
            this.rdbRachat.AutoSize = true;
            this.rdbRachat.Location = new System.Drawing.Point(33, 39);
            this.rdbRachat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbRachat.Name = "rdbRachat";
            this.rdbRachat.Size = new System.Drawing.Size(495, 33);
            this.rdbRachat.TabIndex = 0;
            this.rdbRachat.TabStop = true;
            this.rdbRachat.Text = "La concession rachète le véhicule du client";
            this.rdbRachat.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(560, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(371, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Rachat du véhicule du client";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.Location = new System.Drawing.Point(1088, 738);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(258, 74);
            this.btnSuivant.TabIndex = 21;
            this.btnSuivant.Text = "Suivant >";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // groupBoxInformations
            // 
            this.groupBoxInformations.Controls.Add(this.cbxMarque);
            this.groupBoxInformations.Controls.Add(this.cbxModele);
            this.groupBoxInformations.Controls.Add(this.cbxAnnee);
            this.groupBoxInformations.Controls.Add(this.cbxCarburant);
            this.groupBoxInformations.Controls.Add(this.txtBxPuissance);
            this.groupBoxInformations.Controls.Add(this.label1);
            this.groupBoxInformations.Controls.Add(this.txtBxKilometrage);
            this.groupBoxInformations.Controls.Add(this.label2);
            this.groupBoxInformations.Controls.Add(this.txtBxPrix);
            this.groupBoxInformations.Controls.Add(this.label3);
            this.groupBoxInformations.Controls.Add(this.label7);
            this.groupBoxInformations.Controls.Add(this.label4);
            this.groupBoxInformations.Controls.Add(this.label6);
            this.groupBoxInformations.Controls.Add(this.label5);
            this.groupBoxInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformations.Location = new System.Drawing.Point(18, 198);
            this.groupBoxInformations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInformations.Name = "groupBoxInformations";
            this.groupBoxInformations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInformations.Size = new System.Drawing.Size(727, 582);
            this.groupBoxInformations.TabIndex = 22;
            this.groupBoxInformations.TabStop = false;
            this.groupBoxInformations.Text = "Informations du véhicule";
            // 
            // frmAcheter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 910);
            this.Controls.Add(this.groupBoxInformations);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.groupBoxChoix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAcheter";
            this.Text = "Acheter un véhicule";
            this.Load += new System.EventHandler(this.frmAcheter_Load);
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            this.groupBoxInformations.ResumeLayout(false);
            this.groupBoxInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMarque;
        private System.Windows.Forms.ComboBox cbxModele;
        private System.Windows.Forms.ComboBox cbxAnnee;
        private System.Windows.Forms.ComboBox cbxCarburant;
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
        private System.Windows.Forms.GroupBox groupBoxChoix;
        private System.Windows.Forms.RadioButton rdbNeRachetePas;
        private System.Windows.Forms.RadioButton rdbRachat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.GroupBox groupBoxInformations;
    }
}