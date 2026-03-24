using System;

namespace MediaTekDocuments.model
{
    public class CommandeDocument
    {
        public string Id { get; set; }
        public DateTime DateCommande { get; set; }
        public double Montant { get; set; }
        public int NbExemplaire { get; set; }
        public string IdLivreDvd { get; set; }
        public int IdSuivi { get; set; }
        public string LibelleSuivi { get; set; }

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