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
        public frmClt()
        {
            InitializeComponent();
            controlesVisuels();

            // Begin - Initialisation de la comboBox Nature de la Société
            this.cbxActivite.Items.Clear();
            this.cbxActivite.Items.AddRange(new string[] { "Agro", "Industrie", "..." });
            //End - Initialisation de la comboBox Nature de la Société
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            FicheClient nouveauClient = new FicheClient();
            
            try
            {
                nouveauClient.IdClient = Int32.Parse(this.txtIdClient.Text.Trim());
                nouveauClient.RaisonSociale = this.txtRaisonSociale.Text.Trim();
                nouveauClient.Activite = this.cbxActivite.SelectedItem.ToString().Trim();
                nouveauClient.Adresse = this.txtAdresse.Text.Trim();
                nouveauClient.Ville = this.txtVille.Text.Trim().ToUpper();
                nouveauClient.CP = this.txtCP.Text.Trim();
                nouveauClient.Telephone = this.txtTelephone.Text.Trim();
                nouveauClient.CA = decimal.Parse(this.txtCA.Text.Trim());
                nouveauClient.Effectif = Int32.Parse(this.txtEffectif.Text.Trim());
                nouveauClient.CommentComm = this.txtCommentComm.Text.Trim();
                nouveauClient.Nature = grpStringValue(grpNature);//grpStringValue renvoie le string lie au rdb Actif du grpBox
                nouveauClient.TypeSociete = grpStringValue(grpTypeSociete);

                Donnees.ListeFicheClient.Add(nouveauClient);
               
                this.DialogResult=DialogResult.OK;

            }
            catch (Exception ex)
            {
                nouveauClient = null;
                MessageBox.Show(ex.Message);
            }




        }









        /// <summary>
        /// grpStringValue renvoie le string lie au rdb Actif dans la groupbox choisie
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
            //Place tout les controles ON
            this.btnAnnuler.Enabled = true;
            this.btnContacts.Enabled = true;//??tant que pas de controle
            this.btnFermer.Enabled = true;
            this.btnSupprimer.Enabled = true;
            this.btnValider.Enabled = true;//??? Faire un controle pour voir si un txtbox est rempli


            //Verifie dans quel cas les disable
            this.btnContacts.Enabled = false;//??tant que pas de controle
            //if(Donnees.ListeFicheClient)
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

    }







}
