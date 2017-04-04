using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abi
{
    public partial class frmContact : Form
    {
        private FicheClient leClientActif = Donnees.ListeFicheClient[Donnees.idClientActif];
        private Contact leContact; // attribut de classe
        private bool IsNewContact;// vrai si le client est nouveau, permet d'ajouter un nouveau client a la liste dans donnees,
                                  //ou de remplacer le Client actuel à modifier

        public frmContact()
        {
            IsNewContact = true;
            InitializeComponent();
            controlesVisuels();
        }


        public frmContact(Contact c)
        {
            IsNewContact = false;
            this.leContact = c;
            InitializeComponent();
            controlesVisuels();

            afficheContact();//fonction permettant d'afficher le Contac
        }
        //END - CONSTRUCTEUR DE CLASSE


        //BEGIN - EVENEMENT LIES AUX BOUTONS

        /// <summary>
        /// bouton fermer: ferme la boite de dialogue et retourne a la recherche de Client (modal)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Supprime le contacte de la liste des Clients si ce n'est pas un nouveau Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (!IsNewContact)
                leClientActif.ListContacts.Remove(this.leContact);

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Bouton annuler: remet a vide les cases ou  annule les modifications faites sur le Client actuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            //if (!IsNewContact)
            //{
            //    afficheContact();
            //    controlesVisuels();
            //}
            //else
            //{


            //    this.txtIdClient.Text = "";
            //    this.txtRaisonSociale.Text = "";

            //    this.txtAdresse.Text = "";
            //    this.txtCP.Text = "";
            //    this.txtVille.Text = "";


            //    //Gestion des radioboutons
            //    this.rdbPrincipal.Checked = true;
            //    this.rdbTypeClientPublic.Checked = true;

            //    this.cbxActivite.SelectedItem = "Agro";
            //    this.txtTelephone.Text = "";
            //    this.txtCA.Text = "";
            //    this.txtEffectif.Text = "";
            //    this.txtCommentComm.Text = "";
            //    controlesVisuels(); //met en place les contrôles visuels
            //}
        }


        /// <summary>
        /// au Clic Bouton Valider:
        /// - si c'est un nouveau Client, ajoute à la liste des Clients
        /// - sinon, modifie le Client existant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            // instanciation de leClient en cas de nouveau Client
            if (IsNewContact)
            {
                leContact = new Contact();
            }


            // tente de rentrer ou modifier un nouveau Client, sinon renvoie une exception (venant des accesseurs)
            try
            {
                this.leContact.Entreprise = this.txtEntreprise.Text.Trim(); //trim enleve les espaces avant et apres la chaine
                this.leContact.Nom = this.txtNom.Text.Trim();
                this.leContact.Prenom = this.txtPrenom.Text.Trim();
                this.leContact.Fonction = this.txtFonction.Text.Trim();//ToUpper met en majuscule
                this.leContact.Telephone = this.txtTelephone.Text.Trim();
                this.leContact.Projet = this.txtProjet.Text;
                this.leContact.Activite = this.txtActivite.Text;



                //Création ou modification du Client
                if (IsNewContact)
                {
                    Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts.Add(this.leContact); //Ajoute le nouveau Client à la liste statique dans données
                }
                else
                {
                    Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts.Remove(this.leContact);//remplace le Client par le Client modifié
                    Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts.Insert(this.leContact.IdContact, this.leContact);
                }
                this.DialogResult = DialogResult.OK; //ferme la fenetre modale

            }
            catch (Exception ex)
            {
                if (IsNewContact)
                    leContact = null;// annule la création si l'essai n'est pas concluant
                MessageBox.Show(ex.Message); // renvoie le message d'exception
            }
        }

        //END - GESTION DES BOUTONS


        //FONCTION D'affichage DIVERS////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// controleVisuel met tout les controles actifs, puis gere en fonction des cas quel boutons il faut afficher
        /// </summary>
        private void controlesVisuels()
        {
            this.txtEntreprise.Select();

            //Place tout les controles ON
            this.btnDocuments.Enabled = false;
            this.btnAnnuler.Enabled = true;
            this.btnValider.Enabled = true;//??? Faire un controle pour voir si un txtbox est rempli
            this.btnSupprimer.Enabled = true;
            this.btnFermer.Enabled = true;

            //Verifie dans quel cas les disable
            this.btnDocuments.Enabled = false;//??tant que pas de controle
                                              //if(Donnees.ListeFicheClient)
            this.txtActivite.Enabled = true;
        }

        /// <summary>
        /// Affiche le Client en cours de modification
        /// </summary>
        private void afficheContact()
        {
            this.txtEntreprise.Text = leContact.Entreprise.ToString();
            this.txtNom.Text = leContact.Nom.ToString();
            this.txtPrenom.Text = leContact.Prenom.ToString();
            this.txtFonction.Text = leContact.Fonction.ToString();
            this.txtTelephone.Text = leContact.Telephone.ToString();
            this.txtProjet.Text = leContact.ToString();

            this.txtActivite.Text = leContact.Activite.ToString();
            this.txtContact.Text = leContact.IdContact.ToString();


        }
    }
}
