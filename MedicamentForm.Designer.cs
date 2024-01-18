<<<<<<< HEAD
﻿namespace Medina_Medix_Pharma_Proj
=======
﻿using System;

namespace Medina_Medix_Pharma_Proj
>>>>>>> Ajoutez des fichiers projet.
{
    partial class MedicamentForm
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
<<<<<<< HEAD
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "MedicamentForm";
        }

        #endregion
=======
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDateDExpiration = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodeABarres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtTauxDePriseEnCharge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContreIndications = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUtilisations = new System.Windows.Forms.TextBox();
            this.txtEffetsSecondaires = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantiteDisponible = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantiteMinimale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrixVente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrixAchat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMedicaments = new System.Windows.Forms.DataGridView();
            this.médicamentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.désignationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixAchatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitéMinimaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitéDisponibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilisationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsSecondairesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tauxDePriseEnChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeÀBarresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDExpirationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.médicamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmaProjDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharma_ProjDataSet = new Medina_Medix_Pharma_Proj.Pharma_ProjDataSet();
            this.médicamentsTableAdapter = new Medina_Medix_Pharma_Proj.Pharma_ProjDataSetTableAdapters.MédicamentsTableAdapter();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnChargerImage = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.médicamentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaProjDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharma_ProjDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDateDExpiration);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCodeABarres);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtTauxDePriseEnCharge);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtContreIndications);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUtilisations);
            this.groupBox1.Controls.Add(this.txtEffetsSecondaires);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQuantiteDisponible);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQuantiteMinimale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrixVente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrixAchat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDesignation);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détail de Médicament";
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Date d\'expiration";
            // 
            // txtDateDExpiration
            // 
            this.txtDateDExpiration.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtDateDExpiration.Location = new System.Drawing.Point(508, 148);
            this.txtDateDExpiration.Name = "txtDateDExpiration";
            this.txtDateDExpiration.Size = new System.Drawing.Size(134, 23);
            this.txtDateDExpiration.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Code à Barres";
            // 
            // txtCodeABarres
            // 
            this.txtCodeABarres.Location = new System.Drawing.Point(137, 148);
            this.txtCodeABarres.Name = "txtCodeABarres";
            this.txtCodeABarres.Size = new System.Drawing.Size(182, 23);
            this.txtCodeABarres.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Taux de Prise en Charge";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(566, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // txtTauxDePriseEnCharge
            // 
            this.txtTauxDePriseEnCharge.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTauxDePriseEnCharge.Location = new System.Drawing.Point(508, 119);
            this.txtTauxDePriseEnCharge.Name = "txtTauxDePriseEnCharge";
            this.txtTauxDePriseEnCharge.Size = new System.Drawing.Size(134, 23);
            this.txtTauxDePriseEnCharge.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Contre Indications";
            // 
            // txtContreIndications
            // 
            this.txtContreIndications.Location = new System.Drawing.Point(471, 90);
            this.txtContreIndications.Name = "txtContreIndications";
            this.txtContreIndications.Size = new System.Drawing.Size(171, 23);
            this.txtContreIndications.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Utilisations";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Effets Secondaires";
            // 
            // txtUtilisations
            // 
            this.txtUtilisations.Location = new System.Drawing.Point(102, 90);
            this.txtUtilisations.Name = "txtUtilisations";
            this.txtUtilisations.Size = new System.Drawing.Size(217, 23);
            this.txtUtilisations.TabIndex = 17;
            // 
            // txtEffetsSecondaires
            // 
            this.txtEffetsSecondaires.Location = new System.Drawing.Point(137, 119);
            this.txtEffetsSecondaires.Name = "txtEffetsSecondaires";
            this.txtEffetsSecondaires.Size = new System.Drawing.Size(182, 23);
            this.txtEffetsSecondaires.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantité Disponible";
            // 
            // txtQuantiteDisponible
            // 
            this.txtQuantiteDisponible.Location = new System.Drawing.Point(564, 61);
            this.txtQuantiteDisponible.Name = "txtQuantiteDisponible";
            this.txtQuantiteDisponible.Size = new System.Drawing.Size(78, 23);
            this.txtQuantiteDisponible.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantité Minimale";
            // 
            // txtQuantiteMinimale
            // 
            this.txtQuantiteMinimale.Location = new System.Drawing.Point(345, 61);
            this.txtQuantiteMinimale.Name = "txtQuantiteMinimale";
            this.txtQuantiteMinimale.Size = new System.Drawing.Size(78, 23);
            this.txtQuantiteMinimale.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prix de Vente";
            // 
            // txtPrixVente
            // 
            this.txtPrixVente.Location = new System.Drawing.Point(102, 61);
            this.txtPrixVente.Name = "txtPrixVente";
            this.txtPrixVente.Size = new System.Drawing.Size(78, 23);
            this.txtPrixVente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prix d\'achat";
            // 
            // txtPrixAchat
            // 
            this.txtPrixAchat.Location = new System.Drawing.Point(375, 32);
            this.txtPrixAchat.Name = "txtPrixAchat";
            this.txtPrixAchat.Size = new System.Drawing.Size(78, 23);
            this.txtPrixAchat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Désignation";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(94, 32);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(172, 23);
            this.txtDesignation.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMedicaments);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvMedicaments
            // 
            this.dgvMedicaments.AllowUserToAddRows = false;
            this.dgvMedicaments.AllowUserToDeleteRows = false;
            this.dgvMedicaments.AutoGenerateColumns = false;
            this.dgvMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.médicamentIDDataGridViewTextBoxColumn,
            this.désignationDataGridViewTextBoxColumn,
            this.prixAchatDataGridViewTextBoxColumn,
            this.prixVenteDataGridViewTextBoxColumn,
            this.quantitéMinimaleDataGridViewTextBoxColumn,
            this.quantitéDisponibleDataGridViewTextBoxColumn,
            this.utilisationsDataGridViewTextBoxColumn,
            this.contreIndicationsDataGridViewTextBoxColumn,
            this.effetsSecondairesDataGridViewTextBoxColumn,
            this.tauxDePriseEnChargeDataGridViewTextBoxColumn,
            this.codeÀBarresDataGridViewTextBoxColumn,
            this.dateDExpirationDataGridViewTextBoxColumn});
            this.dgvMedicaments.DataSource = this.médicamentsBindingSource;
            this.dgvMedicaments.Location = new System.Drawing.Point(0, 6);
            this.dgvMedicaments.Name = "dgvMedicaments";
            this.dgvMedicaments.Size = new System.Drawing.Size(772, 197);
            this.dgvMedicaments.TabIndex = 0;
            this.dgvMedicaments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicaments_CellContentClick);
            // 
            // médicamentIDDataGridViewTextBoxColumn
            // 
            this.médicamentIDDataGridViewTextBoxColumn.DataPropertyName = "MédicamentID";
            this.médicamentIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.médicamentIDDataGridViewTextBoxColumn.Name = "médicamentIDDataGridViewTextBoxColumn";
            this.médicamentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.médicamentIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // désignationDataGridViewTextBoxColumn
            // 
            this.désignationDataGridViewTextBoxColumn.DataPropertyName = "Désignation";
            this.désignationDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.désignationDataGridViewTextBoxColumn.Name = "désignationDataGridViewTextBoxColumn";
            this.désignationDataGridViewTextBoxColumn.Width = 80;
            // 
            // prixAchatDataGridViewTextBoxColumn
            // 
            this.prixAchatDataGridViewTextBoxColumn.DataPropertyName = "PrixAchat";
            this.prixAchatDataGridViewTextBoxColumn.HeaderText = "PA";
            this.prixAchatDataGridViewTextBoxColumn.Name = "prixAchatDataGridViewTextBoxColumn";
            this.prixAchatDataGridViewTextBoxColumn.Width = 50;
            // 
            // prixVenteDataGridViewTextBoxColumn
            // 
            this.prixVenteDataGridViewTextBoxColumn.DataPropertyName = "PrixVente";
            this.prixVenteDataGridViewTextBoxColumn.HeaderText = "PV";
            this.prixVenteDataGridViewTextBoxColumn.Name = "prixVenteDataGridViewTextBoxColumn";
            this.prixVenteDataGridViewTextBoxColumn.Width = 50;
            // 
            // quantitéMinimaleDataGridViewTextBoxColumn
            // 
            this.quantitéMinimaleDataGridViewTextBoxColumn.DataPropertyName = "QuantitéMinimale";
            this.quantitéMinimaleDataGridViewTextBoxColumn.HeaderText = "Qté Min";
            this.quantitéMinimaleDataGridViewTextBoxColumn.Name = "quantitéMinimaleDataGridViewTextBoxColumn";
            this.quantitéMinimaleDataGridViewTextBoxColumn.Width = 50;
            // 
            // quantitéDisponibleDataGridViewTextBoxColumn
            // 
            this.quantitéDisponibleDataGridViewTextBoxColumn.DataPropertyName = "QuantitéDisponible";
            this.quantitéDisponibleDataGridViewTextBoxColumn.HeaderText = "Qté Dispo";
            this.quantitéDisponibleDataGridViewTextBoxColumn.Name = "quantitéDisponibleDataGridViewTextBoxColumn";
            this.quantitéDisponibleDataGridViewTextBoxColumn.Width = 50;
            // 
            // utilisationsDataGridViewTextBoxColumn
            // 
            this.utilisationsDataGridViewTextBoxColumn.DataPropertyName = "Utilisations";
            this.utilisationsDataGridViewTextBoxColumn.HeaderText = "Utilisations";
            this.utilisationsDataGridViewTextBoxColumn.Name = "utilisationsDataGridViewTextBoxColumn";
            this.utilisationsDataGridViewTextBoxColumn.Width = 70;
            // 
            // contreIndicationsDataGridViewTextBoxColumn
            // 
            this.contreIndicationsDataGridViewTextBoxColumn.DataPropertyName = "ContreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.HeaderText = "Ctre Indica";
            this.contreIndicationsDataGridViewTextBoxColumn.Name = "contreIndicationsDataGridViewTextBoxColumn";
            this.contreIndicationsDataGridViewTextBoxColumn.Width = 70;
            // 
            // effetsSecondairesDataGridViewTextBoxColumn
            // 
            this.effetsSecondairesDataGridViewTextBoxColumn.DataPropertyName = "EffetsSecondaires";
            this.effetsSecondairesDataGridViewTextBoxColumn.HeaderText = "Effets Secon";
            this.effetsSecondairesDataGridViewTextBoxColumn.Name = "effetsSecondairesDataGridViewTextBoxColumn";
            this.effetsSecondairesDataGridViewTextBoxColumn.Width = 70;
            // 
            // tauxDePriseEnChargeDataGridViewTextBoxColumn
            // 
            this.tauxDePriseEnChargeDataGridViewTextBoxColumn.DataPropertyName = "TauxDePriseEnCharge";
            this.tauxDePriseEnChargeDataGridViewTextBoxColumn.HeaderText = "Taux PEC";
            this.tauxDePriseEnChargeDataGridViewTextBoxColumn.Name = "tauxDePriseEnChargeDataGridViewTextBoxColumn";
            this.tauxDePriseEnChargeDataGridViewTextBoxColumn.Width = 50;
            // 
            // codeÀBarresDataGridViewTextBoxColumn
            // 
            this.codeÀBarresDataGridViewTextBoxColumn.DataPropertyName = "CodeÀBarres";
            this.codeÀBarresDataGridViewTextBoxColumn.HeaderText = "Code Barre";
            this.codeÀBarresDataGridViewTextBoxColumn.Name = "codeÀBarresDataGridViewTextBoxColumn";
            this.codeÀBarresDataGridViewTextBoxColumn.Width = 70;
            // 
            // dateDExpirationDataGridViewTextBoxColumn
            // 
            this.dateDExpirationDataGridViewTextBoxColumn.DataPropertyName = "DateDExpiration";
            this.dateDExpirationDataGridViewTextBoxColumn.HeaderText = "Date Expir";
            this.dateDExpirationDataGridViewTextBoxColumn.Name = "dateDExpirationDataGridViewTextBoxColumn";
            this.dateDExpirationDataGridViewTextBoxColumn.Width = 70;
            // 
            // médicamentsBindingSource
            // 
            this.médicamentsBindingSource.DataMember = "Médicaments";
            this.médicamentsBindingSource.DataSource = this.pharmaProjDataSetBindingSource;
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
            // médicamentsTableAdapter
            // 
            this.médicamentsTableAdapter.ClearBeforeFill = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAjouter.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(687, 49);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(103, 26);
            this.btnAjouter.TabIndex = 18;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnModifier.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(687, 81);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(103, 26);
            this.btnModifier.TabIndex = 19;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click_1);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSupprimer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(687, 113);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(103, 26);
            this.btnSupprimer.TabIndex = 20;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // btnChargerImage
            // 
            this.btnChargerImage.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnChargerImage.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargerImage.Location = new System.Drawing.Point(687, 178);
            this.btnChargerImage.Name = "btnChargerImage";
            this.btnChargerImage.Size = new System.Drawing.Size(103, 26);
            this.btnChargerImage.TabIndex = 21;
            this.btnChargerImage.Text = "Retour";
            this.btnChargerImage.UseVisualStyleBackColor = false;
            this.btnChargerImage.Click += new System.EventHandler(this.btnChargerImage_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnActualiser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.Location = new System.Drawing.Point(687, 146);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(103, 26);
            this.btnActualiser.TabIndex = 22;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Format_Prix: 00,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(157, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Format_Date: AAAA-MM-JJ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(330, 434);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Format_Taux: 00,00";
            // 
            // MedicamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(802, 461);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnChargerImage);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicamentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicamentForm";
            this.Load += new System.EventHandler(this.MedicamentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.médicamentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaProjDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharma_ProjDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContreIndications;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUtilisations;
        private System.Windows.Forms.TextBox txtEffetsSecondaires;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantiteDisponible;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantiteMinimale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrixVente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrixAchat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDateDExpiration;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodeABarres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTauxDePriseEnCharge;
        private System.Windows.Forms.DataGridView dgvMedicaments;
        private System.Windows.Forms.BindingSource pharmaProjDataSetBindingSource;
        private Pharma_ProjDataSet pharma_ProjDataSet;
        private System.Windows.Forms.BindingSource médicamentsBindingSource;
        private Pharma_ProjDataSetTableAdapters.MédicamentsTableAdapter médicamentsTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnChargerImage;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.DataGridViewTextBoxColumn médicamentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn désignationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixAchatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitéMinimaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitéDisponibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilisationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsSecondairesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tauxDePriseEnChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeÀBarresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDExpirationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;

        public EventHandler label7_Click { get; private set; }
        public EventHandler txtEffetsSecondaires_TextChanged { get; private set; }
>>>>>>> Ajoutez des fichiers projet.
    }
}