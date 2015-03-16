using MySql.Data.MySqlClient;
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
    public partial class consultation_commande_form : customForm
    {

        private string whereTiers;
        private string whereProduits;
        private string whereEtat;
        private string whereType;
        private String selectSql = "Select c.id as ID,t.nom as Tiers,c.type as Type,c.etat as Etat,c.date as Date,c.montant as Montant from commande c ,usertiers ut,tiers t where c.idtiers = t.id and t.id = ut.idtiers and ut.idusers = '" + Toolbox.userSession.Id + "'";
        private List<produit> listProduits = new List<produit>();
        private List<commandeProduit> listCommandeProduit = new List<commandeProduit>();
        private commande currentCommande = new commande();
        private commandeProduit currentCommandeProduit;
        private produit currentProduit;
        private tiers currentTiers;
        private commandeConnect commandeConnect;
        private bool isSelected;

        public consultation_commande_form()
        {
            InitializeComponent();
            commandeConnect = new commandeConnect();
            initcomponent(panelCommande);
        }

        #region initialisation du formulaire

        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
            initGridView(null);
            initCombobox();
        }

        private void initGridView(string where)
        {
            Toolbox.loadGridView(dataCommande, commandeConnect.connection, where, selectSql);
            dataCommande.Columns[0].Visible = false;
        }

        private void initCombobox()
        {
            Toolbox.cbTiers(tiers_cb, commandeConnect);
            Toolbox.cbType(type_cb);
            Toolbox.cbEtat(etat_cb,"");
        }
        #endregion

        private void initFicheProduit(string tiers, string type, string sumProd,string montant,int index_local)
        {
            tiers_lbl.Visible = true;
            type_lbl.Visible = true;
            nbprod_lbl.Visible = true;
            montant_lbl.Visible = true;
            tiers_lbl.Text = tiers;
            type_lbl.Text = type;
            nbprod_lbl.Text = sumProd;
            montant_lbl.Text = montant + "Euros";
            if (currentCommande.Type.Equals(type_action.commande))
            {
                client_ck.Checked = true;
            }
            else {
                client_ck.Checked = false;
            }

            Toolbox.cbEtat(etat_cmd_cb,currentCommande.Type.ToString());
            if (index_local != -1)
            {
                etat_cmd_cb.Text = dataCommande.Rows[index_local].Cells[3].Value.ToString();
            }
            else
            {
                etat_cmd_cb.Text = currentCommande.Etat_prop.ToString();
            }
            
            client_ck.Enabled = false;
            cmdValid_bt.Enabled = true;
        }

        private void initAjouterProduit(bool isSelected){
            
            if (!isSelected)
            {
                listProduits.Clear();
                listProduits = Toolbox.cbProduits(produit_cb, commandeConnect);
                produit_cb.Enabled = true;
            }
            else
            {
                produit_cb.Text = currentProduit.Nom;
                produit_cb.Enabled = false;
                produit_cb_SelectedIndexChanged(null, null);
            }
            
            
        }

        private bool sauvegarderProduit()
        {
            if (!memeProduitAjouter(currentProduit.Id))
            {
                commandeProduit commandeProduit = new commandeProduit(currentCommande.Id, currentProduit.Id,Convert.ToInt32(quantite_cb.Text));
                commandeConnect.gestionCommande(commandeProduit);
                listCommandeProduit.Add(commandeProduit);
                currentCommande.Montant = calculMontant();
                commandeConnect.updateCommande(currentCommande);
                MessageBox.Show("Votre produit a été ajouté à la commande", "Commande");
                return true;
            }

            return false;

        }

        private Boolean memeProduitAjouter(int idProduit)
        {
            int i = 0;
            if (listCommandeProduit != null)
            {
                foreach (commandeProduit commandeProduit in listCommandeProduit)
                {
                    if (commandeProduit.Idproduit == idProduit)
                    {
                        MessageBox.Show("Ce Produit a déjà été ajouté à la commande", "Commande Erreur");
                    
                        return true;
                    }
                    i++;
                }
            }
            return false;
        }

        private void cbComportement(ComboBox cb, string titre, int size)
        {
            cb.Items.Add(titre);
            cb.SelectedIndex = size;
        }

        private double calculMontant(){
            string dec = currentTiers.Numero_tva.Replace(".", ",");
            double tvaTotal = (Convert.ToDouble(dec) / 100);
            double montant = 0;

            foreach (commandeProduit cmdProduit in listCommandeProduit)
            {
               int qte = cmdProduit.Quantite;
               produit prod = new produit();
               prod = commandeConnect.getProduitByID(cmdProduit.Idproduit.ToString());
               montant += qte * prod.Prix;
            }

            montant = montant + (tvaTotal * montant);
            return montant;
             
    }

        private void loadListView(int id)
        {
            int i = 0;

            listProduits.Clear();
            listView1.Clear();
            currentCommande = commandeConnect.getCommandeByID(id);
            listCommandeProduit = commandeConnect.getCommandeProduitsByID(id);
            foreach (commandeProduit cmdProduit in listCommandeProduit)
            {
                listProduits.Add(commandeConnect.getProduitByID(cmdProduit.Idproduit.ToString()));
                produit produit = listProduits[i];
                listView1.Items.Add(produit.Nom);
                i++;
            }
        }

        private void clearControls()
        {
            prix_txb.Clear();
            montant_txb.Clear();
            quantite_cb.Items.Clear();
            produit_cb.Enabled = false;
            quantite_cb.Enabled = false;
            modifier_btn.Enabled = false;
            supprimer_btn.Enabled = false;
        }

        private void tiers_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            whereTiers = "and t.nom ='" + tiers_cb.Text.ToString() + "' ";
            initGridView(whereTiers + whereProduits + whereType + whereEtat);
        }

        private void etat_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            whereEtat = "and c.etat ='" + etat_cb.Text + "'";
            initGridView(whereTiers + whereProduits + whereType + whereEtat);
        }

        private void type_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            whereType = "and c.type ='" + type_cb.Text + "'";
            etat_cb.Items.Clear();
            Toolbox.cbEtat(etat_cb, type_cb.Text);
            initGridView(whereTiers + whereProduits + whereType + whereEtat);

        }

        private void produit_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirQuantiteCb(isSelected);
        }

        private void quantite_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (quantite_cb.Text != "Quantité")
            {
                quantite_cb.Items.Remove("Quantité");
                int qte = Convert.ToInt32(quantite_cb.Text);
                double montant = qte * currentProduit.Prix;
                montant_txb.Text = montant.ToString();
                if (!isSelected)
                {
                    Ajout_prod_bt.Enabled = true;
                }
                
            }
        }

        private void reinitialiser_btn_Click(object sender, EventArgs e)
        {
            whereEtat = "";
            whereProduits = "";
            whereTiers = "";
            whereType = "";
            etat_cb.Text = "Etat";
            type_cb.Text = "Type";
            tiers_cb.Text = "Tiers";
            initcomponent(panelCommande);
        }

        private void dataCommande_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index_local = dataCommande.CurrentRow.Index;
            int id = int.Parse(dataCommande.Rows[index_local].Cells[0].Value.ToString());
            loadListView(id);
            clearControls();
            initFicheProduit(dataCommande.Rows[index_local].Cells[1].Value.ToString(), currentCommande.Type.ToString(), listProduits.Count.ToString(), currentCommande.Montant.ToString(), index_local);
            currentTiers = commandeConnect.SelectWhereTiers("*", "tiers", "nom", tiers_lbl.Text);
            listView1.Enabled = false;
            if (currentCommande.Type.Equals(type_action.proposition))
            {
                isSelected = false;
                initAjouterProduit(isSelected);
                listView1.Enabled = true;
            }
            
        }

        private void cmdValid_bt_Click(object sender, EventArgs e)
        {
            if (etat_cmd_cb.Text.Equals(etat_prop.validée.ToString()))
            {
                currentCommande.Type = type_action.commande;
                currentCommande.Etat_commande = currentCommande.getEtatCommande("en cours de production");
                commandeConnect.updateTiers(currentTiers);
            }
            else if (type_action.commande.Equals(currentCommande.Type))
            {
                currentCommande.Etat_commande = currentCommande.getEtatCommande(etat_cmd_cb.Text);
            }
            else
            {
                currentCommande.Etat_prop = currentCommande.getEtatProp(etat_cmd_cb.Text);
            }
            currentCommande.Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            commandeConnect.updateCommande(currentCommande);
            MessageBox.Show("La commande a bien été modifié");
            initGridView("");
        }

        private void Ajout_prod_bt_Click(object sender, EventArgs e)
        {
            if (sauvegarderProduit())
            {
                reloadForm();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string produitNom = listView1.FocusedItem.Text;
            currentProduit = new produit().getCurrentProduit(listProduits, produitNom);
            currentCommandeProduit = new commandeProduit().getCurrentCmdProduit(listCommandeProduit, currentProduit.Id);
            isSelected = true;
            modifier_btn.Enabled = true;
            supprimer_btn.Enabled = true;
            Ajout_prod_bt.Enabled = false;
            initAjouterProduit(isSelected);
        }

        private void remplirQuantiteCb(bool isSelected)
        {
            if (!isSelected)
            {
                currentProduit = new produit().getCurrentProduit(listProduits, produit_cb.Text);
                cbComportement(quantite_cb, "Quantité", 0);  
            }
                quantite_cb.Enabled = true;
                quantite_cb.Items.Clear();
                for (int i = 1; i <= currentProduit.Quantite; i++)
                {
                    quantite_cb.Items.Add(i);
                }
                prix_txb.Text = currentProduit.Prix.ToString();

                if (isSelected)
                {
                    quantite_cb.Text = currentCommandeProduit.Quantite.ToString();
                    montant_txb.Text = (currentProduit.Prix * currentCommandeProduit.Quantite).ToString();
                }
        }

        private void modifier_btn_Click(object sender, EventArgs e)
        {
            int i=0;
            int qte = currentCommandeProduit.Quantite;
            
            currentCommandeProduit.Quantite = Convert.ToInt32(quantite_cb.Text.ToString());
            
            foreach (commandeProduit cmdProduit in listCommandeProduit)
            {
                if (cmdProduit.Idproduit == currentCommandeProduit.Idproduit)
                {
                    commandeConnect.updateProduit(qte, cmdProduit.Idproduit, "+");
                    listCommandeProduit.RemoveAt(i);
                    break;
                }
                i++;
            }

            listCommandeProduit.Add(currentCommandeProduit);
            currentCommande.Montant = calculMontant();
            commandeConnect.updateCommande(currentCommande);
            commandeConnect.updateCommandeProduit(currentCommandeProduit);
            commandeConnect.updateProduit(currentCommandeProduit.Quantite, currentCommandeProduit.Idproduit, "-");
            reloadForm();
            MessageBox.Show("La modification du produit a été effectuée");
        }

        private void reloadForm()
        {

            initGridView(null);
            initFicheProduit(currentTiers.Nom, currentCommande.Type.ToString(), listProduits.Count.ToString(), currentCommande.Montant.ToString(), -1);
            loadListView(currentCommande.Id);
            clearControls();
        }

        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (commandeProduit cmdProduit in listCommandeProduit)
            {
                if (cmdProduit.Idproduit == currentCommandeProduit.Idproduit)
                {
                    break;
                }
                i++;
            }
            if (listCommandeProduit.Count != 1)
            {
                commandeConnect.updateProduit(currentCommandeProduit.Quantite, currentCommandeProduit.Idproduit, "+");
                commandeConnect.deleteCommandeProduit(currentCommandeProduit);
                listCommandeProduit.RemoveAt(i);
                reloadForm();
                MessageBox.Show("Le produit a été supprimé de la commande");
            }
            else
            {
                MessageBox.Show("vous ne pouvez pas supprimer ce produit car il n'y a plus que ce produit dans cette commande");
            }

            

        }

    }
}
