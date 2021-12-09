using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Connexion
    {
        // Function pour vérifier la connexion
        public bool ConnexionValide(DbStockContext db, string Nom, string Mot_de_passe)
        {
            Utilisateur U = new Utilisateur(); // Table Utilisateur
            U.NomUtilisateur = Nom;
            U.Mot_De_Passe = Mot_de_passe;
            if(db.Utilisateurs.SingleOrDefault(s => s.NomUtilisateur == Nom && s.Mot_De_Passe == Mot_de_passe ) !=null) // si le User et le MDP existe dans la BDD
            {
                return true;
            }else // si n'existe pas
            {
                return false;
            }
        }
    }
}
