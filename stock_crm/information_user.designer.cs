namespace stock_crm
{
    partial class information_user
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modifierMdp_user = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mdpConfirm_user = new System.Windows.Forms.MaskedTextBox();
            this.mdp_user = new System.Windows.Forms.MaskedTextBox();
            this.mdp_label = new System.Windows.Forms.Label();
            this.identifiant_user = new System.Windows.Forms.TextBox();
            this.identifiant_label = new System.Windows.Forms.Label();
            this.statut_user = new System.Windows.Forms.TextBox();
            this.nom_label = new System.Windows.Forms.Label();
            this.statut_label = new System.Windows.Forms.Label();
            this.nom_user = new System.Windows.Forms.TextBox();
            this.prenom_user = new System.Windows.Forms.TextBox();
            this.prenom_label = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.modifierMdp_user);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.identifiant_user);
            this.groupBox1.Controls.Add(this.identifiant_label);
            this.groupBox1.Controls.Add(this.statut_user);
            this.groupBox1.Controls.Add(this.nom_label);
            this.groupBox1.Controls.Add(this.statut_label);
            this.groupBox1.Controls.Add(this.nom_user);
            this.groupBox1.Controls.Add(this.prenom_user);
            this.groupBox1.Controls.Add(this.prenom_label);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information de l\'utilisateur";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // modifierMdp_user
            // 
            this.modifierMdp_user.BackColor = System.Drawing.Color.LightSteelBlue;
            this.modifierMdp_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.modifierMdp_user.Location = new System.Drawing.Point(133, 166);
            this.modifierMdp_user.Name = "modifierMdp_user";
            this.modifierMdp_user.Size = new System.Drawing.Size(100, 23);
            this.modifierMdp_user.TabIndex = 25;
            this.modifierMdp_user.Text = "Modifier";
            this.modifierMdp_user.UseVisualStyleBackColor = false;
            this.modifierMdp_user.Click += new System.EventHandler(this.modifierMdp_user_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.mdpConfirm_user);
            this.groupBox2.Controls.Add(this.mdp_user);
            this.groupBox2.Controls.Add(this.mdp_label);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 80);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nouveau mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Confirmer mot de passe * :";
            // 
            // mdpConfirm_user
            // 
            this.mdpConfirm_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.mdpConfirm_user.Location = new System.Drawing.Point(177, 50);
            this.mdpConfirm_user.Name = "mdpConfirm_user";
            this.mdpConfirm_user.PasswordChar = '*';
            this.mdpConfirm_user.Size = new System.Drawing.Size(100, 20);
            this.mdpConfirm_user.TabIndex = 31;
            // 
            // mdp_user
            // 
            this.mdp_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.mdp_user.Location = new System.Drawing.Point(177, 24);
            this.mdp_user.Name = "mdp_user";
            this.mdp_user.PasswordChar = '*';
            this.mdp_user.Size = new System.Drawing.Size(100, 20);
            this.mdp_user.TabIndex = 29;
            // 
            // mdp_label
            // 
            this.mdp_label.AutoSize = true;
            this.mdp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp_label.Location = new System.Drawing.Point(9, 25);
            this.mdp_label.Name = "mdp_label";
            this.mdp_label.Size = new System.Drawing.Size(162, 16);
            this.mdp_label.TabIndex = 28;
            this.mdp_label.Text = "Nouveau mot de passe * :";
            // 
            // identifiant_user
            // 
            this.identifiant_user.BackColor = System.Drawing.SystemColors.Window;
            this.identifiant_user.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.identifiant_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.identifiant_user.Location = new System.Drawing.Point(257, 54);
            this.identifiant_user.Name = "identifiant_user";
            this.identifiant_user.ReadOnly = true;
            this.identifiant_user.Size = new System.Drawing.Size(100, 20);
            this.identifiant_user.TabIndex = 29;
            // 
            // identifiant_label
            // 
            this.identifiant_label.AutoSize = true;
            this.identifiant_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiant_label.Location = new System.Drawing.Point(181, 58);
            this.identifiant_label.Name = "identifiant_label";
            this.identifiant_label.Size = new System.Drawing.Size(70, 16);
            this.identifiant_label.TabIndex = 26;
            this.identifiant_label.Text = "Identifiant :";
            // 
            // statut_user
            // 
            this.statut_user.BackColor = System.Drawing.SystemColors.Window;
            this.statut_user.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.statut_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.statut_user.Location = new System.Drawing.Point(75, 54);
            this.statut_user.Name = "statut_user";
            this.statut_user.ReadOnly = true;
            this.statut_user.Size = new System.Drawing.Size(100, 20);
            this.statut_user.TabIndex = 27;
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_label.Location = new System.Drawing.Point(26, 29);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(43, 16);
            this.nom_label.TabIndex = 19;
            this.nom_label.Text = "Nom :";
            // 
            // statut_label
            // 
            this.statut_label.AutoSize = true;
            this.statut_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statut_label.Location = new System.Drawing.Point(22, 55);
            this.statut_label.Name = "statut_label";
            this.statut_label.Size = new System.Drawing.Size(47, 16);
            this.statut_label.TabIndex = 23;
            this.statut_label.Text = "Statut :";
            // 
            // nom_user
            // 
            this.nom_user.BackColor = System.Drawing.SystemColors.Window;
            this.nom_user.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nom_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nom_user.Location = new System.Drawing.Point(75, 28);
            this.nom_user.Name = "nom_user";
            this.nom_user.ReadOnly = true;
            this.nom_user.Size = new System.Drawing.Size(100, 20);
            this.nom_user.TabIndex = 20;
            // 
            // prenom_user
            // 
            this.prenom_user.BackColor = System.Drawing.SystemColors.Window;
            this.prenom_user.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.prenom_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.prenom_user.Location = new System.Drawing.Point(257, 28);
            this.prenom_user.Name = "prenom_user";
            this.prenom_user.ReadOnly = true;
            this.prenom_user.Size = new System.Drawing.Size(100, 20);
            this.prenom_user.TabIndex = 22;
            // 
            // prenom_label
            // 
            this.prenom_label.AutoSize = true;
            this.prenom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_label.Location = new System.Drawing.Point(190, 29);
            this.prenom_label.Name = "prenom_label";
            this.prenom_label.Size = new System.Drawing.Size(61, 16);
            this.prenom_label.TabIndex = 21;
            this.prenom_label.Text = "Prénom :";
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.groupBox1);
            this.panelUser.Location = new System.Drawing.Point(12, 12);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(386, 210);
            this.panelUser.TabIndex = 1;
            // 
            // information_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 231);
            this.Controls.Add(this.panelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "information_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label mdp_label;
        private System.Windows.Forms.Button modifierMdp_user;
        private System.Windows.Forms.TextBox identifiant_user;
        private System.Windows.Forms.Label identifiant_label;
        private System.Windows.Forms.TextBox statut_user;
        private System.Windows.Forms.Label nom_label;
        private System.Windows.Forms.Label statut_label;
        private System.Windows.Forms.TextBox nom_user;
        private System.Windows.Forms.TextBox prenom_user;
        private System.Windows.Forms.Label prenom_label;
        private System.Windows.Forms.MaskedTextBox mdpConfirm_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mdp_user;
        private System.Windows.Forms.Panel panelUser;
    }
}