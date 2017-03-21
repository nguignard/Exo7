using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exo6;

namespace Exo7
{
    public partial class frmExo7 : Form
    {
        public frmExo7()
        {
            InitializeComponent();
        }









        private void afficheStagiaire()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            //on ajoute 3 colonnes à la dataTable
            dt.Columns.Add("Numero Osia", typeof(System.String));
            dt.Columns.Add("Nom", typeof(System.String));
            dt.Columns.Add("prenom", typeof(System.String));

            for (int i = 0; i < Donnees.ArrayStag.Count; i++)
            {
                dr = dt.NewRow(); //instanciation datarow = ligne

                dr[0] = Donnees.ArrayStag[i].NumOsia; //affectation des 3 colonne
                dr[1] = Donnees.ArrayStag[i].Nom;
                dr[2] = Donnees.ArrayStag[i].Prenom;

                dt.Rows.Add(dr); // ajjout d'unne nouvelle ligne, Rows est une collection
            }

            this.dataGridView1.DataSource = dt; // on affecte la source de la datagrid est dt
            this.dataGridView1.Refresh();
            dt = null;
            dr = null;



        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAjoutStagiaire frmAjout = new frmAjoutStagiaire(); //instancie un form Ajout Stagiaire

            if (frmAjout.ShowDialog() == DialogResult.OK) afficheStagiaire(); //si on sort des controles de frmAjout positivement on affiche la table
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            //On ouvre le stagiaire correspondant au double click
            int iStag; // rang du stagiaire dans le tableau
            iStag = this.dataGridView1.CurrentRow.Index; // n° de stagiaire = n° de la ligne

       
        }
    }
}
