namespace Medina_Medix_Pharma_Proj
{
    partial class OrdonnanceForm
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateOrdonnance = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOrdonnances = new System.Windows.Forms.DataGridView();
            this.ordonnanceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordonnancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmaProjDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharma_ProjDataSet = new Medina_Medix_Pharma_Proj.Pharma_AppDataSet();
            this.ordonnancesTableAdapter = new Medina_Medix_Pharma_Proj.Pharma_AppDataSetTableAdapters.OrdonnancesTableAdapter();
            this.btnAjouterOrdonnance = new System.Windows.Forms.Button();
            this.btnSupprimerOrdonnance = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bttnQuitter = new System.Windows.Forms.Button();
            this.ordonnancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAfficherOrdonnances = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdonnances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaProjDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharma_ProjDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnancesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDateOrdonnance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbClients);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(609, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détail de l\'Ordonnance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(382, 92);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(113, 23);
            this.txtTotal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // dtpDateOrdonnance
            // 
            this.dtpDateOrdonnance.Location = new System.Drawing.Point(85, 89);
            this.dtpDateOrdonnance.Name = "dtpDateOrdonnance";
            this.dtpDateOrdonnance.Size = new System.Drawing.Size(208, 23);
            this.dtpDateOrdonnance.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client";
            // 
            // cmbClients
            // 
            this.cmbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(85, 47);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(208, 26);
            this.cmbClients.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox2.Controls.Add(this.dgvOrdonnances);
            this.groupBox2.Location = new System.Drawing.Point(45, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(538, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvOrdonnances
            // 
            this.dgvOrdonnances.AllowUserToAddRows = false;
            this.dgvOrdonnances.AllowUserToDeleteRows = false;
            this.dgvOrdonnances.AutoGenerateColumns = false;
            this.dgvOrdonnances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdonnances.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdonnances.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdonnances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdonnances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdonnances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordonnanceIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvOrdonnances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvOrdonnances.DataSource = this.ordonnancesBindingSource;
            this.dgvOrdonnances.Location = new System.Drawing.Point(0, -1);
            this.dgvOrdonnances.Name = "dgvOrdonnances";
            this.dgvOrdonnances.Size = new System.Drawing.Size(538, 274);
            this.dgvOrdonnances.TabIndex = 0;
            // 
            // ordonnanceIDDataGridViewTextBoxColumn
            // 
            this.ordonnanceIDDataGridViewTextBoxColumn.DataPropertyName = "OrdonnanceID";
            this.ordonnanceIDDataGridViewTextBoxColumn.HeaderText = "OrdonnanceID";
            this.ordonnanceIDDataGridViewTextBoxColumn.Name = "ordonnanceIDDataGridViewTextBoxColumn";
            this.ordonnanceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // ordonnancesBindingSource
            // 
            this.ordonnancesBindingSource.DataMember = "Ordonnances";
            this.ordonnancesBindingSource.DataSource = this.pharmaProjDataSetBindingSource;
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
            // ordonnancesTableAdapter
            // 
            this.ordonnancesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAjouterOrdonnance
            // 
            this.btnAjouterOrdonnance.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAjouterOrdonnance.Location = new System.Drawing.Point(634, 28);
            this.btnAjouterOrdonnance.Name = "btnAjouterOrdonnance";
            this.btnAjouterOrdonnance.Size = new System.Drawing.Size(156, 30);
            this.btnAjouterOrdonnance.TabIndex = 2;
            this.btnAjouterOrdonnance.Text = "Ajouter";
            this.btnAjouterOrdonnance.UseVisualStyleBackColor = false;
            this.btnAjouterOrdonnance.Click += new System.EventHandler(this.btnAjouterOrdonnance_Click);
            // 
            // btnSupprimerOrdonnance
            // 
            this.btnSupprimerOrdonnance.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSupprimerOrdonnance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSupprimerOrdonnance.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSupprimerOrdonnance.FlatAppearance.BorderSize = 0;
            this.btnSupprimerOrdonnance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSupprimerOrdonnance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSupprimerOrdonnance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimerOrdonnance.Location = new System.Drawing.Point(634, 64);
            this.btnSupprimerOrdonnance.Name = "btnSupprimerOrdonnance";
            this.btnSupprimerOrdonnance.Size = new System.Drawing.Size(156, 28);
            this.btnSupprimerOrdonnance.TabIndex = 3;
            this.btnSupprimerOrdonnance.Text = "Supprimer";
            this.btnSupprimerOrdonnance.UseVisualStyleBackColor = false;
            this.btnSupprimerOrdonnance.Click += new System.EventHandler(this.btnSupprimerOrdonnance_Click);
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
            // ordonnancesBindingSource1
            // 
            this.ordonnancesBindingSource1.DataMember = "Ordonnances";
            this.ordonnancesBindingSource1.DataSource = this.pharmaProjDataSetBindingSource;
            // 
            // btnAfficherOrdonnances
            // 
            this.btnAfficherOrdonnances.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAfficherOrdonnances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAfficherOrdonnances.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAfficherOrdonnances.FlatAppearance.BorderSize = 0;
            this.btnAfficherOrdonnances.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAfficherOrdonnances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAfficherOrdonnances.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAfficherOrdonnances.Location = new System.Drawing.Point(634, 135);
            this.btnAfficherOrdonnances.Name = "btnAfficherOrdonnances";
            this.btnAfficherOrdonnances.Size = new System.Drawing.Size(156, 28);
            this.btnAfficherOrdonnances.TabIndex = 6;
            this.btnAfficherOrdonnances.Text = "Afficher Tout";
            this.btnAfficherOrdonnances.UseVisualStyleBackColor = false;
            this.btnAfficherOrdonnances.Click += new System.EventHandler(this.btnAfficherOrdonnances_Click);
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
            // OrdonnanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(802, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAfficherOrdonnances);
            this.Controls.Add(this.bttnQuitter);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnSupprimerOrdonnance);
            this.Controls.Add(this.btnAjouterOrdonnance);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdonnanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordonnance";
            this.Load += new System.EventHandler(this.OrdonnanceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdonnances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaProjDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharma_ProjDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnancesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateOrdonnance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOrdonnances;
        private System.Windows.Forms.BindingSource pharmaProjDataSetBindingSource;
        private Pharma_AppDataSet pharma_ProjDataSet;
        private System.Windows.Forms.BindingSource ordonnancesBindingSource;
        private Pharma_AppDataSetTableAdapters.OrdonnancesTableAdapter ordonnancesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordonnanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAjouterOrdonnance;
        private System.Windows.Forms.Button btnSupprimerOrdonnance;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bttnQuitter;
        private System.Windows.Forms.BindingSource ordonnancesBindingSource1;
        private System.Windows.Forms.Button btnAfficherOrdonnances;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
