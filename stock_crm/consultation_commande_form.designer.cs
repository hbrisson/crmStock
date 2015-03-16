namespace stock_crm
{
    partial class consultation_commande_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelCommande = new System.Windows.Forms.Panel();
            this.cmdValid_bt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.modifier_btn = new System.Windows.Forms.Button();
            this.Ajout_prod_bt = new System.Windows.Forms.Button();
            this.supprimer_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.quantite_cb = new System.Windows.Forms.ComboBox();
            this.produit_cb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.prix_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.montant_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.etat_cmd_cb = new System.Windows.Forms.ComboBox();
            this.montant_lbl = new System.Windows.Forms.Label();
            this.nbprod_lbl = new System.Windows.Forms.Label();
            this.type_lbl = new System.Windows.Forms.Label();
            this.tiers_lbl = new System.Windows.Forms.Label();
            this.client_ck = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reinitialiser_btn = new System.Windows.Forms.Button();
            this.type_cb = new System.Windows.Forms.ComboBox();
            this.dataCommande = new System.Windows.Forms.DataGridView();
            this.tiers_cb = new System.Windows.Forms.ComboBox();
            this.etat_cb = new System.Windows.Forms.ComboBox();
            this.panelCommande.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCommande
            // 
            this.panelCommande.Controls.Add(this.cmdValid_bt);
            this.panelCommande.Controls.Add(this.label9);
            this.panelCommande.Controls.Add(this.modifier_btn);
            this.panelCommande.Controls.Add(this.Ajout_prod_bt);
            this.panelCommande.Controls.Add(this.supprimer_btn);
            this.panelCommande.Controls.Add(this.groupBox4);
            this.panelCommande.Controls.Add(this.groupBox3);
            this.panelCommande.Controls.Add(this.groupBox2);
            this.panelCommande.Controls.Add(this.groupBox1);
            this.panelCommande.Location = new System.Drawing.Point(4, 12);
            this.panelCommande.Name = "panelCommande";
            this.panelCommande.Size = new System.Drawing.Size(901, 422);
            this.panelCommande.TabIndex = 14;
            // 
            // cmdValid_bt
            // 
            this.cmdValid_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdValid_bt.Enabled = false;
            this.cmdValid_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmdValid_bt.Location = new System.Drawing.Point(686, 389);
            this.cmdValid_bt.Name = "cmdValid_bt";
            this.cmdValid_bt.Size = new System.Drawing.Size(144, 23);
            this.cmdValid_bt.TabIndex = 21;
            this.cmdValid_bt.Text = "Validation de la commande";
            this.cmdValid_bt.UseVisualStyleBackColor = false;
            this.cmdValid_bt.Click += new System.EventHandler(this.cmdValid_bt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(622, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Selectionner un produit appartenant a la liste ci-dessous";
            // 
            // modifier_btn
            // 
            this.modifier_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.modifier_btn.Enabled = false;
            this.modifier_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.modifier_btn.Location = new System.Drawing.Point(471, 350);
            this.modifier_btn.Name = "modifier_btn";
            this.modifier_btn.Size = new System.Drawing.Size(127, 23);
            this.modifier_btn.TabIndex = 18;
            this.modifier_btn.Text = "Modifier un produit";
            this.modifier_btn.UseVisualStyleBackColor = false;
            this.modifier_btn.Click += new System.EventHandler(this.modifier_btn_Click);
            // 
            // Ajout_prod_bt
            // 
            this.Ajout_prod_bt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Ajout_prod_bt.Enabled = false;
            this.Ajout_prod_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Ajout_prod_bt.Location = new System.Drawing.Point(471, 321);
            this.Ajout_prod_bt.Name = "Ajout_prod_bt";
            this.Ajout_prod_bt.Size = new System.Drawing.Size(127, 23);
            this.Ajout_prod_bt.TabIndex = 17;
            this.Ajout_prod_bt.Text = "Ajouter un produit";
            this.Ajout_prod_bt.UseVisualStyleBackColor = false;
            this.Ajout_prod_bt.Click += new System.EventHandler(this.Ajout_prod_bt_Click);
            // 
            // supprimer_btn
            // 
            this.supprimer_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.supprimer_btn.Enabled = false;
            this.supprimer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.supprimer_btn.Location = new System.Drawing.Point(471, 379);
            this.supprimer_btn.Name = "supprimer_btn";
            this.supprimer_btn.Size = new System.Drawing.Size(127, 23);
            this.supprimer_btn.TabIndex = 16;
            this.supprimer_btn.Text = "Supprimer ce produit";
            this.supprimer_btn.UseVisualStyleBackColor = false;
            this.supprimer_btn.Click += new System.EventHandler(this.supprimer_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.quantite_cb);
            this.groupBox4.Controls.Add(this.produit_cb);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.prix_txb);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.montant_txb);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(17, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 94);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modification d\'un produit";
            // 
            // quantite_cb
            // 
            this.quantite_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantite_cb.Enabled = false;
            this.quantite_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.quantite_cb.FormattingEnabled = true;
            this.quantite_cb.Location = new System.Drawing.Point(297, 28);
            this.quantite_cb.Name = "quantite_cb";
            this.quantite_cb.Size = new System.Drawing.Size(121, 21);
            this.quantite_cb.TabIndex = 10;
            this.quantite_cb.SelectedIndexChanged += new System.EventHandler(this.quantite_cb_SelectedIndexChanged);
            // 
            // produit_cb
            // 
            this.produit_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produit_cb.Enabled = false;
            this.produit_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.produit_cb.FormattingEnabled = true;
            this.produit_cb.Location = new System.Drawing.Point(63, 28);
            this.produit_cb.Name = "produit_cb";
            this.produit_cb.Size = new System.Drawing.Size(121, 21);
            this.produit_cb.TabIndex = 9;
            this.produit_cb.SelectedIndexChanged += new System.EventHandler(this.produit_cb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Prix :";
            // 
            // prix_txb
            // 
            this.prix_txb.Enabled = false;
            this.prix_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.prix_txb.Location = new System.Drawing.Point(63, 61);
            this.prix_txb.Name = "prix_txb";
            this.prix_txb.Size = new System.Drawing.Size(121, 20);
            this.prix_txb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Montant : ";
            // 
            // montant_txb
            // 
            this.montant_txb.Enabled = false;
            this.montant_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.montant_txb.Location = new System.Drawing.Point(297, 61);
            this.montant_txb.Name = "montant_txb";
            this.montant_txb.Size = new System.Drawing.Size(121, 20);
            this.montant_txb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantité :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(625, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 158);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produits de la commande";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Enabled = false;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listView1.Location = new System.Drawing.Point(3, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(261, 130);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.etat_cmd_cb);
            this.groupBox2.Controls.Add(this.montant_lbl);
            this.groupBox2.Controls.Add(this.nbprod_lbl);
            this.groupBox2.Controls.Add(this.type_lbl);
            this.groupBox2.Controls.Add(this.tiers_lbl);
            this.groupBox2.Controls.Add(this.client_ck);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(628, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 178);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiche commande";
            // 
            // etat_cmd_cb
            // 
            this.etat_cmd_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.etat_cmd_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etat_cmd_cb.FormattingEnabled = true;
            this.etat_cmd_cb.Location = new System.Drawing.Point(10, 147);
            this.etat_cmd_cb.Name = "etat_cmd_cb";
            this.etat_cmd_cb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.etat_cmd_cb.Size = new System.Drawing.Size(160, 21);
            this.etat_cmd_cb.TabIndex = 16;
            // 
            // montant_lbl
            // 
            this.montant_lbl.AutoSize = true;
            this.montant_lbl.Location = new System.Drawing.Point(114, 94);
            this.montant_lbl.Name = "montant_lbl";
            this.montant_lbl.Size = new System.Drawing.Size(56, 22);
            this.montant_lbl.TabIndex = 15;
            this.montant_lbl.Text = "Tiers :";
            this.montant_lbl.Visible = false;
            // 
            // nbprod_lbl
            // 
            this.nbprod_lbl.AutoSize = true;
            this.nbprod_lbl.Location = new System.Drawing.Point(114, 72);
            this.nbprod_lbl.Name = "nbprod_lbl";
            this.nbprod_lbl.Size = new System.Drawing.Size(56, 22);
            this.nbprod_lbl.TabIndex = 14;
            this.nbprod_lbl.Text = "Tiers :";
            this.nbprod_lbl.Visible = false;
            // 
            // type_lbl
            // 
            this.type_lbl.AutoSize = true;
            this.type_lbl.Location = new System.Drawing.Point(114, 50);
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.Size = new System.Drawing.Size(56, 22);
            this.type_lbl.TabIndex = 13;
            this.type_lbl.Text = "Tiers :";
            this.type_lbl.Visible = false;
            // 
            // tiers_lbl
            // 
            this.tiers_lbl.AutoSize = true;
            this.tiers_lbl.Location = new System.Drawing.Point(114, 28);
            this.tiers_lbl.Name = "tiers_lbl";
            this.tiers_lbl.Size = new System.Drawing.Size(56, 22);
            this.tiers_lbl.TabIndex = 12;
            this.tiers_lbl.Text = "Tiers :";
            this.tiers_lbl.Visible = false;
            // 
            // client_ck
            // 
            this.client_ck.AutoSize = true;
            this.client_ck.Location = new System.Drawing.Point(10, 115);
            this.client_ck.Name = "client_ck";
            this.client_ck.Size = new System.Drawing.Size(174, 26);
            this.client_ck.TabIndex = 11;
            this.client_ck.Text = "Valider par le client";
            this.client_ck.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Montant :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nb produit :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiers :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reinitialiser_btn);
            this.groupBox1.Controls.Add(this.type_cb);
            this.groupBox1.Controls.Add(this.dataCommande);
            this.groupBox1.Controls.Add(this.tiers_cb);
            this.groupBox1.Controls.Add(this.etat_cb);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultation des commandes";
            // 
            // reinitialiser_btn
            // 
            this.reinitialiser_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.reinitialiser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.reinitialiser_btn.Location = new System.Drawing.Point(423, 26);
            this.reinitialiser_btn.Name = "reinitialiser_btn";
            this.reinitialiser_btn.Size = new System.Drawing.Size(100, 23);
            this.reinitialiser_btn.TabIndex = 15;
            this.reinitialiser_btn.Text = "Réinitialiser";
            this.reinitialiser_btn.UseVisualStyleBackColor = false;
            this.reinitialiser_btn.Click += new System.EventHandler(this.reinitialiser_btn_Click);
            // 
            // type_cb
            // 
            this.type_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.type_cb.FormattingEnabled = true;
            this.type_cb.Location = new System.Drawing.Point(133, 28);
            this.type_cb.Name = "type_cb";
            this.type_cb.Size = new System.Drawing.Size(121, 21);
            this.type_cb.TabIndex = 14;
            this.type_cb.Text = "Type";
            this.type_cb.SelectedIndexChanged += new System.EventHandler(this.type_cb_SelectedIndexChanged);
            // 
            // dataCommande
            // 
            this.dataCommande.AllowUserToAddRows = false;
            this.dataCommande.AllowUserToDeleteRows = false;
            this.dataCommande.BackgroundColor = System.Drawing.Color.White;
            this.dataCommande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCommande.Location = new System.Drawing.Point(6, 55);
            this.dataCommande.Name = "dataCommande";
            this.dataCommande.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCommande.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataCommande.Size = new System.Drawing.Size(569, 225);
            this.dataCommande.TabIndex = 13;
            this.dataCommande.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataCommande_CellMouseClick);
            // 
            // tiers_cb
            // 
            this.tiers_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiers_cb.FormattingEnabled = true;
            this.tiers_cb.Location = new System.Drawing.Point(6, 28);
            this.tiers_cb.Name = "tiers_cb";
            this.tiers_cb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tiers_cb.Size = new System.Drawing.Size(121, 21);
            this.tiers_cb.TabIndex = 9;
            this.tiers_cb.Text = "Tiers";
            this.tiers_cb.SelectedIndexChanged += new System.EventHandler(this.tiers_cb_SelectedIndexChanged);
            // 
            // etat_cb
            // 
            this.etat_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.etat_cb.FormattingEnabled = true;
            this.etat_cb.Location = new System.Drawing.Point(260, 28);
            this.etat_cb.Name = "etat_cb";
            this.etat_cb.Size = new System.Drawing.Size(121, 21);
            this.etat_cb.TabIndex = 11;
            this.etat_cb.Text = "Etat";
            this.etat_cb.SelectedIndexChanged += new System.EventHandler(this.etat_cb_SelectedIndexChanged);
            // 
            // consultation_commande_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 514);
            this.ControlBox = false;
            this.Controls.Add(this.panelCommande);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consultation_commande_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultation_commande_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelCommande.ResumeLayout(false);
            this.panelCommande.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox etat_cb;
        private System.Windows.Forms.ComboBox tiers_cb;
        private System.Windows.Forms.DataGridView dataCommande;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelCommande;
        private System.Windows.Forms.ComboBox type_cb;
        private System.Windows.Forms.Button reinitialiser_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button modifier_btn;
        private System.Windows.Forms.Button Ajout_prod_bt;
        private System.Windows.Forms.Button supprimer_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox montant_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox prix_txb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox client_ck;
        private System.Windows.Forms.Button cmdValid_bt;
        private System.Windows.Forms.Label montant_lbl;
        private System.Windows.Forms.Label nbprod_lbl;
        private System.Windows.Forms.Label type_lbl;
        private System.Windows.Forms.Label tiers_lbl;
        private System.Windows.Forms.ComboBox etat_cmd_cb;
        private System.Windows.Forms.ComboBox produit_cb;
        private System.Windows.Forms.ComboBox quantite_cb;
    }
}