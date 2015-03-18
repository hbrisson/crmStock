namespace stock_crm
{
    partial class action
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
            this.label1 = new System.Windows.Forms.Label();
            this.combo_contact = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboActions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_date = new System.Windows.Forms.DateTimePicker();
            this.panel_ajout = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.commentaire_box = new System.Windows.Forms.TextBox();
            this.combo_minute = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_heure = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_tiers = new System.Windows.Forms.ComboBox();
            this.ajout_action = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_a_venir = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_historique = new System.Windows.Forms.DataGridView();
            this.panel_ajout.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_a_venir)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_historique)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectionner un contact:";
            // 
            // combo_contact
            // 
            this.combo_contact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_contact.FormattingEnabled = true;
            this.combo_contact.Location = new System.Drawing.Point(166, 79);
            this.combo_contact.Name = "combo_contact";
            this.combo_contact.Size = new System.Drawing.Size(121, 21);
            this.combo_contact.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Actions à réaliser:";
            // 
            // comboActions
            // 
            this.comboActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboActions.FormattingEnabled = true;
            this.comboActions.Location = new System.Drawing.Point(166, 131);
            this.comboActions.Name = "comboActions";
            this.comboActions.Size = new System.Drawing.Size(121, 21);
            this.comboActions.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date:";
            // 
            // combo_date
            // 
            this.combo_date.Location = new System.Drawing.Point(166, 184);
            this.combo_date.Name = "combo_date";
            this.combo_date.Size = new System.Drawing.Size(200, 20);
            this.combo_date.TabIndex = 5;
            // 
            // panel_ajout
            // 
            this.panel_ajout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_ajout.Controls.Add(this.label7);
            this.panel_ajout.Controls.Add(this.commentaire_box);
            this.panel_ajout.Controls.Add(this.combo_minute);
            this.panel_ajout.Controls.Add(this.label6);
            this.panel_ajout.Controls.Add(this.combo_heure);
            this.panel_ajout.Controls.Add(this.label5);
            this.panel_ajout.Controls.Add(this.label4);
            this.panel_ajout.Controls.Add(this.combo_tiers);
            this.panel_ajout.Controls.Add(this.ajout_action);
            this.panel_ajout.Controls.Add(this.label1);
            this.panel_ajout.Controls.Add(this.label2);
            this.panel_ajout.Controls.Add(this.combo_date);
            this.panel_ajout.Controls.Add(this.comboActions);
            this.panel_ajout.Controls.Add(this.combo_contact);
            this.panel_ajout.Controls.Add(this.label3);
            this.panel_ajout.Location = new System.Drawing.Point(12, 12);
            this.panel_ajout.Name = "panel_ajout";
            this.panel_ajout.Size = new System.Drawing.Size(388, 401);
            this.panel_ajout.TabIndex = 7;
            this.panel_ajout.TabStop = false;
            this.panel_ajout.Text = "Planifier une action";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Commentaire:";
            // 
            // commentaire_box
            // 
            this.commentaire_box.Location = new System.Drawing.Point(166, 278);
            this.commentaire_box.Multiline = true;
            this.commentaire_box.Name = "commentaire_box";
            this.commentaire_box.Size = new System.Drawing.Size(200, 83);
            this.commentaire_box.TabIndex = 13;
            // 
            // combo_minute
            // 
            this.combo_minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_minute.FormattingEnabled = true;
            this.combo_minute.Location = new System.Drawing.Point(293, 233);
            this.combo_minute.Name = "combo_minute";
            this.combo_minute.Size = new System.Drawing.Size(46, 21);
            this.combo_minute.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Minutes:";
            // 
            // combo_heure
            // 
            this.combo_heure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_heure.FormattingEnabled = true;
            this.combo_heure.Location = new System.Drawing.Point(166, 233);
            this.combo_heure.Name = "combo_heure";
            this.combo_heure.Size = new System.Drawing.Size(51, 21);
            this.combo_heure.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Heure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selectionner un tiers:";
            // 
            // combo_tiers
            // 
            this.combo_tiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tiers.FormattingEnabled = true;
            this.combo_tiers.Location = new System.Drawing.Point(166, 36);
            this.combo_tiers.Name = "combo_tiers";
            this.combo_tiers.Size = new System.Drawing.Size(121, 21);
            this.combo_tiers.TabIndex = 7;
            this.combo_tiers.SelectedIndexChanged += new System.EventHandler(this.combo_tiers_SelectedIndexChanged);
            // 
            // ajout_action
            // 
            this.ajout_action.Location = new System.Drawing.Point(166, 367);
            this.ajout_action.Name = "ajout_action";
            this.ajout_action.Size = new System.Drawing.Size(75, 23);
            this.ajout_action.TabIndex = 6;
            this.ajout_action.Text = "Créer";
            this.ajout_action.UseVisualStyleBackColor = true;
            this.ajout_action.Click += new System.EventHandler(this.ajout_action_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_a_venir);
            this.groupBox1.Location = new System.Drawing.Point(423, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 185);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evenements à venir";
            // 
            // dataGridView_a_venir
            // 
            this.dataGridView_a_venir.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_a_venir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_a_venir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_a_venir.Location = new System.Drawing.Point(30, 20);
            this.dataGridView_a_venir.Name = "dataGridView_a_venir";
            this.dataGridView_a_venir.Size = new System.Drawing.Size(549, 149);
            this.dataGridView_a_venir.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_historique);
            this.groupBox2.Location = new System.Drawing.Point(423, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 191);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historique des événements";
            // 
            // dataGridView_historique
            // 
            this.dataGridView_historique.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_historique.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_historique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_historique.Location = new System.Drawing.Point(30, 28);
            this.dataGridView_historique.Name = "dataGridView_historique";
            this.dataGridView_historique.Size = new System.Drawing.Size(549, 150);
            this.dataGridView_historique.TabIndex = 0;
            // 
            // action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1231, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_ajout);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "action";
            this.Text = "action";
            this.panel_ajout.ResumeLayout(false);
            this.panel_ajout.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_a_venir)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_historique)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_contact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboActions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker combo_date;
        private System.Windows.Forms.GroupBox panel_ajout;
        private System.Windows.Forms.Button ajout_action;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_tiers;
        private System.Windows.Forms.ComboBox combo_minute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_heure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox commentaire_box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_a_venir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_historique;
    }
}