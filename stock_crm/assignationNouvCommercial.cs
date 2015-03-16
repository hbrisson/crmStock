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
    public partial class assignationNouvCommercial : customForm
    {
        private int rows = 1;
        private List<int> list_idtiers = new List<int>();

        public assignationNouvCommercial()
        {
            InitializeComponent();
            initcomponent(panelAssignation);
            insert_data();

        }
        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
        }

        public void insert_data()
        {
            List<tiers> list_tiers = Toolbox.assignation_list;
            int count = list_tiers.Count();

            UserConnect db = new UserConnect();
            
            int i = 0;
            

            foreach (tiers tiers in list_tiers)
            {
                list_idtiers.Add(tiers.Id);
                ComboBox combo = new ComboBox();
                List<user> user = Toolbox.cbUsers(combo, db);
                combo.Name = "combo" + i;
                combo.SelectedIndex = 0;
                combo.DropDownStyle = ComboBoxStyle.DropDownList;
                tableLayoutPanel1.Controls.Add(new Label() { Text = tiers.Nom, Anchor = AnchorStyles.None, AutoSize = true }, 0, rows);
                tableLayoutPanel1.Controls.Add(combo, 1, rows);
                rows++;
                i++;
                if (rows == count+1)
                {
                    tableLayoutPanel1.Controls.Add(new Label() { Text = "", Anchor = AnchorStyles.None, AutoSize = true, Visible = true }, 0, rows);
                }
            }
        }

        private void valid_assignation_Click(object sender, EventArgs e)
        {
            try
            {
                List<ComboBox> list_combo = new List<ComboBox>();
                foreach (Control ctrl in tableLayoutPanel1.Controls)
                {

                    string str = Convert.ToString(ctrl.GetType());
                    if (str == "System.Windows.Forms.ComboBox")
                    {
                        list_combo.Add((ComboBox)ctrl);
                    }
                }

                int i = 0;
                foreach (ComboBox combo in list_combo)
                {
                    var identifiant_item = combo.SelectedItem;
                    string identifiant = Convert.ToString(identifiant_item);
                    var id_tiers = list_idtiers[i];

                    UserConnect db = new UserConnect();
                    tiersConnect dbtiers = new tiersConnect();
                    user user = db.getUser(identifiant);

                    dbtiers.Update_userTiers(user, id_tiers);
                    i++;
                }
                MessageBox.Show("Les tiers ont correctement étaient affectés");
                
                Toolbox.user_delete = true;
                Toolbox.fermer_form();
                
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
    }
}
