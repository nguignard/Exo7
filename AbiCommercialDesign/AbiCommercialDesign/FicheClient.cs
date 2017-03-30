using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abi
{
    /// <summary>
    /// FicheClient est la Classe définnissant ce qu'est un Client de l'entreprise
    /// </summary>
    public class FicheClient
    {
        //BEGIN ATTRIBUT
        private Int32 idClient;
        private string raisonSociale;
        private string typeSociete;
        private string nature;
        private string adresse;
        private int cp;
        private string ville;
        private string activite;
        private string telephone;
        private decimal ca;
        private Int32 effectif;
        //pivate string nomContact;
        //private string prenomContact;
        private string commentComm;
        // END ATTRIBUT




        //BEGIN - CONSTRUCTEURS DE LA CLASSE

        /// <summary>
        /// Constructeur avec tout les Attributs
        /// </summary>
        /// <param name="idClient"></param>
        /// <param name="raisonSociale"></param>
        /// <param name="typeSociete"></param>
        /// <param name="nature"></param>
        /// <param name="adresse"></param>
        /// <param name="cp"></param>
        /// <param name="ville"></param>
        /// <param name="activite"></param>
        /// <param name="telephone"></param>
        /// <param name="ca"></param>
        /// <param name="effectif"></param>
        /// <param name="commentComm"></param>
        public FicheClient(int idClient, string raisonSociale, string typeSociete, string nature, string adresse, int cp, string ville, string activite, string telephone, decimal ca, int effectif, string commentComm)
        {
            this.idClient = idClient;
            this.raisonSociale = raisonSociale;
            this.typeSociete = typeSociete;
            this.nature = nature;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            this.activite = activite;
            this.telephone = telephone;
            this.ca = ca;
            this.effectif = effectif;
            this.commentComm = commentComm;
        }

        /// <summary>
        /// Constructeur demandant aucun attribut
        /// </summary>
        public FicheClient()
        {
        }

        //END CONSTRUCTEURS


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

        public int CP
        {
            get
            {
                return cp;
            }

            set
            {
                cp = value;
            }
        }

        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }

        ///  FIN ACCESSEURS
    }
}
