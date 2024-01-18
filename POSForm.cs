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
        public POSForm()
        {
            InitializeComponent();
        }

        private void POSForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pharma_ProjDataSet.Médicaments'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.médicamentsTableAdapter.Fill(this.pharma_ProjDataSet.Médicaments);
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
                string query = "SELECT ClientID, Nom FROM Clients";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cmbClientID.DisplayMember = "Nom";
                    cmbClientID.ValueMember = "ClientID";
                    cmbClientID.DataSource = dt;
                }
            }
        }

        private void ChargerVentesDansDataGridView()
        //{
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        string query = "SELECT VenteID, Date, ClientID, Total, Réduction FROM Ventes";
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable dt = new DataTable();
        //            adapter.Fill(dt);
        //            dgvVentes.DataSource = dt;
        //        }
        //    }
        //}

        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT MédicamentID, Désignation, PrixAchat, PrixVente, QuantitéDisponible FROM Médicaments";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMedicaments.DataSource = dt;
                }
            }
        }



        private void cmbClientID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Ventes (Date, ClientID, Total, Réduction) VALUES (@Date, @ClientID, @Total, @Réduction)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@ClientID", cmbClientID.SelectedValue);
                    cmd.Parameters.AddWithValue("@Total", decimal.Parse(txtTotal.Text));
                    cmd.Parameters.AddWithValue("@Réduction", string.IsNullOrEmpty(txtReduction.Text) ? 0 : decimal.Parse(txtReduction.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vente ajoutée avec succès !");
                }
            }
            ChargerVentesDansDataGridView();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        //{
        //    ChargerVentesDansDataGridView();
        //}

        {
            List<VenteMedicament> ventes = new List<VenteMedicament>();

            foreach (DataGridViewRow row in dgvMedicaments.Rows)
            {
                if (row.Cells["QuantiteVendue"].Value != null)
                {
                    int medicamentId = Convert.ToInt32(row.Cells["MedicamentID"].Value);
                    int quantiteVendue = Convert.ToInt32(row.Cells["QuantiteVendue"].Value);

                    ventes.Add(new VenteMedicament
                    {
                        MedicamentId = medicamentId,
                        QuantiteVendue = quantiteVendue
                    });
                }
            }

            EnregistrerVente(ventes);
        }

        private void EnregistrerVente(List<VenteMedicament> ventes)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {

                        foreach (var vente in ventes)
                        {
                            string queryDetailsVente = "INSERT INTO DetailsVente (VenteID, MédicamentID, QuantitéVendue) VALUES (@VenteID, @MédicamentID, @QuantitéVendue)";
                            using (SqlCommand cmdDetailsVente = new SqlCommand(queryDetailsVente, con, transaction))
                            {
                                cmdDetailsVente.Parameters.AddWithValue("@VenteID", vente.VenteId); 
                                cmdDetailsVente.Parameters.AddWithValue("@MédicamentID", vente.MedicamentId);
                                cmdDetailsVente.Parameters.AddWithValue("@QuantitéVendue", vente.QuantiteVendue);
                                cmdDetailsVente.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Vente enregistrée avec succès !");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Une erreur est survenue : " + ex.Message);
                    }
                }
            }
        }



        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvVentes.CurrentRow != null)
            {
                int venteId = Convert.ToInt32(dgvVentes.CurrentRow.Cells["VenteID"].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Ventes SET Date = @Date, ClientID = @ClientID, Total = @Total, Réduction = @Réduction WHERE VenteID = @VenteID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VenteID", venteId);
                        cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                        cmd.Parameters.AddWithValue("@ClientID", cmbClientID.SelectedValue);
                        cmd.Parameters.AddWithValue("@Total", decimal.Parse(txtTotal.Text));
                        cmd.Parameters.AddWithValue("@Réduction", string.IsNullOrEmpty(txtReduction.Text) ? 0 : decimal.Parse(txtReduction.Text));

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vente modifiée avec succès !");
                    }
                }
                ChargerVentesDansDataGridView();
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
                int venteId = Convert.ToInt32(dgvVentes.CurrentRow.Cells["VenteID"].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Ventes WHERE VenteID = @VenteID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VenteID", venteId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vente supprimée avec succès !");
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
    }

    //public class VenteMedicament
    //{
    //    public int MedicamentId { get; set; }
    //    public int QuantiteVendue { get; set; }

    //}
}



