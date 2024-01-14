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
    public partial class AddUserForm : Form
    {
        string connectionString = @"Server=DESKTOP-3RKAS3I; Database=Pharma Proj; Integrated Security=True;";

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        public AddUserForm()
        {
            InitializeComponent();
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
                        cmd.Parameters.AddWithValue("@Nom", nomUtilisateur);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@MotDePasse", motDePasse);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Utilisateur ajouté avec succès !");
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
            string role = txtRole.Text;
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


        //private void btnAjouterUtilisateur_Click_1(object sender, EventArgs e)
        //{
        //    string nomUtilisateur = txtNomUtilisateur.Text;
        //    string role = txtRole.Text;
        //    string motDePasse = txtMotDePasse.Text;

        //    AjouterUtilisateur(nomUtilisateur, role, motDePasse);
        //}

    }
}
