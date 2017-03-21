using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exo6;

namespace Exo7
{
    public partial class frmVisuStagiaire : Exo6.frmStagiaire
    {
        private MStagiaire leStagiaire; // leStagiaire est de nivau class pour être utiliser dans toutes la classe et est initialisee par le constructeur

        public frmVisuStagiaire(MStagiaire unStagiaire)
        {
            this.leStagiaire = unStagiaire; //instanciation de leStagiaire par l'instance transmise
            InitializeComponent();
        }

        private void frmVisuStagiaire_Load(object sender, EventArgs e)
        {
            this.afficheStagiaire(this.leStagiaire);
        }

        private void afficheStagiaire(MStagiaire unStagiaire)
        {
            this.txtOSIA.Text = unStagiaire.NumOsia.ToString();
            this.txtNom.Text = unStagiaire.Nom;
            this.txtPrenom.Text = unStagiaire.Prenom;
            this.txtAdresse.Text = unStagiaire.Rue;
            this.txtVille.Text = unStagiaire.Ville;
            this.txtCodePostal.Text = unStagiaire.CodePostal.ToString();
        }




        private void btnValider_Click(object sender, EventArgs e)
        { //Creer un stagiaire
            if (this.controle())
            {
                if (this.instancie())
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }


        private bool controle()
        {
            bool code = true;

            if (!Outils.EstEntier(this.txtOSIA.Text))
            {
                code = false;
                MessageBox.Show("le n°Osia saisie est incorrecte", "Erreur", MessageBoxButtons.OK);
            }
            if (!Outils.EstEntier(this.txtCodePostal.Text))
            {
                code = false;
                MessageBox.Show("le code Postal saisie est incorrecte", "Erreur", MessageBoxButtons.OK);
            }
            return code;
        }






        /// <summary>
        ///        //instancie controle et affecte les membres , intercepte les eventuelles erreur
        /// </summary>
        /// <returns>boolean : true = instanciation reussie/false erreur</returns>
        private bool instancie()
        {
            try
            {
                //affecter les donnees de la form a la nouvelle instance de  stagiaire
                //conversion de n°Osias en entier
                leStagiaire.NumOsia = int.Parse(base.txtOSIA.Text.Trim());

                // conversion en majuscule
                leStagiaire.Nom = base.txtNom.Text.ToUpper();

                // avec conversion en min      
                leStagiaire.Prenom = base.txtPrenom.Text.ToLower();
                leStagiaire.Rue = base.txtAdresse.Text;         // avec conversion en MAJ     
                leStagiaire.Ville = base.txtVille.Text;
                leStagiaire.CodePostal = base.txtCodePostal.Text.Trim();

                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de stagiaire");
                return false;

            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.afficheStagiaire(this.leStagiaire);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Donnees.ArrayStag.Remove(leStagiaire);
            this.DialogResult = DialogResult.OK;

        }
    }
}

