using System;
using System.Windows.Forms;

namespace Medina_Medix_Pharma_Proj
{
    public partial class DashboardForm : Form
    {
        private string userRole;

        public DashboardForm(string role)
        {
            InitializeComponent();
            userRole = role;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            AjusterBoutonsSelonRole();
        }

        private void AjusterBoutonsSelonRole()
        {
            if (userRole.Equals("Pharmacien", StringComparison.OrdinalIgnoreCase))
            {
                btnStock.Enabled = false;
                btnFournisseur.Enabled = false;
                btnOrdonnance.Enabled = false;

                btnStock.BackColor = System.Drawing.Color.Gray;
                btnFournisseur.BackColor = System.Drawing.Color.Gray;
                btnOrdonnance.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void btnMedicament_Click(object sender, EventArgs e)
        {
            MedicamentForm medicamentForm = new MedicamentForm(userRole);
            medicamentForm.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Clients clientsForm = new Clients(userRole);
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
            POSForm posForm = new POSForm(userRole);
            posForm.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockForm stockForm = new StockForm(userRole);
            stockForm.Show();
        }

        private void btnOrdonnance_Click(object sender, EventArgs e)
        {
            OrdonnanceForm ordonnanceForm = new OrdonnanceForm(userRole);
            ordonnanceForm.Show();
        }

        private void btnFournisseur_Click(object sender, EventArgs e)
        {
            FournisseursForm fournisseursForm = new FournisseursForm(userRole);
            fournisseursForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManuelForm manuelForm = new ManuelForm(userRole);
            manuelForm.Show();
        }
    }
}
