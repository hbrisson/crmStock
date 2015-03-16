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
    public partial class formulaire_user_supprimer : customForm
    {
        public formulaire_user_supprimer()
        {
            InitializeComponent();
            initcomponent(panelUser);
            
        }

        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
            identifiant_user_load();
        }

        private void identifiant_user_load()
        {

            UserConnect db = new UserConnect();
            List<string> listIdentifidant = db.afficheUsersSaufActif("identifiant");
            int compt = 0;

            foreach (var identifiant in listIdentifidant)
            {
                if (compt == 0)
                {
                    identifiant_user.Items.Add("Sélectionnez l'identifiant");
                    compt++;
                }
                identifiant_user.Items.Add(identifiant);
            }

            identifiant_user.SelectedIndex = 0;

        }

        private void supprimer_user_Click(object sender, EventArgs e)
        {
            if (identifiant_user.Text != "Sélectionnez l'identifiant")
            {

                UserConnect db = new UserConnect();
                db.DeleteUser(identifiant_user.Text);
                identifiant_user.Items.Clear();
                identifiant_user_load();
                MessageBox.Show("L'utilisateur a été supprimé avec succès !");

            }
            else
            {
                MessageBox.Show("Vous n'avez pas sélectionné l'identifiant !");
            }
        }

        private void identifiant_user_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (identifiant_user.Text != "Sélectionnez l'identifiant")
            {

                UserConnect db = new UserConnect();
                user user = new user();
                user = db.getUser(identifiant_user.Text);
                nom_user.Text = user.Nom;
                prenom_user.Text = user.Prenom;


            }
            else
            {

                nom_user.Text = "";
                prenom_user.Text = "";

            }
        }
    }
}
