using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_crm
{
    class produit
    {
        private int id;
        private string nom;
        private double prix;
        private int quantite;

        public produit()
        {
        }

        public produit(int id,string nom,double prix,int quantite)
        {
            this.id = id;
            this.nom = nom;
            this.prix = prix;
            this.quantite = quantite;
        }

        public produit getCurrentProduit(List<produit> listProduits,string produitNom)
        {
            foreach (produit produit in listProduits)
            {
                if (produit.nom == produitNom)
                {
                    return produit;
                }
            }
            return null;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
       
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }
       
        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

    }


}
