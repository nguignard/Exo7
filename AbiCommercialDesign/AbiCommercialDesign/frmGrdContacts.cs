using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abi
{
    public partial class frmGrdContacts : Abi.frmGrdClt
    {

        frmContact frmNewContact;
        int idClient, idContact;
        private FicheClient leClientActif;
        private Contact leContactActif;

        public frmGrdContacts()
        {
            this.idClient = Donnees.idClientActif;
            this.leClientActif = Donnees.ListeFicheClient[this.idClient];

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
        protected override void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNewContact = new frmContact();

            if (frmNewContact.ShowDialog() == DialogResult.OK)
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
        protected override void btnCltDspQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Boutton supprimer , supprime le Client selectionne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void btnCltDspSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep = new DialogResult();
            rep = MessageBox.Show("Voulez vous vraiment supprimer?", "suppression", MessageBoxButtons.OKCancel);
            if (rep == DialogResult.OK)
            {
                if (this.grdCltDsp.CurrentRow != null)
                {
                    idContact = (Int32)this.grdCltDsp.CurrentRow.Cells[0].Value;
                }
                foreach (Contact c in leClientActif.ListContacts)
                {
                    if (c.IdContact == idContact)
                    {
                        leContactActif = c;
                    }
                }
                leClientActif.ListContacts.Remove(leContactActif);
                this.controlesVisuels();
                this.afficheClients();
            }
        }

        /// <summary>
        /// Doubvle Clic sur le Grid : ouvre le Client Sellectionnne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void grdCltDsp_DoubleClick(object sender, EventArgs e)
        {
            if (grdCltDsp.CurrentRow != null)
            {
                idContact = (Int32)this.grdCltDsp.CurrentRow.Cells[0].Value;
            }
            foreach (Contact c in leClientActif.ListContacts)
            {
                if (c.IdContact == idContact)
                {
                    leContactActif = c;
                }
            }

            frmContact frmNewContact = new frmContact(this.leContactActif);
            if (frmNewContact.ShowDialog() == DialogResult.OK)
            {
                this.controlesVisuels();
                this.afficheClients();
            }

        }
        /// <summary>
        /// Réaffiche la liste complete des Clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void btnCltDspTous_Click(object sender, EventArgs e)
        {
            this.txtCltDspNomRecherche.Text = null;
            afficheClients();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void grdCltDsp_SelectionChanged(object sender, EventArgs e)
        {
            if (this.grdCltDsp.CurrentRow != null)
            {
                idClient = (Int32)grdCltDsp.CurrentRow.Cells[0].Value;
            }
        }
        /// <summary>
        /// Quand on ecrit dans le txtbox Recherche, commence un tri actif
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCltDspNomRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            ((DataView)(this.grdCltDsp.DataSource)).RowFilter = "[Raison Sociale] like '%" + this.txtCltDspNomRecherche.Text + "%'";
        }
        //END - GESTION DES BOUTONS/////////////////////////////////////::




        // BEGIN - FONCTIONS D'AFFICHAGE////////////////////////////////////////////////////////////:

        /// <summary>
        /// Permets de rendre accessible les bons boutons version non optimisee mais plus secur
        /// </summary>
        protected override void controlesVisuels()
        {
            //Place tout les controles Accessibles
            this.btnAjouter.Enabled = true;
            this.btnCltDspQuitter.Enabled = true;
            this.btnCltDspSupprimer.Enabled = true;
            this.btnCltDspTous.Enabled = true;
            this.txtCltDspNomRecherche.ReadOnly = false;

            //si il n'y a pas encore de Client, Rechercher, supprimer et tous ne sont pas visible
            if (Donnees.ListeFicheClient.Count == 0)
            {
                this.btnAjouter.Enabled = true;
                this.btnCltDspQuitter.Enabled = true;
                this.btnCltDspSupprimer.Enabled = false;
                this.btnCltDspTous.Enabled = false;
                this.txtCltDspNomRecherche.ReadOnly = true;
            }
            else
            {
                this.btnAjouter.Enabled = true;
                this.btnCltDspQuitter.Enabled = true;
                this.btnCltDspSupprimer.Enabled = true;
                this.btnCltDspTous.Enabled = true;
                this.txtCltDspNomRecherche.ReadOnly = false;
            }
        }

        /// <summary>
        /// Prépare l'affichage et Affiche les Clients dans le dataGrid 
        /// </summary>
        protected override void afficheClients()
        {
            DataTable dtc = new DataTable();
            DataRow drc;

            dtc.Columns.Add(new DataColumn("IdContact", typeof(Int32)));
            dtc.Columns.Add(new DataColumn("Nom", typeof(string)));
            dtc.Columns.Add(new DataColumn("Prénom", typeof(string)));
            dtc.Columns.Add(new DataColumn("Entreprise", typeof(string)));
            dtc.Columns.Add(new DataColumn("Téléphone", typeof(Decimal)));
  

            for (int i = 0; i < this.leClientActif.ListContacts.Count; i++)
            {
                drc = dtc.NewRow();
                drc[0] = this.leClientActif.ListContacts[i].IdContact;
                drc[1] = this.leClientActif.ListContacts[i].Nom;
                drc[2] = this.leClientActif.ListContacts[i].Prenom;
                drc[3] = this.leClientActif.ListContacts[i].Entreprise;
                drc[4] = this.leClientActif.ListContacts[i].Telephone;
                dtc.Rows.Add(drc);
            }

            this.grdCltDsp.DataSource = dtc.DefaultView;
            this.grdCltDsp.Refresh();

            dtc = null;
            drc = null;

        }
    }
}
