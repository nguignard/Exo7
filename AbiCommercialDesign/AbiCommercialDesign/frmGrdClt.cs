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
    public partial class frmGrdClt : Form
    {
        frmClt frmFicheClient;

        public frmGrdClt()

        {
            InitializeComponent();
            controlesVisuels();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmFicheClient = new frmClt();
        
            if (frmFicheClient.ShowDialog() == DialogResult.OK)
            {
                //?????afficheListe Client
            }

        }


        private void fermeFicheClient(object sender, FormClosingEventArgs e)
        {

        }




        private void controlesVisuels()
        {
            //Place tout les controles ON
            this.btnAjouter.Enabled = true;
            this.btnCltDspQuitter.Enabled = true;
            this.btnCltDspRechercher.Enabled = true;
            this.btnCltDspSupprimer.Enabled = true;
            this.btnCltDspTous.Enabled = true;
            this.txtCltDspNomRecherche.ReadOnly = false;


            if (Donnees.ListeFicheClient.Count ==0)
            {
                this.btnAjouter.Enabled = true;
                this.btnCltDspQuitter.Enabled = true;
                this.btnCltDspRechercher.Enabled = false;
                this.btnCltDspSupprimer.Enabled = false;
                this.btnCltDspTous.Enabled = false;
                this.txtCltDspNomRecherche.ReadOnly = true;
            }
        }


        /// <summary>
        /// bouton fermer: Ferme le Form de recherche de Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
