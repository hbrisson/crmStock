using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    class Toolbox
    {
        
        public static user userSession;
        public static bool assignation = false;
        public static string assignation_user = "";
        public static List<tiers> assignation_list = new List<tiers>();
        public static bool user_delete = false;

        //Methode permettant la fermeture de tous les forms
        static public void fermer_form()
        {
            FormCollection fc = Application.OpenForms;
            if (fc != null && fc.Count > 0)
            {
                for (int i = 1; i < fc.Count; i++)
                {
                    if (fc[i] != null && fc[i].IsDisposed != true)
                    {
                        fc[i].Dispose();
                    }
                }
            }
        }

        static public bool MD5(MD5 mdpCrypt,string name)
        {
            string mdp;
            mdp=GetMd5Hash(mdpCrypt,name);
            return VerifyMd5Hash(mdpCrypt, name, mdp);
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
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

        // Verify a hash against a string.
        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
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

        public static List<tiers> cbTiers(ComboBox cb, commandeConnect cc)
        {
            cb.Items.Clear();
  
            List<tiers> listTiers = cc.getAllTiersByUser(Toolbox.userSession.Id.ToString());

            foreach (tiers tiers in listTiers)
            {
                cb.Items.Add(tiers.Nom);
            }
            return listTiers;
        }

        public static List<produit> cbProduits(ComboBox cb, commandeConnect cc)
        {
            cb.Items.Clear();
            List<produit> listProduits = cc.getAllProduits();

            foreach (produit produit in listProduits)
            {
                cb.Items.Add(produit.Nom);
            }

            return listProduits;
        }

        public static List<user> cbUsers(ComboBox cb, UserConnect cc)
        {
            cb.Items.Clear();
            var delete_user = Toolbox.assignation_user;
            List<user> listUsers = cc.getAllUsers();

            foreach (user user in listUsers)
            {
                if (user.Identifiant != delete_user)
                {
                    cb.Items.Add(user.Identifiant);
                }
            }
            return listUsers;
        }

        public static void cbEtat(ComboBox cb,string type)
        {
            cb.Items.Clear();
            if (type.Equals(type_action.proposition.ToString()))
            {
                cb.Items.Add(etat_prop.envoyée.ToString());
                cb.Items.Add("en cours de négociation");
                cb.Items.Add(etat_prop.validée.ToString());
                cb.Items.Add(etat_prop.refusée.ToString());
            }
            else if (type.Equals(type_action.commande.ToString()))
            {
                cb.Items.Add("à facturer");
                cb.Items.Add("en cours de livraison");
                cb.Items.Add("en préparation");
                cb.Items.Add("en cours de production");
            }
            else
            {
                cb.Items.Add(etat_prop.envoyée.ToString());
                cb.Items.Add("en cours de négociation");
                cb.Items.Add(etat_prop.validée.ToString());
                cb.Items.Add(etat_prop.refusée.ToString());
                cb.Items.Add("à facturer");
                cb.Items.Add("en cours de livraison");
                cb.Items.Add("en préparation");
                cb.Items.Add("en cours de production");
            }
            
        }

        public static void cbType(ComboBox cb){
            cb.Items.Clear();
            cb.Items.Add(type_action.proposition.ToString());
            cb.Items.Add(type_action.commande.ToString());
        }

        public static void loadGridView(DataGridView dataGridView,MySqlConnection connection,string where,string selectSql)
        {
            string reqsql;
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            reqsql = selectSql + where ;
            adapter.SelectCommand = new MySqlCommand(reqsql,connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = table;
            dataGridView.DataSource = bsource;

        }

    }
}
