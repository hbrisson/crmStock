using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_crm
{

    public enum statut { commercial, admin, directeur };

    class user
    {

        private int id;
        private string nom;
        private string prenom;
        private statut _statut;
        private string identifiant;
        private string mdp;

        public user()
        {

        }
        public user(string nom, string prenom, statut statut, string identifiant, string mdp)
        {

            this.nom = nom;
            this.prenom = prenom;
            this._statut = statut;
            this.identifiant = identifiant;
            this.mdp = mdp;

        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public statut Statut
        {
            get { return _statut; }
            set { _statut = value; }
        }

        public string Identifiant
        {
            get { return identifiant; }
            set { identifiant = value; }
        }

        public string Mdp
        {
            get { return mdp; }
            set { mdp = value; }
        }

    }
}
