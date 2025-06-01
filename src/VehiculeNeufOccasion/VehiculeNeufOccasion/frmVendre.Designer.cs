
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnVendre = new System.Windows.Forms.Button();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.listViewVehicules.Location = new System.Drawing.Point(21, 23);
            this.listViewVehicules.MultiSelect = false;
            this.listViewVehicules.Name = "listViewVehicules";
            this.listViewVehicules.Size = new System.Drawing.Size(997, 479);
            this.listViewVehicules.TabIndex = 25;
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
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(17, 517);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(77, 20);
            this.lblMessage.TabIndex = 26;
            this.lblMessage.Text = "Message";
            // 
            // btnVendre
            // 
            this.btnVendre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendre.Location = new System.Drawing.Point(873, 542);
            this.btnVendre.Name = "btnVendre";
            this.btnVendre.Size = new System.Drawing.Size(145, 44);
            this.btnVendre.TabIndex = 27;
            this.btnVendre.Text = "&Vendre...";
            this.btnVendre.UseVisualStyleBackColor = true;
            this.btnVendre.Click += new System.EventHandler(this.btnVendre_Click);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // frmVendre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 633);
            this.ControlBox = false;
            this.Controls.Add(this.btnVendre);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.listViewVehicules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1055, 633);
            this.MinimumSize = new System.Drawing.Size(1055, 633);
            this.Name = "frmVendre";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Revendre un véhicule";
            this.Shown += new System.EventHandler(this.frmVendre_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewVehicules;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ColumnHeader Marque;
        private System.Windows.Forms.ColumnHeader Modèle;
        private System.Windows.Forms.ColumnHeader Année;
        private System.Windows.Forms.ColumnHeader Kilometrage;
        private System.Windows.Forms.ColumnHeader Prix;
        private System.Windows.Forms.ColumnHeader Puissance;
        private System.Windows.Forms.ColumnHeader Couleur;
        private System.Windows.Forms.ColumnHeader Carburant;
        private System.Windows.Forms.ColumnHeader État;
        private System.Windows.Forms.Button btnVendre;
        private System.Windows.Forms.ColumnHeader Id;
    }
}