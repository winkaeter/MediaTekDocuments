using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;
using System;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur pour la fenêtre d'authentification
    /// </summary>
    class FrmAuthController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Constructeur : récupère l'instance unique d'accès aux données
        /// </summary>
        public FrmAuthController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Vérifie les identifiants de connexion
        /// </summary>
        /// <param name="login">Identifiant de l'utilisateur</param>
        /// <param name="pwd">Mot de passe de l'utilisateur</param>
        /// <returns>Objet Utilisateur si connexion réussie, null sinon</returns>
        public Utilisateur GetConnection(string login, string pwd)
        {
            return access.GetConnection(login, pwd);
        }
    }
}
