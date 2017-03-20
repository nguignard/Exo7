using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6
{
    public class MStagiaire
    {

        public static Int32 Nstag;
        private int numOsia;
        private string nomStagiaire;
        private string prenomStagiaire;
        private string rue;
        private string villeStagiaire;
        private string codePostalStagiaire;
        private int nbreNotes;
        private double pointsNotes;

        public int NumOsia { get { return numOsia; } set { this.numOsia = value; } }
        public string Nom { get { return this.nomStagiaire; } set { this.nomStagiaire = value.Trim().ToUpper(); } }
        public string Prenom { get { return this.prenomStagiaire; } set { this.prenomStagiaire = value.Trim().ToLower(); } }
        public string Rue { get { return this.rue; } set { this.rue = value; } }
        public string Ville { get { return this.villeStagiaire; } set { this.villeStagiaire = value.Trim().ToUpper(); } }
        public string CodePostal
        {
            get { return this.codePostalStagiaire; }
            set
            {
                // l'appelant doit fournir un code postal valide à 5 chiffres  
                Int32 i;               // variable de boucle  
                Boolean erreur = false; // indicateur erreur   
                if (value.Length == 5) // 5 car. attendus : OK ==> contrôler un à un          
                {
                    for (i = 0; i < value.Length; i++)  // controle chiffres par boucle          
                    {
                        if (!(Char.IsDigit(value[i]))) // charabia ??     
                        { erreur = true; }
                    } // fin de boucle controle chiffres          
                    if (erreur) //on a rencontre un non-chiffre              
                    {                 // première solution par simple messagebox         
                        System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : uniquement des chiffres", "Erreur Classe MStagiaire", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    else
                    {
                        codePostalStagiaire = value;  // tout est bon, on affecte la propriété           
                    }
                }
                else // il n'y a pas 5 caractères        
                {                 // première solution par simple messagebox           
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins", "Erreur Classe MStagiaire", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }

        }



        /// <summary>     /// alimente nbreNotes et pointsNotes     /// </summary>     /// <param name="laNote">la nouvelle note à prendre en compte</param>     
        public void RecevoirNote(float laNote) { this.nbreNotes++; this.pointsNotes += laNote; }

        /// <summary>     /// calcule et retourne la moyenne des notes     /// </summary>     /// <returns>nouvelle moyenne des notes</returns>    
        public Double DonnerMoyenne()
        { return this.pointsNotes / this.nbreNotes; }



    }
}
