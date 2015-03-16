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
    public partial class formulaire_contact_form : customForm
    {
        public formulaire_contact_form()
        {
            InitializeComponent();
            initcomponent(panelContact);
        }

        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
            chargement_combo_tiers();
            combo_nom_tiers.SelectedIndex = 0;
        }

        private void creation_contact(object sender, EventArgs e)
        {
            if ((nom_contact.Text != "") && (prenom_contact.Text != "") && (telephone_contact.Text != "") && (portable_contact.Text != "") && (mail_contact.Text != "") && (fonction_contact.Text != "") && (commentaire_contact.Text != ""))
            {
                string nom = nom_contact.Text;
                string prenom = prenom_contact.Text;
                string telephone = telephone_contact.Text;
                string portable = portable_contact.Text;
                string mail = mail_contact.Text;
                DateTime anniversaire = date_anniv_contact.Value;
                string date = anniversaire.ToString("yyyy-MM-dd HH:mm:ss");
                string fonction = fonction_contact.Text;
                string commentaire = commentaire_contact.Text;
                string combo_tiers = combo_nom_tiers.Text;

                contactConnect contactConnect = new contactConnect();
                string id_str = contactConnect.SelectWhereContact("id", "nom", "tiers", combo_tiers);
                int id = Convert.ToInt32(id_str);
                contact contact = new contact(id, nom, prenom, telephone, portable, mail, date, fonction, commentaire);
                contactConnect.InsertContact(contact);

                MessageBox.Show("Le contact a bien été crée");
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les informations obligatoires (*)");
            }
        }

        private void chargement_combo_tiers()
        {
            contactConnect contactConnect = new contactConnect();
            List<string> retour = contactConnect.Select("nom", "tiers");
            foreach(string data in retour)
            {
                combo_nom_tiers.Items.Add(data);
            }
        }
    }
}
