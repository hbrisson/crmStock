using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm.Tiers
{
    public partial class commande_tiers_form : customForm
    {

        private string query;
        private commandeConnect commandeConnect;

        public commande_tiers_form(tiers tiers)
        {
            InitializeComponent();
            initcomponent(panel1);
            initDataGridView(tiers);
            initLabel(tiers);
        }

        private void initLabel(tiers tiers)
        {
            try
            {
                List<string> list = commandeConnect.getCommandeCountAndSumByID(tiers, false);
                label1.Text += " " + list[0];
                label2.Text += " " + list[1];
                list = commandeConnect.getCommandeCountAndSumByID(tiers, true);
                label4.Text += " " + list[0];
                label3.Text += " " + list[1];
                list = commandeConnect.getCommandeSumByID(tiers, true);
                label5.Text = list[0] + " €";
                list = commandeConnect.getCommandeSumByID(tiers, false);
                label6.Text = list[0] + " €";
            }catch(Exception ex){
            }
           
        }

        private void initDataGridView(tiers tiers)
        {
            commandeConnect = new commandeConnect();
            query = "Select c.id as ID,c.type as Type,c.etat as Etat,c.date as Date,c.montant as Montant from commande c ,usertiers ut,tiers t where c.idtiers = t.id and t.id = ut.idtiers and ut.idusers = '" + Toolbox.userSession.Id + "' And c.type ='commande' And c.etat != 'à facturer' and t.id=" + tiers.Id + "";
            Toolbox.loadGridView(dataGridView1, commandeConnect.connection, null, query);
            dataGridView1.Columns[0].Visible = false;

           
            string etat = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(etat_prop.refusée.ToString()));
            query = "Select c.id as ID,c.type as Type,c.etat as Etat,c.date as Date,c.montant as Montant from commande c ,usertiers ut,tiers t where c.idtiers = t.id and t.id = ut.idtiers and ut.idusers = '" + Toolbox.userSession.Id + "' And c.type ='proposition' and c.etat not like '%refu%' and t.id=" + tiers.Id + "";
            Toolbox.loadGridView(dataGridView2, commandeConnect.connection, null, query);
            dataGridView2.Columns[0].Visible = false;

        }
    }
}
