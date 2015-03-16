using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    public partial class Accueil_form : customForm
    {
        
        top_info top_info;

        public Accueil_form()
        {
            InitializeComponent();
            initcomponent(panel1);
            init();
        }

        public override void initcomponent(Panel panel)
        {
            base.initcomponent(panel);
        }

        private void init()
        {
            DateTimeFormatInfo dtf = new CultureInfo("fr-FR", false).DateTimeFormat;
            titre_lbl.Text = titre_lbl.Text.Replace("#nomprenom#", Toolbox.userSession.Nom + " " + Toolbox.userSession.Prenom);
            date_lbl.Text = date_lbl.Text.Replace("#dateDuJour#",DateTime.Now.ToString("dddd dd MMMM yyyy hh:mm:ss", dtf));
            if(!Toolbox.userSession.Statut.Equals(statut.directeur)){
                groupBox1.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //On ajoute le form voulu dans le main panel
            top_info = new top_info();
            top_info.Text = "Accueil";
            top_info.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(top_info);
            top_info.Show();
        }
    }
}
