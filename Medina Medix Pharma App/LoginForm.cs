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
            cmbRole.Items.Add("Pharmacien");
            cmbRole.Items.Add("Manager");
            cmbRole.Items.Add("Docteur");
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = txtNomUtilisateur.Text;
            string motDePasse = txtMotDePasse.Text;
            string role = cmbRole.SelectedItem?.ToString();  

            if (VerifierIdentifiantsUtilisateur(nomUtilisateur, motDePasse, role))
            {
                MessageBox.Show("Connexion réussie !");
                this.Hide();
                DashboardForm dashboardForm = new DashboardForm(role);
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur, mot de passe ou rôle incorrect.");
            }
        }

        private bool VerifierIdentifiantsUtilisateur(string nomUtilisateur, string motDePasse, string role)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(1) FROM Utilisateurs WHERE Nom = @Nom AND MotDePasse = @MotDePasse AND Role = @Role";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nomUtilisateur.ToUpper());
                        cmd.Parameters.AddWithValue("@MotDePasse", motDePasse);
                        cmd.Parameters.AddWithValue("@Role", role);
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
