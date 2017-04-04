 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abi
{
    class Contact
    {

        private string entreprise;
        private string nom;
        private string prenom;
        private string fonction;
        private string telephone;
        private string projet;

        public string Entreprise
        {
            get
            {
                return entreprise;
            }

            set
            {
                entreprise = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Fonction
        {
            get
            {
                return fonction;
            }

            set
            {
                fonction = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public string Projet
        {
            get
            {
                return projet;
            }

            set
            {
                projet = value;
            }
        }

        public Contact(string entreprise, string nom, string prenom, string fonction, string telephone, string projet)
        {
            this.Entreprise = entreprise;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Fonction = fonction;
            this.Telephone = telephone;
            this.Projet = projet;
        }
    }
}
