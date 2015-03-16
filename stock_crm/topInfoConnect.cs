using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    class topInfoConnect: DBConnect
    {
        public List<user> SelectUsers()
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

        public List<usertiers> Selectidtiers(user user)
        {
            string query = "SELECT idtiers, idusers FROM usertiers WHERE idusers = '" + user.Id + "'";

            //Create a list to store the result
            List<usertiers> Lusertiers = new List<usertiers>();

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
                    usertiers usertiers = new usertiers();
                    usertiers.Idtiers = (int)dataReader["idtiers"];
                    usertiers.Idusers = (int)dataReader["idusers"];
                    Lusertiers.Add(usertiers);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return Lusertiers;
            }
            else
            {
                return Lusertiers;
            }
        }

        public List<commande> Selectcommand(usertiers usertiers)
        {
            string query = "SELECT montant FROM commande WHERE idtiers = '" + usertiers.Idtiers + "'";

            //Create a list to store the result
            List<commande> Lcommande = new List<commande>();

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
                    commande commande = new commande();
                    commande.Montant = (float)dataReader["montant"];
                    Lcommande.Add(commande);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return Lcommande;
            }
            else
            {
                return Lcommande;
            }
        }
    }

    
}
