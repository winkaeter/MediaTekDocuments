using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using MediaTekDocuments.model;
using MediaTekDocuments.controller;
using System.Linq;
using System.Drawing;
using System.IO;

namespace MediaTekDocuments.view
{
    /// <summary>
    /// Fenêtre d'authentification de l'application.
    /// Permet à l'utilisateur de se connecter en saisissant ses identifiants.
    /// </summary>
    public partial class FrmAuth : Form
    {
        /// <summary>
        /// Instance du contrôleur pour la gestion de l'authentification.
        /// </summary>
        private readonly FrmAuthController controller;

        /// <summary>
        /// Obtient l'utilisateur authentifié.
        /// </summary>
        public Utilisateur user { get; private set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="FrmAuth"/>.
        /// Configure le contrôleur d'authentification.
        /// </summary>
        public FrmAuth()
        {
            InitializeComponent();
            this.controller = new FrmAuthController();
        }

        /// <summary>
        /// Gère l'événement de chargement du formulaire.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void FrmAuth_Load(object sender, EventArgs e)
        {
            // Méthode laissée vide intentionnellement. 
            // Aucun traitement spécifique n'est requis au chargement du formulaire d'authentification.
        }

        /// <summary>
        /// Gère le clic sur le bouton de connexion.
        /// Vérifie les identifiants et le service de l'utilisateur pour autoriser l'accès.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string identifiant = txtIdentifiant.Text;
            string password = txtPassword.Text;

            Utilisateur utilisateur = controller.GetConnection(identifiant, password);

            if(utilisateur == null)
            {
                txtIdentifiant.Text = "";
                txtPassword.Text = "";
                lblErreur.Text = "Identifiant ou mot de passe invalide.";
                return;
            }

            if(utilisateur.LibelleService == "Culture")
            {
                MessageBox.Show("Vous n'êtes pas autorisé à accéder à cette application !", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Abort;
                this.Close();
                return;
            }

            this.user = utilisateur;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
