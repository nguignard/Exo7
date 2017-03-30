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
        private frmClt ficheClient;

        public frmGrdClt()

        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            if (this.ficheClient == null)
            {
                this.ficheClient = new frmClt();
                this.ficheClient.FormClosing += new FormClosingEventHandler(fermeFicheClient);
                this.ficheClient.MdiParent = this.MdiParent; 
                this.ficheClient.Show();
            }
            else
            {
                this.ficheClient.Activate();
            }
        }


        private void fermeFicheClient(object sender, FormClosingEventArgs e)
        {
            ficheClient = null;
        }



    }
}
