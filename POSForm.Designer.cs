namespace Medina_Medix_Pharma_Proj
{
    partial class POSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReduction = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClientID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvVentes = new System.Windows.Forms.DataGridView();
            this.médicamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharma_ProjDataSet = new Medina_Medix_Pharma_Proj.Pharma_ProjDataSet();
            this.ventesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksTableAdapter = new Medina_Medix_Pharma_Proj.Pharma_ProjDataSetTableAdapters.StocksTableAdapter();
            this.ventesTableAdapter = new Medina_Medix_Pharma_Proj.Pharma_ProjDataSetTableAdapters.VentesTableAdapter();
            this.médicamentsTableAdapter = new Medina_Medix_Pharma_Proj.Pharma_ProjDataSetTableAdapters.MédicamentsTableAdapter();
            this.médicamentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.désignationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixAchatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitéDisponibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtéVendue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.médicamentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharma_ProjDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReduction);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbClientID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détail de Vente";
            // 
            // txtReduction
            // 
            this.txtReduction.Location = new System.Drawing.Point(306, 63);
            this.txtReduction.Name = "txtReduction";
            this.txtReduction.Size = new System.Drawing.Size(121, 23);
            this.txtReduction.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Réduction";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(79, 63);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 23);
            this.txtTotal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(306, 26);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(233, 23);
            this.dtpDate.TabIndex = 7;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date";
            // 
            // cmbClientID
            // 
            this.cmbClientID.FormattingEnabled = true;
            this.cmbClientID.Location = new System.Drawing.Point(79, 26);
            this.cmbClientID.Name = "cmbClientID";
            this.cmbClientID.Size = new System.Drawing.Size(121, 26);
            this.cmbClientID.TabIndex = 5;
            this.cmbClientID.SelectedIndexChanged += new System.EventHandler(this.cmbClientID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ClientID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvVentes);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvVentes
            // 
            this.dgvVentes.AllowUserToAddRows = false;
            this.dgvVentes.AllowUserToDeleteRows = false;
            this.dgvVentes.AutoGenerateColumns = false;
            this.dgvVentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.médicamentIDDataGridViewTextBoxColumn,
            this.désignationDataGridViewTextBoxColumn,
            this.prixAchatDataGridViewTextBoxColumn,
            this.prixVenteDataGridViewTextBoxColumn,
            this.quantitéDisponibleDataGridViewTextBoxColumn,
            this.QtéVendue});
            this.dgvVentes.DataSource = this.médicamentsBindingSource;
            this.dgvVentes.Location = new System.Drawing.Point(0, 0);
            this.dgvVentes.Name = "dgvVentes";
            this.dgvVentes.Size = new System.Drawing.Size(635, 211);
            this.dgvVentes.TabIndex = 0;
            this.dgvVentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentes_CellContentClick);
            // 
            // médicamentsBindingSource
            // 
            this.médicamentsBindingSource.DataMember = "Médicaments";
            this.médicamentsBindingSource.DataSource = this.pharma_ProjDataSet;
            // 
            // pharma_ProjDataSet
            // 
            this.pharma_ProjDataSet.DataSetName = "Pharma_ProjDataSet";
            this.pharma_ProjDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventesBindingSource
            // 
            this.ventesBindingSource.DataMember = "Ventes";
            this.ventesBindingSource.DataSource = this.pharma_ProjDataSet;
            // 
            // stocksBindingSource1
            // 
            this.stocksBindingSource1.DataMember = "Stocks";
            this.stocksBindingSource1.DataSource = this.pharma_ProjDataSet;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAjouter.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(641, 34);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(112, 26);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnModifier.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(641, 66);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(112, 26);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSupprimer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(641, 98);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(112, 26);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnActualiser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.Location = new System.Drawing.Point(641, 130);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(112, 26);
            this.btnActualiser.TabIndex = 5;
            this.btnActualiser.Text = "Finaliser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(682, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Medina Medix";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Medina_Medix_Pharma_Proj.Properties.Resources.pink_pharmacy_logo_hi;
            this.pictureBox1.Location = new System.Drawing.Point(695, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRetour.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(641, 162);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(112, 26);
            this.btnRetour.TabIndex = 19;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.pharma_ProjDataSet;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // ventesTableAdapter
            // 
            this.ventesTableAdapter.ClearBeforeFill = true;
            // 
            // médicamentsTableAdapter
            // 
            this.médicamentsTableAdapter.ClearBeforeFill = true;
            // 
            // médicamentIDDataGridViewTextBoxColumn
            // 
            this.médicamentIDDataGridViewTextBoxColumn.DataPropertyName = "MédicamentID";
            this.médicamentIDDataGridViewTextBoxColumn.HeaderText = "MédicamentID";
            this.médicamentIDDataGridViewTextBoxColumn.Name = "médicamentIDDataGridViewTextBoxColumn";
            this.médicamentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // désignationDataGridViewTextBoxColumn
            // 
            this.désignationDataGridViewTextBoxColumn.DataPropertyName = "Désignation";
            this.désignationDataGridViewTextBoxColumn.HeaderText = "Désignation";
            this.désignationDataGridViewTextBoxColumn.Name = "désignationDataGridViewTextBoxColumn";
            // 
            // prixAchatDataGridViewTextBoxColumn
            // 
            this.prixAchatDataGridViewTextBoxColumn.DataPropertyName = "PrixAchat";
            this.prixAchatDataGridViewTextBoxColumn.HeaderText = "PrixAchat";
            this.prixAchatDataGridViewTextBoxColumn.Name = "prixAchatDataGridViewTextBoxColumn";
            // 
            // prixVenteDataGridViewTextBoxColumn
            // 
            this.prixVenteDataGridViewTextBoxColumn.DataPropertyName = "PrixVente";
            this.prixVenteDataGridViewTextBoxColumn.HeaderText = "PrixVente";
            this.prixVenteDataGridViewTextBoxColumn.Name = "prixVenteDataGridViewTextBoxColumn";
            // 
            // quantitéDisponibleDataGridViewTextBoxColumn
            // 
            this.quantitéDisponibleDataGridViewTextBoxColumn.DataPropertyName = "QuantitéDisponible";
            this.quantitéDisponibleDataGridViewTextBoxColumn.HeaderText = "Qté Dispo";
            this.quantitéDisponibleDataGridViewTextBoxColumn.Name = "quantitéDisponibleDataGridViewTextBoxColumn";
            // 
            // QtéVendue
            // 
            this.QtéVendue.DataPropertyName = "QuantiteVendue";
            this.QtéVendue.HeaderText = "Qté Vendue";
            this.QtéVendue.Name = "QtéVendue";
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(786, 422);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSForm";
            this.Load += new System.EventHandler(this.POSForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.médicamentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharma_ProjDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtReduction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.DataGridView dgvVentes;
        private Pharma_ProjDataSet pharma_ProjDataSet;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private Pharma_ProjDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.BindingSource stocksBindingSource1;
        private System.Windows.Forms.BindingSource ventesBindingSource;
        private Pharma_ProjDataSetTableAdapters.VentesTableAdapter ventesTableAdapter;
        private System.Windows.Forms.BindingSource médicamentsBindingSource;
        private Pharma_ProjDataSetTableAdapters.MédicamentsTableAdapter médicamentsTableAdapter;
        private System.Windows.Forms.DataGridView dgvMedicaments;
        private System.Windows.Forms.DataGridViewTextBoxColumn médicamentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn désignationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixAchatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitéDisponibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtéVendue;
    }
}