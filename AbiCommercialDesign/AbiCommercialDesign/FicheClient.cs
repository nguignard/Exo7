using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abi
{
    public class FicheClient
    {

        //BEGIN ATTRIBUT
        private Int32 idClient;
        private string raisonSociale;
        private string typeSociete;
        private string nature;
        private string adresse;
        private string activite;
        private string telephone;
        private decimal ca;
        private Int32 effectif;
        //pivate string nomContact;
        //private string prenomContact;
        private string commentComm;

        // END ATTRIBUT











        ///  DEBUT ACCESSEURS
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

        public string RaisonSociale
        {
            get
            {
                return raisonSociale;
            }

            set
            {
                raisonSociale = value.Trim().ToUpper();
            }
        }

        public string TypeSociete
        {
            get
            {

                return typeSociete;
            }

            set
            {
                typeSociete = value;
            }
        }

        public string Nature
        {
            get
            {
                return nature;
            }

            set
            {
                nature = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
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

        public decimal CA
        {
            get
            {
                return ca;
            }

            set
            {
                ca = value;
            }
        }

        public int Effectif
        {
            get
            {
                return effectif;
            }

            set
            {
                effectif = value;
            }
        }

        public string CommentComm
        {
            get
            {
                return commentComm;
            }

            set
            {
                commentComm = value;
            }
        }

        ///  FIN ACCESSEURS
    }
}
