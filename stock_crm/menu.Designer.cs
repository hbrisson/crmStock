namespace stock_crm
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.groupPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.roleUser = new System.Windows.Forms.Label();
            this.nomUser = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tiersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelForm = new System.Windows.Forms.Panel();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPanel.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel
            // 
            this.groupPanel.BackColor = System.Drawing.Color.White;
            this.groupPanel.ColumnCount = 1;
            this.groupPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupPanel.Controls.Add(this.panelMenu, 0, 0);
            this.groupPanel.Controls.Add(this.panelForm, 0, 1);
            this.groupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel.Location = new System.Drawing.Point(0, 0);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.RowCount = 2;
            this.groupPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.groupPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupPanel.Size = new System.Drawing.Size(1134, 561);
            this.groupPanel.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMenu.Controls.Add(this.roleUser);
            this.panelMenu.Controls.Add(this.nomUser);
            this.panelMenu.Controls.Add(this.menuStrip);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(3, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1128, 55);
            this.panelMenu.TabIndex = 1;
            // 
            // roleUser
            // 
            this.roleUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roleUser.AutoSize = true;
            this.roleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.roleUser.Location = new System.Drawing.Point(992, 23);
            this.roleUser.Name = "roleUser";
            this.roleUser.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.roleUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.roleUser.Size = new System.Drawing.Size(127, 20);
            this.roleUser.TabIndex = 2;
            this.roleUser.Text = "Directeur Commercial";
            // 
            // nomUser
            // 
            this.nomUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nomUser.AutoSize = true;
            this.nomUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.nomUser.Location = new System.Drawing.Point(992, 6);
            this.nomUser.Name = "nomUser";
            this.nomUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nomUser.Size = new System.Drawing.Size(105, 17);
            this.nomUser.TabIndex = 1;
            this.nomUser.Text = "Brisson Hugo";
            this.nomUser.Click += new System.EventHandler(this.nomUser_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.userItem,
            this.tiersItem,
            this.contactItem,
            this.commandeItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(783, 56);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accueilToolStripMenuItem.Image")));
            this.accueilToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accueilToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(136, 52);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            // 
            // userItem
            // 
            this.userItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerToolStripMenuItem,
            this.consulterToolStripMenuItem3});
            this.userItem.Image = ((System.Drawing.Image)(resources.GetObject("userItem.Image")));
            this.userItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.userItem.Name = "userItem";
            this.userItem.Size = new System.Drawing.Size(113, 52);
            this.userItem.Text = "User";
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.créerToolStripMenuItem.Text = "Créer";
            this.créerToolStripMenuItem.Click += new System.EventHandler(this.créerToolStripMenuItem_Click);
            // 
            // consulterToolStripMenuItem3
            // 
            this.consulterToolStripMenuItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.consulterToolStripMenuItem3.Name = "consulterToolStripMenuItem3";
            this.consulterToolStripMenuItem3.Size = new System.Drawing.Size(149, 24);
            this.consulterToolStripMenuItem3.Text = "Consulter";
            this.consulterToolStripMenuItem3.Click += new System.EventHandler(this.consulterToolStripMenuItem3_Click);
            // 
            // tiersItem
            // 
            this.tiersItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerToolStripMenuItem,
            this.modifierToolStripMenuItem1});
            this.tiersItem.Image = ((System.Drawing.Image)(resources.GetObject("tiersItem.Image")));
            this.tiersItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tiersItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tiersItem.Name = "tiersItem";
            this.tiersItem.Size = new System.Drawing.Size(116, 52);
            this.tiersItem.Text = "Tiers";
            // 
            // creerToolStripMenuItem
            // 
            this.creerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.creerToolStripMenuItem.Name = "creerToolStripMenuItem";
            this.creerToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.creerToolStripMenuItem.Text = "Créer";
            this.creerToolStripMenuItem.Click += new System.EventHandler(this.creerToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(149, 24);
            this.modifierToolStripMenuItem1.Text = "Consulter";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // contactItem
            // 
            this.contactItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerToolStripMenuItem1,
            this.supprimerToolStripMenuItem2,
            this.historiqueToolStripMenuItem});
            this.contactItem.Image = ((System.Drawing.Image)(resources.GetObject("contactItem.Image")));
            this.contactItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.contactItem.Name = "contactItem";
            this.contactItem.Size = new System.Drawing.Size(140, 52);
            this.contactItem.Text = "Contact";
            // 
            // creerToolStripMenuItem1
            // 
            this.creerToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.creerToolStripMenuItem1.Name = "creerToolStripMenuItem1";
            this.creerToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.creerToolStripMenuItem1.Text = "Créer";
            this.creerToolStripMenuItem1.Click += new System.EventHandler(this.creerToolStripMenuItem1_Click);
            // 
            // supprimerToolStripMenuItem2
            // 
            this.supprimerToolStripMenuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.supprimerToolStripMenuItem2.Name = "supprimerToolStripMenuItem2";
            this.supprimerToolStripMenuItem2.Size = new System.Drawing.Size(153, 24);
            this.supprimerToolStripMenuItem2.Text = "Consulter";
            this.supprimerToolStripMenuItem2.Click += new System.EventHandler(this.modifier_contact);
            // 
            // commandeItem
            // 
            this.commandeItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerToolStripMenuItem1,
            this.consulterToolStripMenuItem});
            this.commandeItem.Image = ((System.Drawing.Image)(resources.GetObject("commandeItem.Image")));
            this.commandeItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.commandeItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.commandeItem.Name = "commandeItem";
            this.commandeItem.Size = new System.Drawing.Size(174, 52);
            this.commandeItem.Text = "Commande";
            // 
            // créerToolStripMenuItem1
            // 
            this.créerToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.créerToolStripMenuItem1.Name = "créerToolStripMenuItem1";
            this.créerToolStripMenuItem1.Size = new System.Drawing.Size(149, 24);
            this.créerToolStripMenuItem1.Text = "Créer";
            this.créerToolStripMenuItem1.Click += new System.EventHandler(this.créerToolStripMenuItem1_Click);
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.consulterToolStripMenuItem.Text = "Consulter";
            this.consulterToolStripMenuItem.Click += new System.EventHandler(this.consulterToolStripMenuItem_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(3, 64);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1128, 494);
            this.panelForm.TabIndex = 0;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.historiqueToolStripMenuItem.Text = "Historique";
            this.historiqueToolStripMenuItem.Click += new System.EventHandler(this.historiqueToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.groupPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM_Stock";
            this.groupPanel.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel groupPanel;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem userItem;
        private System.Windows.Forms.ToolStripMenuItem tiersItem;
        private System.Windows.Forms.ToolStripMenuItem contactItem;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem commandeItem;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.Label nomUser;
        private System.Windows.Forms.Label roleUser;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;

    }
}