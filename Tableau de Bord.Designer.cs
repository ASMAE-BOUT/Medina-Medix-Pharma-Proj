namespace Medina_Medix_Pharma_Proj
{
    partial class DashboardForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnFournisseur = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnOrdonnance = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnMedicament = new System.Windows.Forms.Button();
            this.btnnQuitter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(20, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Medina Medix";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Medina_Medix_Pharma_Proj.Properties.Resources.pink_pharmacy_logo_hi;
            this.pictureBox1.Location = new System.Drawing.Point(33, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnPOS.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.Image = global::Medina_Medix_Pharma_Proj.Properties.Resources.icons8_pharma_100;
            this.btnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.Location = new System.Drawing.Point(306, 64);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(174, 72);
            this.btnPOS.TabIndex = 5;
            this.btnPOS.Text = "POS";
            this.btnPOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPOS.UseCompatibleTextRendering = true;
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnFournisseur
            // 
            this.btnFournisseur.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnFournisseur.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFournisseur.Image = global::Medina_Medix_Pharma_Proj.Properties.Resources.icons8_supplier_64;
            this.btnFournisseur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFournisseur.Location = new System.Drawing.Point(544, 174);
            this.btnFournisseur.Name = "btnFournisseur";
            this.btnFournisseur.Size = new System.Drawing.Size(174, 72);
            this.btnFournisseur.TabIndex = 4;
            this.btnFournisseur.Text = "Fournisseurs";
            this.btnFournisseur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFournisseur.UseCompatibleTextRendering = true;
            this.btnFournisseur.UseVisualStyleBackColor = false;
            this.btnFournisseur.Click += new System.EventHandler(this.btnFournisseur_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClient.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Image = global::Medina_Medix_Pharma_Proj.Properties.Resources.icons8_clients_64;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(544, 64);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(174, 72);
            this.btnClient.TabIndex = 3;
            this.btnClient.Text = "Clients";
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClient.UseCompatibleTextRendering = true;
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnOrdonnance
            // 
            this.btnOrdonnance.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOrdonnance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdonnance.Image = global::Medina_Medix_Pharma_Proj.Properties.Resources.icons8_treatment_64;
            this.btnOrdonnance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdonnance.Location = new System.Drawing.Point(306, 174);
            this.btnOrdonnance.Name = "btnOrdonnance";
            this.btnOrdonnance.Size = new System.Drawing.Size(174, 72);
            this.btnOrdonnance.TabIndex = 2;
            this.btnOrdonnance.Text = "Ordonnance";
            this.btnOrdonnance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrdonnance.UseCompatibleTextRendering = true;
            this.btnOrdonnance.UseVisualStyleBackColor = false;
            this.btnOrdonnance.Click += new System.EventHandler(this.btnOrdonnance_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnStock.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Image = global::Medina_Medix_Pharma_Proj.Properties.Resources.icons8_stock_64;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(55, 174);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(174, 72);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStock.UseCompatibleTextRendering = true;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnMedicament
            // 
            this.btnMedicament.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnMedicament.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicament.Image = global::Medina_Medix_Pharma_Proj.Properties.Resources.icons8_pilules_64;
            this.btnMedicament.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicament.Location = new System.Drawing.Point(55, 64);
            this.btnMedicament.Name = "btnMedicament";
            this.btnMedicament.Size = new System.Drawing.Size(174, 72);
            this.btnMedicament.TabIndex = 0;
            this.btnMedicament.Text = "Médicament";
            this.btnMedicament.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedicament.UseCompatibleTextRendering = true;
            this.btnMedicament.UseVisualStyleBackColor = false;
            this.btnMedicament.Click += new System.EventHandler(this.btnMedicament_Click);
            // 
            // btnnQuitter
            // 
            this.btnnQuitter.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnnQuitter.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnQuitter.Location = new System.Drawing.Point(567, 342);
            this.btnnQuitter.Name = "btnnQuitter";
            this.btnnQuitter.Size = new System.Drawing.Size(151, 32);
            this.btnnQuitter.TabIndex = 16;
            this.btnnQuitter.Text = "Retour";
            this.btnnQuitter.UseVisualStyleBackColor = false;
            this.btnnQuitter.Click += new System.EventHandler(this.btnnQuitter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(567, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Afficher Manuel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(802, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnnQuitter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnFournisseur);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnOrdonnance);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnMedicament);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau_de_Bord";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedicament;
        private System.Windows.Forms.Button btnOrdonnance;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnFournisseur;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnnQuitter;
        private System.Windows.Forms.Button button1;
    }
}