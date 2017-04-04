﻿using System;
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

        private frmContact frmFicheContact;
        private FicheClient leClientActif = Donnees.ListeFicheClient[Donnees.idClientActif];

        public frmGrdContacts()
        {
            InitializeComponent();
            controlesVisuels();
            afficheContacts();
        }


        //BEGIN - GESTION DES BOUTONS/////////////////////////////////////::
        /// <summary>
        /// Affiche un Contact individuel vide pour ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmFicheContact = new frmContact();

            if (frmFicheContact.ShowDialog() == DialogResult.OK)
            {
                controlesVisuels();// réaffiche la liste des Clients
                afficheContacts();
            }
        }


        /// <summary>
        /// bouton fermer: Ferme le Form de recherche de Client retourne à frmMDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspQuitter_Click(object sender, EventArgs e)
        {

            Donnees.ListeFicheClient.Clear();
            this.Close();
        }

        /// <summary>
        /// Boutton supprimer , supprime le Client selectionne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspSupprimer_Click(object sender, EventArgs e)
        {
            int i = base.grdCltDsp.CurrentRow.Index;
            leClientActif.ListContacts.RemoveAt(i);
            this.controlesVisuels();
            this.afficheContacts();
        }

        /// <summary>
        /// Doubvle Clic sur le Grid : ouvre le Client Sellectionnne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdCltDsp_DoubleClick(object sender, EventArgs e)
        {
            int i = base.grdCltDsp.CurrentRow.Index;

            frmContact frmModifContact = new frmContact(leClientActif.ListContacts[i]);


            frmModifContact.ShowDialog();
            this.afficheContacts();
        }

        //END - GESTION DES BOUTONS/////////////////////////////////////::










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



        private void afficheContacts()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Societe", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(string)));
            dt.Columns.Add(new DataColumn("Prenom", typeof(string)));
            dt.Columns.Add(new DataColumn("Fonction", typeof(Decimal)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(String)));

            for (int i = 0; i < Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts[i].Entreprise;
                dr[1] = Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts[i].Nom;
                dr[2] = Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts[i].Prenom;
                dr[3] = Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts[i].Fonction;
                dr[4] = Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts[i].Telephone;
                dt.Rows.Add(dr);
            }

            base.grdCltDsp.DataSource = dt;
            base.grdCltDsp.Refresh();

            dt = null;
            dr = null;

        }





    }
}
