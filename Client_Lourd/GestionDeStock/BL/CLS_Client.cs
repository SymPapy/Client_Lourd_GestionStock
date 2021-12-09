using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Client
    {
        private DbStockContext db = new DbStockContext();
        private Client C; // table Client

        // fonction pour ajouter un client dans la base de données

        public bool Ajouter_Client(string Nom, string prenom, string Adresse, string Telephone, string Email, string pays, string Ville)
        {
            C = new Client(); // Nouveau Client
            C.Nom_Client = Nom;
            C.Prenom_Client = prenom;
            C.Adresse_Client = Adresse;
            C.Telephone_Client = Telephone;
            C.Email_Client = Email;
            C.Pays_Client = pays;
            C.Ville_CLient = Ville;

            // Verification si le Nom et Prenom existe déjà dans la BDD

            if(db.Clients.SingleOrDefault(s=>s.Nom_Client == Nom && C.Prenom_Client == prenom)== null) // si n'existe pas
            {
                db.Clients.Add(C); // Ajouter dans la table client
                db.SaveChanges(); // Enregistrer dans la base de données
                return true;
            }
            else // si existe
            {
                return false;
            }
        }
    }
}
