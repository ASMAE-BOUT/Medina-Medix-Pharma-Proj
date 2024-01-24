using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Medina_Medix_Pharma_Proj
{
    public partial class LoginForm : Form
    {
        string connectionString = @"Server=DESKTOP-3RKAS3I; Database=Pharma Proj; User Id=PharmaLogin; Password=PharmaApp159;";
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

            if (VerifierIdentifiantsUtilisateur(nomUtilisateur, motDePasse))
            {
                MessageBox.Show("Connexion réussie !");
                this.Hide();
                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
            }
        }

        private bool VerifierIdentifiantsUtilisateur(string nomUtilisateur, string motDePasse)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(1) FROM Utilisateurs WHERE Nom = @Nom AND MotDePasse = @MotDePasse";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nomUtilisateur.ToUpper());
                        cmd.Parameters.AddWithValue("@MotDePasse", motDePasse);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
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
