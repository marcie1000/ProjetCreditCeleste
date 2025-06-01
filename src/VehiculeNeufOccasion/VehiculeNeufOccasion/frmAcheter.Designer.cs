
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
            this.cmdRetour = new System.Windows.Forms.Button();
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.rdbNeRachetePas = new System.Windows.Forms.RadioButton();
            this.rdbRachat = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.listViewVehicules = new System.Windows.Forms.ListView();
            this.Marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modèle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Année = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kilometrage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Puissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Couleur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Carburant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.État = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbChoixV = new System.Windows.Forms.GroupBox();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxChoix.SuspendLayout();
            this.gpbChoixV.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRetour
            // 
            this.cmdRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRetour.Location = new System.Drawing.Point(603, 646);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(188, 49);
            this.cmdRetour.TabIndex = 8;
            this.cmdRetour.Text = "< Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // groupBoxChoix
            // 
            this.groupBoxChoix.Controls.Add(this.rdbNeRachetePas);
            this.groupBoxChoix.Controls.Add(this.rdbRachat);
            this.groupBoxChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChoix.Location = new System.Drawing.Point(13, 46);
            this.groupBoxChoix.Name = "groupBoxChoix";
            this.groupBoxChoix.Size = new System.Drawing.Size(966, 65);
            this.groupBoxChoix.TabIndex = 20;
            this.groupBoxChoix.TabStop = false;
            this.groupBoxChoix.Text = "Choix";
            // 
            // rdbNeRachetePas
            // 
            this.rdbNeRachetePas.AutoSize = true;
            this.rdbNeRachetePas.Location = new System.Drawing.Point(527, 26);
            this.rdbNeRachetePas.Name = "rdbNeRachetePas";
            this.rdbNeRachetePas.Size = new System.Drawing.Size(413, 24);
            this.rdbNeRachetePas.TabIndex = 1;
            this.rdbNeRachetePas.TabStop = true;
            this.rdbNeRachetePas.Text = "La concession ne rachète PAS le véhicule du client\r\n";
            this.rdbNeRachetePas.UseVisualStyleBackColor = true;
            this.rdbNeRachetePas.CheckedChanged += new System.EventHandler(this.rdbNeRachetePas_CheckedChanged);
            // 
            // rdbRachat
            // 
            this.rdbRachat.AutoSize = true;
            this.rdbRachat.Location = new System.Drawing.Point(24, 26);
            this.rdbRachat.Name = "rdbRachat";
            this.rdbRachat.Size = new System.Drawing.Size(352, 24);
            this.rdbRachat.TabIndex = 0;
            this.rdbRachat.TabStop = true;
            this.rdbRachat.Text = "La concession rachète le véhicule du client";
            this.rdbRachat.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Rachat du véhicule du client";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.Location = new System.Drawing.Point(818, 646);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(188, 49);
            this.btnSuivant.TabIndex = 21;
            this.btnSuivant.Text = "Suivant >";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Véhicules en possession du client :";
            // 
            // btnCreer
            // 
            this.btnCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.Location = new System.Drawing.Point(726, 261);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(277, 71);
            this.btnCreer.TabIndex = 25;
            this.btnCreer.Text = "➕ Ajouter un véhicule en possession du client...";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // listViewVehicules
            // 
            this.listViewVehicules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Marque,
            this.Modèle,
            this.Année,
            this.Kilometrage,
            this.Prix,
            this.Puissance,
            this.Couleur,
            this.Carburant,
            this.État,
            this.Id});
            this.listViewVehicules.FullRowSelect = true;
            this.listViewVehicules.GridLines = true;
            this.listViewVehicules.HideSelection = false;
            this.listViewVehicules.Location = new System.Drawing.Point(6, 52);
            this.listViewVehicules.MultiSelect = false;
            this.listViewVehicules.Name = "listViewVehicules";
            this.listViewVehicules.Size = new System.Drawing.Size(997, 183);
            this.listViewVehicules.TabIndex = 26;
            this.listViewVehicules.UseCompatibleStateImageBehavior = false;
            this.listViewVehicules.View = System.Windows.Forms.View.Details;
            // 
            // Marque
            // 
            this.Marque.Text = "Marque";
            // 
            // Modèle
            // 
            this.Modèle.Text = "Modèle";
            // 
            // Année
            // 
            this.Année.Text = "Année";
            // 
            // Kilometrage
            // 
            this.Kilometrage.Text = "Kilometrage";
            this.Kilometrage.Width = 90;
            // 
            // Prix
            // 
            this.Prix.Text = "Prix";
            this.Prix.Width = 100;
            // 
            // Puissance
            // 
            this.Puissance.Text = "Puissance";
            this.Puissance.Width = 80;
            // 
            // Couleur
            // 
            this.Couleur.Text = "Couleur";
            // 
            // Carburant
            // 
            this.Carburant.Text = "Carburant";
            this.Carburant.Width = 80;
            // 
            // État
            // 
            this.État.Text = "État";
            // 
            // gpbChoixV
            // 
            this.gpbChoixV.Controls.Add(this.listViewVehicules);
            this.gpbChoixV.Controls.Add(this.label1);
            this.gpbChoixV.Controls.Add(this.btnCreer);
            this.gpbChoixV.Location = new System.Drawing.Point(13, 145);
            this.gpbChoixV.Name = "gpbChoixV";
            this.gpbChoixV.Size = new System.Drawing.Size(1038, 385);
            this.gpbChoixV.TabIndex = 27;
            this.gpbChoixV.TabStop = false;
            this.gpbChoixV.Text = "Choix du véhicule";
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // frmAcheter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 719);
            this.Controls.Add(this.gpbChoixV);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.groupBoxChoix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcheter";
            this.Text = "Acheter un véhicule";
            this.Load += new System.EventHandler(this.frmAcheter_Load);
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            this.gpbChoixV.ResumeLayout(false);
            this.gpbChoixV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.GroupBox groupBoxChoix;
        private System.Windows.Forms.RadioButton rdbNeRachetePas;
        private System.Windows.Forms.RadioButton rdbRachat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.ListView listViewVehicules;
        private System.Windows.Forms.ColumnHeader Marque;
        private System.Windows.Forms.ColumnHeader Modèle;
        private System.Windows.Forms.ColumnHeader Année;
        private System.Windows.Forms.ColumnHeader Kilometrage;
        private System.Windows.Forms.ColumnHeader Prix;
        private System.Windows.Forms.ColumnHeader Puissance;
        private System.Windows.Forms.ColumnHeader Couleur;
        private System.Windows.Forms.ColumnHeader Carburant;
        private System.Windows.Forms.ColumnHeader État;
        private System.Windows.Forms.GroupBox gpbChoixV;
        private System.Windows.Forms.ColumnHeader Id;
    }
}