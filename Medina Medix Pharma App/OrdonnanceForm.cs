using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Medina_Medix_Pharma_Proj
{
    public partial class OrdonnanceForm : Form
    {
        string connectionString = "Data Source=DESKTOP-3HOM7H2\\SQLEXPRESS;Initial Catalog=Pharma_App;Integrated Security=True;TrustServerCertificate=True";

        public OrdonnanceForm()
        {
            InitializeComponent();
            dgvOrdonnances.SelectionChanged += dgvOrdonnances_SelectionChanged;
        }

        private void OrdonnanceForm_Load(object sender, EventArgs e)
        {
            ChargerOrdonnancesDansDataGridView();
            ChargerClientsDansComboBox();
        }

        private void ChargerOrdonnancesDansDataGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Ordonnances", con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvOrdonnances.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChargerClientsDansComboBox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ClientID, Nom FROM Clients", con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbClients.Items.Clear();
                            while (reader.Read())
                            {
                                cmbClients.Items.Add(new { Text = reader["Nom"].ToString(), Value = reader["ClientID"].ToString() });
                            }
                            cmbClients.DisplayMember = "Text";
                            cmbClients.ValueMember = "Value";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOrdonnances_SelectionChanged(object sender, EventArgs e)
        {
            ChargerDetailsOrdonnance();
        }

        private void ChargerDetailsOrdonnance()
        {
            if (dgvOrdonnances.CurrentRow != null)
            {
                dtpDateOrdonnance.Value = Convert.ToDateTime(dgvOrdonnances.CurrentRow.Cells[1].Value);
                cmbClients.SelectedValue = dgvOrdonnances.CurrentRow.Cells[2].Value.ToString();
                txtTotal.Text = dgvOrdonnances.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnAjouterOrdonnance_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtTotal.Text, out decimal total))
            {
                MessageBox.Show("Le total n'est pas dans un format valide.");
                return;
            }

            AjouterOrdonnance(dtpDateOrdonnance.Value, Convert.ToInt32(cmbClients.SelectedValue), total);
            ChargerOrdonnancesDansDataGridView();
        }

        private void AjouterOrdonnance(DateTime date, int clientId, decimal total)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Ordonnances (Date, ClientID, Total) VALUES (@Date, @ClientID, @Total)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@ClientID", clientId);
                        cmd.Parameters.AddWithValue("@Total", total);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimerOrdonnance_Click(object sender, EventArgs e)
        {
            if (dgvOrdonnances.CurrentRow != null)
            {
                int ordonnanceId = Convert.ToInt32(dgvOrdonnances.CurrentRow.Cells[0].Value);
                SupprimerOrdonnance(ordonnanceId);
                ChargerOrdonnancesDansDataGridView();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ordonnance à supprimer.");
            }
        }

        private void SupprimerOrdonnance(int ordonnanceId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM Ordonnances WHERE OrdonnanceID = @OrdonnanceID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@OrdonnanceID", ordonnanceId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Ordonnances WHERE ClientID = @ClientID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ClientID", cmbClients.SelectedValue);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvOrdonnances.DataSource = dt;
                }
            }
        }

        private void btnAfficherOrdonnances_Click(object sender, EventArgs e)
        {
            ChargerOrdonnancesDansDataGridView();
        }

        private void bttnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }
    }
}
