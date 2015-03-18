using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_crm
{
    class commandeConnect : DBConnect
    {
        public commandeConnect() : base() { }

        private void commandeChamp(commande commande, MySqlDataReader dataReader)
        {
            commande.Id = (int)dataReader["id"];
            commande.Idtiers = (int)dataReader["idtiers"];
            commande.Type = (type_action)Enum.Parse(typeof(type_action), (string)dataReader["type"]);
            string etat = (string)dataReader["etat"];

            if (commande.Type == type_action.proposition)
            {
                commande.Etat_prop = commande.getEtatProp(etat);
            }
            else
            {
                commande.Etat_commande = commande.getEtatCommande(etat);
            }

            DateTime date = (DateTime)dataReader["date"];
            commande.Date = date.ToString();
            commande.Montant = Convert.ToDouble((float)dataReader["montant"]);
            commande.Commentaire = (string)dataReader["commentaire"];
        }

        //insert Commande , Get ID Commande for Insert Commande Prodruit and update quantite produit
        public void gestionCommande(commandeProduit commandeProduit)
        {
            insertCommandeProduit(commandeProduit);
            updateProduit(commandeProduit.Quantite, commandeProduit.Idproduit, "-");
        }

        public void insertCommande(commande commande)
        {
            string query = "INSERT INTO commande VALUES(null,'" + commande.Idtiers + "','" + commande.Type + "','" + commande.Etat_prop + "','" + commande.Date + "','" + commande.Montant.ToString().Replace(",", ".") + "','" + commande.Commentaire + "')";

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

        public int getIdCommande(int idTiers)
        {
            string query = "SELECT id FROM commande Where idtiers='" + idTiers + "' Order by id DESC limit 1";

            //Create a list to store the result
            commande commande = new commande();

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
                    commande.Id = (int)dataReader["id"];
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return commande.Id;
            }
            else
            {
                return commande.Id;
            }
        }

        private void insertCommandeProduit(commandeProduit commandeProduit)
        {
            string query = "INSERT INTO commandeproduit VALUES('" + commandeProduit.Idcommand + "','" + commandeProduit.Idproduit + "','" + commandeProduit.Quantite + "')";

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

        public void updateProduit(int qte, int idProduit, string operateur)
        {

            string query = "UPDATE produit SET quantite = quantite " + operateur + " '" + qte + "' WHERE id = '" + idProduit + "'";

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

        public void updateCommande(commande commande)
        {
            string query;
            if (commande.Type.Equals(type_action.commande))
            {
                query = "UPDATE commande SET type = '" + commande.Type + "' , etat ='" + commande.Etat_commande.ToString().Replace("_", " ") + "', date ='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' , montant ='" + commande.Montant.ToString().Replace(",", ".") + "' , commentaire = '" + commande.Commentaire + "' WHERE id = '" + commande.Id + "'";

            }
            else
            {
                query = "UPDATE commande SET type = '" + commande.Type + "' , etat ='" + commande.Etat_prop.ToString().Replace("_", " ") + "', date ='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' , montant ='" + commande.Montant.ToString().Replace(",", ".") + "' , commentaire = '" + commande.Commentaire + "' WHERE id = '" + commande.Id + "'";
            }

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

        public void updateCommandeProduit(commandeProduit commandeProduit)
        {
            string query = "UPDATE commandeproduit SET quantite = '" + commandeProduit.Quantite + "' where idcommande ='" + commandeProduit.Idcommand + "' and idproduit ='" + commandeProduit.Idproduit + "'";

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

        public void updateTiers(tiers tiers)
        {
            string query = "UPDATE tiers SET type =  '" + type.client + "' WHERE id = '" + tiers.Id + "'";

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

        public void deleteCommandeProduit(commandeProduit commandeProduit)
        {
            string query = "Delete From commandeproduit WHERE idcommande = '" + commandeProduit.Idcommand + "' and idproduit ='" + commandeProduit.Idproduit + "'";

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

        public List<commandeProduit> getCommandeProduitsByID(int id)
        {
            string query = "SELECT * FROM commandeproduit Where idcommande = '" + id + "'";

            //Create a list to store the result
            List<commandeProduit> listCommandeProduit = new List<commandeProduit>();

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
                    commandeProduit cmdProduit = new commandeProduit();
                    cmdProduit.Idcommand = (int)dataReader["idcommande"];
                    cmdProduit.Idproduit = (int)dataReader["idproduit"];
                    cmdProduit.Quantite = (int)dataReader["quantite"];

                    listCommandeProduit.Add(cmdProduit);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return listCommandeProduit;
            }
            else
            {
                return listCommandeProduit;
            }
        }

        public commande getCommandeByID(int id)
        {
            string query = "SELECT * FROM commande Where id ='" + id + "'";

            //Create a list to store the result
            commande commande = new commande();

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
                    commandeChamp(commande, dataReader);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return commande;
            }
            else
            {
                return commande;
            }
        }

        public List<string> getCommandeCountAndSumByID(tiers tiers, Boolean isNegoc)
        {
            string query;

            if (isNegoc)
            {
                query = "Select COUNT(c.id) AS total,SUM(c.montant) AS montant_total from commande c ,usertiers ut,tiers t where c.idtiers = t.id and t.id = ut.idtiers and ut.idusers = '" + Toolbox.userSession.Id + "'  And c.type ='proposition' and c.etat not like '%refu%' and t.id=" + tiers.Id + "";

            }
            else
            {
                query = "Select COUNT(c.id) AS total,SUM(c.montant) AS montant_total from commande c ,usertiers ut,tiers t where c.idtiers = t.id and t.id = ut.idtiers and ut.idusers = '" + Toolbox.userSession.Id + "' And c.type ='commande' And c.etat != 'à facturer' and t.id=" + tiers.Id + "";

            }


            //Create a list to store the result
            List<string> listString = new List<string>();

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
                    listString.Add(Convert.ToString((long)dataReader["total"]));
                    listString.Add(Convert.ToString((double)dataReader["montant_total"]));
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return listString;
            }
            else
            {
                return listString;
            }
        }

        public List<string> getCommandeSumByID(tiers tiers, Boolean isNegoc)
        {
            string query;

            if (isNegoc)
            {
                query = "Select SUM(c.montant) AS montant_total from commande c ,usertiers ut,tiers t where c.idtiers = t.id and t.id = ut.idtiers and ut.idusers = '" + Toolbox.userSession.Id + "'  And c.type ='proposition' and c.etat like '%refu%' and t.id=" + tiers.Id + "";

            }
            else
            {
                query = "Select SUM(c.montant) AS montant_total from commande c ,usertiers ut,tiers t where c.idtiers = t.id and t.id = ut.idtiers and ut.idusers = '" + Toolbox.userSession.Id + "' And c.type ='commande' And c.etat = 'à facturer' and t.id=" + tiers.Id + "";

            }


            //Create a list to store the result
            List<string> listString = new List<string>();

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
                    try
                    {
                        listString.Add(Convert.ToString((double)dataReader["montant_total"]));
                    }
                    catch (Exception ex)
                    {
                        return listString;
                    }

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return listString;
            }
            else
            {
                return listString;
            }
        }
    }
}

