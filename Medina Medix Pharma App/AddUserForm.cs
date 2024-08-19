using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Medina_Medix_Pharma_Proj
{
    public partial class AddUserForm : Form
    {
        string connectionString = "Data Source=DESKTOP-3HOM7H2\\SQLEXPRESS;Initial Catalog=Pharma_App;Integrated Security=True;TrustServerCertificate=True";

        public AddUserForm()
        {
            InitializeComponent();

            cmbRole.Items.Add("Pharmacien");
            cmbRole.Items.Add("Manager");
            cmbRole.Items.Add("Docteur");
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void AjouterUtilisateur(string nomUtilisateur, string role, string motDePasse)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Utilisateurs (Nom, Role, MotDePasse) VALUES (@Nom, @Role, @MotDePasse)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nomUtilisateur.ToUpper());
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@MotDePasse", motDePasse);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Utilisateur ajouté avec succès !");

                    DashboardForm dashboardForm = new DashboardForm(role);
                    dashboardForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'utilisateur : " + ex.Message);
            }
        }

        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtConfirmMotDePasse_TextChanged(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text != txtConfirmMotDePasse.Text)
            {
                lblStatus.Text = "Les mots de passe ne correspondent pas.";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.Text = "Les mots de passe correspondent.";
                lblStatus.ForeColor = Color.Green;
            }
        }

        private void btnAjouterUtilisateur_Click_1(object sender, EventArgs e)
        {
            string nomUtilisateur = txtNomUtilisateur.Text;
            string role = cmbRole.SelectedItem.ToString(); 
            string motDePasse = txtMotDePasse.Text;
            string confirmMotDePasse = txtConfirmMotDePasse.Text;

            if (motDePasse != confirmMotDePasse)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.");
                return;
            }

            if (!string.IsNullOrEmpty(nomUtilisateur) && !string.IsNullOrEmpty(motDePasse))
            {
                AjouterUtilisateur(nomUtilisateur, role, motDePasse);
            }
            else
            {
                MessageBox.Show("Le nom d'utilisateur et le mot de passe sont requis.");
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
