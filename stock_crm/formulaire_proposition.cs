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

    public partial class formulaire_proposition : customForm
    {
        private List<produit> listProduits;
        private List<tiers> listTiers;
        private commandeConnect commandeConnect;
        private double montant;
        private double montantTotal;
        private int qte;
        private produit currentProduit;
        private tiers currentTiers;
        private List<commande> listCommandes;
        private List<commandeProduit> listCommandeProduits;
        private int rows = 1;

        public formulaire_proposition()
        {

            InitializeComponent();
            initcomponent(panelCommande);
        }

        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
            commandeConnect = new commandeConnect();
            labelVisible(false);
            initCombobox();
            listCommandeProduits = new List<commandeProduit>();
            listCommandes = new List<commande>();
            commandeValid.Enabled = false;
        }

        private void labelVisible(bool visible)
        {
            tiers_resulat_lbl.Visible = visible;
            produit_resultat_lbl.Visible = visible;
            prix_unit_resultat_lbl.Visible = visible;
            quantite_resultat_lbl.Visible = visible;
            montant_resultat_lbl.Visible = visible;
            tva_resultat_lbl.Visible = visible;
            qte_dispo_lbl.Visible = visible;
            montant_total_resultat_lbl.Visible = visible;

        }

        private void initCombobox()
        {

            listTiers = Toolbox.cbTiers(tiers_cb, commandeConnect);
            listProduits = Toolbox.cbProduits(produit_cb, commandeConnect);
            quantite_cb.Enabled = false;
            cbComportement(tiers_cb, "Tiers", listTiers.Count());
            cbComportement(produit_cb, "Produit", listProduits.Count());

        }

        private void tiers_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tiers_cb.Text != "Tiers")
            {
                tiers_cb.Items.Remove("Tiers");

                currentTiers = new tiers().getCurrentTiers(listTiers, tiers_cb.Text);
                tiers_resulat_lbl.Visible = true;
                tiers_resulat_lbl.Text = currentTiers.Nom;

                tva_resultat_lbl.Visible = true;
                tva_resultat_lbl.Text = currentTiers.Numero_tva + " %";
            }

        }

        private void produit_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (produit_cb.Text != "Produit")
            {
                produit_cb.Items.Remove("Produit");
                quantite_cb.Enabled = true;

                currentProduit = new produit().getCurrentProduit(listProduits, produit_cb.Text);

                produit_resultat_lbl.Visible = true;
                produit_resultat_lbl.Text = currentProduit.Nom;

                prix_unit_resultat_lbl.Visible = true;
                prix_unit_resultat_lbl.Text = currentProduit.Prix.ToString() + " Euros";

                quantite_cb.Items.Clear();
                cbComportement(quantite_cb, "Quantité", 0);
                for (int i = 1; i <= currentProduit.Quantite; i++)
                {
                    quantite_cb.Items.Add(i);
                }
                int dispo = quantite_cb.Items.Count-1;
                qte_dispo_lbl.Text = dispo.ToString();
                qte_dispo_lbl.Visible = true;
            }
        }

        private void quantite_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (quantite_cb.Text != "Quantité")
            {
                quantite_cb.Items.Remove("Quantité");

                quantite_resultat_lbl.Visible = true;
                qte = Convert.ToInt32(quantite_cb.Text);
                quantite_resultat_lbl.Text = qte.ToString();
                montant = currentProduit.Prix * qte;
                montant_resultat_lbl.Visible = true;
                montant_resultat_lbl.Text = montant.ToString() + " Euros";
            }
            
        }

        private void valider_btn_Click(object sender, EventArgs e)
        {
            sauvegarderProduit();
            commandeValid.Enabled = true;

        }

        private void commandeValid_Click(object sender, EventArgs e)
        {
            sauvegarderCommande();
            imprimer_btn.Enabled = true;
        }

        private void calculMontantTotal(string tva)
        {
            if (montant_resultat_lbl.Visible && tva_resultat_lbl.Visible)
            {
                if (!"".Equals(tva))
                {
                    string dec = currentTiers.Numero_tva.Replace(".", ",");
                    montantTotal = 1 + (Convert.ToDouble(dec) / 100);
                    montantTotal = montantTotal * montant; 
                }
                else
                {
                    montant = currentProduit.Prix * qte;
                    montant_resultat_lbl.Text = montant.ToString() + " Euros";
                }

                montantTotal = Math.Round(montantTotal, 2, MidpointRounding.AwayFromZero);
                montant_total_resultat_lbl.Visible = true;
                montant_total_resultat_lbl.Text = Convert.ToString(montantTotal) + " Euros";
            }
        }

        private void sauvegarderProduit()
        {
            if (!memeProduitAjouter(currentProduit.Id))
            {
               
                ajouterLayout(currentProduit.Nom, currentProduit.Prix.ToString(),qte.ToString());
                montant += montantTotal;
                calculMontantTotal(currentTiers.Numero_tva);
                commandeProduit commandeProduit = new commandeProduit(1, currentProduit.Id, qte);
                listCommandeProduits.Add(commandeProduit);
                MessageBox.Show("Votre produit a été ajouté à la commande", "Commande");
            }
           
               
            
        }

        private void ajouterLayout(String produit,String prix , String qte)
        {
            tableLayoutPanel1.Controls.Add(new Label() { Text = produit, Anchor = AnchorStyles.Left, AutoSize = true }, 0, rows);
            tableLayoutPanel1.Controls.Add(new Label() { Text = prix, Anchor = AnchorStyles.Left, AutoSize = true }, 2, rows);
            tableLayoutPanel1.Controls.Add(new Label() { Text = qte, Anchor = AnchorStyles.Left, AutoSize = true }, 3, rows);
            rows++;
            tableLayoutPanel1.Controls.Add(new Label() { Text = "", Anchor = AnchorStyles.Left, AutoSize = true,Visible=true},0, rows);
        
        }

        private Boolean memeProduitAjouter(int idProduit)
        {
            int i=0;
            if (listCommandeProduits!= null)
            {
                foreach (commandeProduit commandeProduit in listCommandeProduits)
                {
                    if (commandeProduit.Idproduit == idProduit)
                    {
                        if (MessageBox.Show("Ce Produit a déjà été ajouté à la commande.\n Voulez vous le modifier ?", "Commande Erreur", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            listCommandes.RemoveAt(i);
                            listCommandeProduits.RemoveAt(i);
                        }
                        return true;
                    }
                    i++;
                }
            }

            return false;
        }

        private void sauvegarderCommande()
        {
            commande commande = new commande(1, currentTiers.Id, type_action.proposition, etat_prop.envoyée, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), montantTotal, commentaire_txb.Text);
            try
            {
                commandeConnect.insertCommande(commande);
                int idCommandeProduit = commandeConnect.getIdCommande(currentTiers.Id);
                foreach (commandeProduit cmdProduit in listCommandeProduits)
                {
                    cmdProduit.Idcommand = idCommandeProduit;
                    commandeConnect.gestionCommande(cmdProduit);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("La commande a été effectuée");

        }

        private void cbComportement(ComboBox cb, string titre, int size)
        {
            cb.Items.Add(titre);
            cb.SelectedIndex = size;
        }

        private void imprimer_btn_Click(object sender, EventArgs e)
        {
            facture_form facture_form = new facture_form();
            facture_form.Show();
        }

      

    }
}
