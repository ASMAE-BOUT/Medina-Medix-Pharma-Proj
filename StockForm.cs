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
    public partial class StockForm : Form
    {
        private string connectionString = @"Server=DESKTOP-3RKAS3I; Database=Pharma Proj; User Id=PharmaLogin; Password=PharmaApp159;";

        public static DataTable DataSource { get; private set; }

        public StockForm()
        {
            InitializeComponent();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            ChargerStocksDansDataGridView();
            RemplirComboBoxMedicament();
        }

        private void cmbMedicamentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicamentID.SelectedValue != null)
            {
                int medicamentId = Convert.ToInt32(cmbMedicamentID.SelectedValue);
            }
        }

        private void RemplirComboBoxMedicament()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT MédicamentID, Désignation FROM Médicaments";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cmbMedicamentID.DisplayMember = "Désignation"; 
                        cmbMedicamentID.ValueMember = "MédicamentID"; 
                        cmbMedicamentID.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des médicaments : " + ex.Message);
                }
            }
        }


        private void ChargerStocksDansDataGridView()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT StockID, MédicamentID, Quantité, DateEntrée FROM Stocks";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    StockForm.DataSource = dt;
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        //{
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        string query = "INSERT INTO Stocks (MédicamentID, Quantité, DateEntrée) VALUES (@MédicamentID, @Quantité, @DateEntrée)";
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.AddWithValue("@MédicamentID", cmbMedicamentID.SelectedValue);
        //            cmd.Parameters.AddWithValue("@Quantité", int.Parse(txtQuantite.Text));
        //            cmd.Parameters.AddWithValue("@DateEntrée", dtpDateEntree.Value);

        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Stock ajouté avec succès !");
        //        }
        //    }
        //    ChargerStocksDansDataGridView();
        //}

        {
            // Supposons que vous ayez un champ pour entrer la quantité à ajouter
            int quantiteAjoutee = int.Parse(txtQuantite.Text);
            int medicamentId = Convert.ToInt32(cmbMedicamentID.SelectedValue);
            DateTime dateEntree = dtpDateEntree.Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("AjouterAuStock", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MédicamentID", medicamentId);
                    cmd.Parameters.AddWithValue("@Quantité", quantiteAjoutee);
                    cmd.Parameters.AddWithValue("@DateEntrée", dateEntree);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Stock mis à jour avec succès !");
            ChargerStocksDansDataGridView();
        }



        private void btnModifier_Click(object sender, EventArgs e)
        {
            int stockId = Convert.ToInt32(dgvStocks.CurrentRow.Cells[0].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Stocks SET MédicamentID = @MédicamentID, Quantité = @Quantité, DateEntrée = @DateEntrée WHERE StockID = @StockID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StockID", stockId);
                    cmd.Parameters.AddWithValue("@MédicamentID", cmbMedicamentID.SelectedValue);
                    cmd.Parameters.AddWithValue("@Quantité", int.Parse(txtQuantite.Text));
                    cmd.Parameters.AddWithValue("@DateEntrée", dtpDateEntree.Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stock modifié avec succès !");
                }
            }
            ChargerStocksDansDataGridView();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int stockId = Convert.ToInt32(dgvStocks.CurrentRow.Cells[0].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Stocks WHERE StockID = @StockID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StockID", stockId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stock supprimé avec succès !");
                }
            }
            ChargerStocksDansDataGridView();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ChargerStocksDansDataGridView();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }

        private void dgvStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == "btnSupprimer" && int.TryParse(senderGrid.Rows[e.RowIndex].Cells["StockID"].Value.ToString(), out int stockId))
                {
                    SupprimerStock(stockId);
                    ChargerStocksDansDataGridView();
                }
                else
                {
                    MessageBox.Show("ID de stock non valide.");
                }
            }
        }

        private void SupprimerStock(int stockId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Stocks WHERE StockID = @StockID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StockID", stockId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Entrée de stock supprimée avec succès !");
                }
            }
        }

    }
}
