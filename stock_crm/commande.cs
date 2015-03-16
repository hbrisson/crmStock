using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_crm
{
    public enum type_action {proposition,commande};
    public enum etat_prop {envoyée,en_cours_de_negociation,validée,refusée};
    public enum etat_commande {en_cours_de_production,en_préparation,en_cours_de_livraison,à_facturer};
    class commande
    {

        private int id;
        private int idtiers;
        private type_action _type;
        private etat_prop _etat_prop;
        private etat_commande _etat_commande;
        private string date;     
        private double montant;
        private string commentaire;

        public commande()
        {
        }

        // pour une proposition
        public commande(int id,int idtiers,type_action _type,etat_prop _etat,string date,double montant,string commentaire)
        {
            this.id = id;
            this.idtiers = idtiers;
            this._type = _type;
            this._etat_prop = _etat;
            this.date = date;
            this.montant = montant;
            this.commentaire = commentaire;
        }

        //pour une commande
        public commande(int id, int idtiers, type_action _type, etat_commande _etat, string date, double montant, string commentaire)
        {
            this.id = id;
            this.idtiers = idtiers;
            this._type = _type;
            this._etat_commande = _etat;
            this.date = date;
            this.montant = montant;
            this.commentaire = commentaire;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Idtiers
        {
            get { return idtiers; }
            set { idtiers = value; }
        }

        public type_action Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public etat_prop Etat_prop
        {
            get { return _etat_prop; }
            set { _etat_prop = value; }
        }

        public etat_commande Etat_commande
        {
            get { return _etat_commande; }
            set { _etat_commande = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public double Montant
        {
            get { return montant; }
            set { montant = Math.Round(value, 2, MidpointRounding.AwayFromZero);}
        }

        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }

        public etat_prop getEtatProp(string etat)
        {
            if (etat.Equals("refusée"))
            {
                return etat_prop.refusée;
            }
            else if (etat.Equals("envoyée"))
            {
                return etat_prop.envoyée;
            }
            else if (etat.Equals("validée"))
            {
                return etat_prop.validée;
            }
            else
            {
                return etat_prop.en_cours_de_negociation;
            }

        }

        public etat_commande getEtatCommande(string etat)
        {
            if(etat.Equals("en cours de production")){
                return etat_commande.en_cours_de_production;
            }
            else if (etat.Equals("à facturer"))
            {
                return etat_commande.à_facturer;
            }
            else if (etat.Equals("en préparation"))
            {
                return etat_commande.en_préparation;
            }
            else
            {
                return etat_commande.en_cours_de_livraison;
            }

        }


    }
}
