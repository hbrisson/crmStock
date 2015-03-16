using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_crm
{
    class contact
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private string portable;
        private string mail;
        private string date;
        private string fonction;
        private string commentaire;
        private int idtiers;

        public contact()
        {
        }

        public contact(int Idtiers, string Nom, string Prenom, string Telephone, string Portable, string Mail, string Date, string Fonction, string Commentaire)
        {
            this.idtiers = Idtiers;
            this.nom = Nom;
            this.prenom = Prenom;
            this.telephone = Telephone;
            this.portable = Portable;
            this.mail = Mail;
            this.date = Date;
            this.fonction = Fonction;
            this.commentaire = Commentaire;
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

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string Portable
        {
            get { return portable; }
            set { portable = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Fonction
        {
            get { return fonction; }
            set { fonction = value; }
        }

        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }
    }
}
