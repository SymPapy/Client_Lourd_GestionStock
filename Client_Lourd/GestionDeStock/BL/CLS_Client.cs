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

        //*******************************************************
        //**
        //************* FONCTION AJOUTER CLIENT BDD
        //**
        //*******************************************************
        public bool Ajouter_Client(string Nom, string prenom, string Adresse, string Telephone, string Email, string Ville, string pays)
        {
            C = new Client(); // Nouveau Client
            C.Nom_Client = Nom;
            C.Prenom_Client = prenom;
            C.Adresse_Client = Adresse;
            C.Telephone_Client = Telephone;
            C.Email_Client = Email;
            C.Ville_CLient = Ville;
            C.Pays_Client = pays;
          
            
           //**************************** VERIFICATION SI NOM & PRENOM EXISTE EN BASE ************************************

            if (db.Clients.SingleOrDefault(s=>s.Nom_Client == Nom && C.Prenom_Client == prenom)== null) // si n'existe pas
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
        //*******************************************************
        //**
        //************* FONCTION MODIFIER CLIENT BDD
        //**
        //*******************************************************
        public void Modifier_Client( int id, string Nom, string prenom, string Adresse, string Telephone, string Email, string Ville, string pays)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id); // Vérifie si id du client existe
            if (C != null) // Si existe
            {
                C.Nom_Client = Nom; // Nouveau nom de client
                C.Prenom_Client = prenom;
                C.Adresse_Client = Adresse;
                C.Telephone_Client = Telephone;
                C.Email_Client = Email;
                C.Ville_CLient = Ville;
                C.Pays_Client = pays;
                db.SaveChanges(); // Enregistre les modification dans la base de données
            }
        }

        //*******************************************************
        //**
        //************* FONCTION SUPPRIMER CLIENT DATAGRID
        //**
        //*******************************************************
        public void supprimer_Client(int id)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id);
            if (C != null) // Si Existe
            {
                db.Clients.Remove(C); // Pour supprimer le client
                db.SaveChanges();
            }
        }
    }
}
