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
        {
            //Creer unstagiaire

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
            }

            catch (Exception ex)
            {
                
                nouveauStagiaire = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de stagiaire");

            }




            //Ajout du stagiaire dans la liste
            Donnees.ArrayStag.Add(nouveauStagiaire);

            //incrémentation du compteur de stagiaire reussi
            MStagiaire.NStag += 1;


            //FERMETURE FENETRE AJOUTER STAGIAIRE 
            //par validation, cela ferme le btnOK_Click
            this.DialogResult = DialogResult.OK;
        }






        //Cas d'annulation de la création
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //fermeture de la boite de dialogue par abandon
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
