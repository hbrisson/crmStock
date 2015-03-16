using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    public partial class formulaire_user : customForm
    {
        public formulaire_user()
        {
            InitializeComponent();
            initcomponent(panelUser);
            
        }

        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
            statut_user_load();
        }

        private void statut_user_load()
        {
            foreach (var statut in Enum.GetValues(typeof(statut)))
            {
                statut_user.Items.Add(statut.ToString());  
            }

            statut_user.SelectedIndex = 0;

        }

        private void ajouter_user_Click(object sender, EventArgs e)
        {

            // Création des variables du formulaire User
            UserConnect db = new UserConnect();
            string nom = nom_user.Text.ToString();
            string prenom = prenom_user.Text.ToString();
            string identifiant = identifiant_user.Text.ToString();
            statut statut = (statut) statut_user.SelectedIndex;
            string mdp = mdp_user.Text.ToString();
            using (MD5 mdpHash = MD5.Create())

            // Si tous les champs du formulaire sont remplis d'au moins un caractère
            if (nom == String.Empty || prenom == String.Empty || identifiant == String.Empty || mdp == String.Empty)
            {
                MessageBox.Show("Erreur ! Tous les champs sont obligatoire !");
            }
            // Si l'identifiant saisi existe déjà dans la BDD
            else if (db.IdentifiantExistant(identifiant))
            {
                MessageBox.Show("Erreur ! L'identifiant saisi existe déjà, Vous devez saisir un autre identifiant !");
            }
            else
            {

                // Cryptage du mot de passe de l'utilisateur
                string hash = Toolbox.GetMd5Hash(mdpHash, mdp);
                user user = new user(nom, prenom, statut, identifiant, hash);
                db.InsertUser(user);
                MessageBox.Show("L'utilisateur a été enregistré avec succès !");
                
            }

        }

    }
}
