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
    public partial class information_user : customForm
    {
        public information_user()
        {
            InitializeComponent();
            initcomponent(panelUser);
           
        }

        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
            info_user_load("nom", nom_user);
            info_user_load("prenom", prenom_user);
            info_user_load("statut", statut_user);
            info_user_load("identifiant", identifiant_user);
        }

        private void info_user_load(string champ, TextBox name)
        {
             UserConnect db = new UserConnect();
             name.Text = (string) db.afficheInfoUser(champ);
        }

        // Méthode pour la modification du mot de passe d'un utilisateur
        private void modifierMdp_user_Click(object sender, EventArgs e)
        {
            // Si le nouveau mot de passe et la confirmation du nouveau de passe
            if (mdp_user.Text.ToString() == String.Empty || mdpConfirm_user.Text.ToString() == String.Empty)
            {
                MessageBox.Show("Erreur ! Au moins l'un des mots de passe n'a pas été saisi !");
            }
            // Si les 2 mots de passe saisis sont différents
            else if (mdp_user.Text.ToString() != mdpConfirm_user.Text.ToString())
            {
                MessageBox.Show("Erreur ! Les 2 mots de passe saisis sont différents");
            }
            else
            {
                string hash ;
                string mdp = mdp_user.Text.ToString();
                string identifiant = identifiant_user.Text.ToString();
                using (MD5 mdpCrypt = MD5.Create())
                // Cryptage du mot de passe de l'utilisateur
                hash = GetMd5Hash(mdpCrypt, mdp);

                UserConnect db = new UserConnect();
                db.UpdateMdpUser(hash, identifiant);
                MessageBox.Show("Le mot de passe a été modifié avec succès !");

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = mdp_user;
        }

        // Méthode pour crypter un élément
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }

        // Vérification du cryptage d'un élément 
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input. 
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
