using Exo7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exo6
{
    public partial class frmAjoutStagiaire : Exo6.frmStagiaire
    {
        public frmAjoutStagiaire()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        { //Creer un stagiaire
            if (this.controle())
            {
                if (this.instancie())
                {
                    MStagiaire.NStag++;
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

            MStagiaire nouveauStagiaire = new MStagiaire();

            try
            {
                //affecter les donnees de la form a la nouvelle instance de  stagiaire
                //conversion de n°Osias en entier
                nouveauStagiaire.NumOsia = int.Parse(base.txtOSIA.Text.Trim());

                // conversion en majuscule
                nouveauStagiaire.Nom = base.txtNom.Text.ToUpper();

                // avec conversion en min      
                nouveauStagiaire.Prenom = base.txtPrenom.Text.ToLower();
                nouveauStagiaire.Rue = base.txtAdresse.Text;         // avec conversion en MAJ     
                nouveauStagiaire.Ville = base.txtVille.Text;
                nouveauStagiaire.CodePostal = base.txtCodePostal.Text.Trim();


                //Ajout du stagiaire dans la liste
                Donnees.ArrayStag.Add(nouveauStagiaire);
                return true;
            }

            catch (Exception ex)
            {

                nouveauStagiaire = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de stagiaire");
                return false;

            }

        }






        //Cas d'annulation de la création
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //fermeture de la boite de dialogue par abandon
            this.DialogResult = DialogResult.Cancel;
        }







    }
}
