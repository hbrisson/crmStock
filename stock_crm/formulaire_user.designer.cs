namespace stock_crm
{
    partial class formulaire_user
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
            this.prenom_label = new System.Windows.Forms.Label();
            this.prenom_user = new System.Windows.Forms.TextBox();
            this.nom_user = new System.Windows.Forms.TextBox();
            this.statut_label = new System.Windows.Forms.Label();
            this.nom_label = new System.Windows.Forms.Label();
            this.statut_user = new System.Windows.Forms.ComboBox();
            this.ajouter_user = new System.Windows.Forms.Button();
            this.mdp_label = new System.Windows.Forms.Label();
            this.identifiant_user = new System.Windows.Forms.TextBox();
            this.identifiant_label = new System.Windows.Forms.Label();
            this.mdp_user = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // prenom_label
            // 
            this.prenom_label.AutoSize = true;
            this.prenom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.prenom_label.Location = new System.Drawing.Point(17, 66);
            this.prenom_label.Name = "prenom_label";
            this.prenom_label.Size = new System.Drawing.Size(69, 16);
            this.prenom_label.TabIndex = 9;
            this.prenom_label.Text = "Prénom * :";
            // 
            // prenom_user
            // 
            this.prenom_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.prenom_user.Location = new System.Drawing.Point(92, 65);
            this.prenom_user.Name = "prenom_user";
            this.prenom_user.Size = new System.Drawing.Size(100, 20);
            this.prenom_user.TabIndex = 2;
            // 
            // nom_user
            // 
            this.nom_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_user.Location = new System.Drawing.Point(92, 39);
            this.nom_user.Name = "nom_user";
            this.nom_user.Size = new System.Drawing.Size(100, 20);
            this.nom_user.TabIndex = 1;
            // 
            // statut_label
            // 
            this.statut_label.AutoSize = true;
            this.statut_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.statut_label.Location = new System.Drawing.Point(31, 92);
            this.statut_label.Name = "statut_label";
            this.statut_label.Size = new System.Drawing.Size(55, 16);
            this.statut_label.TabIndex = 11;
            this.statut_label.Text = "Statut * :";
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nom_label.Location = new System.Drawing.Point(35, 40);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(51, 16);
            this.nom_label.TabIndex = 7;
            this.nom_label.Text = "Nom * :";
            // 
            // statut_user
            // 
            this.statut_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statut_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.statut_user.FormattingEnabled = true;
            this.statut_user.Location = new System.Drawing.Point(92, 91);
            this.statut_user.Name = "statut_user";
            this.statut_user.Size = new System.Drawing.Size(100, 21);
            this.statut_user.TabIndex = 3;
            // 
            // ajouter_user
            // 
            this.ajouter_user.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ajouter_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter_user.Location = new System.Drawing.Point(53, 180);
            this.ajouter_user.Name = "ajouter_user";
            this.ajouter_user.Size = new System.Drawing.Size(121, 23);
            this.ajouter_user.TabIndex = 6;
            this.ajouter_user.Text = "Ajouter";
            this.ajouter_user.UseVisualStyleBackColor = false;
            this.ajouter_user.Click += new System.EventHandler(this.ajouter_user_Click);
            // 
            // mdp_label
            // 
            this.mdp_label.AutoSize = true;
            this.mdp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mdp_label.Location = new System.Drawing.Point(37, 145);
            this.mdp_label.Name = "mdp_label";
            this.mdp_label.Size = new System.Drawing.Size(49, 16);
            this.mdp_label.TabIndex = 16;
            this.mdp_label.Text = "Mdp * :";
            // 
            // identifiant_user
            // 
            this.identifiant_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.identifiant_user.Location = new System.Drawing.Point(92, 118);
            this.identifiant_user.Name = "identifiant_user";
            this.identifiant_user.Size = new System.Drawing.Size(100, 20);
            this.identifiant_user.TabIndex = 4;
            // 
            // identifiant_label
            // 
            this.identifiant_label.AutoSize = true;
            this.identifiant_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.identifiant_label.Location = new System.Drawing.Point(8, 119);
            this.identifiant_label.Name = "identifiant_label";
            this.identifiant_label.Size = new System.Drawing.Size(78, 16);
            this.identifiant_label.TabIndex = 14;
            this.identifiant_label.Text = "Identifiant * :";
            // 
            // mdp_user
            // 
            this.mdp_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mdp_user.Location = new System.Drawing.Point(92, 144);
            this.mdp_user.Name = "mdp_user";
            this.mdp_user.PasswordChar = '*';
            this.mdp_user.Size = new System.Drawing.Size(100, 20);
            this.mdp_user.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.mdp_user);
            this.groupBox1.Controls.Add(this.identifiant_label);
            this.groupBox1.Controls.Add(this.identifiant_user);
            this.groupBox1.Controls.Add(this.mdp_label);
            this.groupBox1.Controls.Add(this.statut_user);
            this.groupBox1.Controls.Add(this.nom_label);
            this.groupBox1.Controls.Add(this.statut_label);
            this.groupBox1.Controls.Add(this.nom_user);
            this.groupBox1.Controls.Add(this.prenom_user);
            this.groupBox1.Controls.Add(this.prenom_label);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Création d\'un utilisateur";
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.groupBox1);
            this.panelUser.Controls.Add(this.ajouter_user);
            this.panelUser.Location = new System.Drawing.Point(12, 12);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(228, 222);
            this.panelUser.TabIndex = 9;
            // 
            // formulaire_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(249, 244);
            this.Controls.Add(this.panelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formulaire_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label prenom_label;
        private System.Windows.Forms.TextBox prenom_user;
        private System.Windows.Forms.TextBox nom_user;
        private System.Windows.Forms.Label statut_label;
        private System.Windows.Forms.Label nom_label;
        private System.Windows.Forms.ComboBox statut_user;
        private System.Windows.Forms.Button ajouter_user;
        private System.Windows.Forms.Label mdp_label;
        private System.Windows.Forms.TextBox identifiant_user;
        private System.Windows.Forms.Label identifiant_label;
        private System.Windows.Forms.MaskedTextBox mdp_user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelUser;


    }
}