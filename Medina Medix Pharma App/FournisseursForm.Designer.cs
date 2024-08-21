using System;

namespace Medina_Medix_Pharma_Proj
{
    partial class FournisseursForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomFournisseur = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvFournisseurs = new System.Windows.Forms.DataGridView();
            this.fournisseurIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fournisseursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmaProjDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharma_ProjDataSet = new Medina_Medix_Pharma_Proj.Pharma_AppDataSet();
            this.fournisseursTableAdapter = new Medina_Medix_Pharma_Proj.Pharma_AppDataSetTableAdapters.FournisseursTableAdapter();
            this.btnAjouterFournisseur = new System.Windows.Forms.Button();
            this.btnSupprimerFournisseur = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bttnQuitter = new System.Windows.Forms.Button();
            this.fournisseursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAfficherFournisseurs = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaProjDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharma_ProjDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAdresse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomFournisseur);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(609, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détail du Fournisseur";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(106, 89);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(487, 23);
            this.txtAdresse.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(369, 47);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(224, 23);
            this.txtContact.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // txtNomFournisseur
            // 
            this.txtNomFournisseur.Location = new System.Drawing.Point(48, 47);
            this.txtNomFournisseur.Name = "txtNomFournisseur";
            this.txtNomFournisseur.Size = new System.Drawing.Size(224, 23);
            this.txtNomFournisseur.TabIndex = 2;
            this.txtNomFournisseur.TextChanged += new System.EventHandler(this.txtNomFournisseur_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox2.Controls.Add(this.dgvFournisseurs);
            this.groupBox2.Location = new System.Drawing.Point(45, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(538, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvFournisseurs
            // 
            this.dgvFournisseurs.AllowUserToAddRows = false;
            this.dgvFournisseurs.AllowUserToDeleteRows = false;
            this.dgvFournisseurs.AutoGenerateColumns = false;
            this.dgvFournisseurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFournisseurs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFournisseurs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFournisseurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFournisseurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fournisseurIDDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn});
            this.dgvFournisseurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFournisseurs.DataSource = this.fournisseursBindingSource;
            this.dgvFournisseurs.Location = new System.Drawing.Point(0, -1);
            this.dgvFournisseurs.Name = "dgvFournisseurs";
            this.dgvFournisseurs.Size = new System.Drawing.Size(538, 274);
            this.dgvFournisseurs.TabIndex = 0;
            this.dgvFournisseurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFournisseurs_CellContentClick);
            this.dgvFournisseurs.SelectionChanged += new System.EventHandler(this.dgvFournisseurs_SelectionChanged);
            // 
            // fournisseurIDDataGridViewTextBoxColumn
            // 
            this.fournisseurIDDataGridViewTextBoxColumn.DataPropertyName = "FournisseurID";
            this.fournisseurIDDataGridViewTextBoxColumn.HeaderText = "FournisseurID";
            this.fournisseurIDDataGridViewTextBoxColumn.Name = "fournisseurIDDataGridViewTextBoxColumn";
            this.fournisseurIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // fournisseursBindingSource
            // 
            this.fournisseursBindingSource.DataMember = "Fournisseurs";
            this.fournisseursBindingSource.DataSource = this.pharmaProjDataSetBindingSource;
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
            // fournisseursTableAdapter
            // 
            this.fournisseursTableAdapter.ClearBeforeFill = true;
            // 
            // btnAjouterFournisseur
            // 
            this.btnAjouterFournisseur.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAjouterFournisseur.Location = new System.Drawing.Point(634, 28);
            this.btnAjouterFournisseur.Name = "btnAjouterFournisseur";
            this.btnAjouterFournisseur.Size = new System.Drawing.Size(156, 30);
            this.btnAjouterFournisseur.TabIndex = 2;
            this.btnAjouterFournisseur.Text = "Ajouter";
            this.btnAjouterFournisseur.UseVisualStyleBackColor = false;
            this.btnAjouterFournisseur.Click += new System.EventHandler(this.btnAjouterFournisseur_Click);
            // 
            // btnSupprimerFournisseur
            // 
            this.btnSupprimerFournisseur.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSupprimerFournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSupprimerFournisseur.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSupprimerFournisseur.FlatAppearance.BorderSize = 0;
            this.btnSupprimerFournisseur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSupprimerFournisseur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSupprimerFournisseur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimerFournisseur.Location = new System.Drawing.Point(634, 64);
            this.btnSupprimerFournisseur.Name = "btnSupprimerFournisseur";
            this.btnSupprimerFournisseur.Size = new System.Drawing.Size(156, 28);
            this.btnSupprimerFournisseur.TabIndex = 3;
            this.btnSupprimerFournisseur.Text = "Supprimer";
            this.btnSupprimerFournisseur.UseVisualStyleBackColor = false;
            this.btnSupprimerFournisseur.Click += new System.EventHandler(this.btnSupprimerFournisseur_Click);
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
            this.bttnQuitter.Location = new System.Drawing.Point(634, 169);
            this.bttnQuitter.Name = "bttnQuitter";
            this.bttnQuitter.Size = new System.Drawing.Size(156, 28);
            this.bttnQuitter.TabIndex = 5;
            this.bttnQuitter.Text = "Retour";
            this.bttnQuitter.UseVisualStyleBackColor = false;
            this.bttnQuitter.Click += new System.EventHandler(this.bttnQuitter_Click);
            // 
            // fournisseursBindingSource1
            // 
            this.fournisseursBindingSource1.DataMember = "Fournisseurs";
            this.fournisseursBindingSource1.DataSource = this.pharmaProjDataSetBindingSource;
            // 
            // btnAfficherFournisseurs
            // 
            this.btnAfficherFournisseurs.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAfficherFournisseurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAfficherFournisseurs.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAfficherFournisseurs.FlatAppearance.BorderSize = 0;
            this.btnAfficherFournisseurs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAfficherFournisseurs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAfficherFournisseurs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAfficherFournisseurs.Location = new System.Drawing.Point(634, 135);
            this.btnAfficherFournisseurs.Name = "btnAfficherFournisseurs";
            this.btnAfficherFournisseurs.Size = new System.Drawing.Size(156, 28);
            this.btnAfficherFournisseurs.TabIndex = 6;
            this.btnAfficherFournisseurs.Text = "Afficher Tout";
            this.btnAfficherFournisseurs.UseVisualStyleBackColor = false;
            this.btnAfficherFournisseurs.Click += new System.EventHandler(this.btnAfficherFournisseurs_Click);
            // 
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
            // FournisseursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(802, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAfficherFournisseurs);
            this.Controls.Add(this.bttnQuitter);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnSupprimerFournisseur);
            this.Controls.Add(this.btnAjouterFournisseur);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FournisseursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fournisseurs";
            this.Load += new System.EventHandler(this.FournisseursForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournisseurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaProjDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharma_ProjDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomFournisseur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.DataGridView dgvFournisseurs;
        private System.Windows.Forms.BindingSource pharmaProjDataSetBindingSource;
        private Pharma_AppDataSet pharma_ProjDataSet;
        private System.Windows.Forms.BindingSource fournisseursBindingSource;
        private Pharma_AppDataSetTableAdapters.FournisseursTableAdapter fournisseursTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fournisseurIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAjouterFournisseur;
        private System.Windows.Forms.Button btnSupprimerFournisseur;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bttnQuitter;
        private System.Windows.Forms.BindingSource fournisseursBindingSource1;
        private System.Windows.Forms.Button btnAfficherFournisseurs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
