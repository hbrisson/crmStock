namespace stock_crm
{
    partial class identificationForm
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
            this.identifiant_txb = new System.Windows.Forms.TextBox();
            this.mdp_label = new System.Windows.Forms.Label();
            this.identifant_label = new System.Windows.Forms.Label();
            this.mdp_txb = new System.Windows.Forms.TextBox();
            this.connexion_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.identifiant_txb);
            this.groupBox1.Controls.Add(this.mdp_label);
            this.groupBox1.Controls.Add(this.identifant_label);
            this.groupBox1.Controls.Add(this.mdp_txb);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identification";
            // 
            // identifiant_txb
            // 
            this.identifiant_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.identifiant_txb.Location = new System.Drawing.Point(85, 34);
            this.identifiant_txb.Name = "identifiant_txb";
            this.identifiant_txb.Size = new System.Drawing.Size(100, 20);
            this.identifiant_txb.TabIndex = 11;
            // 
            // mdp_label
            // 
            this.mdp_label.AutoSize = true;
            this.mdp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp_label.Location = new System.Drawing.Point(44, 64);
            this.mdp_label.Name = "mdp_label";
            this.mdp_label.Size = new System.Drawing.Size(35, 16);
            this.mdp_label.TabIndex = 10;
            this.mdp_label.Text = "Mdp";
            // 
            // identifant_label
            // 
            this.identifant_label.AutoSize = true;
            this.identifant_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifant_label.Location = new System.Drawing.Point(15, 35);
            this.identifant_label.Name = "identifant_label";
            this.identifant_label.Size = new System.Drawing.Size(64, 16);
            this.identifant_label.TabIndex = 9;
            this.identifant_label.Text = "Identifiant";
            // 
            // mdp_txb
            // 
            this.mdp_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mdp_txb.Location = new System.Drawing.Point(85, 60);
            this.mdp_txb.Name = "mdp_txb";
            this.mdp_txb.PasswordChar = '*';
            this.mdp_txb.Size = new System.Drawing.Size(100, 20);
            this.mdp_txb.TabIndex = 12;
            // 
            // connexion_btn
            // 
            this.connexion_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.connexion_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.connexion_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.connexion_btn.ForeColor = System.Drawing.Color.Black;
            this.connexion_btn.Location = new System.Drawing.Point(59, 112);
            this.connexion_btn.Name = "connexion_btn";
            this.connexion_btn.Size = new System.Drawing.Size(100, 23);
            this.connexion_btn.TabIndex = 13;
            this.connexion_btn.Text = "Connexion";
            this.connexion_btn.UseVisualStyleBackColor = false;
            this.connexion_btn.Click += new System.EventHandler(this.connexion_btn_Click);
            // 
            // identificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(221, 147);
            this.Controls.Add(this.connexion_btn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "identificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button connexion_btn;
        private System.Windows.Forms.TextBox identifiant_txb;
        private System.Windows.Forms.Label mdp_label;
        private System.Windows.Forms.Label identifant_label;
        private System.Windows.Forms.TextBox mdp_txb;


    }
}