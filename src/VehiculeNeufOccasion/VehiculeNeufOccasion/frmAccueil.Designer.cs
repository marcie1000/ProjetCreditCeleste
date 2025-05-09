
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
            this.cmdRevendre = new System.Windows.Forms.Button();
            this.cmdLouer = new System.Windows.Forms.Button();
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.btnCompte = new System.Windows.Forms.Button();
            this.btnAdministration = new System.Windows.Forms.Button();
            this.btnCreerUser = new System.Windows.Forms.Button();
            this.panelConteneur = new System.Windows.Forms.Panel();
            this.gpbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRevendre
            // 
            this.cmdRevendre.Location = new System.Drawing.Point(6, 26);
            this.cmdRevendre.Name = "cmdRevendre";
            this.cmdRevendre.Size = new System.Drawing.Size(228, 36);
            this.cmdRevendre.TabIndex = 2;
            this.cmdRevendre.Text = "Revendre un véhicule";
            this.cmdRevendre.UseVisualStyleBackColor = true;
            this.cmdRevendre.Click += new System.EventHandler(this.cmdRevendre_Click);
            // 
            // cmdLouer
            // 
            this.cmdLouer.Location = new System.Drawing.Point(240, 26);
            this.cmdLouer.Name = "cmdLouer";
            this.cmdLouer.Size = new System.Drawing.Size(229, 36);
            this.cmdLouer.TabIndex = 3;
            this.cmdLouer.Text = "Louer un véhicule";
            this.cmdLouer.UseVisualStyleBackColor = true;
            this.cmdLouer.Click += new System.EventHandler(this.cmdLouer_Click);
            // 
            // gpbMenu
            // 
            this.gpbMenu.Controls.Add(this.btnCompte);
            this.gpbMenu.Controls.Add(this.btnAdministration);
            this.gpbMenu.Controls.Add(this.btnCreerUser);
            this.gpbMenu.Controls.Add(this.cmdRevendre);
            this.gpbMenu.Controls.Add(this.cmdLouer);
            this.gpbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMenu.Location = new System.Drawing.Point(27, 12);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(1519, 80);
            this.gpbMenu.TabIndex = 9;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Menu";
            // 
            // btnCompte
            // 
            this.btnCompte.Location = new System.Drawing.Point(937, 26);
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.Size = new System.Drawing.Size(225, 36);
            this.btnCompte.TabIndex = 6;
            this.btnCompte.Text = "👤 Compte";
            this.btnCompte.UseVisualStyleBackColor = true;
            // 
            // btnAdministration
            // 
            this.btnAdministration.Location = new System.Drawing.Point(706, 26);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.Size = new System.Drawing.Size(225, 36);
            this.btnAdministration.TabIndex = 5;
            this.btnAdministration.Text = "🛠️ Administration";
            this.btnAdministration.UseVisualStyleBackColor = true;
            // 
            // btnCreerUser
            // 
            this.btnCreerUser.Location = new System.Drawing.Point(475, 26);
            this.btnCreerUser.Name = "btnCreerUser";
            this.btnCreerUser.Size = new System.Drawing.Size(225, 36);
            this.btnCreerUser.TabIndex = 4;
            this.btnCreerUser.Text = "Créer un utilisateur";
            this.btnCreerUser.UseVisualStyleBackColor = true;
            this.btnCreerUser.Click += new System.EventHandler(this.btnCreerUser_Click);
            // 
            // panelConteneur
            // 
            this.panelConteneur.AutoScroll = true;
            this.panelConteneur.Location = new System.Drawing.Point(27, 111);
            this.panelConteneur.Name = "panelConteneur";
            this.panelConteneur.Size = new System.Drawing.Size(1597, 721);
            this.panelConteneur.TabIndex = 12;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 917);
            this.Controls.Add(this.gpbMenu);
            this.Controls.Add(this.panelConteneur);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.gpbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdRevendre;
        private System.Windows.Forms.Button cmdLouer;
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.Button btnCreerUser;
        private System.Windows.Forms.Panel panelConteneur;
        private System.Windows.Forms.Button btnCompte;
        private System.Windows.Forms.Button btnAdministration;
    }
}

