﻿
namespace VehiculeNeufOccasion
{
    partial class frmAccueil
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAcheter = new System.Windows.Forms.Button();
            this.cmdRevendre = new System.Windows.Forms.Button();
            this.cmdLouer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION VOITURES";
            // 
            // cmdAcheter
            // 
            this.cmdAcheter.Location = new System.Drawing.Point(153, 367);
            this.cmdAcheter.Name = "cmdAcheter";
            this.cmdAcheter.Size = new System.Drawing.Size(95, 44);
            this.cmdAcheter.TabIndex = 1;
            this.cmdAcheter.Text = "Acheter un véhicule";
            this.cmdAcheter.UseVisualStyleBackColor = true;
            this.cmdAcheter.Click += new System.EventHandler(this.cmdAcheter_Click);
            // 
            // cmdRevendre
            // 
            this.cmdRevendre.Location = new System.Drawing.Point(344, 367);
            this.cmdRevendre.Name = "cmdRevendre";
            this.cmdRevendre.Size = new System.Drawing.Size(96, 44);
            this.cmdRevendre.TabIndex = 2;
            this.cmdRevendre.Text = "Revendre un véhicule";
            this.cmdRevendre.UseVisualStyleBackColor = true;
            this.cmdRevendre.Click += new System.EventHandler(this.cmdRevendre_Click);
            // 
            // cmdLouer
            // 
            this.cmdLouer.Location = new System.Drawing.Point(551, 367);
            this.cmdLouer.Name = "cmdLouer";
            this.cmdLouer.Size = new System.Drawing.Size(89, 44);
            this.cmdLouer.TabIndex = 3;
            this.cmdLouer.Text = "Louer un véhicule";
            this.cmdLouer.UseVisualStyleBackColor = true;
            this.cmdLouer.Click += new System.EventHandler(this.cmdLouer_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdLouer);
            this.Controls.Add(this.cmdRevendre);
            this.Controls.Add(this.cmdAcheter);
            this.Controls.Add(this.label1);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAcheter;
        private System.Windows.Forms.Button cmdRevendre;
        private System.Windows.Forms.Button cmdLouer;
    }
}

