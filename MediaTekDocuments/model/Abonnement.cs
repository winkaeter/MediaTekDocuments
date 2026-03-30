using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Abonnement (contient les informations sur un abonnement à une revue)
    /// </summary>
    public class Abonnement
    {
        /// <summary>
        /// Obtient ou définit l'identifiant de l'abonnement
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Obtient ou définit la date de la commande
        /// </summary>
        public DateTime DateCommande { get; set; }
        /// <summary>
        /// Obtient ou définit le montant de l'abonnement
        /// </summary>
        public double Montant { get; set; }
        /// <summary>
        /// Obtient ou définit la date de fin de l'abonnement
        /// </summary>
        public DateTime DateFinAbonnement { get; set; }
        /// <summary>
        /// Obtient ou définit l'identifiant de la revue associée
        /// </summary>
        public string IdRevue { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Abonnement"/>
        /// </summary>
        /// <param name="id">Identifiant de l'abonnement</param>
        /// <param name="dateCommande">Date de la commande</param>
        /// <param name="montant">Montant de l'abonnement</param>
        /// <param name="dateFinAbonnement">Date de fin de l'abonnement</param>
        /// <param name="idRevue">Identifiant de la revue associée</param>
        public Abonnement(string id, DateTime dateCommande, double montant, DateTime dateFinAbonnement, string idRevue)
        {
            this.Id = id;
            this.DateCommande = dateCommande;
            this.Montant = montant;
            this.DateFinAbonnement = dateFinAbonnement;
            this.IdRevue = idRevue;
        }
    }
}