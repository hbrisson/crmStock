using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_crm
{
    class accueilConnect : DBConnect
    {
        //Constructor
        public accueilConnect()
            : base()
        {

        }

        public actionCl selectaction(string query)
        {
            actionCl actionCl = new actionCl();

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    actionCl.Date = (DateTime)dataReader["date"];
                    actionCl.Commentaire = (string)dataReader["commentaire"];
                    string nom_enum = (string)dataReader["nom"];
                    actionCl.Commentaire = (string)dataReader["contact"];
                    actionCl.Commentaire += " " + (string)dataReader["prenom"];
                    nom nom;

                    if (nom_enum.Equals("appel telephonique"))
                    {
                        nom = nom.appel_telephonique;
                    }
                    else if (nom_enum.Equals("rendez-vous"))
                    {
                        nom = nom.rendez_vous;
                    }
                    else if (nom_enum.Equals("contact mail"))
                    {
                        nom = nom.contact_mail;
                    }
                    else
                    {
                        nom = nom.prise_de_contact;
                    }

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return actionCl;
            }
            else
            {
                return actionCl;
            }

        }
    }
}
