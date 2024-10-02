
namespace CreditCeleste
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
            this.cmdIntroduction = new System.Windows.Forms.Button();
            this.cmdEtude = new System.Windows.Forms.Button();
            this.cmdRelance = new System.Windows.Forms.Button();
            this.lblMonApplication = new System.Windows.Forms.Label();
            this.lblMaRegion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdIntroduction
            // 
            this.cmdIntroduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIntroduction.Location = new System.Drawing.Point(73, 411);
            this.cmdIntroduction.Name = "cmdIntroduction";
            this.cmdIntroduction.Size = new System.Drawing.Size(122, 41);
            this.cmdIntroduction.TabIndex = 0;
            this.cmdIntroduction.Text = "&Introduction";
            this.cmdIntroduction.UseVisualStyleBackColor = true;
            this.cmdIntroduction.Click += new System.EventHandler(this.cmdIntroduction_Click);
            // 
            // cmdEtude
            // 
            this.cmdEtude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEtude.Location = new System.Drawing.Point(244, 411);
            this.cmdEtude.Name = "cmdEtude";
            this.cmdEtude.Size = new System.Drawing.Size(133, 41);
            this.cmdEtude.TabIndex = 1;
            this.cmdEtude.Text = "&Étude";
            this.cmdEtude.UseVisualStyleBackColor = true;
            // 
            // cmdRelance
            // 
            this.cmdRelance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRelance.Location = new System.Drawing.Point(417, 411);
            this.cmdRelance.Name = "cmdRelance";
            this.cmdRelance.Size = new System.Drawing.Size(133, 41);
            this.cmdRelance.TabIndex = 2;
            this.cmdRelance.Text = "&Relance";
            this.cmdRelance.UseVisualStyleBackColor = true;
            // 
            // lblMonApplication
            // 
            this.lblMonApplication.AutoSize = true;
            this.lblMonApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonApplication.Location = new System.Drawing.Point(765, 111);
            this.lblMonApplication.Name = "lblMonApplication";
            this.lblMonApplication.Size = new System.Drawing.Size(33, 20);
            this.lblMonApplication.TabIndex = 3;
            this.lblMonApplication.Text = "xxx";
            // 
            // lblMaRegion
            // 
            this.lblMaRegion.AutoSize = true;
            this.lblMaRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaRegion.Location = new System.Drawing.Point(69, 73);
            this.lblMaRegion.Name = "lblMaRegion";
            this.lblMaRegion.Size = new System.Drawing.Size(33, 20);
            this.lblMaRegion.TabIndex = 4;
            this.lblMaRegion.Text = "xxx";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 540);
            this.Controls.Add(this.lblMaRegion);
            this.Controls.Add(this.lblMonApplication);
            this.Controls.Add(this.cmdRelance);
            this.Controls.Add(this.cmdEtude);
            this.Controls.Add(this.cmdIntroduction);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdIntroduction;
        private System.Windows.Forms.Button cmdEtude;
        private System.Windows.Forms.Button cmdRelance;
        private System.Windows.Forms.Label lblMonApplication;
        private System.Windows.Forms.Label lblMaRegion;
    }
}

