namespace VehiculeNeufOccasion
{
    partial class frmRecapitulatif
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
            this.lblVehicule = new System.Windows.Forms.Label();
            this.lblPrixTotal = new System.Windows.Forms.Label();
            this.lblRachat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVehicule
            // 
            this.lblVehicule.AutoSize = true;
            this.lblVehicule.Location = new System.Drawing.Point(357, 128);
            this.lblVehicule.Name = "lblVehicule";
            this.lblVehicule.Size = new System.Drawing.Size(35, 13);
            this.lblVehicule.TabIndex = 0;
            this.lblVehicule.Text = "label1";
            // 
            // lblPrixTotal
            // 
            this.lblPrixTotal.AutoSize = true;
            this.lblPrixTotal.Location = new System.Drawing.Point(357, 164);
            this.lblPrixTotal.Name = "lblPrixTotal";
            this.lblPrixTotal.Size = new System.Drawing.Size(35, 13);
            this.lblPrixTotal.TabIndex = 1;
            this.lblPrixTotal.Text = "label2";
            // 
            // lblRachat
            // 
            this.lblRachat.AutoSize = true;
            this.lblRachat.Location = new System.Drawing.Point(357, 196);
            this.lblRachat.Name = "lblRachat";
            this.lblRachat.Size = new System.Drawing.Size(35, 13);
            this.lblRachat.TabIndex = 2;
            this.lblRachat.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmRecapitulatif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRachat);
            this.Controls.Add(this.lblPrixTotal);
            this.Controls.Add(this.lblVehicule);
            this.Name = "frmRecapitulatif";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicule;
        private System.Windows.Forms.Label lblPrixTotal;
        private System.Windows.Forms.Label lblRachat;
        private System.Windows.Forms.Button button1;
    }
}