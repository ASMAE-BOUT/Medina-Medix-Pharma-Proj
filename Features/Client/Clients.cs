using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medina_Medix_Pharma_Proj
{

    public partial class Clients : Form
    {
        string connectionString = @"Server=DESKTOP-3RKAS3I; Database=Pharma Proj; User Id=PharmaLogin; Password=PharmaApp159;";

        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            ChargerClientsDansDataGridView();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtNomClient.Clear();
            txtAdresse.Clear();
            txtTéléphone.Clear();
            txtRéduction.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            ChargerClientsDansDataGridView();
        }

        private void ChargerClientsDansDataGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Clients", con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvClients.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (int.TryParse(senderGrid["ClientIDColumn", e.RowIndex].Value.ToString(), out int clientId))
            {
                SupprimerClient(clientId);
                ChargerClientsDansDataGridView();
            }
            else
            {
                MessageBox.Show("ID du client non valide.");
            }
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            string nom = txtNomClient.Text;
            string adresse = txtAdresse.Text;
            string telephone = txtTéléphone.Text;
            //decimal reduction = decimal.Parse(txtRéduction.Text);
            if (!decimal.TryParse(txtRéduction.Text, out decimal reduction))
            {
                MessageBox.Show("La réduction n'est pas dans un format valide.");
                return;
            }


            AjouterClient(nom, adresse, telephone, reduction);
            ChargerClientsDansDataGridView();
        }

        private void AjouterClient(string nom, string adresse, string telephone, decimal reduction)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Clients (Nom, Adresse, Téléphone, Réduction) VALUES (@Nom, @Adresse, @Téléphone, @Réduction)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@Adresse", adresse);
                        cmd.Parameters.AddWithValue("@Téléphone", telephone);
                        cmd.Parameters.AddWithValue("@Réduction", reduction);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SupprimerClient(int clientId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM Clients WHERE ClientID = @ClientID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ClientID", clientId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void btnSupprimerClient_Click(object sender, EventArgs e)
        //{
        //    if (dgvClients.CurrentRow != null)
        //    {
        //        string nomClient = dgvClients.CurrentRow.Cells["Nom"].Value.ToString(); // Assurez-vous que "Nom" correspond au nom de la colonne dans le DataGridView
        //        SupprimerClientParNom(nomClient);
        //        ChargerClientsDansDataGridView();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Veuillez sélectionner un client à supprimer.");
        //    }
        //}

        //private void SupprimerClientParNom(string nom)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(connectionString))
        //        {
        //            con.Open();
        //            string query = "DELETE FROM Clients WHERE Nom = @Nom";
        //            using (SqlCommand cmd = new SqlCommand(query, con))
        //            {
        //                cmd.Parameters.AddWithValue("@Nom", nom);
        //                int rowsAffected = cmd.ExecuteNonQuery();
        //                if (rowsAffected > 0)
        //                {
        //                    MessageBox.Show("Client supprimé avec succès !");
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Aucun client trouvé avec ce nom.");
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erreur lors de la suppression du client : " + ex.Message);
        //    }
        //}


        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow != null)
            {
                int clientId = Convert.ToInt32(dgvClients.CurrentRow.Cells[0].Value);
                SupprimerClient(clientId);
                ChargerClientsDansDataGridView();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.");
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Clients WHERE Nom LIKE @Nom";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nom", "%" + txtNomClient.Text + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvClients.DataSource = dt;
                }
            }
        }

        private void bttnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }

        private void txtNomClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAfficherClients_Click(object sender, EventArgs e)
        {
            ChargerClientsDansDataGridView();
        }
    }
}
