
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.btnCreerUser = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.gpbConnexion = new System.Windows.Forms.GroupBox();
            this.gpbCompte = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.gpbMenu.SuspendLayout();
            this.gpbConnexion.SuspendLayout();
            this.gpbCompte.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION VOITURES";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login";
            // 
            // txtMdp
            // 
            this.txtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.Location = new System.Drawing.Point(20, 155);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(271, 27);
            this.txtMdp.TabIndex = 6;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(20, 68);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(271, 27);
            this.txtLogin.TabIndex = 5;
            // 
            // gpbMenu
            // 
            this.gpbMenu.Controls.Add(this.btnCreerUser);
            this.gpbMenu.Controls.Add(this.cmdAcheter);
            this.gpbMenu.Controls.Add(this.cmdRevendre);
            this.gpbMenu.Controls.Add(this.cmdLouer);
            this.gpbMenu.Location = new System.Drawing.Point(60, 404);
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
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(19, 248);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(272, 41);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // gpbConnexion
            // 
            this.gpbConnexion.Controls.Add(this.btnValider);
            this.gpbConnexion.Controls.Add(this.txtLogin);
            this.gpbConnexion.Controls.Add(this.txtMdp);
            this.gpbConnexion.Controls.Add(this.label3);
            this.gpbConnexion.Controls.Add(this.label2);
            this.gpbConnexion.Location = new System.Drawing.Point(60, 56);
            this.gpbConnexion.Name = "gpbConnexion";
            this.gpbConnexion.Size = new System.Drawing.Size(321, 311);
            this.gpbConnexion.TabIndex = 11;
            this.gpbConnexion.TabStop = false;
            this.gpbConnexion.Text = "Connexion";
            // 
            // gpbCompte
            // 
            this.gpbCompte.Controls.Add(this.btnDeconnecter);
            this.gpbCompte.Controls.Add(this.lblNomUtilisateur);
            this.gpbCompte.Controls.Add(this.label4);
            this.gpbCompte.Location = new System.Drawing.Point(442, 56);
            this.gpbCompte.Name = "gpbCompte";
            this.gpbCompte.Size = new System.Drawing.Size(413, 311);
            this.gpbCompte.TabIndex = 12;
            this.gpbCompte.TabStop = false;
            this.gpbCompte.Text = "Compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vous êtes connecté(e) en tant que :";
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = true;
            this.lblNomUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUtilisateur.Location = new System.Drawing.Point(19, 75);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(0, 20);
            this.lblNomUtilisateur.TabIndex = 1;
            // 
            // btnDeconnecter
            // 
            this.btnDeconnecter.Location = new System.Drawing.Point(23, 248);
            this.btnDeconnecter.Name = "btnDeconnecter";
            this.btnDeconnecter.Size = new System.Drawing.Size(272, 41);
            this.btnDeconnecter.TabIndex = 2;
            this.btnDeconnecter.Text = "Déconnexion";
            this.btnDeconnecter.UseVisualStyleBackColor = true;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 553);
            this.Controls.Add(this.gpbCompte);
            this.Controls.Add(this.gpbConnexion);
            this.Controls.Add(this.gpbMenu);
            this.Controls.Add(this.label1);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.gpbMenu.ResumeLayout(false);
            this.gpbConnexion.ResumeLayout(false);
            this.gpbConnexion.PerformLayout();
            this.gpbCompte.ResumeLayout(false);
            this.gpbCompte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAcheter;
        private System.Windows.Forms.Button cmdRevendre;
        private System.Windows.Forms.Button cmdLouer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.Button btnCreerUser;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox gpbConnexion;
        private System.Windows.Forms.GroupBox gpbCompte;
        private System.Windows.Forms.Button btnDeconnecter;
        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.Label label4;
    }
}

