using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Utilisateurs
    {
        private DbStockContext db = new DbStockContext();
        private Utilisateur U; // table utilisateur

        public bool Ajouter_Utilisateur(string Nomutilisateur, string Motdepasse)
        {
            U = new Utilisateur(); // Nouveau utilisateur
            U.NomUtilisateur = Nomutilisateur;
            U.Mot_De_Passe = Motdepasse;

            if (db.Utilisateurs.SingleOrDefault(s => s.NomUtilisateur == Nomutilisateur && U.Mot_De_Passe == Motdepasse) == null) // si n'existe pas
            {
                db.Utilisateurs.Add(U); // Ajouter dans la table utilisateur
                db.SaveChanges(); // Enregistrer dans la base de données
                return true;
            }
            else // si existe
            {
                return false;
            }
        }

        public void Modifier_Utilisateur (string Nomutilisateur, string Motdepasse)
        {
            U = new Utilisateur();
            U = db.Utilisateurs.SingleOrDefault(s => s.NomUtilisateur == Nomutilisateur);

            if (U != null) // Si existe
            {
                U.NomUtilisateur = Nomutilisateur; // Nouveau nom d'utilisateur
                U.Mot_De_Passe = Motdepasse;
                db.SaveChanges(); // Enregistre les modification dans la base de données
            }
        }
        public void Supprimer_Utilisateur(string Nomutilisateur)
        {
            U = new Utilisateur();
            U = db.Utilisateurs.SingleOrDefault(s => s.NomUtilisateur == Nomutilisateur);
            if (U != null) // Si Existe
            {
                db.Utilisateurs.Remove(U); // Pour supprimer l'utilisateur
                db.SaveChanges();
            }
        }
    }
}
