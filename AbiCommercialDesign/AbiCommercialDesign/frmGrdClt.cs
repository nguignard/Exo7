﻿using System;
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
        private FicheClient ClientActif;

        /// <summary>
        /// Constructeur de la fenetre liste Client et ajout de 6 Clients
        /// </summary>
        public frmGrdClt()
        {
            //BEGIN  - JEU DE TEST: Création de 5 Clients virtuels comme jeux de test a l'ouverture du Form
            List<Contact> lc;
            for (int i = 0; i < 5; i++)
            {
                lc = new List<Contact>();
                Donnees.ListeFicheClient.Add(new FicheClient(i, 20 * i, 30 * i, "SARL" + i.ToString(), "Public", "Ancienne", "Adrese" + i.ToString(), "0680" + i.ToString(), "ville" + i.ToString(), "Agro", "0606060" + i.ToString(), i.ToString(), lc));
            }
            for (int i = 0; i < 4; i++)
            {
                Contact c;
                for (int j = 0; j < 5; j++)
                {
                    c = new Contact(Donnees.ListeFicheClient[i].IdClient, Donnees.ListeFicheClient[i].ListContacts.Count, "entreprise" + i.ToString() + "ET" + j.ToString(), "nom" + i.ToString() + "ET" + j.ToString(), "prenom" + i.ToString() + "ET" + j.ToString(), "fonction" + i.ToString() + "ET" + j.ToString(), "060606" + i.ToString(), "projet" + i.ToString(), "activite" + i.ToString());
                    Donnees.ListeFicheClient[i].ListContacts.Add(c);
                }
            }
            //END - JEU DE TEST


            //INITIALISATION DES COMPOSANTS ET AFFICHAGES DES CLIENTS
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
        private void btnAjouter_Click(object sender, EventArgs e)
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
            DialogResult rep = new DialogResult();
            rep = MessageBox.Show("Voulez vous vraiment supprimer?", "suppression", MessageBoxButtons.OKCancel);
            if (rep == DialogResult.OK)
            {
                if (grdCltDsp.CurrentRow != null)
                {
                    idClient = (Int32)grdCltDsp.CurrentRow.Cells[0].Value;
                }
                foreach (FicheClient c in Donnees.ListeFicheClient)
                {
                    if (c.IdClient == idClient)
                    {
                        ClientActif = c;
                    }
                }
                Donnees.ListeFicheClient.Remove(ClientActif);
                this.controlesVisuels();
                this.afficheClients();
            }
        }

        /// <summary>
        /// Doubvle Clic sur le Grid : ouvre le Client Sellectionnne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdCltDsp_DoubleClick(object sender, EventArgs e)
        {
            if (grdCltDsp.CurrentRow != null)
            {
                idClient = (Int32)grdCltDsp.CurrentRow.Cells[0].Value;
            }
            foreach (FicheClient c in Donnees.ListeFicheClient)
            {
                if (c.IdClient == idClient)
                {
                    ClientActif = c;
                }
            }


            frmClt frmClient = new frmClt(ClientActif);
            DialogResult result = frmClient.ShowDialog();
            Console.WriteLine("Result " + result);
            if (frmClient.ShowDialog() == DialogResult.OK) 
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
        private void btnCltDspTous_Click(object sender, EventArgs e)
        {
            this.txtCltDspNomRecherche.Text = null;
            afficheClients();
        }

        /// <summary>
        /// Conserve l'idClient à chaque changement de selection, est utilisé pour s'assurer la bonne selection d'unClient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdCltDsp_SelectionChanged(object sender, EventArgs e)
        {
            if (grdCltDsp.CurrentRow != null)
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
        private void controlesVisuels()
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
        private void afficheClients()
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
