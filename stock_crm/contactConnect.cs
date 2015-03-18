using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    class contactConnect : DBConnect
    {
       
        //Constructor
        public contactConnect():base()
        {
            
        }

         //Select statement
         public string SelectWhereSimple(string champ, string table, string column_where, string where_value)
         {
             string query = "SELECT " + champ + " FROM " + table + " WHERE " + column_where + " = '" + where_value + "'";

             //Create a list to store the result
             string data = "";

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
                     data = dataReader[champ] + "";
                 }

                 //close Data Reader
                 dataReader.Close();

                 //close Connection
                 this.CloseConnection();

                 //return list to be displayed
                 return data;
             }
             else
             {
                 return data;
             }
         }

         public void UpdateContact(contact contact)
         {
             string query = "UPDATE contact SET idtiers='" + contact.Idtiers + "', nom='" + contact.Nom + "', prenom = '" + contact.Prenom + "', telephone = '" + contact.Telephone + "', portable = '" + contact.Telephone + "', mail = '" + contact.Mail + "', date_anniv ='" + contact.Date + "', fonction = '" + contact.Fonction + "', commentaire = '" + contact.Commentaire + "'  WHERE nom='" + contact.Nom + "'";

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

         public contact SelectWhereContactForm(string champ, string table, string column_where, string value_where)
         {
             string query = "SELECT " + champ + " FROM " + table + " WHERE " + column_where + " = '" + value_where + "'";

             //Create a list to store the result
             contact contact = new contact();

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
                     contact.Id = (int)dataReader["id"];
                     contact.Idtiers = (int)dataReader["idtiers"];
                     contact.Nom = (string)dataReader["nom"];
                     contact.Prenom = (string)dataReader["prenom"];
                     contact.Telephone = (string)dataReader["telephone"];
                     contact.Portable = (string)dataReader["portable"];
                     contact.Mail = (string)dataReader["mail"];
                     DateTime date_ = (DateTime)dataReader["date_anniv"];
                     contact.Date = Convert.ToString(date_);
                     contact.Fonction = (string)dataReader["fonction"];
                     contact.Commentaire = (string)dataReader["commentaire"];
                 }

                 //close Data Reader
                 dataReader.Close();

                 //close Connection
                 this.CloseConnection();

                 //return list to be displayed
                 return contact;
             }
             else
             {
                 return contact;
             }
         }

         public List<contact> SelectWhereContactList(string champ, string table, string column_where, string value_where)
         {
             string query = "SELECT " + champ + " FROM " + table + " WHERE " + column_where + " = '" + value_where + "'";

             //Create a list to store the result
             
             List<contact> list_contact = new List<contact>();
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
                     contact contact = new contact();
                     contact.Id = (int)dataReader["id"];
                     contact.Idtiers = (int)dataReader["idtiers"];
                     contact.Nom = (string)dataReader["nom"];
                     contact.Prenom = (string)dataReader["prenom"];
                     contact.Telephone = (string)dataReader["telephone"];
                     contact.Portable = (string)dataReader["portable"];
                     contact.Mail = (string)dataReader["mail"];
                     DateTime date_ = (DateTime)dataReader["date_anniv"];
                     contact.Date = Convert.ToString(date_);
                     contact.Fonction = (string)dataReader["fonction"];
                     contact.Commentaire = (string)dataReader["commentaire"];

                     list_contact.Add(contact);
                 }

                 //close Data Reader
                 dataReader.Close();

                 //close Connection
                 this.CloseConnection();

                 //return list to be displayed
                 return list_contact;
             }
             else
             {
                 return list_contact;
             }
         }

         //Select statement
         public List<string> Select(string champ, string table)
         {
             string query = "SELECT " + champ + " FROM " + table;

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

        public List<string> SelectWhereContactModif(string champ, string champ_deux, string table, string value_where)
        {
            string query = "SELECT " + champ + "," + champ_deux + " FROM " + table + " WHERE " + champ_deux + " = '" + value_where + "'";

            //Create a list to store the result
            List<string> id = new List<string>();

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
                    id.Add(dataReader[champ] + "");
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

        //Insert contact
        public void InsertContact(contact contact)
        {
            string query = "INSERT INTO contact VALUES(null,'" + contact.Idtiers + "','" + contact.Nom + "','" + contact.Prenom + "','" + contact.Telephone + "','" + contact.Portable + "','" + contact.Mail + "','" + contact.Date + "','" + contact.Fonction + "','" + contact.Commentaire + "')";

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

        public void DeleteContact(contact contact)
        {
            string query = "DELETE FROM contact WHERE id = '" + contact.Id + "'";
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
