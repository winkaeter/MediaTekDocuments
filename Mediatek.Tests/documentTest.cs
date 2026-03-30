using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using System;

namespace Mediatek.Tests
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void TestLivre_Initialization()
        {
            // Données de test
            string id = "001";
            string titre = "Le Seigneur des Anneaux";
            string image = "image.jpg";
            string isbn = "123456";
            string auteur = "J.R.R. Tolkien";
            string collection = "Pocket";
            string idGenre = "G01";
            string genre = "Fantastique";
            string idPublic = "P01";
            string lePublic = "Adulte";
            string idRayon = "R01";
            string rayon = "Rayon 1";

            // Instanciation
            Livre livre = new Livre(id, titre, image, isbn, auteur, collection, idGenre, genre, idPublic, lePublic, idRayon, rayon);

            // Assertions
            Assert.AreEqual(id, livre.Id);
            Assert.AreEqual(titre, livre.Titre);
            Assert.AreEqual(auteur, livre.Auteur);
            Assert.AreEqual(isbn, livre.Isbn);
            Assert.AreEqual(genre, livre.Genre);
        }

        [TestMethod]
        public void TestRevue_Initialization()
        {
            Revue revue = new Revue("003", "Science et Vie", "img.jpg", "G03", "Science", "P01", "Adulte", "R03", "Rayon 3", "Mensuel", 15);

            Assert.AreEqual("003", revue.Id);
            Assert.AreEqual("Science et Vie", revue.Titre);
            Assert.AreEqual("Mensuel", revue.Periodicite);
            Assert.AreEqual(15, revue.DelaiMiseADispo);
        }

    }

    [TestClass]
    public class CommandeModelTests
    {
        [TestMethod]
        public void TestAbonnement_Initialization()
        {
            string id = "A001";
            DateTime dateCommande = new DateTime(2023, 10, 01, 0, 0, 0, DateTimeKind.Local);
            double montant = 50.5;
            DateTime dateFin = new DateTime(2024, 10, 01, 0, 0, 0, DateTimeKind.Local);
            string idRevue = "R001";

            Abonnement abo = new Abonnement(id, dateCommande, montant, dateFin, idRevue);

            Assert.AreEqual(id, abo.Id);
            Assert.AreEqual(montant, abo.Montant);
            Assert.AreEqual(dateFin, abo.DateFinAbonnement);
            Assert.AreEqual(idRevue, abo.IdRevue);
        }

        [TestMethod]
        public void TestCommandeDocument_Initialization()
        {
            CommandeDocument cmd = new CommandeDocument("C001", DateTime.Now, 25.0, 5, "L001", 1, "En cours");

            Assert.AreEqual(5, cmd.NbExemplaire);
            Assert.AreEqual("L001", cmd.IdLivreDvd);
            Assert.AreEqual("En cours", cmd.LibelleSuivi);
        }
    }

    [TestClass]
    public class SystemModelTests
    {
        [TestMethod]
        public void TestUtilisateur_Initialization()
        {
            Utilisateur user = new Utilisateur("1", "jdupont", "dupont", "Jean", 2, "Prêts");

            Assert.AreEqual("jdupont", user.Identifiant);
            Assert.AreEqual("Jean", user.Prenom);
            Assert.AreEqual("Prêts", user.LibelleService);
        }

        [TestMethod]
        public void TestEtat_Initialization()
        {
            Etat etat = new Etat("00001", "Neuf");
            Assert.AreEqual("00001", etat.Id);
            Assert.AreEqual("Neuf", etat.Libelle);
        }
    }

}