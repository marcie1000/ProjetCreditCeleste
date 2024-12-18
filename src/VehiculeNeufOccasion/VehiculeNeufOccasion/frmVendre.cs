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
    public partial class frmVendre : Form
    {
        Voiture voitureTemporaire = new Voiture();

        public frmVendre()
        {
            InitializeComponent();
        }
        private void frmVendre_Load(object sender, EventArgs e)
        {

        }
        private void frmVendre_Close(object sender, EventArgs e)
        {
        }

        private void txtMarque_TextChanged(object sender, EventArgs e)  {   voitureTemporaire.setMarque(txtMarque.Text);    }

        private void txtModele_TextChanged(object sender, EventArgs e)  { voitureTemporaire.setModele(txtModele.Text);    }

        private void txtPrixSouhaite_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnnee_TextChanged(object sender, EventArgs e)   {  voitureTemporaire.setAnnee(Convert.ToInt32(txtAnnee.Text)); }

        private void txtKilometrage_TextChanged(object sender, EventArgs e) {   voitureTemporaire.setKm(Convert.ToInt32(txtKilometrage.Text)); }

        private void txtCarburant_TextChanged(object sender, EventArgs e)   {   voitureTemporaire.setCarburant(txtCarburant.Text);  }

        private void txtPuissance_TextChanged(object sender, EventArgs e)   {   voitureTemporaire.setPuissance(Convert.ToInt32(txtPuissance.Text)); }

        private void btnVendre_Click(object sender, EventArgs e)
        {
            // ajouter la voiture temporaire à la base de donnée, en lui affectant le prix souhaité
            // comment faire ppour réinitialiser la voitureTemporaire?
        }
    }
}
