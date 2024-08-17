using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Medina_Medix_Pharma_Proj
{
    public partial class FournisseursForm : Form
    {
        string connectionString = "Data Source=DESKTOP-3HOM7H2\\SQLEXPRESS;Initial Catalog=Pharma_App;Integrated Security=True;TrustServerCertificate=True";

        public FournisseursForm()
        {
            InitializeComponent();
            dgvFournisseurs.SelectionChanged += dgvFournisseurs_SelectionChanged;
        }

        private void FournisseursForm_Load(object sender, EventArgs e)
        {
            ChargerFournisseursDansDataGridView();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtNomFournisseur.Clear();
            txtAdresse.Clear();
            txtContact.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            ChargerFournisseursDansDataGridView();
        }

        private void ChargerFournisseursDansDataGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Fournisseurs", con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFournisseurs.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFournisseurs_SelectionChanged(object sender, EventArgs e)
        {
            ChargerDetailsFournisseur();
        }

        private void ChargerDetailsFournisseur()
        {
            if (dgvFournisseurs.CurrentRow != null)
            {
                txtNomFournisseur.Text = dgvFournisseurs.CurrentRow.Cells[1].Value.ToString();
                txtAdresse.Text = dgvFournisseurs.CurrentRow.Cells[3].Value.ToString();
                txtContact.Text = dgvFournisseurs.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnAjouterFournisseur_Click(object sender, EventArgs e)
        {
            string nom = txtNomFournisseur.Text;
            string adresse = txtAdresse.Text;
            string contact = txtContact.Text;

            AjouterFournisseur(nom, adresse, contact);
            ChargerFournisseursDansDataGridView();
        }

        private void AjouterFournisseur(string nom, string adresse, string contact)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Fournisseurs (Nom, Adresse, Contact) VALUES (@Nom, @Adresse, @Contact)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@Adresse", adresse);
                        cmd.Parameters.AddWithValue("@Contact", contact);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SupprimerFournisseur(int fournisseurId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM Fournisseurs WHERE FournisseurID = @FournisseurID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FournisseurID", fournisseurId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimerFournisseur_Click(object sender, EventArgs e)
        {
            if (dgvFournisseurs.CurrentRow != null)
            {
                int fournisseurId = Convert.ToInt32(dgvFournisseurs.CurrentRow.Cells[0].Value);
                SupprimerFournisseur(fournisseurId);
                ChargerFournisseursDansDataGridView();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur à supprimer.");
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Fournisseurs WHERE Nom LIKE @Nom";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nom", "%" + txtNomFournisseur.Text + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvFournisseurs.DataSource = dt;
                }
            }
        }

        private void bttnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }

        private void btnAfficherFournisseurs_Click(object sender, EventArgs e)
        {
            ChargerFournisseursDansDataGridView();
        }

        private void txtNomFournisseur_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add any specific logic needed when the text changes in the fournisseur name textbox.
        }
    }
}

