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
    public partial class modiier_contact:customForm
    {
        private string query = "SELECT c.* FROM contact c, tiers t, usertiers ut WHERE c.idtiers = t.id AND ut.idtiers = t.id AND ut.idusers = '" + Toolbox.userSession.Id + "'";
        private int index_local = 0;

        public modiier_contact()
        {
            InitializeComponent();
            contactConnect contactConnect = new contactConnect();
            //remplir_list();
            initcomponent(panel1);
            Toolbox.loadGridView(dataGridView1, contactConnect.connection, null, query);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[9].Visible = false;      
        }

        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
        }

        private void modifier_contact_Click(object sender, EventArgs e)
        {
            try
            {
                #region Récupération formulaire

                contact contact = new contact();
                contact.Nom = nom_contact_modifier.Text;
                contact.Prenom = prenom_contact_modifier.Text;
                contact.Telephone = telephone_contact_modifier.Text;
                contact.Portable = portable_contact_modifier.Text;
                DateTime datetime = date_anniv_contact_modifier.Value;
                string date = datetime.ToString("yyyy-MM-dd HH:mm:ss");
                contact.Date = date;
                contact.Fonction = fonction_contact_modifier.Text;
                contact.Commentaire = commentaire_contact_modifier.Text;
                contact.Mail = mail_contact_modifier.Text;

                contactConnect contactConnect = new contactConnect();
                string nom_tiers = combo_nom_tiers_modifier.Text;
                string retour = contactConnect.SelectWhereSimple("id", "tiers", "nom", nom_tiers);

                var index = dataGridView1.CurrentRow.Index;
                string id_contact = dataGridView1.Rows[index].Cells[0].Value.ToString();

                int idtiers = Convert.ToInt32(retour);
                int id = Convert.ToInt32(id_contact);
                contact.Idtiers = idtiers;
                contact.Id = id;

                #endregion

                contactConnect.UpdateContact(contact);
                MessageBox.Show("La modification a bien été effectué");

                Toolbox.loadGridView(dataGridView1, contactConnect.connection, null, query);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[9].Visible = false;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sup_contact_Click(object sender, EventArgs e)
        {
            try
            {
                if (index_local < (dataGridView1.Rows.Count - 1))
                {
                    contact contact = new contact();
                    contactConnect contactConnect = new contactConnect();
                    contact.Id = Convert.ToInt32(idcontact.Text);
                    contactConnect.DeleteContact(contact);

                    MessageBox.Show("Le contact a bien été supprimé");
                    Toolbox.loadGridView(dataGridView1, contactConnect.connection, null, query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index_local = dataGridView1.CurrentRow.Index;
            string id_contact = dataGridView1.Rows[index_local].Cells[0].Value.ToString();

            contactConnect contactConnect = new contactConnect();
            contact contact = contactConnect.SelectWhereContactForm("*", "contact", "id", id_contact);
            string idtier_str = Convert.ToString(contact.Idtiers);
            string nom_tiers = contactConnect.SelectWhereSimple("nom", "tiers", "id", idtier_str);

            if (index_local < (dataGridView1.Rows.Count - 1))
            {
                #region On remplit le formulaire en fonction du contact séléctionné

                nom_contact_modifier.Text = contact.Nom;
                prenom_contact_modifier.Text = contact.Prenom;
                telephone_contact_modifier.Text = contact.Telephone;
                portable_contact_modifier.Text = contact.Portable;
                mail_contact_modifier.Text = contact.Mail;
                DateTime anniversaire = Convert.ToDateTime(contact.Date);
                date_anniv_contact_modifier.Value = anniversaire;
                fonction_contact_modifier.Text = contact.Fonction;
                commentaire_contact_modifier.Text = contact.Commentaire;
                idcontact.Text = Convert.ToString(contact.Id);

                List<string> retour = contactConnect.Select("nom", "tiers");
                foreach (string data in retour)
                {
                    combo_nom_tiers_modifier.Items.Add(data);
                }
                combo_nom_tiers_modifier.Text = nom_tiers;
            }
            #endregion
        }
    }
}
