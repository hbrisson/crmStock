namespace stock_crm
{
    partial class formulaire_user_modifier
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
            this.statut_label = new System.Windows.Forms.Label();
            this.identifiant_label = new System.Windows.Forms.Label();
            this.nouv_identifiant_user = new System.Windows.Forms.TextBox();
            this.modifier_user = new System.Windows.Forms.Button();
            this.statut_user = new System.Windows.Forms.ComboBox();
            this.modification_user = new System.Windows.Forms.GroupBox();
            this.nom_label = new System.Windows.Forms.Label();
            this.nom_user = new System.Windows.Forms.TextBox();
            this.prenom_user = new System.Windows.Forms.TextBox();
            this.prenom_label = new System.Windows.Forms.Label();
            this.identifiant_user = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.supprimer_user = new System.Windows.Forms.Button();
            this.modification_user.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // statut_label
            // 
            this.statut_label.AutoSize = true;
            this.statut_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statut_label.Location = new System.Drawing.Point(71, 108);
            this.statut_label.Name = "statut_label";
            this.statut_label.Size = new System.Drawing.Size(47, 16);
            this.statut_label.TabIndex = 34;
            this.statut_label.Text = "Statut :";
            // 
            // identifiant_label
            // 
            this.identifiant_label.AutoSize = true;
            this.identifiant_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiant_label.Location = new System.Drawing.Point(2, 135);
            this.identifiant_label.Name = "identifiant_label";
            this.identifiant_label.Size = new System.Drawing.Size(116, 16);
            this.identifiant_label.TabIndex = 35;
            this.identifiant_label.Text = "Nouvel identifiant :";
            // 
            // nouv_identifiant_user
            // 
            this.nouv_identifiant_user.BackColor = System.Drawing.SystemColors.Window;
            this.nouv_identifiant_user.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nouv_identifiant_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nouv_identifiant_user.Location = new System.Drawing.Point(126, 134);
            this.nouv_identifiant_user.Name = "nouv_identifiant_user";
            this.nouv_identifiant_user.Size = new System.Drawing.Size(167, 20);
            this.nouv_identifiant_user.TabIndex = 37;
            // 
            // modifier_user
            // 
            this.modifier_user.BackColor = System.Drawing.Color.LightSteelBlue;
            this.modifier_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.modifier_user.Location = new System.Drawing.Point(90, 174);
            this.modifier_user.Name = "modifier_user";
            this.modifier_user.Size = new System.Drawing.Size(121, 23);
            this.modifier_user.TabIndex = 38;
            this.modifier_user.Text = "Modifier";
            this.modifier_user.UseVisualStyleBackColor = false;
            this.modifier_user.Click += new System.EventHandler(this.modifier_user_Click);
            // 
            // statut_user
            // 
            this.statut_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statut_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.statut_user.FormattingEnabled = true;
            this.statut_user.Location = new System.Drawing.Point(126, 107);
            this.statut_user.Name = "statut_user";
            this.statut_user.Size = new System.Drawing.Size(167, 21);
            this.statut_user.TabIndex = 39;
            // 
            // modification_user
            // 
            this.modification_user.BackColor = System.Drawing.Color.White;
            this.modification_user.Controls.Add(this.nom_label);
            this.modification_user.Controls.Add(this.nom_user);
            this.modification_user.Controls.Add(this.prenom_user);
            this.modification_user.Controls.Add(this.prenom_label);
            this.modification_user.Controls.Add(this.identifiant_user);
            this.modification_user.Controls.Add(this.label1);
            this.modification_user.Controls.Add(this.statut_user);
            this.modification_user.Controls.Add(this.nouv_identifiant_user);
            this.modification_user.Controls.Add(this.identifiant_label);
            this.modification_user.Controls.Add(this.statut_label);
            this.modification_user.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modification_user.Location = new System.Drawing.Point(3, 3);
            this.modification_user.Name = "modification_user";
            this.modification_user.Size = new System.Drawing.Size(300, 163);
            this.modification_user.TabIndex = 0;
            this.modification_user.TabStop = false;
            this.modification_user.Text = "Modification d\'un utilisateur";
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_label.Location = new System.Drawing.Point(75, 56);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(43, 16);
            this.nom_label.TabIndex = 42;
            this.nom_label.Text = "Nom :";
            // 
            // nom_user
            // 
            this.nom_user.BackColor = System.Drawing.SystemColors.Window;
            this.nom_user.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nom_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nom_user.Location = new System.Drawing.Point(126, 55);
            this.nom_user.Name = "nom_user";
            this.nom_user.ReadOnly = true;
            this.nom_user.Size = new System.Drawing.Size(167, 20);
            this.nom_user.TabIndex = 43;
            // 
            // prenom_user
            // 
            this.prenom_user.BackColor = System.Drawing.SystemColors.Window;
            this.prenom_user.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.prenom_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.prenom_user.Location = new System.Drawing.Point(126, 81);
            this.prenom_user.Name = "prenom_user";
            this.prenom_user.ReadOnly = true;
            this.prenom_user.Size = new System.Drawing.Size(167, 20);
            this.prenom_user.TabIndex = 45;
            // 
            // prenom_label
            // 
            this.prenom_label.AutoSize = true;
            this.prenom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_label.Location = new System.Drawing.Point(57, 82);
            this.prenom_label.Name = "prenom_label";
            this.prenom_label.Size = new System.Drawing.Size(61, 16);
            this.prenom_label.TabIndex = 44;
            this.prenom_label.Text = "Prénom :";
            // 
            // identifiant_user
            // 
            this.identifiant_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.identifiant_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.identifiant_user.FormattingEnabled = true;
            this.identifiant_user.Location = new System.Drawing.Point(126, 28);
            this.identifiant_user.Name = "identifiant_user";
            this.identifiant_user.Size = new System.Drawing.Size(167, 21);
            this.identifiant_user.TabIndex = 41;
            this.identifiant_user.SelectedIndexChanged += new System.EventHandler(this.identifiant_user_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Identifiant * :";
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.supprimer_user);
            this.panelUser.Controls.Add(this.modification_user);
            this.panelUser.Controls.Add(this.modifier_user);
            this.panelUser.Location = new System.Drawing.Point(12, 12);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(306, 238);
            this.panelUser.TabIndex = 39;
            // 
            // supprimer_user
            // 
            this.supprimer_user.BackColor = System.Drawing.Color.LightSteelBlue;
            this.supprimer_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.supprimer_user.Location = new System.Drawing.Point(90, 203);
            this.supprimer_user.Name = "supprimer_user";
            this.supprimer_user.Size = new System.Drawing.Size(121, 23);
            this.supprimer_user.TabIndex = 39;
            this.supprimer_user.Text = "Supprimer";
            this.supprimer_user.UseVisualStyleBackColor = false;
            this.supprimer_user.Click += new System.EventHandler(this.supprimer_user_Click);
            // 
            // formulaire_user_modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 262);
            this.Controls.Add(this.panelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formulaire_user_modifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.modification_user.ResumeLayout(false);
            this.modification_user.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label statut_label;
        private System.Windows.Forms.Label identifiant_label;
        private System.Windows.Forms.TextBox nouv_identifiant_user;
        private System.Windows.Forms.Button modifier_user;
        private System.Windows.Forms.ComboBox statut_user;
        private System.Windows.Forms.GroupBox modification_user;
        private System.Windows.Forms.Label nom_label;
        private System.Windows.Forms.TextBox nom_user;
        private System.Windows.Forms.TextBox prenom_user;
        private System.Windows.Forms.Label prenom_label;
        private System.Windows.Forms.ComboBox identifiant_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Button supprimer_user;

    }
}