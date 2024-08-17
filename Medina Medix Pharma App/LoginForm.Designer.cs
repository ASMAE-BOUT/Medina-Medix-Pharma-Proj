using System;
using Guna.UI2.WinForms;

namespace Medina_Medix_Pharma_Proj
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNomUtilisateur = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotDePasse = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSeConnecter = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreerUtilisateur = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomUtilisateur.DefaultText = "";
            this.txtNomUtilisateur.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNomUtilisateur.Location = new System.Drawing.Point(73, 165);
            this.txtNomUtilisateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.PasswordChar = '\0';
            this.txtNomUtilisateur.PlaceholderText = "Nom d\'utilisateur";
            this.txtNomUtilisateur.SelectedText = "";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(206, 36);
            this.txtNomUtilisateur.TabIndex = 0;
            this.txtNomUtilisateur.TextChanged += new System.EventHandler(this.txtNomUtilisateur_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de Passe";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotDePasse.DefaultText = "";
            this.txtMotDePasse.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMotDePasse.Location = new System.Drawing.Point(73, 224);
            this.txtMotDePasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.PasswordChar = '●';
            this.txtMotDePasse.PlaceholderText = "Mot de passe";
            this.txtMotDePasse.SelectedText = "";
            this.txtMotDePasse.Size = new System.Drawing.Size(206, 36);
            this.txtMotDePasse.TabIndex = 2;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.BackColor = System.Drawing.Color.Transparent;
            this.btnSeConnecter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeConnecter.FillColor = System.Drawing.Color.Gray;
            this.btnSeConnecter.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSeConnecter.ForeColor = System.Drawing.Color.Black;
            this.btnSeConnecter.Location = new System.Drawing.Point(73, 264);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(206, 36);
            this.btnSeConnecter.TabIndex = 4;
            this.btnSeConnecter.Text = "Se Connecter";
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // btnCreerUtilisateur
            // 
            this.btnCreerUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.btnCreerUtilisateur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreerUtilisateur.FillColor = System.Drawing.Color.Gray;
            this.btnCreerUtilisateur.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCreerUtilisateur.ForeColor = System.Drawing.Color.Black;
            this.btnCreerUtilisateur.Location = new System.Drawing.Point(73, 306);
            this.btnCreerUtilisateur.Name = "btnCreerUtilisateur";
            this.btnCreerUtilisateur.Size = new System.Drawing.Size(206, 36);
            this.btnCreerUtilisateur.TabIndex = 5;
            this.btnCreerUtilisateur.Text = "Nouveau Utilisateur";
            this.btnCreerUtilisateur.Click += new System.EventHandler(this.btnCreerUtilisateur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Medina_Medix_Pharma_Proj.Properties.Resources.pink_pharmacy_logo_hi;
            this.pictureBox1.Location = new System.Drawing.Point(704, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(691, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medina Medix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(148, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Système de Gestion de Medina Medix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(295, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Version 1.0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FillColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(73, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Quitter";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::Medina_Medix_Pharma_Proj.Properties.Resources.pexels_castorly_stock_40582321;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreerUtilisateur);
            this.Controls.Add(this.btnSeConnecter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna2TextBox txtNomUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna2TextBox txtMotDePasse;
        private Guna2Button btnSeConnecter;
        private Guna2Button btnCreerUtilisateur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna2Button button1;
    }
}
