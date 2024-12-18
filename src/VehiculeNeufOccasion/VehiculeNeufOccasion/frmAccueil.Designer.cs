
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
            this.btnAcheter = new System.Windows.Forms.Button();
            this.btnRevendre = new System.Windows.Forms.Button();
            this.btnLouer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION VOITURES";
            // 
            // btnAcheter
            // 
            this.btnAcheter.Location = new System.Drawing.Point(351, 1041);
            this.btnAcheter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcheter.Name = "btnAcheter";
            this.btnAcheter.Size = new System.Drawing.Size(250, 70);
            this.btnAcheter.TabIndex = 1;
            this.btnAcheter.Text = "Acheter un véhicule";
            this.btnAcheter.UseVisualStyleBackColor = true;
            this.btnAcheter.Click += new System.EventHandler(this.btnAcheter_Click);
            // 
            // btnRevendre
            // 
            this.btnRevendre.Location = new System.Drawing.Point(637, 1041);
            this.btnRevendre.Margin = new System.Windows.Forms.Padding(4);
            this.btnRevendre.Name = "btnRevendre";
            this.btnRevendre.Size = new System.Drawing.Size(250, 70);
            this.btnRevendre.TabIndex = 2;
            this.btnRevendre.Text = "Revendre un véhicule";
            this.btnRevendre.UseVisualStyleBackColor = true;
            this.btnRevendre.Click += new System.EventHandler(this.btnRevendre_Click);
            // 
            // btnLouer
            // 
            this.btnLouer.Location = new System.Drawing.Point(921, 1041);
            this.btnLouer.Margin = new System.Windows.Forms.Padding(4);
            this.btnLouer.Name = "btnLouer";
            this.btnLouer.Size = new System.Drawing.Size(250, 70);
            this.btnLouer.TabIndex = 3;
            this.btnLouer.Text = "Louer un véhicule";
            this.btnLouer.UseVisualStyleBackColor = true;
            this.btnLouer.Click += new System.EventHandler(this.btnLouer_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(637, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 796);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(125, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 796);
            this.panel2.TabIndex = 5;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1976, 1436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLouer);
            this.Controls.Add(this.btnRevendre);
            this.Controls.Add(this.btnAcheter);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(2000, 1500);
            this.MinimumSize = new System.Drawing.Size(2000, 1500);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcheter;
        private System.Windows.Forms.Button btnRevendre;
        private System.Windows.Forms.Button btnLouer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

