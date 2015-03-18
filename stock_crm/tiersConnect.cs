using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    class tiersConnect : DBConnect
    {

        //Constructor
        public tiersConnect()
            : base()
        {

        }

        //private void tiersChamp(tiers tiers, MySqlDataReader dataReader)
        //{
        //    tiers.Id = (int)dataReader["id"];
        //    tiers.Nom = (string)dataReader["nom"];
        //    tiers.Type = (type)Enum.Parse(typeof(type), (string)dataReader["type"]);
        //    tiers.Siret = (string)dataReader["siret"];
        //    tiers.Juridique = (juridique)Enum.Parse(typeof(juridique), (string)dataReader["juridique"]);
        //    tiers.Adresse_livraison = (string)dataReader["adresse_liv"];
        //    tiers.Adresse_facturation = (string)dataReader["adresse_fact"];
        //    tiers.Pays = (string)dataReader["pays"];
        //    tiers.Numero_tva = (string)dataReader["num_tva"];
        //    tiers.Code_naf = (string)dataReader["code_naf"];
        //    tiers.Reglement = (reglement)Enum.Parse(typeof(reglement), (string)dataReader["reglement"]);
        //    DateTime date = (DateTime)dataReader["delai_paiement"];
        //    tiers.Delai_paiement = Convert.ToString(date);
        //    tiers.Telephone = (string)dataReader["telephone"];
        //    tiers.Fax = (string)dataReader["fax"];
        //    tiers.Site_web = (string)dataReader["web"];
        //    tiers.Commentaire = (string)dataReader["commentaire"];
        //    tiers.Secteur = (string)dataReader["secteur"];
        //    tiers.Segment = (string)dataReader["segment"];
        //}

        //Select modifier tiers 
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

        public tiers SelectWhereTiersId(string champ, string table, string column_where, string value_where)
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
                    tiers.Id = (int)dataReader["id"];
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

        //Update tiers
        public void UpdateTiers(tiers tiers)
        {

            string query = "UPDATE tiers SET nom='" + tiers.Nom + "', siret='" + tiers.Siret + "', juridique='" + tiers.Juridique + "', adresse_liv = '" + tiers.Adresse_livraison + "', adresse_fact = '" + tiers.Adresse_facturation + "', pays = '" + tiers.Pays + "', num_tva = '" + tiers.Numero_tva + "', code_naf = '" + tiers.Code_naf + "', reglement = '" + tiers.Reglement + "', delai_paiement = '" + tiers.Delai_paiement + "', telephone = '" + tiers.Telephone + "', fax = '" + tiers.Fax + "', web = '" + tiers.Site_web + "', commentaire = '" + tiers.Commentaire + "', secteur = '" + tiers.Secteur + "', segment = '" + tiers.Segment + "' WHERE id='" + tiers.Id + "'";

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

        public void Update_userTiers(user user, int id_tiers)
        {
            //string identifiant = Toolbox.assignation_user;
            string query = "UPDATE usertiers SET idusers='" + user.Id + "' WHERE idtiers ='" + id_tiers + "'";

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

        //Insert tiers
        public void InsertTiers(tiers tiers)
        {
            string query = "INSERT INTO tiers VALUES(null,'" + tiers.Nom + "','" + tiers.Type + "','" + tiers.Siret + "','" + tiers.Juridique + "','" + tiers.Adresse_livraison + "','" + tiers.Adresse_facturation + "','" + tiers.Pays + "','" + tiers.Numero_tva + "','" + tiers.Code_naf + "','" + tiers.Reglement + "','" + tiers.Delai_paiement + "','" + tiers.Telephone + "','" + tiers.Fax + "','" + tiers.Site_web + "','" + tiers.Commentaire + "','" + tiers.Secteur + "','" + tiers.Segment + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Insert usertiers
        public void InsertUserTiers(usertiers usertiers)
        {
            string query = "INSERT INTO usertiers VALUES(null,'" + usertiers.Idtiers + "','" + usertiers.Idusers + "','" + usertiers.Contact_tiers + "','" + usertiers.Date_action + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public string SelectWhereContact(string champ, string champ_deux, string table, string value_where)
        {
            string query = "SELECT " + champ + "," + champ_deux + " FROM " + table + " WHERE " + champ_deux + " = '" + value_where + "'";

            //Create a list to store the result
            string id = "";

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
                    var data = dataReader[champ];
                    id = dataReader[champ] + "";
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return id;
            }
            else
            {
                return id;
            }
        }

        public List<string> SelectWhereModifier(string champ, string champ_deux, string table, string value_where)
        {
            string query = "SELECT " + champ + "," + champ_deux + " FROM " + table + " WHERE " + champ_deux + " = '" + value_where + "'";

            //Create a list to store the result
            List<string> list = new List<string>();

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
                    var data = dataReader[champ];
                    list.Add(dataReader[champ] + "");

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public void DeleteTiers(tiers tiers)
        {
            string query = "DELETE FROM tiers WHERE id = '" + tiers.Id + "'";
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
    }
}
