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
    public partial class FrmMDI : Form
    {

        private frmGrdClt frmlisteClient;

        public FrmMDI()
        {
            InitializeComponent();

        }

        private void commercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmlisteClient == null)
            {
                frmlisteClient = new frmGrdClt();
                frmlisteClient.MdiParent = this;
                this.frmlisteClient.FormClosing += new FormClosingEventHandler(this.fermeFrmGrdClt);
                frmlisteClient.Show();
            }
            else
                this.frmlisteClient.Activate();
        }

        private void fermeFrmGrdClt(object sender, FormClosingEventArgs e)
        {
            this.frmlisteClient = null;
        }



    }
}
