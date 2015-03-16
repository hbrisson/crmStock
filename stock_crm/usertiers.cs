using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_crm
{
    public enum etat { rdv, contact_telephonique, rappel, travail_a_founir };
    class usertiers
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int idtiers;
        private int idusers;
        private etat _contact_tiers;
        private string date_action;

        public usertiers()
        {
        }

        public usertiers(int Idtiers, int Idusers, etat _Contact_tiers, string Date_action)
        {
            this.idtiers = Idtiers;
            this.idusers = Idusers;
            this._contact_tiers = _Contact_tiers;
            this.date_action = Date_action;
        }

        public etat Contact_tiers
        {
            get { return _contact_tiers; }
            set { _contact_tiers = value; }
        }

        public int Idtiers
        {
            get { return idtiers; }
            set { idtiers = value; }
        }

        public int Idusers
        {
            get { return idusers; }
            set { idusers = value; }
        }

        public string Date_action
        {
            get { return date_action; }
            set { date_action = value; }
        }
    }
}
