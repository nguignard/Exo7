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
    public partial class frmClt : Form
    {
        private FicheClient leClient;
        private bool IsNewClient;

        public frmClt()
        {

            IsNewClient = true;
            InitializeComponent();
            controlesVisuels();


        }

        public frmClt(FicheClient unClient)
        {
            IsNewClient = false;
            this.leClient = unClient;
            InitializeComponent();
            controlesVisuels();

            afficheLeClient(this.leClient);
        }



        private void btnValider_Click(object sender, EventArgs e)
        {
            if (IsNewClient)
            {
                leClient = new FicheClient();
            }

            try
            {
                this.leClient.RaisonSociale = this.txtRaisonSociale.Text.Trim();
                this.leClient.Activite = this.cbxActivite.SelectedItem.ToString().Trim();
                this.leClient.Adresse = this.txtAdresse.Text.Trim();
                this.leClient.Ville = this.txtVille.Text.Trim().ToUpper();
                this.leClient.CP = this.txtCP.Text.Trim();
                this.leClient.Telephone = this.txtTelephone.Text.Trim();
                this.leClient.CA = decimal.Parse(this.txtCA.Text.Trim());
                this.leClient.Effectif = Int32.Parse(this.txtEffectif.Text.Trim());
                this.leClient.CommentComm = this.txtCommentComm.Text.Trim();
                this.leClient.Nature = grpStringValue(grpNature);//grpStringValue renvoie le string lie au rdb Actif du grpBox
                this.leClient.TypeSociete = grpStringValue(grpTypeSociete);

                if (IsNewClient)
                {
                    Donnees.ListeFicheClient.Add(leClient);
                }
                else
                {
                    Donnees.ListeFicheClient.Remove(this.leClient);
                    Donnees.ListeFicheClient.Insert(this.leClient.IdClient, this.leClient);
                }


                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                if (IsNewClient)
                    leClient = null;


                MessageBox.Show(ex.Message);
            }
        }









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
            this.btnContacts.Enabled = false;//??tant que pas de controle
                                             //if(Donnees.ListeFicheClient)

            // Begin - Initialisation de la comboBox Nature de la Société
            this.cbxActivite.Items.Clear();
            this.cbxActivite.Items.AddRange(new string[] { "Agro", "Industrie", "..." });
            //End - Initialisation de la comboBox Nature de la Société


            this.txtRaisonSociale.Focus();
        }

        /// <summary>
        /// bouton fermer ferme la boite de dialogue et retourne a la recherche de Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            //Verifier si 
            this.DialogResult = DialogResult.OK;

        }



        private void afficheLeClient(FicheClient unClient)
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

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (!IsNewClient)
                Donnees.ListeFicheClient.Remove(this.leClient);
            this.Close();
        }
    }







}
