using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abi
{
    public class Contact
    {
        private string entreprise;
        private string nom;
        private string prenom;
        private string fonction;
        private string telephone;
        private string projet;
        private string activite;

        private int idClient;
        private int idContact;

        public Contact(int idClient, int idContact,  string entreprise, string nom, string prenom, string fonction, string telephone, string projet, string activite)
        {
            this.idContact = idContact;// Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts.Count; 
            this.idClient = idClient;

            this.entreprise = entreprise;
            this.nom = nom;
            this.prenom = prenom;
            this.fonction = fonction;
            this.telephone = telephone;
            this.projet = projet;
            this.activite = activite;
        }

        public Contact()
        {
            this.IdContact = Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts.Count + 1;
        }


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


        public string Activite
        {
            get
            {
                return activite;
            }

            set
            {
                activite = value;
            }
        }



        //public static List<Contact> ListeContacts
        //{
        //    get
        //    {
        //        return listeContacts;
        //    }

        //    set
        //    {
        //        listeContacts = value;
        //    }
        //}

        public int IdClient
        {
            get
            {
                return idClient;
            }

            set
            {
                idClient = value;
            }
        }

        public int IdContact
        {
            get
            {
                return idContact;
            }

            set
            {
                idContact = value;
            }
        }
    }
}
