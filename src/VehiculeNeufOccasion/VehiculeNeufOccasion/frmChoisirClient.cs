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
    public partial class frmChoisirClient : Form
    {
        public frmChoisirClient()
        {
            InitializeComponent();
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
                btnChoisir.Enabled = true;
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {

        }
    }
}
