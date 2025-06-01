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
            this.lblVendeurConnecté = new System.Windows.Forms.Label();
            this.gpbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRevendre
            // 
            this.cmdRevendre.Location = new System.Drawing.Point(8, 39);
            this.cmdRevendre.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRevendre.Name = "cmdRevendre";
            this.cmdRevendre.Size = new System.Drawing.Size(314, 54);
            this.cmdRevendre.TabIndex = 2;
            this.cmdRevendre.Text = "Revendre un véhicule";
            this.cmdRevendre.UseVisualStyleBackColor = true;
            this.cmdRevendre.Click += new System.EventHandler(this.cmdRevendre_Click);
            // 
            // cmdLouer
            // 
            this.cmdLouer.Location = new System.Drawing.Point(330, 39);
            this.cmdLouer.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLouer.Name = "cmdLouer";
            this.cmdLouer.Size = new System.Drawing.Size(315, 54);
            this.cmdLouer.TabIndex = 3;
            this.cmdLouer.Text = "Louer un véhicule";
            this.cmdLouer.UseVisualStyleBackColor = true;
            this.cmdLouer.Click += new System.EventHandler(this.cmdLouer_Click);
            // 
            // gpbMenu
            // 
            this.gpbMenu.Controls.Add(this.lblVendeurConnecté);
            this.gpbMenu.Controls.Add(this.btnCompte);
            this.gpbMenu.Controls.Add(this.btnAdministration);
            this.gpbMenu.Controls.Add(this.btnCreerUser);
            this.gpbMenu.Controls.Add(this.cmdRevendre);
            this.gpbMenu.Controls.Add(this.cmdLouer);
            this.gpbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMenu.Location = new System.Drawing.Point(37, 18);
            this.gpbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Padding = new System.Windows.Forms.Padding(4);
            this.gpbMenu.Size = new System.Drawing.Size(2089, 120);
            this.gpbMenu.TabIndex = 9;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Menu";
            // 
            // btnCompte
            // 
            this.btnCompte.Location = new System.Drawing.Point(1288, 39);
            this.btnCompte.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.Size = new System.Drawing.Size(309, 54);
            this.btnCompte.TabIndex = 6;
            this.btnCompte.Text = "👤 Compte";
            this.btnCompte.UseVisualStyleBackColor = true;
            this.btnCompte.Click += new System.EventHandler(this.btnCompte_Click);
            // 
            // btnAdministration
            // 
            this.btnAdministration.Location = new System.Drawing.Point(971, 39);
            this.btnAdministration.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.Size = new System.Drawing.Size(309, 54);
            this.btnAdministration.TabIndex = 5;
            this.btnAdministration.Text = "🛠️ Administration";
            this.btnAdministration.UseVisualStyleBackColor = true;
            this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
            // 
            // btnCreerUser
            // 
            this.btnCreerUser.Location = new System.Drawing.Point(653, 39);
            this.btnCreerUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreerUser.Name = "btnCreerUser";
            this.btnCreerUser.Size = new System.Drawing.Size(309, 54);
            this.btnCreerUser.TabIndex = 4;
            this.btnCreerUser.Text = "Créer un utilisateur";
            this.btnCreerUser.UseVisualStyleBackColor = true;
            this.btnCreerUser.Click += new System.EventHandler(this.btnCreerUser_Click);
            // 
            // panelConteneur
            // 
            this.panelConteneur.AutoScroll = true;
            this.panelConteneur.AutoSize = true;
            this.panelConteneur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelConteneur.Location = new System.Drawing.Point(37, 166);
            this.panelConteneur.Margin = new System.Windows.Forms.Padding(4);
            this.panelConteneur.Name = "panelConteneur";
            this.panelConteneur.Size = new System.Drawing.Size(0, 0);
            this.panelConteneur.TabIndex = 12;
            // 
            // lblVendeurConnecté
            // 
            this.lblVendeurConnecté.AutoSize = true;
            this.lblVendeurConnecté.Location = new System.Drawing.Point(1669, 52);
            this.lblVendeurConnecté.Name = "lblVendeurConnecté";
            this.lblVendeurConnecté.Size = new System.Drawing.Size(266, 29);
            this.lblVendeurConnecté.TabIndex = 7;
            this.lblVendeurConnecté.Text = "Vendeur non connecté !";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2269, 1376);
            this.Controls.Add(this.gpbMenu);
            this.Controls.Add(this.panelConteneur);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.gpbMenu.ResumeLayout(false);
            this.gpbMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdRevendre;
        private System.Windows.Forms.Button cmdLouer;
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.Button btnCreerUser;
        private System.Windows.Forms.Panel panelConteneur;
        private System.Windows.Forms.Button btnCompte;
        private System.Windows.Forms.Button btnAdministration;
        private System.Windows.Forms.Label lblVendeurConnecté;
    }
}

