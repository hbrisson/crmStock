using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_crm
{
    class commandeProduit
    {
    
        private int idcommand;
        private int idproduit;
        private int quantite;

        public commandeProduit() { }

        public commandeProduit(int idcommand,int idproduit,int quantite)
        {
            
            this.idcommand = idcommand;
            this.idproduit = idproduit;
            this.quantite = quantite;
        }

        public int Idcommand
        {
            get { return idcommand; }
            set { idcommand = value; }
        }
       

        public int Idproduit
        {
            get { return idproduit; }
            set { idproduit = value; }
        }
        

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        public commandeProduit getCurrentCmdProduit(List<commandeProduit> listCmdProduits, int idProduit)
        {
            foreach (commandeProduit cmdProduit in listCmdProduits)
            {
                if (cmdProduit.Idproduit == idProduit)
                {
                    return cmdProduit;
                }
            }
            return null;
        }
    }
}
