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
            base.grpStagiaire.Visible = false;
            this.lblNoStagiaire.Visible = true;
            this.grpDeplacer.Visible = false;
        }

        private void btnAjoutStagiaire_Click(object sender, EventArgs e)
        {
            frmAjoutStagiaire frmAjout = new frmAjoutStagiaire();
            // affichage en modal "showDialog" et contrôle que l'utilisateur            
            // en sort par OK 

            if (frmAjout.ShowDialog() == DialogResult.OK)
            {
                // au besoin, afficher les txtbox
                this.lblNoStagiaire.Visible = false;
                base.grpStagiaire.Visible = true;
                this.grpDeplacer.Visible = true;

                //recherche le rang du stagiaire
                this.iStag = MStagiaire.Nstag - 1;

                //affiche les bouttons
                afficheBoutons();

                //affiche le stagiaire sur le form
                this.afficheUnStagiaire(iStag);
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
            base.txtCodePostal.Text = leStagiaire.CodePostal;
        }





    }



}


    }
}
