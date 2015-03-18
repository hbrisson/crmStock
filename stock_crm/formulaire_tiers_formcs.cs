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
    public partial class formulaire_tiers_formcs : customForm
    {
        public formulaire_tiers_formcs()
        {
            InitializeComponent();
            initcomponent(panelTiers);

           // TopLevel = false;
        }

        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
            juridique_tiers.SelectedIndex = 0;
            reglement_tiers.SelectedIndex = 0;
            tva_tiers.SelectedIndex = 0;
            pays_tiers.SelectedIndex = 0;
        }

        //On insére le nouveau tiers dans la BDD
        private void creation_tiers_bdd(object sender, EventArgs e)
        {
            //Appel de la méthode de vérification et récupération données du formulaire
            if ((nom_tiers.Text != "") && (siret_tiers.Text != "") && (adresse_livraison_tiers.Text != "") && (adresse_facturation_tiers.Text != "") && (pays_tiers.Text != "") && (naf_tiers.Text != "") && (secteur_activite_tiers.Text != "") && (segment_activite_tiers.Text != ""))
            {
                #region récupération data du formulaire
                string nom = nom_tiers.Text;
                string siret = siret_tiers.Text;
                string adresse_livraison = adresse_livraison_tiers.Text;
                string adresse_facturation = adresse_facturation_tiers.Text;
                DateTime date_paiement = date_paiement_tiers.Value;
                string date = date_paiement.ToString("yyyy-MM-dd HH:mm:ss");
                string telephone = telephone_tiers.Text;
                string code_naf = naf_tiers.Text;
                string fax = fax_tiers.Text;
                string site_web = site_web_tiers.Text;
                string commentaire = commentaire_tiers.Text;
                string secteur = secteur_activite_tiers.Text;
                string segment = segment_activite_tiers.Text;
                DateTime date_etat = DateTime.Now;
                string date_rencontre_ = date_etat.ToString("yyyy-MM-dd HH:mm:ss");
                #endregion

                #region COMBOBOX VALUE
                //On récupére la valeur du juridique
                var juridique_value = juridique_tiers.SelectedItem;
                juridique juridique_data;

                if (juridique_value.Equals("SA"))
                {
                    juridique_data = juridique.SA;
                }
                else if (juridique_value.Equals("SARL"))
                {
                    juridique_data = juridique.SARL;
                }
                else
                {
                    juridique_data = juridique.SAS;
                }

                //On récupére la valeur du réglement
                var reglement_value = reglement_tiers.SelectedItem;
                reglement reglement_data;

                if (reglement_value.Equals("Virement"))
                {
                    reglement_data = reglement.virement;
                }
                else if (reglement_value.Equals("Chèque"))
                {
                    reglement_data = reglement.cheque;
                }
                else
                {
                    reglement_data = reglement.carteBancaire;
                }

                //On récupére la valeur du type de contact
                var type_contact_tiers_ = "";
                etat contact_tiers_enum;

                if (type_contact_tiers_.Equals("Rendez-vous"))
                {
                    contact_tiers_enum = etat.rdv;
                }
                else if (type_contact_tiers_.Equals("Contact téléphonique"))
                {
                    contact_tiers_enum = etat.contact_telephonique;
                }
                else if (type_contact_tiers_.Equals("Rappel"))
                {
                    contact_tiers_enum = etat.rappel;
                }
                else
                {
                    contact_tiers_enum = etat.travail_a_founir;
                }

                //On récupére la tva
                var tva_value = tva_tiers.SelectedItem;
                string tva = Convert.ToString(tva_value);

                //On récupére le pays 
                var pays_value = pays_tiers.SelectedItem;
                string pays = Convert.ToString(pays_value);

                #endregion

                #region BDD
                //Connection et insertion dans la base
                tiers tiers = new tiers(nom, type.prospect, siret, juridique_data, reglement_data, adresse_livraison, adresse_facturation, pays, tva, code_naf, date, telephone, fax, site_web, commentaire, secteur, segment);
                tiersConnect tiersConnect = new tiersConnect();
                tiersConnect.InsertTiers(tiers);

                string id_tiers = tiersConnect.SelectWhereContact("id", "nom", "tiers", nom);
                
                int id_tiers_int = Convert.ToInt32(id_tiers);
                int id_user = Toolbox.userSession.Id;
                usertiers usertiers = new usertiers(id_tiers_int, id_user, contact_tiers_enum, date_rencontre_);
                tiersConnect.InsertUserTiers(usertiers);
                #endregion

                MessageBox.Show("Le tiers a bien été crée");
            }
            else
            {
                MessageBox.Show("Veuillez renseigner tous les champs obligatoires (*)");
            }          
        }
    }
}
