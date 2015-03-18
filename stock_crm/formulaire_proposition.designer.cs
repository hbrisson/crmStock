namespace stock_crm
{
    partial class formulaire_proposition
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
            this.panelCommande = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.commentaire_txb = new System.Windows.Forms.TextBox();
            this.commandeValid = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tiers_lbl = new System.Windows.Forms.Label();
            this.tiers_resulat_lbl = new System.Windows.Forms.Label();
            this.quantite_lbl = new System.Windows.Forms.Label();
            this.quantite_resultat_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.montant_resultat_lbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.qte_dispo_lbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.produit_resultat_lbl = new System.Windows.Forms.Label();
            this.prix_unit_resultat_lbl = new System.Windows.Forms.Label();
            this.tiers_cb = new System.Windows.Forms.ComboBox();
            this.valider_btn = new System.Windows.Forms.Button();
            this.quantite_cb = new System.Windows.Forms.ComboBox();
            this.produit_cb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imprimer_btn = new System.Windows.Forms.Button();
            this.montant_total_resultat_lbl = new System.Windows.Forms.Label();
            this.tva_resultat_lbl = new System.Windows.Forms.Label();
            this.tva_lbl = new System.Windows.Forms.Label();
            this.montant_total_ = new System.Windows.Forms.Label();
            this.panelCommande.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCommande
            // 
            this.panelCommande.Controls.Add(this.label5);
            this.panelCommande.Controls.Add(this.groupBox1);
            this.panelCommande.Controls.Add(this.commentaire_txb);
            this.panelCommande.Controls.Add(this.commandeValid);
            this.panelCommande.Controls.Add(this.groupBox2);
            this.panelCommande.Location = new System.Drawing.Point(12, 12);
            this.panelCommande.Name = "panelCommande";
            this.panelCommande.Size = new System.Drawing.Size(937, 417);
            this.panelCommande.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Commentaire :";
            // 
            // commentaire_txb
            // 
            this.commentaire_txb.Location = new System.Drawing.Point(575, 316);
            this.commentaire_txb.Multiline = true;
            this.commentaire_txb.Name = "commentaire_txb";
            this.commentaire_txb.Size = new System.Drawing.Size(345, 61);
            this.commentaire_txb.TabIndex = 20;
            // 
            // commandeValid
            // 
            this.commandeValid.BackColor = System.Drawing.Color.LightSteelBlue;
            this.commandeValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.commandeValid.Location = new System.Drawing.Point(779, 383);
            this.commandeValid.Name = "commandeValid";
            this.commandeValid.Size = new System.Drawing.Size(141, 26);
            this.commandeValid.TabIndex = 19;
            this.commandeValid.Text = "Valider la commande";
            this.commandeValid.UseVisualStyleBackColor = false;
            this.commandeValid.Click += new System.EventHandler(this.commandeValid_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.tiers_cb);
            this.groupBox2.Controls.Add(this.valider_btn);
            this.groupBox2.Controls.Add(this.quantite_cb);
            this.groupBox2.Controls.Add(this.produit_cb);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 374);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Création d\'une commande";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sélectionner un produit :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tiers_lbl);
            this.groupBox4.Controls.Add(this.tiers_resulat_lbl);
            this.groupBox4.Controls.Add(this.quantite_lbl);
            this.groupBox4.Controls.Add(this.quantite_resultat_lbl);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.montant_resultat_lbl);
            this.groupBox4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 123);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ajout d\'un produit";
            // 
            // tiers_lbl
            // 
            this.tiers_lbl.AutoSize = true;
            this.tiers_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiers_lbl.Location = new System.Drawing.Point(26, 33);
            this.tiers_lbl.Name = "tiers_lbl";
            this.tiers_lbl.Size = new System.Drawing.Size(97, 15);
            this.tiers_lbl.TabIndex = 0;
            this.tiers_lbl.Text = "Nom du tiers :";
            // 
            // tiers_resulat_lbl
            // 
            this.tiers_resulat_lbl.AutoSize = true;
            this.tiers_resulat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiers_resulat_lbl.Location = new System.Drawing.Point(136, 33);
            this.tiers_resulat_lbl.Name = "tiers_resulat_lbl";
            this.tiers_resulat_lbl.Size = new System.Drawing.Size(83, 15);
            this.tiers_resulat_lbl.TabIndex = 7;
            this.tiers_resulat_lbl.Text = "Nom du tiers :";
            // 
            // quantite_lbl
            // 
            this.quantite_lbl.AutoSize = true;
            this.quantite_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantite_lbl.Location = new System.Drawing.Point(52, 62);
            this.quantite_lbl.Name = "quantite_lbl";
            this.quantite_lbl.Size = new System.Drawing.Size(69, 15);
            this.quantite_lbl.TabIndex = 2;
            this.quantite_lbl.Text = "Quantité :";
            // 
            // quantite_resultat_lbl
            // 
            this.quantite_resultat_lbl.AutoSize = true;
            this.quantite_resultat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantite_resultat_lbl.Location = new System.Drawing.Point(136, 62);
            this.quantite_resultat_lbl.Name = "quantite_resultat_lbl";
            this.quantite_resultat_lbl.Size = new System.Drawing.Size(83, 15);
            this.quantite_resultat_lbl.TabIndex = 10;
            this.quantite_resultat_lbl.Text = "Nom du tiers :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Montant :";
            // 
            // montant_resultat_lbl
            // 
            this.montant_resultat_lbl.AutoSize = true;
            this.montant_resultat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montant_resultat_lbl.Location = new System.Drawing.Point(136, 89);
            this.montant_resultat_lbl.Name = "montant_resultat_lbl";
            this.montant_resultat_lbl.Size = new System.Drawing.Size(83, 15);
            this.montant_resultat_lbl.TabIndex = 11;
            this.montant_resultat_lbl.Text = "Nom du tiers :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.qte_dispo_lbl);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.produit_resultat_lbl);
            this.groupBox3.Controls.Add(this.prix_unit_resultat_lbl);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 123);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fiche d\'un produit";
            // 
            // qte_dispo_lbl
            // 
            this.qte_dispo_lbl.AutoSize = true;
            this.qte_dispo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_dispo_lbl.Location = new System.Drawing.Point(133, 92);
            this.qte_dispo_lbl.Name = "qte_dispo_lbl";
            this.qte_dispo_lbl.Size = new System.Drawing.Size(83, 15);
            this.qte_dispo_lbl.TabIndex = 10;
            this.qte_dispo_lbl.Text = "Nom du tiers :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Quantité dispo :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Prix unitaire :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(65, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Produit :";
            // 
            // produit_resultat_lbl
            // 
            this.produit_resultat_lbl.AutoSize = true;
            this.produit_resultat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit_resultat_lbl.Location = new System.Drawing.Point(133, 28);
            this.produit_resultat_lbl.Name = "produit_resultat_lbl";
            this.produit_resultat_lbl.Size = new System.Drawing.Size(83, 15);
            this.produit_resultat_lbl.TabIndex = 8;
            this.produit_resultat_lbl.Text = "Nom du tiers :";
            // 
            // prix_unit_resultat_lbl
            // 
            this.prix_unit_resultat_lbl.AutoSize = true;
            this.prix_unit_resultat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix_unit_resultat_lbl.Location = new System.Drawing.Point(133, 60);
            this.prix_unit_resultat_lbl.Name = "prix_unit_resultat_lbl";
            this.prix_unit_resultat_lbl.Size = new System.Drawing.Size(83, 15);
            this.prix_unit_resultat_lbl.TabIndex = 9;
            this.prix_unit_resultat_lbl.Text = "Nom du tiers :";
            // 
            // tiers_cb
            // 
            this.tiers_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tiers_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiers_cb.FormattingEnabled = true;
            this.tiers_cb.Location = new System.Drawing.Point(18, 185);
            this.tiers_cb.Name = "tiers_cb";
            this.tiers_cb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tiers_cb.Size = new System.Drawing.Size(121, 21);
            this.tiers_cb.TabIndex = 1;
            this.tiers_cb.SelectedIndexChanged += new System.EventHandler(this.tiers_cb_SelectedIndexChanged);
            // 
            // valider_btn
            // 
            this.valider_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.valider_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.valider_btn.Location = new System.Drawing.Point(256, 341);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(141, 26);
            this.valider_btn.TabIndex = 5;
            this.valider_btn.Text = "Ajouter";
            this.valider_btn.UseVisualStyleBackColor = false;
            this.valider_btn.Click += new System.EventHandler(this.valider_btn_Click);
            // 
            // quantite_cb
            // 
            this.quantite_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantite_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.quantite_cb.FormattingEnabled = true;
            this.quantite_cb.Location = new System.Drawing.Point(148, 186);
            this.quantite_cb.Name = "quantite_cb";
            this.quantite_cb.Size = new System.Drawing.Size(121, 21);
            this.quantite_cb.TabIndex = 3;
            this.quantite_cb.SelectedIndexChanged += new System.EventHandler(this.quantite_cb_SelectedIndexChanged);
            // 
            // produit_cb
            // 
            this.produit_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produit_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.produit_cb.FormattingEnabled = true;
            this.produit_cb.Location = new System.Drawing.Point(171, 24);
            this.produit_cb.Name = "produit_cb";
            this.produit_cb.Size = new System.Drawing.Size(121, 21);
            this.produit_cb.TabIndex = 2;
            this.produit_cb.SelectedIndexChanged += new System.EventHandler(this.produit_cb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.imprimer_btn);
            this.groupBox1.Controls.Add(this.montant_total_resultat_lbl);
            this.groupBox1.Controls.Add(this.tva_resultat_lbl);
            this.groupBox1.Controls.Add(this.tva_lbl);
            this.groupBox1.Controls.Add(this.montant_total_);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(432, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proposition";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 213);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantité";
            // 
            // imprimer_btn
            // 
            this.imprimer_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.imprimer_btn.Enabled = false;
            this.imprimer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.imprimer_btn.Location = new System.Drawing.Point(6, 274);
            this.imprimer_btn.Name = "imprimer_btn";
            this.imprimer_btn.Size = new System.Drawing.Size(141, 26);
            this.imprimer_btn.TabIndex = 6;
            this.imprimer_btn.Text = "Imprimer";
            this.imprimer_btn.UseVisualStyleBackColor = false;
            this.imprimer_btn.Click += new System.EventHandler(this.imprimer_btn_Click);
            // 
            // montant_total_resultat_lbl
            // 
            this.montant_total_resultat_lbl.AutoSize = true;
            this.montant_total_resultat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montant_total_resultat_lbl.Location = new System.Drawing.Point(364, 280);
            this.montant_total_resultat_lbl.Name = "montant_total_resultat_lbl";
            this.montant_total_resultat_lbl.Size = new System.Drawing.Size(34, 15);
            this.montant_total_resultat_lbl.TabIndex = 16;
            this.montant_total_resultat_lbl.Text = "TVA :";
            // 
            // tva_resultat_lbl
            // 
            this.tva_resultat_lbl.AutoSize = true;
            this.tva_resultat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tva_resultat_lbl.Location = new System.Drawing.Point(364, 253);
            this.tva_resultat_lbl.Name = "tva_resultat_lbl";
            this.tva_resultat_lbl.Size = new System.Drawing.Size(34, 15);
            this.tva_resultat_lbl.TabIndex = 15;
            this.tva_resultat_lbl.Text = "TVA :";
            // 
            // tva_lbl
            // 
            this.tva_lbl.AutoSize = true;
            this.tva_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tva_lbl.Location = new System.Drawing.Point(319, 253);
            this.tva_lbl.Name = "tva_lbl";
            this.tva_lbl.Size = new System.Drawing.Size(39, 15);
            this.tva_lbl.TabIndex = 14;
            this.tva_lbl.Text = "TVA :";
            // 
            // montant_total_
            // 
            this.montant_total_.AutoSize = true;
            this.montant_total_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montant_total_.Location = new System.Drawing.Point(251, 280);
            this.montant_total_.Name = "montant_total_";
            this.montant_total_.Size = new System.Drawing.Size(107, 15);
            this.montant_total_.TabIndex = 13;
            this.montant_total_.Text = "Montant  Total :";
            // 
            // formulaire_proposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 456);
            this.Controls.Add(this.panelCommande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formulaire_proposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formulaire_proposition";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelCommande.ResumeLayout(false);
            this.panelCommande.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tiers_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label quantite_lbl;
        private System.Windows.Forms.ComboBox tiers_cb;
        private System.Windows.Forms.ComboBox produit_cb;
        private System.Windows.Forms.Button valider_btn;
        private System.Windows.Forms.Label montant_total_resultat_lbl;
        private System.Windows.Forms.Label tva_resultat_lbl;
        private System.Windows.Forms.Label tva_lbl;
        private System.Windows.Forms.Label montant_total_;
        private System.Windows.Forms.Label montant_resultat_lbl;
        private System.Windows.Forms.Label quantite_resultat_lbl;
        private System.Windows.Forms.Label prix_unit_resultat_lbl;
        private System.Windows.Forms.Label produit_resultat_lbl;
        private System.Windows.Forms.Label tiers_resulat_lbl;
        private System.Windows.Forms.Button imprimer_btn;
        private System.Windows.Forms.ComboBox quantite_cb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelCommande;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label qte_dispo_lbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button commandeValid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox commentaire_txb;
    }
}