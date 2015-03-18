using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_crm
{
    public enum nom {appel_telephonique,prise_de_contact, rendez_vous,contact_mail};

    class actionCl
    {
        private int id;
        private int idtiers;
        private int idcontact;
        private DateTime date;
        private string commentaire;
        private nom _nom;
       
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


        public int Idcontact
        {
            get { return idcontact; }
            set { idcontact = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }

        public nom Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public actionCl()
        {
        }

        public actionCl(int id, int idcontact, int idtiers, DateTime date, string commentaire, nom nom)
        {
            this.id = Id;
            this.idcontact = Idcontact;
            this.idtiers = Idtiers;
            this.date = Date;
            this.commentaire = Commentaire;
            this._nom = nom;
        }
    }
}
