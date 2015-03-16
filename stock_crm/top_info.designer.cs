namespace stock_crm
{
    partial class top_info
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radiobutton = new System.Windows.Forms.Panel();
            this.cmd_en_cours = new System.Windows.Forms.RadioButton();
            this.top_produits = new System.Windows.Forms.RadioButton();
            this.nb_cmd = new System.Windows.Forms.RadioButton();
            this.top_customer = new System.Windows.Forms.RadioButton();
            this.Users_info = new System.Windows.Forms.RadioButton();
            this.menu = new System.Windows.Forms.Label();
            this.infos_accueil = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.radiobutton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.radiobutton);
            this.splitContainer1.Panel1.Controls.Add(this.menu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.infos_accueil);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1060, 388);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.TabIndex = 1;
            // 
            // radiobutton
            // 
            this.radiobutton.Controls.Add(this.cmd_en_cours);
            this.radiobutton.Controls.Add(this.top_produits);
            this.radiobutton.Controls.Add(this.nb_cmd);
            this.radiobutton.Controls.Add(this.top_customer);
            this.radiobutton.Controls.Add(this.Users_info);
            this.radiobutton.Location = new System.Drawing.Point(3, 37);
            this.radiobutton.Name = "radiobutton";
            this.radiobutton.Size = new System.Drawing.Size(221, 143);
            this.radiobutton.TabIndex = 6;
            // 
            // cmd_en_cours
            // 
            this.cmd_en_cours.AutoSize = true;
            this.cmd_en_cours.Location = new System.Drawing.Point(3, 40);
            this.cmd_en_cours.Name = "cmd_en_cours";
            this.cmd_en_cours.Size = new System.Drawing.Size(125, 17);
            this.cmd_en_cours.TabIndex = 2;
            this.cmd_en_cours.Text = "Commande en cours ";
            this.cmd_en_cours.UseVisualStyleBackColor = true;
            this.cmd_en_cours.Click += new System.EventHandler(this.cmd_en_cours_Click);
            // 
            // top_produits
            // 
            this.top_produits.AutoSize = true;
            this.top_produits.Location = new System.Drawing.Point(3, 109);
            this.top_produits.Name = "top_produits";
            this.top_produits.Size = new System.Drawing.Size(84, 17);
            this.top_produits.TabIndex = 5;
            this.top_produits.TabStop = true;
            this.top_produits.Text = "Top produits";
            this.top_produits.UseVisualStyleBackColor = true;
            this.top_produits.Click += new System.EventHandler(this.top_produits_Click);
            // 
            // nb_cmd
            // 
            this.nb_cmd.AutoSize = true;
            this.nb_cmd.Location = new System.Drawing.Point(3, 63);
            this.nb_cmd.Name = "nb_cmd";
            this.nb_cmd.Size = new System.Drawing.Size(216, 17);
            this.nb_cmd.TabIndex = 1;
            this.nb_cmd.Text = "Nombres de commandes du dernier mois";
            this.nb_cmd.UseVisualStyleBackColor = true;
            this.nb_cmd.Click += new System.EventHandler(this.nb_cmd_Click);
            // 
            // top_customer
            // 
            this.top_customer.AutoSize = true;
            this.top_customer.Location = new System.Drawing.Point(3, 86);
            this.top_customer.Name = "top_customer";
            this.top_customer.Size = new System.Drawing.Size(77, 17);
            this.top_customer.TabIndex = 4;
            this.top_customer.TabStop = true;
            this.top_customer.Text = "Top clients";
            this.top_customer.UseVisualStyleBackColor = true;
            this.top_customer.Click += new System.EventHandler(this.top_customer_Click);
            // 
            // Users_info
            // 
            this.Users_info.AutoSize = true;
            this.Users_info.Checked = true;
            this.Users_info.Location = new System.Drawing.Point(3, 17);
            this.Users_info.Name = "Users_info";
            this.Users_info.Size = new System.Drawing.Size(180, 17);
            this.Users_info.TabIndex = 3;
            this.Users_info.TabStop = true;
            this.Users_info.Text = "Informations sur les commerciaux";
            this.Users_info.UseVisualStyleBackColor = true;
            this.Users_info.Click += new System.EventHandler(this.Users_info_Click);
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(8, 9);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(153, 20);
            this.menu.TabIndex = 0;
            this.menu.Text = "Top informations :";
            // 
            // infos_accueil
            // 
            this.infos_accueil.AutoSize = true;
            this.infos_accueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infos_accueil.Location = new System.Drawing.Point(3, 9);
            this.infos_accueil.Name = "infos_accueil";
            this.infos_accueil.Size = new System.Drawing.Size(223, 20);
            this.infos_accueil.TabIndex = 1;
            this.infos_accueil.Text = "Informations demandées : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 388);
            this.panel1.TabIndex = 2;
            // 
            // top_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1060, 388);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "top_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.radiobutton.ResumeLayout(false);
            this.radiobutton.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label infos_accueil;
        private System.Windows.Forms.RadioButton top_produits;
        private System.Windows.Forms.RadioButton top_customer;
        private System.Windows.Forms.RadioButton Users_info;
        private System.Windows.Forms.RadioButton cmd_en_cours;
        private System.Windows.Forms.RadioButton nb_cmd;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Panel radiobutton;
        private System.Windows.Forms.Panel panel1;
    }
}