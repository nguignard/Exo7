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

    /// <summary>
    /// frmClt: est une fenetre qui gere la creation et la modification d'un Client Particulier
    /// </summary>
    public partial class frmClt : Form
    {
        private FicheClient leClient; // attribut de classe
        private bool IsNewClient;// vrai si le client est nouveau, permet d'ajouter un nouveau client a la liste dans donnees,
                                 //ou de remplacer le Client actuel à modifier

        private int idClient;

        //BEGIN - CONSTRUCTEURS DE CLASSE

        /// <summary>
        /// Constructeur pour un nouveau Client
        /// </summary>
        public frmClt()
        {
            IsNewClient = true;
            InitializeComponent();
            controlesVisuels(); //met en place les contrôles visuels
        }

        /// <summary>
        /// Constructeur pour un Client Existant
        /// </summary>
        /// <param name="unClient">unClient est de classe ficheClient est est envoye comme paramettre par double clic de la fenetre frmGrdClt </param>
        public frmClt(FicheClient unClient)
        {
            IsNewClient = false;
            this.leClient = unClient;
            InitializeComponent();
            controlesVisuels();
            afficheLeClient();//fonction permettant d'afficher le Client
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
            DialogResult rep = new DialogResult();
            rep = MessageBox.Show("Voulez vous vraiment supprimer?", "suppression", MessageBoxButtons.OKCancel);
            if (rep == DialogResult.OK)
            {
                if (!IsNewClient)
                    Donnees.ListeFicheClient.Remove(this.leClient);
            }
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Bouton annuler: remet a vide les cases ou  annule les modifications faites sur le Client actuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            if (!IsNewClient)
            {
                afficheLeClient();
                controlesVisuels();
            }
            else
            {


                this.txtIdClient.Text = "";
                this.txtRaisonSociale.Text = "";

                this.txtAdresse.Text = "";
                this.txtCP.Text = "";
                this.txtVille.Text = "";


                //Gestion des radioboutons
                this.rdbPrincipal.Checked = true;
                this.rdbTypeClientPublic.Checked = true;

                this.cbxActivite.SelectedItem = "Agro";
                this.txtTelephone.Text = "";
                this.txtCA.Text = "";
                this.txtEffectif.Text = "";
                this.txtCommentComm.Text = "";
                controlesVisuels(); //met en place les contrôles visuels
            }
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
            this.reccordClient();
            this.DialogResult = DialogResult.OK; //ferme la fenetre modale
        }


        private void btnContacts_Click(object sender, EventArgs e)
        {

            this.reccordClient();

            Donnees.idClientActif = this.idClient;

            frmGrdContacts frmModifContact = new frmGrdContacts();
            if (frmModifContact.ShowDialog() == DialogResult.OK)
            {
                this.afficheLeClient();
            }

           


        }



        //END - GESTION DES BOUTONS


        //FONCTION D'affichage DIVERS////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// grpStringValue renvoie le string lie au radiboutonS Actif dans la groupbox choisie
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        private string grpStringValue(GroupBox g)
        {
            string s;

            if (g == this.grpNature) //si on est dans le groupbox nature, on regarde quel rdb est checked et s renvoi le string
            {
                s = "Principal";
                if (this.rdbSecondaire.Checked)
                    s = "Secondaire";
                if (this.rdbAncienne.Checked)
                    s = "Ancienne";
            }
            else
            {
                s = "Public";
                if (this.rdbTypeClientPrive.Checked)
                    s = "Privé";
            }
            return s;
        }

        /// <summary>
        /// controleVisuel met tout les controles actifs, puis gere en fonction des cas quel boutons il faut afficher
        /// </summary>
        private void controlesVisuels()
        {
            this.txtRaisonSociale.Select();

            //Place tout les controles ON
            this.btnAnnuler.Enabled = true;
            this.btnContacts.Enabled = true;//??tant que pas de controle
            this.btnFermer.Enabled = true;
            this.btnSupprimer.Enabled = true;
            this.btnValider.Enabled = true;//??? Faire un controle pour voir si un txtbox est rempli


            //Verifie dans quel cas les disable
            this.btnContacts.Enabled = true;//??tant que pas de controle
                                            //if(Donnees.ListeFicheClient)

            // Begin - Initialisation de la comboBox Nature de la Société
            this.cbxActivite.Items.Clear();
            this.cbxActivite.Items.AddRange(new string[] { "Agro", "Industrie", "..." });
            //End - Initialisation de la comboBox Nature de la Société
        }

        /// <summary>
        /// Affiche le Client en cours de modification
        /// </summary>
        private void afficheLeClient()
        {
            this.txtIdClient.Text = leClient.IdClient.ToString();
            this.txtRaisonSociale.Text = leClient.RaisonSociale.ToString();

            this.txtAdresse.Text = leClient.Adresse.ToString();
            this.txtCP.Text = leClient.CP.ToString();
            this.txtVille.Text = leClient.Ville.ToString();


            //Gestion des radioboutons
            this.rdbAncienne.Checked = true;
            if (leClient.TypeSociete == "Principal")
            {
                this.rdbPrincipal.Checked = true;
            }
            else
            {
                if (leClient.TypeSociete == "Secondaire")
                {
                    this.rdbSecondaire.Checked = true;
                }
            }
            this.rdbTypeClientPublic.Checked = true;
            if (leClient.Nature == "Privé") this.rdbTypeClientPrive.Checked = true;

            this.cbxActivite.SelectedItem = leClient.Activite.ToString();
            this.txtTelephone.Text = leClient.Telephone.ToString();
            this.txtCA.Text = leClient.CA.ToString();
            this.txtEffectif.Text = leClient.Effectif.ToString();
            this.txtCommentComm.Text = leClient.CommentComm.ToString();
        }

        private void reccordClient()
        {
            // instanciation de leClient en cas de nouveau Client
            if (IsNewClient)
            {
                leClient = new FicheClient();
            }
            // tente de rentrer ou modifier un nouveau Client, sinon renvoie une exception (venant des accesseurs)
            try
            {
                this.leClient.RaisonSociale = this.txtRaisonSociale.Text.Trim(); //trim enleve les espaces avant et apres la chaine
                this.leClient.Activite = this.cbxActivite.SelectedItem.ToString().Trim();
                this.leClient.Adresse = this.txtAdresse.Text.Trim();
                this.leClient.Ville = this.txtVille.Text.Trim().ToUpper();//ToUpper met en majuscule
                this.leClient.CP = this.txtCP.Text.Trim();
                this.leClient.Telephone = this.txtTelephone.Text.Trim();
                this.leClient.CA = decimal.Parse(this.txtCA.Text.Trim());
                this.leClient.Effectif = Int32.Parse(this.txtEffectif.Text.Trim());
                this.leClient.CommentComm = this.txtCommentComm.Text.Trim();
                this.leClient.Nature = grpStringValue(grpNature);//grpStringValue renvoie le string lie au rdb Actif du grpBox
                this.leClient.TypeSociete = grpStringValue(grpTypeSociete);

                //Création ou modification du Client
                if (IsNewClient)
                {
                    Donnees.ListeFicheClient.Add(leClient); //Ajoute le nouveau Client à la liste statique dans données
                }
                else
                {
                    Donnees.ListeFicheClient.Remove(this.leClient);//remplace le Client par le Client modifié
                    Donnees.ListeFicheClient.Insert(this.leClient.IdClient, this.leClient);
                }

                this.idClient = leClient.IdClient;
           

            }
            catch (Exception ex)
            {
                if (IsNewClient)
                    leClient = null;// annule la création si l'essai n'est pas concluant
                MessageBox.Show(ex.Message); // renvoie le message d'exception
            }
        }




    }
}