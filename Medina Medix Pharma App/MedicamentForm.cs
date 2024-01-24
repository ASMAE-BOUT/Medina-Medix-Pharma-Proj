using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Medina_Medix_Pharma_Proj
{
    public partial class MedicamentForm : Form
    {
        private string connectionString = @"Server=DESKTOP-3RKAS3I; Database=Pharma Proj; User Id=PharmaLogin; Password=PharmaApp159;";

        public MedicamentForm()
        {
            InitializeComponent();
            dgvMedicaments.SelectionChanged += dgvMedicaments_SelectionChanged;
        }

        private void dgvMedicaments_SelectionChanged(object sender, EventArgs e)
        {
            ChargerDetailsMedicament();
        }

        private void MedicamentForm_Load(object sender, EventArgs e)
        {
            ChargerMedicamentsDansDataGridView();
        }

        private void ChargerDetailsMedicament()
        {
            if (dgvMedicaments.CurrentRow != null)
            {
                int medicamentId = Convert.ToInt32(dgvMedicaments.CurrentRow.Cells[0].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Médicaments WHERE MédicamentID = @MédicamentID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MédicamentID", medicamentId);
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtDesignation.Text = reader["Désignation"].ToString();
                                txtPrixAchat.Text = reader["PrixAchat"].ToString();
                                txtPrixVente.Text = reader["PrixVente"].ToString();
                                txtQuantiteMinimale.Text = reader["QuantitéMinimale"].ToString();
                                txtQuantiteDisponible.Text = reader["QuantitéDisponible"].ToString();
                                txtUtilisations.Text = reader["Utilisations"].ToString();
                                txtContreIndications.Text = reader["ContreIndications"].ToString();
                                txtEffetsSecondaires.Text = reader["EffetsSecondaires"].ToString();
                                txtTauxDePriseEnCharge.Text = reader["TauxDePriseEnCharge"].ToString();
                                txtCodeABarres.Text = reader["CodeÀBarres"].ToString();

                                if (DateTime.TryParse(reader["DateDExpiration"].ToString(), out DateTime dateExpiration))
                                {
                                    txtDateDExpiration.Text = dateExpiration.ToString("yyyy-MM-dd");
                                }
                            }
                        }
                    }
                }
            }
        }


        private void ChargerMedicamentsDansDataGridView()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT MédicamentID, Désignation, PrixAchat, PrixVente, QuantitéMinimale, QuantitéDisponible, Utilisations, ContreIndications, EffetsSecondaires, TauxDePriseEnCharge, CodeÀBarres, DateDExpiration FROM Médicaments";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMedicaments.DataSource = dt;
                }
            }
        }



        //private void btnChargerImage_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog
        //    {
        //        Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"
        //    };
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string filePath = openFileDialog.FileName;
        //        byte[] imageBytes = File.ReadAllBytes(filePath);
        //        int medicamentId = Convert.ToInt32(dgvMedicaments.CurrentRow.Cells["MédicamentID"].Value);

        //        using (SqlConnection con = new SqlConnection(connectionString))
        //        {
        //            string query = "UPDATE Médicaments SET Photo = @Photo WHERE MédicamentID = @MédicamentID";
        //            using (SqlCommand cmd = new SqlCommand(query, con))
        //            {
        //                cmd.Parameters.AddWithValue("@Photo", imageBytes);
        //                cmd.Parameters.AddWithValue("@MédicamentID", medicamentId);

        //                con.Open();
        //                cmd.ExecuteNonQuery();
        //                MessageBox.Show("Image chargée avec succès !");
        //            }
        //        }
        //    }
        //}

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Médicaments (Désignation, PrixAchat, PrixVente, QuantitéMinimale, QuantitéDisponible, Utilisations, ContreIndications, EffetsSecondaires, TauxDePriseEnCharge, CodeÀBarres, DateDExpiration) VALUES (@Désignation, @PrixAchat, @PrixVente, @QuantitéMinimale, @QuantitéDisponible, @Utilisations, @ContreIndications, @EffetsSecondaires, @TauxDePriseEnCharge, @CodeÀBarres, @DateDExpiration)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@Désignation", txtDesignation.Text);
                        cmd.Parameters.AddWithValue("@PrixAchat", decimal.Parse(txtPrixAchat.Text));
                        cmd.Parameters.AddWithValue("@PrixVente", decimal.Parse(txtPrixVente.Text));
                        cmd.Parameters.AddWithValue("@QuantitéMinimale", int.Parse(txtQuantiteMinimale.Text));
                        cmd.Parameters.AddWithValue("@QuantitéDisponible", int.Parse(txtQuantiteDisponible.Text));
                        cmd.Parameters.AddWithValue("@Utilisations", txtUtilisations.Text);
                        cmd.Parameters.AddWithValue("@ContreIndications", txtContreIndications.Text);
                        cmd.Parameters.AddWithValue("@EffetsSecondaires", txtEffetsSecondaires.Text);
                        cmd.Parameters.AddWithValue("@TauxDePriseEnCharge", decimal.Parse(txtTauxDePriseEnCharge.Text));
                        cmd.Parameters.AddWithValue("@CodeÀBarres", txtCodeABarres.Text);
                        cmd.Parameters.AddWithValue("@DateDExpiration", DateTime.Parse(txtDateDExpiration.Text));

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Médicament ajouté avec succès !");
                    }
                }
                ChargerMedicamentsDansDataGridView();
            }
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            if (dgvMedicaments.CurrentRow != null)
            {
                int medicamentId = Convert.ToInt32(dgvMedicaments.CurrentRow.Cells[0].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Médicaments SET Désignation = @Désignation, PrixAchat = @PrixAchat, PrixVente = @PrixVente, QuantitéMinimale = @QuantitéMinimale, QuantitéDisponible = @QuantitéDisponible, Utilisations = @Utilisations, ContreIndications = @ContreIndications, EffetsSecondaires = @EffetsSecondaires, TauxDePriseEnCharge = @TauxDePriseEnCharge, CodeÀBarres = @CodeÀBarres, DateDExpiration = @DateDExpiration WHERE MédicamentID = @MédicamentID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MédicamentID", medicamentId);
                        cmd.Parameters.AddWithValue("@Désignation", txtDesignation.Text);
                        cmd.Parameters.AddWithValue("@PrixAchat", decimal.Parse(txtPrixAchat.Text));
                        cmd.Parameters.AddWithValue("@PrixVente", decimal.Parse(txtPrixVente.Text));
                        cmd.Parameters.AddWithValue("@QuantitéMinimale", int.Parse(txtQuantiteMinimale.Text));
                        cmd.Parameters.AddWithValue("@QuantitéDisponible", int.Parse(txtQuantiteDisponible.Text));
                        cmd.Parameters.AddWithValue("@Utilisations", txtUtilisations.Text);
                        cmd.Parameters.AddWithValue("@ContreIndications", txtContreIndications.Text);
                        cmd.Parameters.AddWithValue("@EffetsSecondaires", txtEffetsSecondaires.Text);
                        cmd.Parameters.AddWithValue("@TauxDePriseEnCharge", decimal.Parse(txtTauxDePriseEnCharge.Text));
                        cmd.Parameters.AddWithValue("@CodeÀBarres", txtCodeABarres.Text);
                        cmd.Parameters.AddWithValue("@DateDExpiration", DateTime.Parse(txtDateDExpiration.Text));

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Médicament modifié avec succès !");
                    }
                }
                ChargerMedicamentsDansDataGridView();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un médicament à modifier.");
            }
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            int medicamentId = Convert.ToInt32(dgvMedicaments.CurrentRow.Cells[0].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Médicaments WHERE MédicamentID = @MédicamentID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MédicamentID", medicamentId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Médicament supprimé avec succès !");
                }
            }
            ChargerMedicamentsDansDataGridView();
        }

        private void btnActualiser_Click_1(object sender, EventArgs e)
        {
            ChargerMedicamentsDansDataGridView();
        }

        private void btnChargerImage_Click(object sender, EventArgs e)
        {
            this.Close();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }

        private void dgvMedicaments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == "btnSupprimer" && int.TryParse(senderGrid.Rows[e.RowIndex].Cells["MédicamentID"].Value.ToString(), out int medicamentId))
                {
                    SupprimerMedicament(medicamentId);
                    ChargerMedicamentsDansDataGridView();
                }
                else
                {
                    MessageBox.Show("ID du médicament non valide.");
                }
            }
        }

        private void SupprimerMedicament(int medicamentId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Médicaments WHERE MédicamentID = @MédicamentID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MédicamentID", medicamentId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Médicament supprimé avec succès !");
                }
            }
            ChargerMedicamentsDansDataGridView();
        }

    }
}



//private void txtEffetsSecondaires_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void MedicamentForm_Load(object sender, EventArgs e)
//        {
//            this.médicamentsTableAdapter.Fill(this.pharma_ProjDataSet.Médicaments);

//        }
//    }
//}
