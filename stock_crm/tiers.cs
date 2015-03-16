using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_crm
{
    public enum juridique {SA,SARL,SAS };
    public enum reglement{virement,cheque,carteBancaire};
    public enum type {prospect,client};
    
    class tiers
    {
        private int id;
        private string nom;
        private type _type;
        private string siret;
        private juridique _juridique;
        private reglement _reglement;
        private string adresse_livraison;
        private string adresse_facturation;
        private string pays;
        private string numero_tva;
        private string code_naf;     
        private string delai_paiement;
        private string telephone;
        private string fax;
        private string site_web;
        private string commentaire;
        private string secteur;
        private string segment;

        public tiers()
        {
            
        }

        public tiers(int id, string Nom, type Type, string Siret, juridique Juridique,reglement Reglement, string Adresse_livraison, string Adresse_facturation, string Pays, string Numero_tva, string Code_naf, string Delai_paiement, string Telephone, string Fax, string Site_web, string Commentaire, string Secteur, string Segment)
        {
            this.id = id;
            this.nom = Nom;
            this._type = Type;
            this.siret = Siret;
            this._juridique = Juridique;
            this._reglement = Reglement;
            this.adresse_livraison = Adresse_livraison;
            this.adresse_facturation = Adresse_facturation;
            this.pays = Pays;
            this.numero_tva = Numero_tva;
            this.code_naf = Code_naf;
            this.delai_paiement = Delai_paiement;
            this.telephone = Telephone;
            this.fax = Fax;
            this.site_web = Site_web;
            this.commentaire = Commentaire;
            this.secteur = Secteur;
            this.segment = Segment;
        }

        public tiers(string Nom, type Type, string Siret, juridique Juridique, reglement Reglement, string Adresse_livraison, string Adresse_facturation, string Pays, string Numero_tva, string Code_naf, string Delai_paiement, string Telephone, string Fax, string Site_web, string Commentaire, string Secteur, string Segment)
        {
            this.nom = Nom;
            this._type = Type;
            this.siret = Siret;
            this._juridique = Juridique;
            this._reglement = Reglement;
            this.adresse_livraison = Adresse_livraison;
            this.adresse_facturation = Adresse_facturation;
            this.pays = Pays;
            this.numero_tva = Numero_tva;
            this.code_naf = Code_naf;
            this.delai_paiement = Delai_paiement;
            this.telephone = Telephone;
            this.fax = Fax;
            this.site_web = Site_web;
            this.commentaire = Commentaire;
            this.secteur = Secteur;
            this.segment = Segment;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public type Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public juridique Juridique
        {
            get { return _juridique; }
            set { _juridique = value; }
        }

        public string Segment
        {
            get { return segment; }
            set { segment = value; }
        }

        public reglement Reglement
        {
            get { return _reglement; }
            set { _reglement = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Siret
        {
            get { return siret; }
            set { siret = value; }
        }

        public string Adresse_livraison
        {
            get { return adresse_livraison; }
            set { adresse_livraison = value; }
        }

        public string Adresse_facturation
        {
            get { return adresse_facturation; }
            set { adresse_facturation = value; }
        }

        public string Pays
        {
            get { return pays; }
            set { pays = value; }
        }

        public string Numero_tva
        {
            get { return numero_tva; }
            set { numero_tva = value; }
        }

        public string Code_naf
        {
            get { return code_naf; }
            set { code_naf = value; }
        }

        public string Delai_paiement
        {
            get { return delai_paiement; }
            set { delai_paiement = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        public string Site_web
        {
            get { return site_web; }
            set { site_web = value; }
        }

        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }

        public string Secteur
        {
            get { return secteur; }
            set { secteur = value; }
        }

        public tiers getCurrentTiers(List<tiers> listTiers, string tiersNom)
        {
            foreach (tiers tiers in listTiers)
            {
                if (tiers.nom == tiersNom)
                {
                    return tiers;
                }
            }

            return null;
        }
    }      
}
