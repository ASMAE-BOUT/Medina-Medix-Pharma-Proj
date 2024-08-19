using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Medina_Medix_Pharma_Proj
{
    public partial class LoginForm : Form
    {
        string connectionString = "Data Source=DESKTOP-3HOM7H2\\SQLEXPRESS;Initial Catalog=Pharma_App;Integrated Security=True;TrustServerCertificate=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = txtNomUtilisateur.Text;
            string motDePasse = txtMotDePasse.Text;

            string role = VerifierIdentifiantsUtilisateur(nomUtilisateur, motDePasse);

            if (!string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Connexion réussie !");
                this.Hide();
                DashboardForm dashboardForm = new DashboardForm(role); 
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
            }
        }

        private string VerifierIdentifiantsUtilisateur(string nomUtilisateur, string motDePasse)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT Role FROM Utilisateurs WHERE Nom = @Nom AND MotDePasse = @MotDePasse";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nomUtilisateur.ToUpper());
                        cmd.Parameters.AddWithValue("@MotDePasse", motDePasse);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString(); 
                        }
                        else
                        {
                            return null; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void txtNomUtilisateur_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreerUtilisateur_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
