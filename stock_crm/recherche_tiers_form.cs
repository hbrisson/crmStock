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
    public partial class consultation_tiers_form : customForm
    {
        private string query = "SELECT b.id,b.nom,b.type,b.reglement,b.adresse_liv,b.adresse_fact,b.pays,b.commentaire FROM tiers b WHERE b.id IN ( SELECT idtiers FROM usertiers WHERE idusers = '" + Toolbox.userSession.Id + "')";
        private int index_local = 0;

        public consultation_tiers_form()
        {

            InitializeComponent();
            initcomponent(panel_modifier_tiers);
            tiersConnect tiersconnect = new tiersConnect();
            panel_modifier_tiers.Location = new Point(this.ClientSize.Width / 2 - panel_modifier_tiers.Size.Width / 2, this.ClientSize.Height / 2 - panel_modifier_tiers.Size.Height / 2);
            panel_modifier_tiers.Anchor = AnchorStyles.None;
            //remplir_list();

            Toolbox.loadGridView(dataGridView1, tiersconnect.connection, null, query);
            dataGridView1.Columns[0].Visible = false;
        }

        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT b.id,b.nom,b.type,b.reglement,b.adresse_liv,b.adresse_fact,b.pays,b.commentaire FROM tiers b WHERE b.id IN ( SELECT idtiers FROM usertiers WHERE idusers = '" + Toolbox.userSession.Id + "') AND  (b.nom like '%" + searchtb.Text + "%' OR b.type like '%" + searchtb.Text + "%' OR b.reglement like '%" + searchtb.Text + "%' OR b.pays like '%" + searchtb.Text + "%' OR b.commentaire like '%" + searchtb.Text + "%' OR b.adresse_liv like'%" + searchtb.Text + "%' OR b.adresse_fact like'%" + searchtb.Text + "%')";
            tiersConnect tiersconnect = new tiersConnect();
            Toolbox.loadGridView(dataGridView1, tiersconnect.connection, null, query);
            dataGridView1.Columns[0].Visible = false;

        }

        private void searchtb_Click(object sender, EventArgs e)
        {
            searchtb.ResetText();
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
              {
                index_local = dataGridView1.CurrentRow.Index;

                string id_tiers = dataGridView1.Rows[index_local].Cells[0].Value.ToString();

                if (index_local < (dataGridView1.Rows.Count - 1))
                {
                    tiersConnect tiersConnect = new tiersConnect();
                    tiers tiers_data = new tiers();
                    tiers_data = tiersConnect.SelectWhereTiers("*", "tiers", "id", id_tiers);
                    menuTiers menuTiers = new menuTiers(tiers_data);
                    menuTiers.Text = "Formulaire";
                    menuTiers.TopLevel = false;
                    panel_modifier_tiers.Controls.Add(menuTiers);
                    menuTiers.Show();
                }
            }
            catch (Exception ex)
            {
            }
        }

    }
}
