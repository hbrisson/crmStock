using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    public partial class menu : Form
    {
        public formulaire_tiers_formcs formulaire_tiers_formcs;
        public formulaire_contact_form formulaire_contact_form;
        public formulaire_user formulaire_user;
        public modifier_tiers modifier_tiers;
        public information_user user;
        public modiier_contact modiier_contact;
        public formulaire_proposition formulaire_proposition;
        public consultation_commande_form consultation_commande_form;
        public formulaire_user_modifier formulaire_user_modifier;
        public formulaire_user_supprimer formulaire_user_supprimer;
        public Accueil_form Accueil_form;
        public assignationNouvCommercial assignationNouvCommercial;
        public action action;

        private bool firstTime=true;

        public menu()
        {
            InitializeComponent();
            init();
            accueilForm();
        }

        private void accueilForm()
        {
            Toolbox.fermer_form();
            //On ajoute le form voulu dans le main panel
            Accueil_form = new Accueil_form();
            Accueil_form.Text = "Accueil";
            Accueil_form.TopLevel = false;
            panelForm.Controls.Add(Accueil_form);
            Accueil_form.Show();
        }

        private void init()
        {
            
            user user = Toolbox.userSession;
            nomUser.Text = user.Nom.ToString() + " " + user.Prenom.ToString(); ;
            roleUser.Text = user.Statut.ToString();
            if (user.Statut == statut.commercial)
            {
                userItem.Enabled = false;
            }  
            
        }     

        private void showConnexion()
        {
            identificationForm ident = new identificationForm();
            ident.ShowDialog();
        }

        private void menuForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (Toolbox.userSession == null)
            {
                init();
                showConnexion();
            }
            else
            {
                user user = Toolbox.userSession;
                nomUser.Text = user.Nom.ToString();
                roleUser.Text = user.Statut.ToString();
            }
        }

        //Creation tiers
        private void creerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //Ferme les forms avant l'ouverture de celle concernée
            Toolbox.fermer_form();

            //On ajoute le form voulu dans le main panel
            formulaire_tiers_formcs = new formulaire_tiers_formcs();
            formulaire_tiers_formcs.Text = "Formulaire";
            formulaire_tiers_formcs.TopLevel = false;
            panelForm.Controls.Add(formulaire_tiers_formcs);
            formulaire_tiers_formcs.Show();
        }

        //Creation contact
        private void creerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Ferme les forms avant l'ouverture de celle concernée
            Toolbox.fermer_form();

            //On ajoute le form voulu dans le main panel
            formulaire_contact_form = new formulaire_contact_form();
            formulaire_contact_form.Text = "Formulaire";
            formulaire_contact_form.TopLevel = false;
            panelForm.Controls.Add(formulaire_contact_form);
            formulaire_contact_form.Show();
        }

        //Création user
        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //Ferme les forms avant l'ouverture de celle concernée
            Toolbox.fermer_form();
            //On ajoute le form voulu dans le main panel
            formulaire_user = new formulaire_user();
            formulaire_user.Text = "Formulaire";
            formulaire_user.TopLevel = false;
            panelForm.Controls.Add(formulaire_user);
            formulaire_user.Show();
        }

        //Modification tiers
        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            //Ferme les forms avant l'ouverture de celle concernée
            Toolbox.fermer_form();
            //On ajoute le form voulu dans le main panel
            modifier_tiers = new modifier_tiers();
            modifier_tiers.Text = "Formulaire";
            modifier_tiers.TopLevel = false;
            panelForm.Controls.Add(modifier_tiers);
            modifier_tiers.Show();
        }

        private void nomUser_Click(object sender, EventArgs e)
        {
            
            Toolbox.fermer_form();
            user = new information_user();
            user.Text = "Formulaire";
            user.TopLevel = false;
            panelForm.Controls.Add(user);
            user.Show();
        }

        private void modifier_contact(object sender, EventArgs e)
        {
            
            //Ferme les forms avant l'ouverture de celle concernée
            Toolbox.fermer_form();

            //On ajoute le form voulu dans le main panel
            modiier_contact = new modiier_contact();
            modiier_contact.Text = "Formulaire";
            modiier_contact.TopLevel = false;
            panelForm.Controls.Add(modiier_contact);
            modiier_contact.Show();
        }

        //creer commande
        private void créerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            //Ferme les forms avant l'ouverture de celle concernée
            Toolbox.fermer_form();

            //On ajoute le form voulu dans le main panel
            formulaire_proposition = new formulaire_proposition();
            formulaire_proposition.Text = "Formulaire";
            formulaire_proposition.TopLevel = false;
            panelForm.Controls.Add(formulaire_proposition);
            formulaire_proposition.Show();
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //Ferme les forms avant l'ouverture de celle concernée
            Toolbox.fermer_form();


            //On ajoute le form voulu dans le main panel
            consultation_commande_form = new consultation_commande_form();
            consultation_commande_form.Text = "Formulaire";
            consultation_commande_form.TopLevel = false;
            panelForm.Controls.Add(consultation_commande_form);

           
            consultation_commande_form.Show();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //Ferme les forms avant l'ouverture de celle concernée
            Toolbox.fermer_form();

            //On ajoute le form voulu dans le main panel
            formulaire_user_modifier = new formulaire_user_modifier();
            formulaire_user_modifier.Text = "Formulaire";
            formulaire_user_modifier.TopLevel = false;
            panelForm.Controls.Add(formulaire_user_modifier);
            formulaire_user_modifier.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            accueilForm();
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {
            if (Toolbox.assignation)
            {
                Toolbox.fermer_form();
                assignationNouvCommercial = new assignationNouvCommercial();
                assignationNouvCommercial.TopLevel = false;
                panelForm.Controls.Add(assignationNouvCommercial);
                assignationNouvCommercial.Show();
                Toolbox.assignation = false;
                panelMenu.Enabled = false;
            }
            if (firstTime)
            {
                Accueil_form.Close();
                accueilForm();
            }
            if (Toolbox.user_delete)
            {
                panelMenu.Enabled = true;
                Toolbox.user_delete = false;
                firstTime = true;
                accueilForm();
            }
            firstTime = false;

        }

        private void consulterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Ferme les forms avant l'ouverture de celle concernée
            Toolbox.fermer_form();

            //On ajoute le form voulu dans le main panel
            formulaire_user_supprimer = new formulaire_user_supprimer();
            formulaire_user_supprimer.Text = "Formulaire";
            formulaire_user_supprimer.TopLevel = false;
            panelForm.Controls.Add(formulaire_user_supprimer);
            formulaire_user_supprimer.Show();

        }

        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ferme les forms avant l'ouverture de celle concernée
            Toolbox.fermer_form();

            //On ajoute le form voulu dans le main panel
            action = new action();
            action.Text = "Historique des actions";
            action.TopLevel = false;
            panelForm.Controls.Add(action);
            action.Show();
        }

    }
}
