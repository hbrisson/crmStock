namespace stock_crm
{
    partial class formulaire_user_supprimer
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
            this.sup_user = new System.Windows.Forms.GroupBox();
            this.nom_label = new System.Windows.Forms.Label();
            this.nom_user = new System.Windows.Forms.TextBox();
            this.prenom_user = new System.Windows.Forms.TextBox();
            this.prenom_label = new System.Windows.Forms.Label();
            this.identifiant_user = new System.Windows.Forms.ComboBox();
            this.identifiant_label = new System.Windows.Forms.Label();
            this.supprimer_user = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.sup_user.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // sup_user
            // 
            this.sup_user.BackColor = System.Drawing.Color.White;
            this.sup_user.Controls.Add(this.nom_label);
            this.sup_user.Controls.Add(this.nom_user);
            this.sup_user.Controls.Add(this.prenom_user);
            this.sup_user.Controls.Add(this.prenom_label);
            this.sup_user.Controls.Add(this.identifiant_user);
            this.sup_user.Controls.Add(this.identifiant_label);
            this.sup_user.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_user.Location = new System.Drawing.Point(3, 3);
            this.sup_user.Name = "sup_user";
            this.sup_user.Size = new System.Drawing.Size(236, 109);
            this.sup_user.TabIndex = 0;
            this.sup_user.TabStop = false;
            this.sup_user.Text = "Suppression d\'un utilisateur";
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_label.Location = new System.Drawing.Point(64, 56);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(43, 16);
            this.nom_label.TabIndex = 23;
            this.nom_label.Text = "Nom :";
            // 
            // nom_user
            // 
            this.nom_user.BackColor = System.Drawing.SystemColors.Window;
            this.nom_user.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nom_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nom_user.Location = new System.Drawing.Point(113, 55);
            this.nom_user.Name = "nom_user";
            this.nom_user.ReadOnly = true;
            this.nom_user.Size = new System.Drawing.Size(100, 20);
            this.nom_user.TabIndex = 2;
            // 
            // prenom_user
            // 
            this.prenom_user.BackColor = System.Drawing.SystemColors.Window;
            this.prenom_user.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.prenom_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.prenom_user.Location = new System.Drawing.Point(113, 81);
            this.prenom_user.Name = "prenom_user";
            this.prenom_user.ReadOnly = true;
            this.prenom_user.Size = new System.Drawing.Size(100, 20);
            this.prenom_user.TabIndex = 3;
            // 
            // prenom_label
            // 
            this.prenom_label.AutoSize = true;
            this.prenom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_label.Location = new System.Drawing.Point(46, 82);
            this.prenom_label.Name = "prenom_label";
            this.prenom_label.Size = new System.Drawing.Size(61, 16);
            this.prenom_label.TabIndex = 25;
            this.prenom_label.Text = "Prénom :";
            // 
            // identifiant_user
            // 
            this.identifiant_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.identifiant_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.identifiant_user.FormattingEnabled = true;
            this.identifiant_user.Location = new System.Drawing.Point(113, 28);
            this.identifiant_user.Name = "identifiant_user";
            this.identifiant_user.Size = new System.Drawing.Size(100, 21);
            this.identifiant_user.TabIndex = 1;
            this.identifiant_user.SelectedIndexChanged += new System.EventHandler(this.identifiant_user_SelectedIndexChanged);
            // 
            // identifiant_label
            // 
            this.identifiant_label.AutoSize = true;
            this.identifiant_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiant_label.Location = new System.Drawing.Point(29, 29);
            this.identifiant_label.Name = "identifiant_label";
            this.identifiant_label.Size = new System.Drawing.Size(78, 16);
            this.identifiant_label.TabIndex = 13;
            this.identifiant_label.Text = "Identifiant * :";
            // 
            // supprimer_user
            // 
            this.supprimer_user.BackColor = System.Drawing.Color.LightSteelBlue;
            this.supprimer_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.supprimer_user.Location = new System.Drawing.Point(70, 118);
            this.supprimer_user.Name = "supprimer_user";
            this.supprimer_user.Size = new System.Drawing.Size(100, 23);
            this.supprimer_user.TabIndex = 4;
            this.supprimer_user.Text = "Supprimer";
            this.supprimer_user.UseVisualStyleBackColor = false;
            this.supprimer_user.Click += new System.EventHandler(this.supprimer_user_Click);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.sup_user);
            this.panelUser.Controls.Add(this.supprimer_user);
            this.panelUser.Location = new System.Drawing.Point(12, 12);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(249, 152);
            this.panelUser.TabIndex = 5;
            // 
            // formulaire_user_supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 178);
            this.Controls.Add(this.panelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formulaire_user_supprimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                             ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sup_user.ResumeLayout(false);
            this.sup_user.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sup_user;
        private System.Windows.Forms.ComboBox identifiant_user;
        private System.Windows.Forms.Label identifiant_label;
        private System.Windows.Forms.Label nom_label;
        private System.Windows.Forms.TextBox nom_user;
        private System.Windows.Forms.TextBox prenom_user;
        private System.Windows.Forms.Label prenom_label;
        private System.Windows.Forms.Button supprimer_user;
        private System.Windows.Forms.Panel panelUser;
    }
}