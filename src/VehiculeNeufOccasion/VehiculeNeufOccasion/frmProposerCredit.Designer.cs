
namespace VehiculeNeufOccasion
{
    partial class frmProposerCredit
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.rdbPasDeCredit = new System.Windows.Forms.RadioButton();
            this.rdbSouscrire = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrixTotalVehicule = new System.Windows.Forms.Label();
            this.lblMontantRachat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrixTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb1_NbMensualités = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb3_PremierApport = new System.Windows.Forms.CheckBox();
            this.cb2_MontantMensualites = new System.Windows.Forms.CheckBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnContinuer = new System.Windows.Forms.Button();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.numNbMensualites = new System.Windows.Forms.NumericUpDown();
            this.numMontantMensualites = new System.Windows.Forms.NumericUpDown();
            this.numTaux = new System.Windows.Forms.NumericUpDown();
            this.numPremierApport = new System.Windows.Forms.NumericUpDown();
            this.groupBoxChoix.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbMensualites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontantMensualites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPremierApport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proposer un crédit";
            // 
            // groupBoxChoix
            // 
            this.groupBoxChoix.Controls.Add(this.rdbPasDeCredit);
            this.groupBoxChoix.Controls.Add(this.rdbSouscrire);
            this.groupBoxChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChoix.Location = new System.Drawing.Point(71, 71);
            this.groupBoxChoix.Name = "groupBoxChoix";
            this.groupBoxChoix.Size = new System.Drawing.Size(966, 65);
            this.groupBoxChoix.TabIndex = 2;
            this.groupBoxChoix.TabStop = false;
            this.groupBoxChoix.Text = "Choix";
            // 
            // rdbPasDeCredit
            // 
            this.rdbPasDeCredit.AutoSize = true;
            this.rdbPasDeCredit.Location = new System.Drawing.Point(551, 26);
            this.rdbPasDeCredit.Name = "rdbPasDeCredit";
            this.rdbPasDeCredit.Size = new System.Drawing.Size(382, 24);
            this.rdbPasDeCredit.TabIndex = 1;
            this.rdbPasDeCredit.TabStop = true;
            this.rdbPasDeCredit.Text = "Le client ne souhaite PAS souscrire à un crédit";
            this.rdbPasDeCredit.UseVisualStyleBackColor = true;
            // 
            // rdbSouscrire
            // 
            this.rdbSouscrire.AutoSize = true;
            this.rdbSouscrire.Location = new System.Drawing.Point(24, 26);
            this.rdbSouscrire.Name = "rdbSouscrire";
            this.rdbSouscrire.Size = new System.Drawing.Size(307, 24);
            this.rdbSouscrire.TabIndex = 0;
            this.rdbSouscrire.TabStop = true;
            this.rdbSouscrire.Text = "Le client souhaite souscrire un crédit";
            this.rdbSouscrire.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prix total du véhicule :";
            // 
            // lblPrixTotalVehicule
            // 
            this.lblPrixTotalVehicule.AutoSize = true;
            this.lblPrixTotalVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixTotalVehicule.Location = new System.Drawing.Point(275, 161);
            this.lblPrixTotalVehicule.Name = "lblPrixTotalVehicule";
            this.lblPrixTotalVehicule.Size = new System.Drawing.Size(32, 20);
            this.lblPrixTotalVehicule.TabIndex = 4;
            this.lblPrixTotalVehicule.Text = "0 €";
            // 
            // lblMontantRachat
            // 
            this.lblMontantRachat.AutoSize = true;
            this.lblMontantRachat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantRachat.Location = new System.Drawing.Point(275, 191);
            this.lblMontantRachat.Name = "lblMontantRachat";
            this.lblMontantRachat.Size = new System.Drawing.Size(32, 20);
            this.lblMontantRachat.TabIndex = 6;
            this.lblMontantRachat.Text = "0 €";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "- Montant du rachat :";
            // 
            // lblPrixTotal
            // 
            this.lblPrixTotal.AutoSize = true;
            this.lblPrixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixTotal.Location = new System.Drawing.Point(275, 222);
            this.lblPrixTotal.Name = "lblPrixTotal";
            this.lblPrixTotal.Size = new System.Drawing.Size(35, 20);
            this.lblPrixTotal.TabIndex = 8;
            this.lblPrixTotal.Text = "0 €";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "= TOTAL à financer :";
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDebut.Location = new System.Drawing.Point(480, 191);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(292, 27);
            this.dateTimePickerDebut.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(476, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Date de début :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(476, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nombre de mensualités :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(476, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Montant des mensualités (€) :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(476, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Taux (%) :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(476, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Premier apport (€) :";
            // 
            // cb1_NbMensualités
            // 
            this.cb1_NbMensualités.AutoSize = true;
            this.cb1_NbMensualités.Location = new System.Drawing.Point(28, 50);
            this.cb1_NbMensualités.Name = "cb1_NbMensualités";
            this.cb1_NbMensualités.Size = new System.Drawing.Size(18, 17);
            this.cb1_NbMensualités.TabIndex = 19;
            this.cb1_NbMensualités.UseVisualStyleBackColor = true;
            this.cb1_NbMensualités.CheckedChanged += new System.EventHandler(this.cb1_NbMensualités_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb3_PremierApport);
            this.groupBox1.Controls.Add(this.cb2_MontantMensualites);
            this.groupBox1.Controls.Add(this.cb1_NbMensualités);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(379, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 228);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manuel";
            // 
            // cb3_PremierApport
            // 
            this.cb3_PremierApport.AutoSize = true;
            this.cb3_PremierApport.Checked = true;
            this.cb3_PremierApport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb3_PremierApport.Location = new System.Drawing.Point(28, 179);
            this.cb3_PremierApport.Name = "cb3_PremierApport";
            this.cb3_PremierApport.Size = new System.Drawing.Size(18, 17);
            this.cb3_PremierApport.TabIndex = 22;
            this.cb3_PremierApport.UseVisualStyleBackColor = true;
            this.cb3_PremierApport.CheckedChanged += new System.EventHandler(this.cb3_PremierApport_CheckedChanged);
            // 
            // cb2_MontantMensualites
            // 
            this.cb2_MontantMensualites.AutoSize = true;
            this.cb2_MontantMensualites.Checked = true;
            this.cb2_MontantMensualites.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb2_MontantMensualites.Location = new System.Drawing.Point(28, 119);
            this.cb2_MontantMensualites.Name = "cb2_MontantMensualites";
            this.cb2_MontantMensualites.Size = new System.Drawing.Size(18, 17);
            this.cb2_MontantMensualites.TabIndex = 20;
            this.cb2_MontantMensualites.UseVisualStyleBackColor = true;
            this.cb2_MontantMensualites.CheckedChanged += new System.EventHandler(this.cb2_MontantMensualites_CheckedChanged);
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(23, 553);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(246, 60);
            this.btnRetour.TabIndex = 21;
            this.btnRetour.Text = "< Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnContinuer
            // 
            this.btnContinuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuer.Location = new System.Drawing.Point(833, 553);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(246, 60);
            this.btnContinuer.TabIndex = 22;
            this.btnContinuer.Text = "Continuer >";
            this.btnContinuer.UseVisualStyleBackColor = true;
            this.btnContinuer.Click += new System.EventHandler(this.btnContinuer_Click);
            // 
            // btnCalculer
            // 
            this.btnCalculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculer.Location = new System.Drawing.Point(480, 553);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(246, 60);
            this.btnCalculer.TabIndex = 23;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // numNbMensualites
            // 
            this.numNbMensualites.Enabled = false;
            this.numNbMensualites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNbMensualites.Location = new System.Drawing.Point(480, 344);
            this.numNbMensualites.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numNbMensualites.Name = "numNbMensualites";
            this.numNbMensualites.Size = new System.Drawing.Size(292, 27);
            this.numNbMensualites.TabIndex = 24;
            // 
            // numMontantMensualites
            // 
            this.numMontantMensualites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMontantMensualites.Location = new System.Drawing.Point(480, 414);
            this.numMontantMensualites.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numMontantMensualites.Name = "numMontantMensualites";
            this.numMontantMensualites.Size = new System.Drawing.Size(292, 27);
            this.numMontantMensualites.TabIndex = 25;
            // 
            // numTaux
            // 
            this.numTaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTaux.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numTaux.Location = new System.Drawing.Point(480, 265);
            this.numTaux.Name = "numTaux";
            this.numTaux.Size = new System.Drawing.Size(292, 27);
            this.numTaux.TabIndex = 26;
            this.numTaux.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // numPremierApport
            // 
            this.numPremierApport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPremierApport.Location = new System.Drawing.Point(480, 480);
            this.numPremierApport.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numPremierApport.Name = "numPremierApport";
            this.numPremierApport.Size = new System.Drawing.Size(292, 27);
            this.numPremierApport.TabIndex = 27;
            // 
            // frmProposerCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 822);
            this.Controls.Add(this.numPremierApport);
            this.Controls.Add(this.numTaux);
            this.Controls.Add(this.numMontantMensualites);
            this.Controls.Add(this.numNbMensualites);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.lblPrixTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMontantRachat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrixTotalVehicule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxChoix);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1127, 685);
            this.Name = "frmProposerCredit";
            this.Text = "Proposer un crédit";
            this.Activated += new System.EventHandler(this.frmProposerCredit_Activated);
            this.Load += new System.EventHandler(this.frmProposerCredit_Load);
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbMensualites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontantMensualites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPremierApport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxChoix;
        private System.Windows.Forms.RadioButton rdbPasDeCredit;
        private System.Windows.Forms.RadioButton rdbSouscrire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrixTotalVehicule;
        private System.Windows.Forms.Label lblMontantRachat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrixTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cb1_NbMensualités;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb3_PremierApport;
        private System.Windows.Forms.CheckBox cb2_MontantMensualites;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnContinuer;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.NumericUpDown numNbMensualites;
        private System.Windows.Forms.NumericUpDown numMontantMensualites;
        private System.Windows.Forms.NumericUpDown numTaux;
        private System.Windows.Forms.NumericUpDown numPremierApport;
    }
}