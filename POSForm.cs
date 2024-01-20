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
    public partial class POSForm : Form
    {
        private string connectionString = @"Server=DESKTOP-3RKAS3I; Database=Pharma Proj; User Id=PharmaLogin; Password=PharmaApp159;";
        //internal EventHandler dgvVentes_SelectionChanged;

        public POSForm()
        {
            InitializeComponent();
            //dgvVentes.SelectionChanged += new EventHandler(dgvVentes_SelectionChanged);
        }

        private void POSForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pharma_ProjDataSet.Ventes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ventesTableAdapter.Fill(this.pharma_ProjDataSet.Ventes);
            //// TODO: cette ligne de code charge les données dans la table 'pharma_ProjDataSet.Stocks'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.stocksTableAdapter.Fill(this.pharma_ProjDataSet.Stocks);
            RemplirComboBoxClient();
            ChargerVentesDansDataGridView();

        }

        private void RemplirComboBoxClient()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // Remplir le ComboBox pour les clients
                    string queryClients = "SELECT ClientID, Nom FROM Clients";
                    using (SqlCommand cmdClients = new SqlCommand(queryClients, con))
                    {
                        SqlDataAdapter adapterClients = new SqlDataAdapter(cmdClients);
                        DataTable dtClients = new DataTable();
                        adapterClients.Fill(dtClients);
                        cmbClientID.DisplayMember = "Nom";
                        cmbClientID.ValueMember = "ClientID";
                        cmbClientID.DataSource = dtClients;
                    }

                    // Remplir le ComboBox pour les médicaments
                    string queryMedicaments = "SELECT MédicamentID, Désignation FROM Médicaments";
                    using (SqlCommand cmdMedicaments = new SqlCommand(queryMedicaments, con))
                    {
                        SqlDataAdapter adapterMedicaments = new SqlDataAdapter(cmdMedicaments);
                        DataTable dtMedicaments = new DataTable();
                        adapterMedicaments.Fill(dtMedicaments);
                        cmbMedicamentID.DisplayMember = "Désignation";
                        cmbMedicamentID.ValueMember = "MédicamentID";
                        cmbMedicamentID.DataSource = dtMedicaments;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
                }
            }
        }

        private void ChargerVentesDansDataGridView()
        {
            ChargerDetailsVente();
        }

        private void dgvVentes_SelectionChanged(object sender, EventArgs e)
        {
            ChargerDetailsVente();
        }

        private void ChargerDetailsVente()
        {
            if (dgvVentes.CurrentRow != null)
            {
                int venteId = Convert.ToInt32(dgvVentes.CurrentRow.Cells[0].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Ventes WHERE VenteID = @VenteID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VenteID", venteId);
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dtpDate.Value = Convert.ToDateTime(reader["Date"]);
                                cmbClientID.SelectedValue = reader["ClientID"];
                                txtTotal.Text = reader["Total"].ToString();
                                txtReduction.Text = reader["Réduction"].ToString();

                                if (reader["MédicamentID"] != DBNull.Value)
                                {
                                    cmbMedicamentID.SelectedValue = reader["MédicamentID"];
                                }
                                if (reader["QuantitéVendue"] != DBNull.Value)
                                {
                                    txtQuantiteVendue.Text = reader["QuantitéVendue"].ToString();
                                }
                            }
                        }
                    }
                }
            }
        }


        private void cmbClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientID.SelectedIndex != -1)
            {

                int clientId = (int)cmbClientID.SelectedValue;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpDate.Value;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                int medicamentId = Convert.ToInt32(cmbMedicamentID.SelectedValue);
                int quantiteVendue = Convert.ToInt32(txtQuantiteVendue.Text);
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string queryVente = @"INSERT INTO Ventes (Date, ClientID, MédicamentID, QuantitéVendue, Total, Réduction) VALUES (@Date, @ClientID, @MédicamentID, @QuantitéVendue, @Total, @Réduction); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmdVente = new SqlCommand(queryVente, con))
                    {
                        cmdVente.Parameters.AddWithValue("@Date", dtpDate.Value);
                        cmdVente.Parameters.AddWithValue("@ClientID", cmbClientID.SelectedValue);
                        cmdVente.Parameters.AddWithValue("@MédicamentID", medicamentId);
                        cmdVente.Parameters.AddWithValue("@QuantitéVendue", quantiteVendue);
                        cmdVente.Parameters.AddWithValue("@Total", decimal.Parse(txtTotal.Text));
                        cmdVente.Parameters.AddWithValue("@Réduction", string.IsNullOrEmpty(txtReduction.Text) ? (object)DBNull.Value : decimal.Parse(txtReduction.Text));

                        int venteId = Convert.ToInt32(cmdVente.ExecuteScalar());
                    }

                    using (SqlCommand cmdStock = new SqlCommand("VendreMedicament", con))
                    {
                        cmdStock.CommandType = CommandType.StoredProcedure;
                        cmdStock.Parameters.AddWithValue("@MédicamentID", medicamentId);
                        cmdStock.Parameters.AddWithValue("@QuantitéVendue", -quantiteVendue);
                        cmdStock.ExecuteNonQuery();
                    }

                    MessageBox.Show("Vente ajoutée avec succès !");
                }
                ChargerVentesDansDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ChargerVentesDansDataGridView();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvVentes.CurrentRow != null)
            {
                try
                {
                    int venteId = Convert.ToInt32(dgvVentes.CurrentRow.Cells[0].Value);
                    int medicamentId = Convert.ToInt32(cmbMedicamentID.SelectedValue);
                    int quantiteVendue = int.Parse(txtQuantiteVendue.Text);

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string queryVente = @"UPDATE Ventes 
                                      SET Date = @Date, 
                                          ClientID = @ClientID, 
                                          Total = @Total, 
                                          Réduction = @Réduction, 
                                          MédicamentID = @MédicamentID, 
                                          QuantitéVendue = @QuantitéVendue 
                                      WHERE VenteID = @VenteID";

                        using (SqlCommand cmdVente = new SqlCommand(queryVente, con))
                        {
                            cmdVente.Parameters.AddWithValue("@VenteID", venteId);
                            cmdVente.Parameters.AddWithValue("@Date", dtpDate.Value);
                            cmdVente.Parameters.AddWithValue("@ClientID", cmbClientID.SelectedValue);
                            cmdVente.Parameters.AddWithValue("@Total", decimal.Parse(txtTotal.Text));
                            cmdVente.Parameters.AddWithValue("@Réduction", string.IsNullOrEmpty(txtReduction.Text) ? 0 : decimal.Parse(txtReduction.Text));
                            cmdVente.Parameters.AddWithValue("@MédicamentID", medicamentId);
                            cmdVente.Parameters.AddWithValue("@QuantitéVendue", quantiteVendue);
                            cmdVente.ExecuteNonQuery();
                        }

                        MessageBox.Show("Vente modifiée avec succès !");
                    }
                    ChargerVentesDansDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une vente à modifier.");
            }
        }


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvVentes.CurrentRow != null)
            {
                int venteId = Convert.ToInt32(dgvVentes.CurrentRow.Cells[0].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            string queryDetails = "DELETE FROM DetailsVente WHERE VenteID = @VenteID";
                            using (SqlCommand cmdDetails = new SqlCommand(queryDetails, con, transaction))
                            {
                                cmdDetails.Parameters.AddWithValue("@VenteID", venteId);
                                cmdDetails.ExecuteNonQuery();
                            }

                            string queryVente = "DELETE FROM Ventes WHERE VenteID = @VenteID";
                            using (SqlCommand cmdVente = new SqlCommand(queryVente, con, transaction))
                            {
                                cmdVente.Parameters.AddWithValue("@VenteID", venteId);
                                cmdVente.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Vente supprimée avec succès !");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                        }
                    }
                }
                ChargerVentesDansDataGridView();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une vente à supprimer.");
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }

        private void dgvVentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateVente(int venteId, int medicamentId, int quantiteVendue)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string checkMedicamentQuery = "SELECT COUNT(1) FROM Médicaments WHERE MédicamentID = @MédicamentID";
                using (SqlCommand checkCmd = new SqlCommand(checkMedicamentQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@MédicamentID", medicamentId);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("Le MédicamentID n'existe pas dans la table Médicaments.");
                        return;
                    }
                }

                string updateQuery = "UPDATE Ventes SET MédicamentID = @MédicamentID, QuantitéVendue = @QuantitéVendue WHERE VenteID = @VenteID";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@VenteID", venteId);
                    updateCmd.Parameters.AddWithValue("@MédicamentID", medicamentId);
                    updateCmd.Parameters.AddWithValue("@QuantitéVendue", quantiteVendue);
                    updateCmd.ExecuteNonQuery();
                }
            }
        }

        private void cmbMedicamentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicamentID.SelectedValue is DataRowView rowView)
            {
                var medicamentId = rowView["MédicamentID"];
            }
            else if (cmbMedicamentID.SelectedValue != null)
            {
                int medicamentId = Convert.ToInt32(cmbMedicamentID.SelectedValue);
            }
            cmbMedicamentID.Refresh();
        }

        //{
        //    if (cmbMedicamentID.SelectedIndex != -1)
        //    {

        //        int medicamentId = (int)cmbMedicamentID.SelectedValue;
        //    }
        //}


        private void txtQuantiteVendue_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantiteVendue.Text, out int quantite))
            {
                MessageBox.Show("Veuillez entrer un nombre valide pour la quantité vendue.");
            }
            else
            {

            }
        }

        private void txtReduction_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
