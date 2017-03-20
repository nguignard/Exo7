using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo6
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // au lancement de l'application, initialiser le nombre de stagiaires             
            MStagiaire.NStag = 0;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //On modifie le form de demarage sachant que par defaut c'est en plus un abstract
            Application.Run(new frmLireStagiaire());
        }
    }
}
