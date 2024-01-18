using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medina_Medix_Pharma_Proj
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMedicament_Click(object sender, EventArgs e)
        {
            MedicamentForm medicamentForm = new MedicamentForm();
            medicamentForm.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Clients clientsForm = new Clients();
            clientsForm.Show();
        }

        private void btnnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POSForm posForm = new POSForm();
            posForm.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockForm stockForm = new StockForm();
            stockForm.Show();
        }

        private void btnOrdonnance_Click(object sender, EventArgs e)
        {
            OrdonnanceForm ordonnanceForm = new OrdonnanceForm();
            ordonnanceForm.Show();
        }

        private void btnFournisseur_Click(object sender, EventArgs e)
        {
            FournisseursForm fournisseursForm = new FournisseursForm();
            fournisseursForm.Show();
        }
    }
}
