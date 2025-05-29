using System;
using System.Windows.Forms;

namespace VehiculeNeufOccasion
{
    public partial class frmLeasing : Form
    {
        public frmLeasing()
        {
            InitializeComponent();
        }

        private void frmLeasing_Load(object sender, EventArgs e)
        {
            // Default selection: 12 months
            rb12.Checked = true;
            UpdateLeaseInfo();
        }

        private void LeaseOption_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLeaseInfo();
        }

        private void UpdateLeaseInfo()
        {
            if (Globales.vehiculeSelectionneLocation == null)
                return;

            decimal capitalCost = Globales.vehiculeSelectionneLocation.Prix;
            int leaseTerm = rb6.Checked ? 6 : rb12.Checked ? 12 : 24;
            decimal residualValue = capitalCost * (decimal)Math.Pow(0.96, leaseTerm);
            decimal moneyFactor = 0.01m / leaseTerm;
            decimal monthlyPayment = (capitalCost - residualValue) / leaseTerm +
                ((capitalCost + residualValue) * moneyFactor) / 2;

            lblDetails.Text = $"Prix initial : {capitalCost:C}\n" +
                $"Durée : {leaseTerm} mois\n" +
                $"Valeur résiduelle : {residualValue:C}\n" +
                $"Facteur financier : {moneyFactor:N3}\n" +
                $"Mensualité estimée : {monthlyPayment:C}";
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Leasing confirmé !");
            // Ajoutez ici la logique d'enregistrement si besoin
            //this.Close();

            try
            {
                // Add frmChoisirClient as the next window if not already present
                int idx = Globales.suiteFenetres.getIndexFenetreActuelle();
                if (idx + 1 >= Globales.suiteFenetres.listeFenetres.Count ||
                    !(Globales.suiteFenetres.listeFenetres[idx + 1] is frmChoisirClient))
                {
                    frmChoisirClient fenChoisirClient = new frmChoisirClient() { TopLevel = false, TopMost = true };
                    Globales.suiteFenetres.listeFenetres.Insert(idx + 1, fenChoisirClient);
                }
                Globales.suiteFenetres.afficherFenetreSuivante(Globales.panelConteneurAcceuil, Globales.fenAccueil);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Globales.suiteFenetres.afficherFenetrePrecedente(Globales.panelConteneurAcceuil, Globales.fenAccueil);
        }
    }
}
