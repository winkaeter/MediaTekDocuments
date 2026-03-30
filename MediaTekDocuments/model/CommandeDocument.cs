using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier CommandeDocument (contient les informations sur une commande de livres ou de DVD)
    /// </summary>
    public class CommandeDocument
    {
        /// <summary>
        /// Obtient ou définit l'identifiant de la commande
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Obtient ou définit la date de la commande
        /// </summary>
        public DateTime DateCommande { get; set; }
        /// <summary>
        /// Obtient ou définit le montant de la commande
        /// </summary>
        public double Montant { get; set; }
        /// <summary>
        /// Obtient ou définit le nombre d'exemplaires commandés
        /// </summary>
        public int NbExemplaire { get; set; }
        /// <summary>
        /// Obtient ou définit l'identifiant du livre ou DVD associé
        /// </summary>
        public string IdLivreDvd { get; set; }
        /// <summary>
        /// Obtient ou définit l'identifiant de l'état de suivi de la commande
        /// </summary>
        public int IdSuivi { get; set; }
        /// <summary>
        /// Obtient ou définit le libellé de l'état de suivi
        /// </summary>
        public string LibelleSuivi { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="CommandeDocument"/>
        /// </summary>
        /// <param name="id">Identifiant de la commande</param>
        /// <param name="dateCommande">Date de la commande</param>
        /// <param name="montant">Montant de la commande</param>
        /// <param name="nbExemplaire">Nombre d'exemplaires</param>
        /// <param name="idLivreDvd">Identifiant du document (livre ou dvd)</param>
        /// <param name="idSuivi">Identifiant du suivi</param>
        /// <param name="libelleSuivi">Libellé du suivi</param>
        public CommandeDocument(string id, DateTime dateCommande, double montant, int nbExemplaire, string idLivreDvd, int idSuivi, string libelleSuivi)
        {
            this.Id = id;
            this.DateCommande = dateCommande;
            this.Montant = montant;
            this.NbExemplaire = nbExemplaire;
            this.IdLivreDvd = idLivreDvd;
            this.IdSuivi = idSuivi;
            this.LibelleSuivi = libelleSuivi;
        }
    }
}