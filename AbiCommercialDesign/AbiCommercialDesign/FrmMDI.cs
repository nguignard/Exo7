using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbiCommercialDesign
{
    public partial class FrmMDI : Form
    {

        private frmGrdClt listeClient;

        public FrmMDI()
        {
            InitializeComponent();

        }

        private void commercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listeClient == null)
            {
                listeClient = new frmGrdClt();
                listeClient.MdiParent = this;
                this.listeClient.FormClosing += new FormClosingEventHandler(this.fermeFrmGrdClt);
                listeClient.Show();
            }
            else
                this.listeClient.Activate();
        }

        private void fermeFrmGrdClt(object sender, FormClosingEventArgs e)
        {
            this.listeClient = null;
        }



    }
}
