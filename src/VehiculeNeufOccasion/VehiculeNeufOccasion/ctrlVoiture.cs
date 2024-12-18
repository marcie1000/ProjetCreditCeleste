using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehiculeNeufOccasion
{
    public partial class ctrlVoiture : UserControl
    {
        public ctrlVoiture()
        {
            InitializeComponent();
        }

        private void lblCtrlVoiture_Click(object sender, EventArgs e)
        {

        }

        private void txtMarque_TextChanged(object sender, EventArgs e)
        {

        }

        [Description("Champ de texte string pour la marque"), Browsable(true)]
        public String Marque
        {
            get
            {
                return this.txtMarque.Text;
            }
            set
            {
                this.txtMarque.Text = value;
            }
        }

        [Description("Champ de texte string pour le modele"), Browsable(true)]
        public String Modele
        {
            get
            {
                return this.txtModele.Text;
            }
            set
            {
                this.txtModele.Text = value;
            }
        }

        [Description("Champ de texte string pour l'année, à convertir en int32"), Browsable(true)]
        public String Annee
        {
            get
            {
                return this.txtAnnee.Text;
            }
            set
            {
                this.txtModele.Text = value;
            }
        }

        [Description("Champ de texte string pour le kilometrage, à convertir en int32"), Browsable(true)]
        public String Kilometrage
        {
            get
            {
                return this.txtKilometrage.Text;
            }
            set
            {
                this.txtKilometrage.Text = value;
            }
        }

        [Description("Champ de texte string pour le carburant"), Browsable(true)]
        public String Carburant
        {
            get
            {
                return this.txtCarburant.Text;
            }
            set
            {
                this.txtCarburant.Text = value;
            }
        }
        
        [Description("Champ de texte string pour la puissance, à convertir en int32"), Browsable(true)]
        public String Puissance
        {
            get
            {
                return this.txtPuissance.Text;
            }
            set
            {
                this.txtPuissance.Text = value;
            }
        }

        private void ctrlVoiture_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
    }
}
