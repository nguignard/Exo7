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
        frmClt frmFicheClient; //attribut de Class
        private Int32 idClient;

        /// <summary>
        /// Constructeur de la fenetre liste Client et ajout de 6 Clients
        /// </summary>
        public frmGrdClt()
        {
            //BEGIN  - JEU DE TEST: Création de 5 Clients virtuels comme jeux de test a l'ouverture du Form
            for (int i = 0; i < 5; i++)
            {
                string cptemp = "0680" + i.ToString();
                Donnees.ListeFicheClient.Add(new FicheClient(i, 20 * i, 30 * i, "SARL" + i.ToString(), "Public", "Ancienne", "Adrese" + i.ToString(), cptemp, "ville" + i.ToString(), "Agro", "0606060" + i.ToString(), i.ToString()));
            }
            //END - TEst

            InitializeComponent();
            controlesVisuels();
            afficheClients();
        }


        //BEGIN - GESTION DES BOUTONS/////////////////////////////////////::
        /// <summary>
        /// Affiche un client individuel vide pour ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnAjouter_Click(object sender, EventArgs e)
        {
            frmFicheClient = new frmClt();

            if (frmFicheClient.ShowDialog() == DialogResult.OK)
            {
                controlesVisuels();// réaffiche la liste des Clients
                afficheClients();
            }
        }

        /// <summary>
        /// bouton fermer: Ferme le Form de recherche de Client retourne à frmMDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnCltDspQuitter_Click(object sender, EventArgs e)
        {
            Donnees.ListeFicheClient.Clear();
            this.Close();
        }

        /// <summary>
        /// Boutton supprimer , supprime le Client selectionne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnCltDspSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep = new DialogResult();
            rep = MessageBox.Show("Voulez vous vraiment supprimer?", "suppression", MessageBoxButtons.OKCancel);
            if (rep == DialogResult.OK)
            {
                if (grdCltDsp.CurrentRow != null)
                {
                    idClient = (Int32)grdCltDsp.CurrentRow.Cells[0].Value;
                }
                Donnees.ListeFicheClient.RemoveAt(idClient);
                this.controlesVisuels();
                this.afficheClients();
            }
        }

        /// <summary>
        /// Doubvle Clic sur le Grid : ouvre le Client Sellectionnne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void grdCltDsp_DoubleClick(object sender, EventArgs e)
        {
            if (grdCltDsp.CurrentRow != null)
            {
                idClient = (Int32)grdCltDsp.CurrentRow.Cells[0].Value;
            }
            FicheClient leClient = Donnees.ListeFicheClient[idClient-1];
            frmClt frmModifClient = new frmClt(leClient);
            if (frmModifClient.ShowDialog() == DialogResult.OK)
            {
                this.afficheClients();
            }
        }


        protected virtual void btnCltDspRechercher_Click(object sender, EventArgs e)
        {
            if (this.txtCltDspNomRecherche.Text != null)
            {
                ((DataView)(this.grdCltDsp.DataSource)).RowFilter = "[Raison Sociale] like '%" + this.txtCltDspNomRecherche.Text + "%'";
            }
        }

        protected virtual void btnCltDspTous_Click(object sender, EventArgs e)
        {
            this.txtCltDspNomRecherche.Text = null;
            afficheClients();
        }


        protected virtual void grdCltDsp_SelectionChanged(object sender, EventArgs e)
        {
            if (grdCltDsp.CurrentRow != null)
            {
                idClient = (Int32)grdCltDsp.CurrentRow.Cells[0].Value;
            }
        }



        private void txtCltDspNomRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            ((DataView)(this.grdCltDsp.DataSource)).RowFilter = "[Raison Sociale] like '%" + this.txtCltDspNomRecherche.Text + "%'";
        }

        //END - GESTION DES BOUTONS/////////////////////////////////////::




        // BEGIN - FONCTIONS D'AFFICHAGE////////////////////////////////////////////////////////////:


        /// <summary>
        /// Permets de rendre accessible les bons boutons version non optimisee mais plus secur
        /// </summary>
        protected virtual void controlesVisuels()
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
        /// Affiche les Clients dans le dataGrid
        /// </summary>
        protected virtual void afficheClients()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Numéro Client", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(string)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(string)));
            dt.Columns.Add(new DataColumn("CA", typeof(Decimal)));
            dt.Columns.Add(new DataColumn("Nature", typeof(String)));

            for (int i = 0; i < Donnees.ListeFicheClient.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = Donnees.ListeFicheClient[i].IdClient;
                dr[1] = Donnees.ListeFicheClient[i].RaisonSociale;
                dr[2] = Donnees.ListeFicheClient[i].Telephone;
                dr[3] = Donnees.ListeFicheClient[i].CA;
                dr[4] = Donnees.ListeFicheClient[i].Nature;
                dt.Rows.Add(dr);
            }

            this.grdCltDsp.DataSource = dt.DefaultView;
            this.grdCltDsp.Refresh();

            dt = null;
            dr = null;

        }

    }
}
