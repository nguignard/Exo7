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
        FicheClient leClient;

        public frmGrdContact(FicheClient fc)
        {
            leClient = fc;

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
        protected virtual void afficheContacts()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("idContact", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(string)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(string)));
            dt.Columns.Add(new DataColumn("Entreprise", typeof(string)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(String)));

            for (int i = 0; i < leClient.ListContacts.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = leClient.ListContacts[i].IdClient;
                dr[1] = leClient.ListContacts[i].Nom;
                dr[2] = leClient.ListContacts[i].Prenom;
                dr[3] = leClient.ListContacts[i].Entreprise;
                dr[4] = leClient.ListContacts[i].Telephone;
                dt.Rows.Add(dr);
            }

            this.grdCltDsp.DataSource = dt.DefaultView;
            this.grdCltDsp.Refresh();

            dt = null;
            dr = null;

        }











    }
}
