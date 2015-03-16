using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    class UserConnect : DBConnect
    {
        //Constructor
        public UserConnect() :base(){ }
       
        public user getUser(string identifiant)
        {
            string query = "SELECT * FROM user Where identifiant='" + identifiant + "'";

            //Create a list to store the result
            user user = new user();


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
                    user.Id = (int)dataReader["id"];
                    user.Nom = (string)dataReader["nom"];
                    user.Prenom = (string)dataReader["prenom"];
                    user.Identifiant = (string)dataReader["identifiant"];
                    user.Mdp = (string)dataReader["mdp"];
                    user.Statut = (statut)Enum.Parse(typeof(statut), (string)dataReader["statut"]);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return user;
            }
            else
            {
                return user;
            }
        }

        // Insertion des données dans la table User
        public void InsertUser(user user)
        {
            string query = "INSERT INTO user VALUES(null,'" + user.Nom + "','" + user.Prenom + "','" + user.Identifiant + "','" + user.Mdp + "','" + user.Statut + "')";

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

        // GW 23/10/2014 : Modifier le mot de passe à partir de l'identifiant
        public void UpdateUser(int id, statut statut, string identifiant)
        {
            string query = "UPDATE user SET statut = '" + statut + "', identifiant = '" + identifiant + "' WHERE id = " + id;

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

        public List<user> getAllUsers()
        {
            string query = "SELECT * FROM user";

            //Create a list to store the result
            List<user> listUsers = new List<user>();


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
                    user user = new user();
                    user.Id = (int)dataReader["id"];
                    user.Nom = (string)dataReader["nom"];
                    user.Prenom = (string)dataReader["prenom"];
                    user.Identifiant = (string)dataReader["identifiant"];
                    user.Mdp = (string)dataReader["mdp"];
                    user.Statut = (statut)Enum.Parse(typeof(statut), (string)dataReader["statut"]);

                    listUsers.Add(user);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return listUsers;
            }
            else
            {
                return listUsers;
            }
        }

        public List<tiers> getAllTiers(string query)
        {
           
            //Create a list to store the result
            List<tiers> listTiers= new List<tiers>();


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
                    tiers tiers = new tiers();
                    tiers.Id = (int)dataReader["id"];
                    tiers.Nom = (string)dataReader["nom"];

                    listTiers.Add(tiers);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return listTiers;
            }
            else
            {
                return listTiers;
            }
        }

        // GW 23/10/2014 : Modifier le mot de passe à partir de l'identifiant
       
        // GW 23/10/2014 : Méthode permettant d'afficher les infos de l'utilisateur actif
        public string afficheInfoUser(String champ)
        {
            string query = "SELECT " + champ + " FROM user WHERE id ="+Toolbox.userSession.Id;

            //Create a list to store the result
            string result = "";

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
                    result = dataReader[champ] + "";
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return result;
            }
            else
            {
                return result;
            }
        }

        // GW 23/10/2014 : Vérifier si le paramètre n'existe pas dans la BDD
        public bool IdentifiantExistant(string champ)
        {
            string query = "SELECT * FROM user WHERE identifiant = '" + champ + "'";

            //Create a list to store the result
            bool result = false;

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
                    result = true;
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                if (result)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        // GW 24/10/2014 : Méthode permettant d'afficher le champ choisi de tous les users sauf le user actif
        public List<string> afficheUsersSaufActif(string champ)
        {
            string query = "SELECT " + champ + " FROM user WHERE id <> " + Toolbox.userSession.Id;

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

        // GW 23/10/2014 : Modifier le mot de passe à partir de l'identifiant
        public void UpdateMdpUser(string champ, string identifiant)
        {
            string query = "UPDATE user SET mdp = '" + champ + "' WHERE identifiant = '" + identifiant + "'";

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

        // GW 24/10/2014 : Supprimer un utilisateur à partir d'un champ
        public void DeleteUser(string champ)
        {
            string query = "DELETE FROM user WHERE identifiant = '" + champ + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

    }
}
