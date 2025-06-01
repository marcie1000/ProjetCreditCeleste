namespace VehiculeNeufOccasion
{
    partial class frmLouer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewVehicules;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLouer;
        private System.Windows.Forms.Button cmdRetour;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLouer = new System.Windows.Forms.Button();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewVehicules
            // 
            this.listViewVehicules.FullRowSelect = true;
            this.listViewVehicules.GridLines = true;
            this.listViewVehicules.HideSelection = false;
            this.listViewVehicules.Location = new System.Drawing.Point(12, 60);
            this.listViewVehicules.MultiSelect = false;
            this.listViewVehicules.Name = "listViewVehicules";
            this.listViewVehicules.Size = new System.Drawing.Size(900, 350);
            this.listViewVehicules.TabIndex = 0;
            this.listViewVehicules.UseCompatibleStateImageBehavior = false;
            this.listViewVehicules.View = System.Windows.Forms.View.Details;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 20);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 1;
            // 
            // btnLouer
            // 
            this.btnLouer.Location = new System.Drawing.Point(700, 430);
            this.btnLouer.Name = "btnLouer";
            this.btnLouer.Size = new System.Drawing.Size(200, 40);
            this.btnLouer.TabIndex = 2;
            this.btnLouer.Text = "Louer ce véhicule";
            this.btnLouer.UseVisualStyleBackColor = true;
            this.btnLouer.Click += new System.EventHandler(this.btnLouer_Click);
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(12, 430);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(120, 40);
            this.cmdRetour.TabIndex = 3;
            this.cmdRetour.Text = "< Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // frmLouer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 482);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.btnLouer);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.listViewVehicules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLouer";
            this.Text = "Louer un véhicule";
            this.Shown += new System.EventHandler(this.frmLouer_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();
            // 
            // listViewVehicules.Columns
            // 
            this.listViewVehicules.Columns.Add("Marque", 100);
            this.listViewVehicules.Columns.Add("Modèle", 100);
            this.listViewVehicules.Columns.Add("Année", 60);
            this.listViewVehicules.Columns.Add("Km", 80);
            this.listViewVehicules.Columns.Add("Prix", 80);
            this.listViewVehicules.Columns.Add("Puissance", 80);
            this.listViewVehicules.Columns.Add("Couleur", 80);
            this.listViewVehicules.Columns.Add("Carburant", 80);
            this.listViewVehicules.Columns.Add("État", 80);
        }

        #endregion
    }
}