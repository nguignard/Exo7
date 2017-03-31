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
           
            //BEGIN  - TEST: Création de 5 Clients virtuels comme jeux de test a l'ouverture du Form
            for (int i = 0; i < 5; i++)
            {
                Donnees.ListeFicheClient.Add(new FicheClient(i, i.ToString(), i.ToString(), i.ToString(), i.ToString(), 60000+i, i.ToString(), i.ToString(), i.ToString(), 20 * i, 30 * i, i.ToString()));
            }

           // Donnees.ListeFicheClient.Add(new FicheClient(i, i.ToString(), i.ToString(), i.ToString(), i.ToString(), 06000 + i, i.ToString(), i.ToString(), i.ToString(), 20 * i, 30 * i, i.ToString()));
           // Donnees.ListeFicheClient.Add(new FicheClient(i, i.ToString(), i.ToString(), i.ToString(), i.ToString(), 06000 + i, i.ToString(), i.ToString(), i.ToString(), 20 * i, 30 * i, i.ToString()));
            //END TEst

            controlesVisuels();
            afficheClients();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmFicheClient = new frmClt();

            if (frmFicheClient.ShowDialog() == DialogResult.OK)
            {
                controlesVisuels();
                afficheClients();
            }
        }


        private void fermeFicheClient(object sender, FormClosingEventArgs e)
        {

        }



        /// <summary>
        /// Permets de rendre accessible les bons boutons version non optimisee mais plus secur
        /// </summary>
        private void controlesVisuels()
        {
            //Place tout les controles Accessibles
            this.btnAjouter.Enabled = true;
            this.btnCltDspQuitter.Enabled = true;
            this.btnCltDspRechercher.Enabled = true;
            this.btnCltDspSupprimer.Enabled = true;
            this.btnCltDspTous.Enabled = true;
            this.txtCltDspNomRecherche.ReadOnly = false;

            //si il n'y a pas encore de Client, Rechercher, supprimer et tous ne sont pas visible
            if (Donnees.ListeFicheClient.Count == 0)
            {
                this.btnAjouter.Enabled = true;
                this.btnCltDspQuitter.Enabled = true;
                this.btnCltDspRechercher.Enabled = false;
                this.btnCltDspSupprimer.Enabled = false;
                this.btnCltDspTous.Enabled = false;
                this.txtCltDspNomRecherche.ReadOnly = true;
            }
            else
            {
                this.btnAjouter.Enabled = true;
                this.btnCltDspQuitter.Enabled = true;
                this.btnCltDspRechercher.Enabled = true;
                this.btnCltDspSupprimer.Enabled = true;
                this.btnCltDspTous.Enabled = true;
                this.txtCltDspNomRecherche.ReadOnly = false;
            }
        }


        /// <summary>
        /// bouton fermer: Ferme le Form de recherche de Client retourne à frmMDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void afficheClients()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Numéro Client", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(string)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(string)));
            dt.Columns.Add(new DataColumn("CA", typeof(Decimal)));

            for (int i = 0; i < Donnees.ListeFicheClient.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = Donnees.ListeFicheClient[i].IdClient;
                dr[1] = Donnees.ListeFicheClient[i].RaisonSociale;
                dr[2] = Donnees.ListeFicheClient[i].Telephone;
                dr[3] = Donnees.ListeFicheClient[i].CA;
                dt.Rows.Add(dr);
            }

            this.grdCltDsp.DataSource = dt;
            this.grdCltDsp.Refresh();

            dt = null;
            dr = null;

        }

        private void btnCltDspSupprimer_Click(object sender, EventArgs e)
        {
            int i = this.grdCltDsp.CurrentRow.Index;



        }
    }
}
