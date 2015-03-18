using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    public partial class top_info : customForm
    {
        private string query_user = " SELECT u.nom, u.prenom, (SELECT COUNT(*) FROM usertiers ut WHERE ut.idusers = u.id) AS Nbtiers, COUNT(c.id) AS NbCommande, SUM(c.montant) AS Montant_Total FROM user u, usertiers ut, commande c, tiers t WHERE u.id = ut.idusers AND ut.idtiers = t.id AND t.id = c.idtiers  GROUP BY ut.idusers";
        private string query_cmd = "Select t.nom as NomTiers,c.type as Type,c.etat as Etat,c.date as Date,p.nom as NomProduit,p.prix as Prix,cp.quantite as Quantite,c.montant as Montant from commande c ,usertiers ut ,commandeproduit cp ,produit p ,tiers t where c.idtiers = t.id and t.id = ut.idtiers and c.id = cp.idcommande and cp.idproduit = p.id AND c.etat != 'refusée' AND c.etat != 'validée' AND c.etat != 'annulée'";
        private string query_top_client = "SELECT t.id, t.nom, t.secteur, t.type, SUM(c.montant) AS Somme FROM commande c, tiers t WHERE c.idtiers = t.id GROUP BY idtiers ORDER BY Somme DESC";
        private string query_top_produit = "SELECT p.id, p.nom, p.quantite, SUM(cp.idproduit) AS NbCommandes, cp.idcommande, SUM(c.montant) AS MontantTotal FROM produit p, commandeproduit cp, commande c WHERE p.id = cp.idproduit AND c.id = cp.idcommande GROUP BY idproduit ORDER BY NbCommandes DESC";

        public top_info()
        {
            topInfoConnect accueilConnect = new topInfoConnect();
            InitializeComponent();
            initcomponent(panel1);
            Toolbox.loadGridView(dataGridView1, accueilConnect.connection, null, query_user);

        }

        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
        }

        private void Users_info_Click(object sender, EventArgs e)
        {
            topInfoConnect accueilConnect = new topInfoConnect();

            Toolbox.loadGridView(dataGridView1, accueilConnect.connection, null, query_user);
        }

        private void cmd_en_cours_Click(object sender, EventArgs e)
        {
            topInfoConnect accueilConnect = new topInfoConnect();

            Toolbox.loadGridView(dataGridView1, accueilConnect.connection, null, query_cmd);
        }

        private void nb_cmd_Click(object sender, EventArgs e)
        {
            topInfoConnect accueilConnect = new topInfoConnect();
            CultureInfo anglais = CultureInfo.GetCultureInfo("zh-CN");
            CultureInfo francais = CultureInfo.GetCultureInfo("fr-FR");

            //On initialise la date d'aujourd'hui ainsi que la date de comparaison
            DateTime date = DateTime.Today;
            var str_date = date.ToShortDateString();
            DateTime intervalle = date.AddMonths(-1);
            var str_intervalle = intervalle.ToShortDateString();

            //On met la date au format nécéssaire AAAA/MM/DD
            string dateEnAnglais = DateTime.Parse(str_date, francais).ToString(anglais);
            string dateEnAnglais_intervalle = DateTime.Parse(str_intervalle, francais).ToString(anglais);

            //On ne garde que la date
            string[] Words = dateEnAnglais.Split(new char[] { ' ' });
            dateEnAnglais = Words[0];
            string[] Words_inter = dateEnAnglais_intervalle.Split(new char[] { ' ' });
            dateEnAnglais_intervalle = Words_inter[0];

            //On effectue la requete et on remplit le tableau
            string query_lastcmd = "Select t.nom as NomTiers,c.type as Type,c.etat as Etat,c.date as Date,p.nom as NomProduit,p.prix as Prix,cp.quantite as Quantite,c.montant as Montant from commande c ,usertiers ut ,commandeproduit cp ,produit p ,tiers t where c.idtiers = t.id and t.id = ut.idtiers and c.id = cp.idcommande and cp.idproduit = p.id AND c.date BETWEEN '" + dateEnAnglais_intervalle + "' AND '" + dateEnAnglais + "'";
            Toolbox.loadGridView(dataGridView1, accueilConnect.connection, null, query_lastcmd);
        }

        private void top_customer_Click(object sender, EventArgs e)
        {
            topInfoConnect accueilConnect = new topInfoConnect();
            Toolbox.loadGridView(dataGridView1, accueilConnect.connection, null, query_top_client);
            dataGridView1.Columns[0].Visible = false;
        }

        private void top_produits_Click(object sender, EventArgs e)
        {
            topInfoConnect accueilConnect = new topInfoConnect();
            Toolbox.loadGridView(dataGridView1, accueilConnect.connection, null, query_top_produit);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

    }
}