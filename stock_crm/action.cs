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
    public partial class action : Form
    {

        private string query = "SELECT b.id, b.nom, b.juridique, b.pays, b.secteur FROM tiers b WHERE b.id IN ( SELECT idtiers FROM usertiers WHERE idusers = '" + Toolbox.userSession.Id + "')";
        private string query_evenement = "SELECT t.nom AS tiers, c.nom AS Contact, a.nom AS action, a.date, a.commentaire FROM action a, tiers t, contact c, usertiers ut WHERE c.id = a.idcontact AND t.id = c.idtiers AND ut.idtiers = t.id AND ut.idusers = '" + Toolbox.userSession.Id + "' AND a.date >= '" +DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")+ "'";
        private string query_historique = "SELECT t.nom AS tiers, c.nom AS Contact, a.nom AS action, a.date, a.commentaire FROM action a, tiers t, contact c, usertiers ut WHERE c.id = a.idcontact AND t.id = c.idtiers AND ut.idtiers = t.id AND ut.idusers = '" + Toolbox.userSession.Id + "' AND a.date < '" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "'";
        public action()
        {
            InitializeComponent();
            combo_contact.Enabled = false;
            combo_date.Enabled = false;
            combo_heure.Enabled = false;
            combo_minute.Enabled = false;
            comboActions.Enabled = false;
            ajout_action.Enabled = false;
            affichage_tiers();
            affichage_action();
            affichage_evenement();
            affichage_historique();
            init_heure();
        }

        private void init_heure()
        {
            for (int i = 9; i < 20; i++)
            {
                combo_heure.Items.Add(i);
            }

            for (int i = 0; i < 60; i = i + 10)
            {
                combo_minute.Items.Add(i);
            }
        }

        private void affichage_action()
        {
            comboActions.Items.Add("appel telephonique");
            comboActions.Items.Add("rendez-vous");
            comboActions.Items.Add("contact mail");
            comboActions.Items.Add("prise de contact");
        }

        private void affichage_tiers()
        {
            actionConnect actionConnect = new actionConnect();
            List<tiers> list_tiers = actionConnect.selectTiers(query);
            foreach (tiers tiers in list_tiers)
            {
                combo_tiers.Items.Add(tiers.Nom);
            }
        }

        private void affichage_contact(List<contact> list_contact)
        {
            foreach (contact contact in list_contact)
            {
                combo_contact.Items.Add(contact.Nom);
            }
        }

        private void combo_tiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On récupére l'ID du tiers séléctionné
            tiers tiers = new tiers();
            tiersConnect tiersConnect = new tiersConnect();
            string select_tiers = (string)combo_tiers.SelectedItem;
            tiers.Nom = select_tiers;
            tiers = tiersConnect.SelectWhereTiersId("id", "tiers", "nom", tiers.Nom);

            //On récupére les contacts liés au tiers séléctionné
            contact contact = new contact();
            List<contact> list_contact = new List<contact>();
            contactConnect contactConnect = new contactConnect();

            string id_tiers = Convert.ToString(tiers.Id);
            list_contact = contactConnect.SelectWhereContactList("*", "contact", "idtiers", id_tiers);
            affichage_contact(list_contact);

            combo_contact.Enabled = true;
            combo_date.Enabled = true;
            combo_heure.Enabled = true;
            combo_minute.Enabled = true;
            comboActions.Enabled = true;
            ajout_action.Enabled = true;
        }

        private void ajout_action_Click(object sender, EventArgs e)
        {
            //On récupére les éléments
            try
            {
                string nom_tiers = (string)combo_tiers.SelectedItem;
                string contact = (string)combo_contact.SelectedItem;
                string action = (string)comboActions.SelectedItem;
                string date = combo_date.Value.ToString("yyyy-MM-dd");
                int heure = (int)combo_heure.SelectedItem;
                int minute = (int)combo_minute.SelectedItem;
                string commentaire = commentaire_box.Text;

                actionCl actionCl = new actionCl();
                nom nom;
                if (action.Equals("appel telephonique"))
                {
                    nom = nom.appel_telephonique;
                }
                else if (action.Equals("rendez-vous"))
                {
                    nom = nom.rendez_vous;
                }
                else if (action.Equals("contact mail"))
                {
                    nom = nom.contact_mail;
                }
                else
                {
                    nom = nom.prise_de_contact;
                }

                date = date + " " + heure + ":" + minute + ":" + "00";

                //DateTime date_action = Convert.ToDateTime(date);
               

                //On recherche les ids
                contactConnect contactConnect = new contactConnect();
                string id_contact = contactConnect.SelectWhereSimple("id", "contact", "nom", contact);
                int id_contact_int = Convert.ToInt32(id_contact);

                tiersConnect tiersConnect = new tiersConnect();
                tiers tiers = tiersConnect.SelectWhereTiers("*", "tiers", "nom", nom_tiers);
                int idtiers = tiers.Id;

                //On insert dans la table action
                string query_action = "INSERT INTO action(idcontact,idtiers,date,commentaire,nom) VALUES ('" + id_contact_int + "', '" + idtiers + "', '" + date + "', '" + commentaire + "', '" + nom + "')";
                actionConnect actionConnect = new actionConnect();
                actionConnect.insertAction(query_action);

                MessageBox.Show("L'evenement a correctement été crée");

                affichage_evenement();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void affichage_evenement()
        {
            actionConnect actionConnect = new actionConnect();
            Toolbox.loadGridView(dataGridView_a_venir, actionConnect.connection, null, query_evenement);
        }

        private void affichage_historique()
        {
            actionConnect actionConnect = new actionConnect();
            Toolbox.loadGridView(dataGridView_historique, actionConnect.connection, null, query_historique);
        }
    }
}
