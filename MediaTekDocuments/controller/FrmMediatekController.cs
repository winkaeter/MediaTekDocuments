using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;
using System;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmMediatek
    /// </summary>
    class FrmMediatekController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmMediatekController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return access.GetAllGenres();
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Liste d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return access.GetAllRayons();
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return access.GetAllPublics();
        }


        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocuement">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }

        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return access.CreerExemplaire(exemplaire);
        }

        /// <summary>
        /// Récupère les commandes d'un document
        /// </summary>
        /// <param name="idDocument">Identifiant du document</param>
        /// <returns>Liste des commandes du document</returns>
        public List<CommandeDocument> GetCommandesDocument(string idDocument)
        {
            return Access.GetInstance().GetCommandesDocument(idDocument);
        }

        /// <summary>
        /// Supprime une commande de document
        /// </summary>
        /// <param name="commande">Objet CommandeDocument à supprimer</param>
        /// <returns>True si la suppression a pu se faire</returns>
        public bool SupprimerCommandeDocument(CommandeDocument commande)
        {
            return Access.GetInstance().DeleteCommande(commande.Id);
        }

        /// <summary>
        /// Récupère la liste des suivis
        /// </summary>
        /// <returns>Liste d'objets Categorie (suivi)</returns>
        public List<Categorie> GetAllSuivis()
        {
            return Access.GetInstance().GetAllSuivis();
        }

        /// <summary>
        /// Crée une nouvelle commande de document
        /// </summary>
        /// <param name="commande">Objet CommandeDocument à créer</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool createCommande(CommandeDocument commande)
        {
            return access.CreerCommande(commande);
        }

        /// <summary>
        /// Récupère le prochain identifiant de commande
        /// </summary>
        /// <returns>Identifiant de commande formaté</returns>
        public string GetNextCommandeId()
        {
            return access.GetNextCommandeId();
        }

        /// <summary>
        /// Met à jour l'état de suivi d'une commande
        /// </summary>
        /// <param name="idCommande">Identifiant de la commande</param>
        /// <param name="idSuivi">Identifiant du nouvel état de suivi</param>
        /// <returns>True si la mise à jour a pu se faire</returns>
        public bool UpdateSuiviCommande(string idCommande, string idSuivi)
        {
            return access.UpdateSuiviCommande(idCommande, idSuivi);
        }

        /// <summary>
        /// Récupère les abonnements d'une revue
        /// </summary>
        /// <param name="idRevue">Identifiant de la revue</param>
        /// <returns>Liste des abonnements de la revue</returns>
        public List<Abonnement> GetAbonnements(string idRevue)
        {
            return access.GetAbonnements(idRevue);
        }

        /// <summary>
        /// Crée un nouvel abonnement
        /// </summary>
        /// <param name="abonnement">Objet Abonnement à créer</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerAbonnement(Abonnement abonnement)
        {
            return access.CreerAbonnement(abonnement);
        }

        /// <summary>
        /// Supprime un abonnement
        /// </summary>
        /// <param name="abonnement">Objet Abonnement à supprimer</param>
        /// <returns>True si la suppression a pu se faire</returns>
        public bool SupprimerAbonnement(Abonnement abonnement)
        {
            return access.SupprimerAbonnement(abonnement.Id);
        }
    }
}
