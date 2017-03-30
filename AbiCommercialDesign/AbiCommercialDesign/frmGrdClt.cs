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
        private frmGrdClt listeClient;

        public frmGrdClt()

        {
            InitializeComponent();
            this.listeClient = new frmGrdClt();
            this.listeClient.MdiParent = this.MdiParent;
            this.listeClient.Show();


        }

    }
}
