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
    public partial class frmGrdContact : Form
    {
        private Int32 idClient;
        private FicheClient clientActif;
        private List<Contact> listContacts;

        frmClt frmClient; //attribut de Class
        
        public frmGrdContact()
        {

            this.idClient = Donnees.idClientActif;
            this.clientActif = Donnees.ListeFicheClient[this.idClient];
            this.listContacts = this.clientActif.ListContacts;

            //INITIALISATION DES COMPOSANTS ET AFFICHAGES DES CLIENTS
            InitializeComponent();
            controlesVisuels();
            afficheContacts();
        }



        // BEGIN - FONCTIONS D'AFFICHAGE////////////////////////////////////////////////////////////:

        /// <summary>
        /// Permets de rendre accessible les bons boutons version non optimisee mais plus secur
        /// </summary>
        private void controlesVisuels()
        {
            //Place tout les controles Accessibles
            this.btnAjouter.Enabled = true;
            this.btnQuitter.Enabled = true;
            this.btnSupprimer.Enabled = true;
            this.btnTous.Enabled = true;
            this.txtRecherche.ReadOnly = false;

            //si il n'y a pas encore de Client, Rechercher, supprimer et tous ne sont pas visible
            if (Donnees.ListeFicheClient.Count == 0)
            {
                this.btnAjouter.Enabled = true;
                this.btnQuitter.Enabled = true;
                this.btnSupprimer.Enabled = false;
                this.btnTous.Enabled = false;
                this.txtRecherche.ReadOnly = true;
            }
            else
            {
                this.btnAjouter.Enabled = true;
                this.btnQuitter.Enabled = true;
                this.btnSupprimer.Enabled = true;
                this.btnTous.Enabled = true;
                this.txtRecherche.ReadOnly = false;
            }
        }



        /// <summary>
        /// Prépare l'affichage et Affiche les Clients dans le dataGrid 
        /// </summary>
        private void afficheContacts()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Numéro Contact", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(string)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(string)));
            dt.Columns.Add(new DataColumn("Entreprise", typeof(string)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(String)));

            for (int i = 0; i < Donnees.ListeFicheClient.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = listContacts[i].IdClient;
                dr[1] = listContacts[i].Nom;
                dr[2] = listContacts[i].Prenom;
                dr[3] = listContacts[i].Entreprise;
                dr[4] = listContacts[i].Telephone;
                dt.Rows.Add(dr);
            }

            this.grdContact.DataSource = dt.DefaultView;
            this.grdContact.Refresh();

            dt = null;
            dr = null;

        }








    }
}
