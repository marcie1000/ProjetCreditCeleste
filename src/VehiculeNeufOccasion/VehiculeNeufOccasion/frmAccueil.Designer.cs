
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
            this.cmdAcheter = new System.Windows.Forms.Button();
            this.cmdRevendre = new System.Windows.Forms.Button();
            this.cmdLouer = new System.Windows.Forms.Button();
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.btnCreerUser = new System.Windows.Forms.Button();
            this.panelConteneur = new System.Windows.Forms.Panel();
            this.gpbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAcheter
            // 
            this.cmdAcheter.Location = new System.Drawing.Point(82, 35);
            this.cmdAcheter.Name = "cmdAcheter";
            this.cmdAcheter.Size = new System.Drawing.Size(95, 44);
            this.cmdAcheter.TabIndex = 1;
            this.cmdAcheter.Text = "Acheter un véhicule";
            this.cmdAcheter.UseVisualStyleBackColor = true;
            this.cmdAcheter.Click += new System.EventHandler(this.cmdAcheter_Click);
            // 
            // cmdRevendre
            // 
            this.cmdRevendre.Location = new System.Drawing.Point(273, 35);
            this.cmdRevendre.Name = "cmdRevendre";
            this.cmdRevendre.Size = new System.Drawing.Size(96, 44);
            this.cmdRevendre.TabIndex = 2;
            this.cmdRevendre.Text = "Revendre un véhicule";
            this.cmdRevendre.UseVisualStyleBackColor = true;
            this.cmdRevendre.Click += new System.EventHandler(this.cmdRevendre_Click);
            // 
            // cmdLouer
            // 
            this.cmdLouer.Location = new System.Drawing.Point(480, 35);
            this.cmdLouer.Name = "cmdLouer";
            this.cmdLouer.Size = new System.Drawing.Size(89, 44);
            this.cmdLouer.TabIndex = 3;
            this.cmdLouer.Text = "Louer un véhicule";
            this.cmdLouer.UseVisualStyleBackColor = true;
            this.cmdLouer.Click += new System.EventHandler(this.cmdLouer_Click);
            // 
            // gpbMenu
            // 
            this.gpbMenu.Controls.Add(this.btnCreerUser);
            this.gpbMenu.Controls.Add(this.cmdAcheter);
            this.gpbMenu.Controls.Add(this.cmdRevendre);
            this.gpbMenu.Controls.Add(this.cmdLouer);
            this.gpbMenu.Location = new System.Drawing.Point(27, 657);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(818, 100);
            this.gpbMenu.TabIndex = 9;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Menu";
            // 
            // btnCreerUser
            // 
            this.btnCreerUser.Location = new System.Drawing.Point(706, 35);
            this.btnCreerUser.Name = "btnCreerUser";
            this.btnCreerUser.Size = new System.Drawing.Size(89, 44);
            this.btnCreerUser.TabIndex = 4;
            this.btnCreerUser.Text = "Créer un utilisateur";
            this.btnCreerUser.UseVisualStyleBackColor = true;
            this.btnCreerUser.Click += new System.EventHandler(this.btnCreerUser_Click);
            // 
            // panelConteneur
            // 
            this.panelConteneur.Location = new System.Drawing.Point(27, 33);
            this.panelConteneur.Name = "panelConteneur";
            this.panelConteneur.Size = new System.Drawing.Size(1597, 605);
            this.panelConteneur.TabIndex = 12;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 917);
            this.Controls.Add(this.panelConteneur);
            this.Controls.Add(this.gpbMenu);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.gpbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdAcheter;
        private System.Windows.Forms.Button cmdRevendre;
        private System.Windows.Forms.Button cmdLouer;
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.Button btnCreerUser;
        private System.Windows.Forms.Panel panelConteneur;
    }
}

