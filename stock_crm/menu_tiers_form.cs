using stock_crm.Tiers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    public partial class menuTiers : customForm
    {
        private tiers mTiers;
        public menuTiers(tiers tiers)
        {
            InitializeComponent();
            initcomponent(splitContainer2);
            mTiers = tiers;
            label1.Text = mTiers.Nom;
        }

        private void Ajout_prod_bt_Click(object sender, EventArgs e)
        {
            commande_tiers_form commande_tiers_form = new commande_tiers_form(mTiers);
            commande_tiers_form.Text = "Formulaire";
            commande_tiers_form.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(commande_tiers_form);
            commande_tiers_form.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            modifier_tiers modifier_tiers = new modifier_tiers(mTiers);
            modifier_tiers.Text = "Formulaire";
            modifier_tiers.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(modifier_tiers);
            modifier_tiers.Show();
        
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
