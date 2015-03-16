namespace stock_crm
{
    partial class modiier_contact
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idcontact = new System.Windows.Forms.Label();
            this.sup_contact = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_nom_tiers_modifier = new System.Windows.Forms.ComboBox();
            this.modifier_contact = new System.Windows.Forms.Button();
            this.mail_label_contact = new System.Windows.Forms.Label();
            this.mail_contact_modifier = new System.Windows.Forms.TextBox();
            this.date_anniv_contact_modifier = new System.Windows.Forms.DateTimePicker();
            this.fonction_label_contact = new System.Windows.Forms.Label();
            this.commentaire_label_contact = new System.Windows.Forms.Label();
            this.portable_contact_modifier = new System.Windows.Forms.TextBox();
            this.prenom_contact_modifier = new System.Windows.Forms.TextBox();
            this.nom_contact_modifier = new System.Windows.Forms.TextBox();
            this.commentaire_contact_modifier = new System.Windows.Forms.TextBox();
            this.telephone_contact_modifier = new System.Windows.Forms.TextBox();
            this.date_anniversaire_label_contact = new System.Windows.Forms.Label();
            this.portable_label_contact = new System.Windows.Forms.Label();
            this.telephone_label_contact = new System.Windows.Forms.Label();
            this.prenom_label_contact = new System.Windows.Forms.Label();
            this.fonction_contact_modifier = new System.Windows.Forms.TextBox();
            this.nom_label_contact = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.select_tiers_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.idcontact);
            this.panel1.Controls.Add(this.sup_contact);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 469);
            this.panel1.TabIndex = 0;
            // 
            // idcontact
            // 
            this.idcontact.AutoSize = true;
            this.idcontact.Location = new System.Drawing.Point(8, 297);
            this.idcontact.Name = "idcontact";
            this.idcontact.Size = new System.Drawing.Size(83, 20);
            this.idcontact.TabIndex = 57;
            this.idcontact.Text = "idcontact";
            this.idcontact.Visible = false;
            // 
            // sup_contact
            // 
            this.sup_contact.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sup_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.sup_contact.Location = new System.Drawing.Point(484, 434);
            this.sup_contact.Name = "sup_contact";
            this.sup_contact.Size = new System.Drawing.Size(97, 23);
            this.sup_contact.TabIndex = 53;
            this.sup_contact.Text = "Supprimer";
            this.sup_contact.UseVisualStyleBackColor = false;
            this.sup_contact.Click += new System.EventHandler(this.sup_contact_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.combo_nom_tiers_modifier);
            this.groupBox2.Controls.Add(this.modifier_contact);
            this.groupBox2.Controls.Add(this.mail_label_contact);
            this.groupBox2.Controls.Add(this.mail_contact_modifier);
            this.groupBox2.Controls.Add(this.date_anniv_contact_modifier);
            this.groupBox2.Controls.Add(this.fonction_label_contact);
            this.groupBox2.Controls.Add(this.commentaire_label_contact);
            this.groupBox2.Controls.Add(this.portable_contact_modifier);
            this.groupBox2.Controls.Add(this.prenom_contact_modifier);
            this.groupBox2.Controls.Add(this.nom_contact_modifier);
            this.groupBox2.Controls.Add(this.commentaire_contact_modifier);
            this.groupBox2.Controls.Add(this.telephone_contact_modifier);
            this.groupBox2.Controls.Add(this.date_anniversaire_label_contact);
            this.groupBox2.Controls.Add(this.portable_label_contact);
            this.groupBox2.Controls.Add(this.telephone_label_contact);
            this.groupBox2.Controls.Add(this.prenom_label_contact);
            this.groupBox2.Controls.Add(this.fonction_contact_modifier);
            this.groupBox2.Controls.Add(this.nom_label_contact);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(137, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 160);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations du contact séléctionné";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Tiers :*";
            // 
            // combo_nom_tiers_modifier
            // 
            this.combo_nom_tiers_modifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_nom_tiers_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.combo_nom_tiers_modifier.FormattingEnabled = true;
            this.combo_nom_tiers_modifier.Location = new System.Drawing.Point(97, 132);
            this.combo_nom_tiers_modifier.Name = "combo_nom_tiers_modifier";
            this.combo_nom_tiers_modifier.Size = new System.Drawing.Size(100, 21);
            this.combo_nom_tiers_modifier.TabIndex = 55;
            // 
            // modifier_contact
            // 
            this.modifier_contact.BackColor = System.Drawing.Color.LightSteelBlue;
            this.modifier_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.modifier_contact.Location = new System.Drawing.Point(344, 130);
            this.modifier_contact.Name = "modifier_contact";
            this.modifier_contact.Size = new System.Drawing.Size(100, 23);
            this.modifier_contact.TabIndex = 52;
            this.modifier_contact.Text = "Modifier";
            this.modifier_contact.UseVisualStyleBackColor = false;
            this.modifier_contact.Click += new System.EventHandler(this.modifier_contact_Click);
            // 
            // mail_label_contact
            // 
            this.mail_label_contact.AutoSize = true;
            this.mail_label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_label_contact.Location = new System.Drawing.Point(281, 29);
            this.mail_label_contact.Name = "mail_label_contact";
            this.mail_label_contact.Size = new System.Drawing.Size(57, 16);
            this.mail_label_contact.TabIndex = 54;
            this.mail_label_contact.Text = "E-mail :*";
            // 
            // mail_contact_modifier
            // 
            this.mail_contact_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.mail_contact_modifier.Location = new System.Drawing.Point(344, 28);
            this.mail_contact_modifier.Name = "mail_contact_modifier";
            this.mail_contact_modifier.Size = new System.Drawing.Size(100, 20);
            this.mail_contact_modifier.TabIndex = 53;
            // 
            // date_anniv_contact_modifier
            // 
            this.date_anniv_contact_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.date_anniv_contact_modifier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_anniv_contact_modifier.Location = new System.Drawing.Point(344, 52);
            this.date_anniv_contact_modifier.Name = "date_anniv_contact_modifier";
            this.date_anniv_contact_modifier.Size = new System.Drawing.Size(100, 20);
            this.date_anniv_contact_modifier.TabIndex = 51;
            // 
            // fonction_label_contact
            // 
            this.fonction_label_contact.AutoSize = true;
            this.fonction_label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fonction_label_contact.Location = new System.Drawing.Point(268, 79);
            this.fonction_label_contact.Name = "fonction_label_contact";
            this.fonction_label_contact.Size = new System.Drawing.Size(70, 16);
            this.fonction_label_contact.TabIndex = 50;
            this.fonction_label_contact.Text = "Fonction :*";
            // 
            // commentaire_label_contact
            // 
            this.commentaire_label_contact.AutoSize = true;
            this.commentaire_label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentaire_label_contact.Location = new System.Drawing.Point(244, 105);
            this.commentaire_label_contact.Name = "commentaire_label_contact";
            this.commentaire_label_contact.Size = new System.Drawing.Size(94, 16);
            this.commentaire_label_contact.TabIndex = 49;
            this.commentaire_label_contact.Text = "Commentaire :";
            // 
            // portable_contact_modifier
            // 
            this.portable_contact_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.portable_contact_modifier.Location = new System.Drawing.Point(97, 106);
            this.portable_contact_modifier.Name = "portable_contact_modifier";
            this.portable_contact_modifier.Size = new System.Drawing.Size(100, 20);
            this.portable_contact_modifier.TabIndex = 46;
            // 
            // prenom_contact_modifier
            // 
            this.prenom_contact_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.prenom_contact_modifier.Location = new System.Drawing.Point(97, 54);
            this.prenom_contact_modifier.Name = "prenom_contact_modifier";
            this.prenom_contact_modifier.Size = new System.Drawing.Size(100, 20);
            this.prenom_contact_modifier.TabIndex = 48;
            // 
            // nom_contact_modifier
            // 
            this.nom_contact_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nom_contact_modifier.Location = new System.Drawing.Point(97, 28);
            this.nom_contact_modifier.Name = "nom_contact_modifier";
            this.nom_contact_modifier.Size = new System.Drawing.Size(100, 20);
            this.nom_contact_modifier.TabIndex = 47;
            // 
            // commentaire_contact_modifier
            // 
            this.commentaire_contact_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.commentaire_contact_modifier.Location = new System.Drawing.Point(344, 104);
            this.commentaire_contact_modifier.Name = "commentaire_contact_modifier";
            this.commentaire_contact_modifier.Size = new System.Drawing.Size(100, 20);
            this.commentaire_contact_modifier.TabIndex = 45;
            // 
            // telephone_contact_modifier
            // 
            this.telephone_contact_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.telephone_contact_modifier.Location = new System.Drawing.Point(97, 80);
            this.telephone_contact_modifier.Name = "telephone_contact_modifier";
            this.telephone_contact_modifier.Size = new System.Drawing.Size(100, 20);
            this.telephone_contact_modifier.TabIndex = 44;
            // 
            // date_anniversaire_label_contact
            // 
            this.date_anniversaire_label_contact.AutoSize = true;
            this.date_anniversaire_label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_anniversaire_label_contact.Location = new System.Drawing.Point(202, 55);
            this.date_anniversaire_label_contact.Name = "date_anniversaire_label_contact";
            this.date_anniversaire_label_contact.Size = new System.Drawing.Size(136, 16);
            this.date_anniversaire_label_contact.TabIndex = 43;
            this.date_anniversaire_label_contact.Text = "Date d\'anniversaire :*";
            // 
            // portable_label_contact
            // 
            this.portable_label_contact.AutoSize = true;
            this.portable_label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portable_label_contact.Location = new System.Drawing.Point(22, 107);
            this.portable_label_contact.Name = "portable_label_contact";
            this.portable_label_contact.Size = new System.Drawing.Size(65, 16);
            this.portable_label_contact.TabIndex = 42;
            this.portable_label_contact.Text = "Portable :";
            // 
            // telephone_label_contact
            // 
            this.telephone_label_contact.AutoSize = true;
            this.telephone_label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone_label_contact.Location = new System.Drawing.Point(6, 81);
            this.telephone_label_contact.Name = "telephone_label_contact";
            this.telephone_label_contact.Size = new System.Drawing.Size(85, 16);
            this.telephone_label_contact.TabIndex = 41;
            this.telephone_label_contact.Text = "Téléphone :*";
            // 
            // prenom_label_contact
            // 
            this.prenom_label_contact.AutoSize = true;
            this.prenom_label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_label_contact.Location = new System.Drawing.Point(25, 55);
            this.prenom_label_contact.Name = "prenom_label_contact";
            this.prenom_label_contact.Size = new System.Drawing.Size(66, 16);
            this.prenom_label_contact.TabIndex = 40;
            this.prenom_label_contact.Text = "Prenom :*";
            // 
            // fonction_contact_modifier
            // 
            this.fonction_contact_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.fonction_contact_modifier.Location = new System.Drawing.Point(344, 78);
            this.fonction_contact_modifier.Name = "fonction_contact_modifier";
            this.fonction_contact_modifier.Size = new System.Drawing.Size(100, 20);
            this.fonction_contact_modifier.TabIndex = 39;
            // 
            // nom_label_contact
            // 
            this.nom_label_contact.AutoSize = true;
            this.nom_label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_label_contact.Location = new System.Drawing.Point(43, 28);
            this.nom_label_contact.Name = "nom_label_contact";
            this.nom_label_contact.Size = new System.Drawing.Size(48, 16);
            this.nom_label_contact.TabIndex = 38;
            this.nom_label_contact.Text = "Nom :*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.select_tiers_label);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection du contact à modifier";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(698, 198);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // select_tiers_label
            // 
            this.select_tiers_label.AutoSize = true;
            this.select_tiers_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_tiers_label.Location = new System.Drawing.Point(6, 25);
            this.select_tiers_label.Name = "select_tiers_label";
            this.select_tiers_label.Size = new System.Drawing.Size(211, 16);
            this.select_tiers_label.TabIndex = 0;
            this.select_tiers_label.Text = "Selectionner le contact à modifier :";
            // 
            // modiier_contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 486);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modiier_contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modiier_contact";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label select_tiers_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_nom_tiers_modifier;
        private System.Windows.Forms.Label mail_label_contact;
        private System.Windows.Forms.TextBox mail_contact_modifier;
        private System.Windows.Forms.Button modifier_contact;
        private System.Windows.Forms.DateTimePicker date_anniv_contact_modifier;
        private System.Windows.Forms.Label fonction_label_contact;
        private System.Windows.Forms.Label commentaire_label_contact;
        private System.Windows.Forms.TextBox portable_contact_modifier;
        private System.Windows.Forms.TextBox prenom_contact_modifier;
        private System.Windows.Forms.TextBox nom_contact_modifier;
        private System.Windows.Forms.TextBox commentaire_contact_modifier;
        private System.Windows.Forms.TextBox telephone_contact_modifier;
        private System.Windows.Forms.Label date_anniversaire_label_contact;
        private System.Windows.Forms.Label portable_label_contact;
        private System.Windows.Forms.Label telephone_label_contact;
        private System.Windows.Forms.Label prenom_label_contact;
        private System.Windows.Forms.TextBox fonction_contact_modifier;
        private System.Windows.Forms.Label nom_label_contact;
        private System.Windows.Forms.Button sup_contact;
        private System.Windows.Forms.Label idcontact;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}