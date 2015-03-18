using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    class actionConnect : DBConnect
    {
           //Constructor
        public actionConnect()
            : base()
        {
            
        }

        public List<tiers> selectTiers(string query)
        {
            List<tiers> list_tiers = new List<tiers>();

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
                    tiers.Id =  (int)dataReader["id"];
                    tiers.Nom = (string)dataReader["nom"];

                    list_tiers.Add(tiers);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list_tiers;
            }
            else
            {
                return list_tiers;
            }
            return list_tiers;

        }

        public void insertAction(string query)
        {
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

            }
            else
            {

            }
        }

    }


}
