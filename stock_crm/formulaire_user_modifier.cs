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
    public partial class formulaire_user_modifier : customForm
    {
        public assignationNouvCommercial assignationNouvCommercial;
        private UserConnect db;
        private List<user> listUsers;

        public formulaire_user_modifier()
        {
            InitializeComponent();
            initcomponent(panelUser);
            
        }

        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
            info_user_load("nom", nom_user);
            info_user_load("prenom", prenom_user);
            info_user_load("identifiant", nouv_identifiant_user);
            statut_user_load();
            identifiant_user_load();
        }

        private void identifiant_user_load()
        {
        
            UserConnect db = new UserConnect();
            List<string> listIdentifidant = db.afficheUsersSaufActif("identifiant");
            listUsers = db.getAllUsers();

            identifiant_user.Items.Add("Sélectionnez l'identifiant");
            foreach (user user in listUsers)
            {
                identifiant_user.Items.Add(user.Identifiant);
             }

            identifiant_user.SelectedIndex = 0;

        }

        private void statut_user_load()
        {
            foreach (var statut in Enum.GetValues(typeof(statut)))
            {
                statut_user.Items.Add(statut.ToString());
            }

            statut_user.SelectedIndex = 0;

        }

        private void info_user_load(string champ, TextBox name)
        {
             db = new UserConnect();
            name.Text = (string)db.afficheInfoUser(champ);
        }

        private void modifier_user_Click(object sender, EventArgs e)
        {
            // Si l'identifiant est vide
            if (nouv_identifiant_user.Text.ToString() == String.Empty)
            {
                MessageBox.Show("Erreur ! L'identifiant n'a pas été saisi !");
            }
            else
            {
                statut statut = (statut)statut_user.SelectedIndex;
                user user = new user();
                user = compareUser(listUsers, identifiant_user.Text);
                int id = user.Id;
                string identifiant = nouv_identifiant_user.Text.ToString();
                
                UserConnect db = new UserConnect();
                db.UpdateUser(id, statut, identifiant);
                MessageBox.Show("L'utilisateur a été modifié avec succès !");

            }
        }

        private user compareUser(List<user> users, string name)
        {
            foreach (user user in users)
            {
                if (user.Identifiant == name)
                {
                    return user;
                }
            }
            return null;
        }

        private void identifiant_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (identifiant_user.Text != "Sélectionnez l'identifiant")
            {
                supprimer_user.Visible = true;
                user user = new user();
                user = compareUser(listUsers, identifiant_user.Text);
                nom_user.Text = user.Nom;
                prenom_user.Text = user.Prenom;
                nouv_identifiant_user.Text = user.Identifiant;
                statut_user.SelectedItem = user.Statut.ToString();
                // GW : Si l'utilisateur 
                if (Toolbox.userSession.Id == user.Id)
                {
                    supprimer_user.Visible = false;
                }

            }
            else
            {

                nom_user.Text = "";
                prenom_user.Text = "";
                nouv_identifiant_user.Text = "";

            }
        }

        private void assignationCommercial(object sender, EventArgs e)
        {
            
        }

        private void supprimer_user_Click(object sender, EventArgs e)
        {
            if (identifiant_user.Text != "Sélectionnez l'identifiant")
            {

                         
                UserConnect db = new UserConnect();
                user user = db.getUser(identifiant_user.Text);

                string query = "SELECT id, nom FROM tiers b WHERE id IN ( SELECT idtiers FROM usertiers WHERE idusers = '" + user.Id + "')";
                List<tiers> list_tiers = new List<tiers>();
                list_tiers = db.getAllTiers(query);

                db.DeleteUser(identifiant_user.Text);
                identifiant_user.Items.Clear();
                identifiant_user_load();
                MessageBox.Show("L'utilisateur a été supprimé avec succès !");
                if (list_tiers.Count != 0)
                {
                    Toolbox.assignation = true;
                    Toolbox.assignation_list = list_tiers;
                    Toolbox.assignation_user = user.Identifiant;

                }
                else
                {
                    Toolbox.user_delete=true;

                }
                this.Close();


            }
            else
            {
                MessageBox.Show("Vous n'avez pas sélectionné l'identifiant !");
            }
        }
    }
}
