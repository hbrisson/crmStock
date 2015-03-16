using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    class DBConnect
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "crm";
            uid = "root";
            password = "toto";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
           
        }

        //open connection to database
        protected bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        protected bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void userTiersChamp(usertiers usertiers, MySqlDataReader dataReader)
        {
            usertiers.Id = (int)dataReader["id"];
            usertiers.Idtiers = (int)dataReader["idtiers"];
            usertiers.Idusers = (int)dataReader["idusers"];
            usertiers.Contact_tiers = (etat)Enum.Parse(typeof(etat), (string)dataReader["etat"]);
            DateTime date_action = (DateTime)dataReader["date_action"];
            usertiers.Date_action = Convert.ToString(date_action);
        }

        protected void tiersChamp(tiers tiers, MySqlDataReader dataReader)
        {
            tiers.Id = (int)dataReader["id"];
            tiers.Nom = (string)dataReader["nom"];
            tiers.Type = (type)Enum.Parse(typeof(type), (string)dataReader["type"]);
            tiers.Siret = (string)dataReader["siret"];
            tiers.Juridique = (juridique)Enum.Parse(typeof(juridique), (string)dataReader["juridique"]);
            tiers.Adresse_livraison = (string)dataReader["adresse_liv"];
            tiers.Adresse_facturation = (string)dataReader["adresse_fact"];
            tiers.Pays = (string)dataReader["pays"];
            tiers.Numero_tva = (string)dataReader["num_tva"];
            tiers.Code_naf = (string)dataReader["code_naf"];
            tiers.Reglement = (reglement)Enum.Parse(typeof(reglement), (string)dataReader["reglement"]);
            DateTime date = (DateTime)dataReader["delai_paiement"];
            tiers.Delai_paiement = Convert.ToString(date);
            tiers.Telephone = (string)dataReader["telephone"];
            tiers.Fax = (string)dataReader["fax"];
            tiers.Site_web = (string)dataReader["web"];
            tiers.Commentaire = (string)dataReader["commentaire"];
            tiers.Secteur = (string)dataReader["secteur"];
            tiers.Segment = (string)dataReader["segment"];
        }

        private void produitChamp(produit produit, MySqlDataReader dataReader)
        {
            produit.Id = (int)dataReader["id"];
            produit.Nom = (string)dataReader["nom"];
            produit.Prix=(double)dataReader["prix"];
            produit.Quantite=(int)dataReader["quantite"];

        }

        public List<tiers> getAllTiersByUser(string idUser)
        {

            //Create a list to store the result
            List<usertiers> listUserTiers = new List<usertiers>();
            List<tiers> listTiers = new List<tiers>();

            string queryUsertiers = "SELECT * FROM usertiers WHERE idusers = '" + idUser + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(queryUsertiers, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    usertiers userTiers = new usertiers();
                    userTiersChamp(userTiers, dataReader);
                    listUserTiers.Add(userTiers);
                }
            }
            //close Connection
            this.CloseConnection();

            foreach (usertiers usertiers in listUserTiers)
            {
                OpenConnection();
                string queryTiers = "SELECT * FROM tiers WHERE  id = '" + usertiers.Idtiers + "'";

                MySqlCommand cmd = new MySqlCommand(queryTiers, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    tiers tiers = new tiers();
                    tiersChamp(tiers, dataReader);
                    listTiers.Add(tiers);
                    
                }

                dataReader.Close();
                CloseConnection();
            }
            return listTiers;
        }

        public List<produit> getAllProduits()
        {

            List<produit> listProduit = new List<produit>();

            string queryUsertiers = "SELECT * FROM produit";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(queryUsertiers, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    produit produit = new produit();
                    produitChamp(produit, dataReader);
                    listProduit.Add(produit);
                }
            }
            //close Connection
            this.CloseConnection();

            return listProduit;
        }

        public produit getProduitByID(string id)
        {

            produit produit = new produit();

            string queryUsertiers = "SELECT * FROM produit WHERE id='"+id+"'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(queryUsertiers, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                   
                    produitChamp(produit, dataReader);
                   
                }
            }
            //close Connection
            this.CloseConnection();

            return produit;
        }

        public tiers SelectWhereTiers(string champ, string table, string column_where, string value_where)
        {
            string query = "SELECT " + champ + " FROM " + table + " WHERE " + column_where + " = '" + value_where + "'";

            //Create a list to store the result
            tiers tiers = new tiers();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    tiersChamp(tiers, dataReader);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tiers;
            }
            else
            {
                return tiers;
            }
        }
        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }


    }
}
