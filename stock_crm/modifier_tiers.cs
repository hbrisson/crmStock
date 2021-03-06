﻿using System;
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
    public partial class modifier_tiers : Form
    {
        private string query = "SELECT b.id, b.nom, b.juridique, b.pays, b.secteur FROM tiers b WHERE b.id IN ( SELECT idtiers FROM usertiers WHERE idusers = '" + Toolbox.userSession.Id + "')";
        private int index_local = 0;
        public modifier_tiers()
        {
            InitializeComponent();
            tiersConnect tiersconnect = new tiersConnect();
            panel_modifier_tiers.Location = new Point(this.ClientSize.Width / 2 - panel_modifier_tiers.Size.Width / 2, this.ClientSize.Height / 2 - panel_modifier_tiers.Size.Height / 2);
            panel_modifier_tiers.Anchor = AnchorStyles.None;
            //remplir_list();

            Toolbox.loadGridView(dataGridView1, tiersconnect.connection, null, query);
            dataGridView1.Columns[0].Visible = false;
        }

        //private void list_tiers_modifier_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string tiers_selectionne = list_tiers_modifier.SelectedItem.ToString();
        //        tiersConnect tiersConnect = new tiersConnect();
        //        tiers tiers_data = tiersConnect.SelectWhereTiers("*", "tiers", "nom", tiers_selectionne);

        //        #region mise des datas dans le formulaire de modification

        //        nom_modifier_tiers.Text = tiers_data.Nom;
        //        siret_modifier_tiers.Text = tiers_data.Siret;
        //        juridique_modifier_tiers.Text = tiers_data.Juridique.ToString();
        //        adresse_livraison_modifier_tiers.Text = tiers_data.Adresse_livraison;
        //        adresse_facturation_modifier_tiers.Text = tiers_data.Adresse_facturation;
        //        pays_modifier_tiers.Text = tiers_data.Pays;
        //        tva_modifier_tiers.Text = tiers_data.Numero_tva;
        //        naf_modifier_tiers.Text = tiers_data.Code_naf;
        //        string reglement_modif_tiers = tiers_data.Reglement.ToString();

        //        if (reglement_modif_tiers.Equals("virement"))
        //        {
        //            reglement_modifier_tiers.Text = "Virement";
        //        }
        //        else if (reglement_modif_tiers.Equals("cheque"))
        //        {
        //            reglement_modifier_tiers.Text = "Chèque";
        //        }
        //        else
        //        {
        //            reglement_modifier_tiers.Text = "Carte Bancaire";
        //        }
        //        DateTime date = Convert.ToDateTime(tiers_data.Delai_paiement);
        //        date_paiement_modifier_tiers.Value = date;
        //        telephone_modifier_tiers.Text = tiers_data.Telephone;
        //        fax_modifier_tiers.Text = tiers_data.Fax;
        //        site_web_modifier_tiers.Text = tiers_data.Site_web;
        //        commentaire_modifier_tiers.Text = tiers_data.Commentaire;
        //        secteur_activite_modifier_tiers.Text = tiers_data.Secteur;
        //        segment_activite_modifier_tiers.Text = tiers_data.Segment;

        //        #endregion
        //    }
        //    catch (Exception ex)
        //    {   
        //        MessageBox.Show( ex.Message);
        //    }

        //}

        private void modifier_tiers_click(object sender, EventArgs e)
        {
            try
            {
                #region récupération data du formulaire
                string nom = nom_modifier_tiers.Text;
                string siret = siret_modifier_tiers.Text;
                string adresse_livraison = adresse_livraison_modifier_tiers.Text;
                string adresse_facturation = adresse_facturation_modifier_tiers.Text;
                DateTime date_paiement = date_paiement_modifier_tiers.Value;
                string date = date_paiement.ToString("yyyy-MM-dd HH:mm:ss");
                string telephone = telephone_modifier_tiers.Text;
                string code_naf = naf_modifier_tiers.Text;
                string fax = fax_modifier_tiers.Text;
                string site_web = site_web_modifier_tiers.Text;
                string commentaire = commentaire_modifier_tiers.Text;
                string secteur = secteur_activite_modifier_tiers.Text;
                string segment = segment_activite_modifier_tiers.Text;
                string str_idtiers = idtiers.Text;
                int int_idtiers = Convert.ToInt32(str_idtiers);

                #endregion

                #region COMBOBOX VALUE
                //On récupére la valeur du juridique
                var juridique_value = juridique_modifier_tiers.SelectedItem;
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
                var reglement_value = reglement_modifier_tiers.SelectedItem;
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

                //On récupére la tva
                var tva_value = tva_modifier_tiers.SelectedItem;
                string tva = Convert.ToString(tva_value);

                //On récupére le pays 
                var pays_value = pays_modifier_tiers.SelectedItem;
                string pays = Convert.ToString(pays_value);

                #endregion

                //UPDATE TIERS
                tiers tiers = new tiers(int_idtiers, nom, type.prospect, siret, juridique_data, reglement_data, adresse_livraison, adresse_facturation, pays, tva, code_naf, date, telephone, fax, site_web, commentaire, secteur, segment);
                tiersConnect tiersConnect = new tiersConnect();
                tiersConnect.UpdateTiers(tiers);              

                MessageBox.Show("La modification a bien été effectué");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

                    nom_modifier_tiers.Text = tiers_data.Nom;
                    siret_modifier_tiers.Text = tiers_data.Siret;
                    juridique_modifier_tiers.Text = tiers_data.Juridique.ToString();
                    adresse_livraison_modifier_tiers.Text = tiers_data.Adresse_livraison;
                    adresse_facturation_modifier_tiers.Text = tiers_data.Adresse_facturation;
                    pays_modifier_tiers.Text = tiers_data.Pays;
                    tva_modifier_tiers.Text = tiers_data.Numero_tva;
                    naf_modifier_tiers.Text = tiers_data.Code_naf;
                    string reglement_modif_tiers = tiers_data.Reglement.ToString();

                    if (reglement_modif_tiers.Equals("virement"))
                    {
                        reglement_modifier_tiers.Text = "Virement";
                    }
                    else if (reglement_modif_tiers.Equals("cheque"))
                    {
                        reglement_modifier_tiers.Text = "Chèque";
                    }
                    else
                    {
                        reglement_modifier_tiers.Text = "Carte Bancaire";
                    }

                    DateTime date = Convert.ToDateTime(tiers_data.Delai_paiement);
                    date_paiement_modifier_tiers.Value = date;
                    telephone_modifier_tiers.Text = tiers_data.Telephone;
                    fax_modifier_tiers.Text = tiers_data.Fax;
                    site_web_modifier_tiers.Text = tiers_data.Site_web;
                    commentaire_modifier_tiers.Text = tiers_data.Commentaire;
                    secteur_activite_modifier_tiers.Text = tiers_data.Secteur;
                    segment_activite_modifier_tiers.Text = tiers_data.Segment;
                    int int_idtiers = tiers_data.Id;
                    idtiers.Text = Convert.ToString(int_idtiers);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void supprimer_tiers_Click(object sender, EventArgs e)
        {
            try
            {
                string id_tiers = dataGridView1.Rows[index_local].Cells[0].Value.ToString();
                var count = dataGridView1.Rows.Count - 1;
                if (index_local < (dataGridView1.Rows.Count - 1))
                {
                    tiers tiers = new tiers();
                    tiersConnect tiersConnect = new tiersConnect();
                    tiers.Id = Convert.ToInt32(idtiers.Text);
                    tiersConnect.DeleteTiers(tiers);

                    MessageBox.Show("Le contact a bien été supprimé");

                    Toolbox.loadGridView(dataGridView1, tiersConnect.connection, null, query);
                    dataGridView1.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("Veuillez séléctionner un tiers a supprimer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
