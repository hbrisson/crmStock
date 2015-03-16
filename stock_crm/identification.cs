using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    public partial class identificationForm : Form
    {
        public static bool isOK = false;

        public identificationForm()   
        {
          
            InitializeComponent();
        }

        private void connexion_btn_Click(object sender, EventArgs e)
        {

            if (!testConnexion())
            {
                MessageBox.Show("l'identifiant ou le mdp n'est pas correct");
                resetControl();
            }
            else
            {
                isOK = true;
                Close();
            }
        }

        private Boolean testConnexion()
        {

            UserConnect db = new UserConnect();
            user user = new user();
            string identifiant;
            string mdp;
            identifiant = identifiant_txb.Text.ToString();
            // on obtient un user ou pas suivant l'identifiant
            user = db.getUser(identifiant);
            mdp = mdp_txb.Text.ToString();
          //  using (MD5 mdpHash = MD5.Create())

          //  if (Toolbox.VerifyMd5Hash(mdpHash, mdp, user.Mdp))
          //  {

                if (identifiant.Equals(user.Identifiant) || mdp.Equals(user.Mdp))
                {
                    Toolbox.userSession = null;
                    Toolbox.userSession = user;
                    return true;
                }
                else
                {
                    return false;
                }
/*
            }
            else
            {

                return false;

            }
 * */

        }

        private void resetControl()
        {
            identifiant_txb.ResetText();
            mdp_txb.ResetText();
        }

        public MD5 mdpCrypt { get; set; }
    }
}
