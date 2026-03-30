using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MediaTekDocuments.model;
using MediaTekDocuments.view; // Nécessaire car la méthode à tester est dans FrmMediatek

namespace Mediatek.Tests
{
    [TestClass]
    public class CommandeTests
    {
        [TestMethod]
        public void TestParutionDansAbonnement_ValidationDates()
        {
            Utilisateur user = new Utilisateur("1", "admin", "philippe", "erwann", 1, "administration");
            FrmMediatek frm = new FrmMediatek(user);

            // Ajout de DateTimeKind.Local à chaque création d'objet DateTime
            DateTime debut = new DateTime(2024, 01, 01, 0, 0, 0, DateTimeKind.Local);
            DateTime fin = new DateTime(2024, 12, 31, 0, 0, 0, DateTimeKind.Local);

            DateTime parutionDebut = new DateTime(2024, 01, 01, 0, 0, 0, DateTimeKind.Local);
            Assert.IsTrue(frm.ParutionDansAbonnement(debut, fin, parutionDebut), "La date de début devrait être incluse.");

            DateTime parutionFin = new DateTime(2024, 12, 31, 0, 0, 0, DateTimeKind.Local);
            Assert.IsTrue(frm.ParutionDansAbonnement(debut, fin, parutionFin), "La date de fin devrait être incluse.");

            DateTime parutionMilieu = new DateTime(2024, 06, 15, 0, 0, 0, DateTimeKind.Local);
            Assert.IsTrue(frm.ParutionDansAbonnement(debut, fin, parutionMilieu), "Une date en milieu d'abonnement doit être vraie.");

            DateTime parutionAvant = new DateTime(2023, 12, 31, 0, 0, 0, DateTimeKind.Local);
            Assert.IsFalse(frm.ParutionDansAbonnement(debut, fin, parutionAvant), "Une date avant le début doit être fausse.");

            DateTime parutionApres = new DateTime(2025, 01, 01, 0, 0, 0, DateTimeKind.Local);
            Assert.IsFalse(frm.ParutionDansAbonnement(debut, fin, parutionApres), "Une date après la fin doit être fausse.");
        }
    }
}