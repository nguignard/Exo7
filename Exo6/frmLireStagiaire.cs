using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exo6
{
    public partial class frmLireStagiaire : Exo6.frmStagiaire
    {
        //Rang du stagiaire
        private int iStag;

        public frmLireStagiaire()
        {
            InitializeComponent();
        }
        private void frmLireStagiaire_Load(object sender, EventArgs e)
        {
            /** initialisation du form             
             ** pour afficher le label "pas de stagiaires"        
             **/
            base.grpStagiaire.Visible = true;
            this.lblNoStagiaire.Visible = true;
            this.grpDeplacer.Visible = false;
        }

        //METHODE DECLENCHEE PAR AJOUTER 

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAjoutStagiaire frmAjout;
            frmAjout = new frmAjoutStagiaire();
            // affichage en modal "showDialog" et contrôle que l'utilisateur - en sort par OK 

            if (frmAjout.ShowDialog() == DialogResult.OK)
            {
                // au besoin, afficher les txtbox
                // this.lblNoStagiaire.Visible = false;
                this.lblNoStagiaire.Visible = false;
                base.grpStagiaire.Visible = true;
                this.grpDeplacer.Visible = true;

                //recherche le rang du stagiaire
                this.iStag = MStagiaire.NStag - 1;

                //affiche les bouttons
                afficheBoutons();

                //affiche le stagiaire sur le form
                this.afficheUnStagiaire(iStag);
            }
        }



        //METHODE AFFICHER UN STAGIAIRE
        private void afficheUnStagiaire(int i)
        {
            MStagiaire leStagiaire = Donnees.ArrayStag[i];

            base.txtOSIA.Text = leStagiaire.NumOsia.ToString();
            base.txtNom.Text = leStagiaire.Nom;
            base.txtPrenom.Text = leStagiaire.Prenom;
            base.txtAdresse.Text = leStagiaire.Rue;
            base.txtVille.Text = leStagiaire.Ville;
            base.txtCodePostal.Text = leStagiaire.CodePostal.ToString();
        }


        //GESTION DES FLECHES
        private void btnPremier_Click(object sender, EventArgs e)
        {
            this.iStag = 0;
            afficheBoutons();
            afficheUnStagiaire(this.iStag);
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            this.iStag = Donnees.ArrayStag.Count - 1;
            afficheBoutons();
            afficheUnStagiaire(this.iStag);
        }


        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            this.iStag--;
            afficheBoutons();
            afficheUnStagiaire(this.iStag);
        }
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            this.iStag++;
            afficheBoutons();
            afficheUnStagiaire(this.iStag);
        }


        private void afficheBoutons()
        {
            // on rétablit d’abord tous les boutons           
            this.btnPremier.Enabled = true;
            this.btnPrecedent.Enabled = true;
            this.btnDernier.Enabled = true;
            this.btnSuivant.Enabled = true;
            // si on pointe le premier       
            if (this.iStag == 0)
            {
                // désactiver boutons Premier et Précédent       
                this.btnPremier.Enabled = false;
                this.btnPrecedent.Enabled = false;
            }
            // si on pointe le dernier          

            if (this.iStag == Donnees.ArrayStag.Count - 1)
            {  // désactiver boutons Dernier et Suivant           
                this.btnDernier.Enabled = false;
                this.btnSuivant.Enabled = false;
            }

        }


    }


}







