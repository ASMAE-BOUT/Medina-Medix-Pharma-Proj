using System;

namespace Medina_Medix_Pharma_Proj
{
    partial class Clients
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRéduction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTéléphone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.téléphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.réductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmaProjDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharma_ProjDataSet = new Medina_Medix_Pharma_Proj.Pharma_ProjDataSet();
            this.clientsTableAdapter = new Medina_Medix_Pharma_Proj.Pharma_ProjDataSetTableAdapters.ClientsTableAdapter();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bttnQuitter = new System.Windows.Forms.Button();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAfficherClients = new System.Windows.Forms.Button();
<<<<<<< HEAD
=======
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
>>>>>>> Ajoutez des fichiers projet.
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaProjDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharma_ProjDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
<<<<<<< HEAD
=======
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
>>>>>>> Ajoutez des fichiers projet.
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRéduction);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTéléphone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdresse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomClient);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(609, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détail de Client";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Réduction";
            // 
            // txtRéduction
            // 
            this.txtRéduction.Location = new System.Drawing.Point(382, 92);
            this.txtRéduction.Name = "txtRéduction";
            this.txtRéduction.Size = new System.Drawing.Size(113, 23);
            this.txtRéduction.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Téléphone";
            // 
            // txtTéléphone
            // 
            this.txtTéléphone.Location = new System.Drawing.Point(85, 89);
            this.txtTéléphone.Name = "txtTéléphone";
            this.txtTéléphone.Size = new System.Drawing.Size(208, 23);
            this.txtTéléphone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(382, 45);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(211, 23);
            this.txtAdresse.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // txtNomClient
            // 
            this.txtNomClient.Location = new System.Drawing.Point(85, 47);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(208, 23);
            this.txtNomClient.TabIndex = 0;
            this.txtNomClient.TextChanged += new System.EventHandler(this.txtNomClient_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox2.Controls.Add(this.dgvClients);
            this.groupBox2.Location = new System.Drawing.Point(45, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(538, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AutoGenerateColumns = false;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.téléphoneDataGridViewTextBoxColumn,
            this.réductionDataGridViewTextBoxColumn});
            this.dgvClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvClients.DataSource = this.clientsBindingSource;
            this.dgvClients.Location = new System.Drawing.Point(0, -1);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(538, 274);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // téléphoneDataGridViewTextBoxColumn
            // 
            this.téléphoneDataGridViewTextBoxColumn.DataPropertyName = "Téléphone";
            this.téléphoneDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.téléphoneDataGridViewTextBoxColumn.Name = "téléphoneDataGridViewTextBoxColumn";
            // 
            // réductionDataGridViewTextBoxColumn
            // 
            this.réductionDataGridViewTextBoxColumn.DataPropertyName = "Réduction";
            this.réductionDataGridViewTextBoxColumn.HeaderText = "Réduction";
            this.réductionDataGridViewTextBoxColumn.Name = "réductionDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.pharmaProjDataSetBindingSource;
            // 
            // pharmaProjDataSetBindingSource
            // 
            this.pharmaProjDataSetBindingSource.DataSource = this.pharma_ProjDataSet;
            this.pharmaProjDataSetBindingSource.Position = 0;
            // 
            // pharma_ProjDataSet
            // 
            this.pharma_ProjDataSet.DataSetName = "Pharma_ProjDataSet";
            this.pharma_ProjDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAjouterClient.Location = new System.Drawing.Point(634, 28);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(156, 30);
            this.btnAjouterClient.TabIndex = 2;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = false;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSupprimerClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSupprimerClient.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSupprimerClient.FlatAppearance.BorderSize = 0;
            this.btnSupprimerClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSupprimerClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSupprimerClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimerClient.Location = new System.Drawing.Point(634, 64);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(156, 28);
            this.btnSupprimerClient.TabIndex = 3;
            this.btnSupprimerClient.Text = "Supprimer";
            this.btnSupprimerClient.UseVisualStyleBackColor = false;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRechercher.Location = new System.Drawing.Point(634, 99);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(156, 30);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bttnQuitter
            // 
            this.bttnQuitter.BackColor = System.Drawing.Color.LavenderBlush;
            this.bttnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bttnQuitter.FlatAppearance.BorderSize = 0;
            this.bttnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.bttnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.bttnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
<<<<<<< HEAD
            this.bttnQuitter.Location = new System.Drawing.Point(634, 135);
            this.bttnQuitter.Name = "bttnQuitter";
            this.bttnQuitter.Size = new System.Drawing.Size(156, 28);
            this.bttnQuitter.TabIndex = 5;
            this.bttnQuitter.Text = "Quitter";
=======
            this.bttnQuitter.Location = new System.Drawing.Point(634, 169);
            this.bttnQuitter.Name = "bttnQuitter";
            this.bttnQuitter.Size = new System.Drawing.Size(156, 28);
            this.bttnQuitter.TabIndex = 5;
            this.bttnQuitter.Text = "Retour";
>>>>>>> Ajoutez des fichiers projet.
            this.bttnQuitter.UseVisualStyleBackColor = false;
            this.bttnQuitter.Click += new System.EventHandler(this.bttnQuitter_Click);
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.pharmaProjDataSetBindingSource;
            // 
            // btnAfficherClients
            // 
            this.btnAfficherClients.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAfficherClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAfficherClients.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAfficherClients.FlatAppearance.BorderSize = 0;
            this.btnAfficherClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAfficherClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAfficherClients.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
<<<<<<< HEAD
            this.btnAfficherClients.Location = new System.Drawing.Point(634, 169);
=======
            this.btnAfficherClients.Location = new System.Drawing.Point(634, 135);
>>>>>>> Ajoutez des fichiers projet.
            this.btnAfficherClients.Name = "btnAfficherClients";
            this.btnAfficherClients.Size = new System.Drawing.Size(156, 28);
            this.btnAfficherClients.TabIndex = 6;
            this.btnAfficherClients.Text = "Afficher Tout";
            this.btnAfficherClients.UseVisualStyleBackColor = false;
            this.btnAfficherClients.Click += new System.EventHandler(this.btnAfficherClients_Click);
            // 
<<<<<<< HEAD
=======
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(694, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Medina Medix";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Medina_Medix_Pharma_Proj.Properties.Resources.pink_pharmacy_logo_hi;
            this.pictureBox1.Location = new System.Drawing.Point(707, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
>>>>>>> Ajoutez des fichiers projet.
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(802, 461);
<<<<<<< HEAD
=======
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
>>>>>>> Ajoutez des fichiers projet.
            this.Controls.Add(this.btnAfficherClients);
            this.Controls.Add(this.bttnQuitter);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnSupprimerClient);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaProjDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharma_ProjDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
<<<<<<< HEAD
            this.ResumeLayout(false);
=======
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> Ajoutez des fichiers projet.

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTéléphone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRéduction;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.BindingSource pharmaProjDataSetBindingSource;
        private Pharma_ProjDataSet pharma_ProjDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Pharma_ProjDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn téléphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn réductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bttnQuitter;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.Button btnAfficherClients;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
>>>>>>> Ajoutez des fichiers projet.

        public EventHandler SupprimerClient_Click { get; private set; }
    }
}

