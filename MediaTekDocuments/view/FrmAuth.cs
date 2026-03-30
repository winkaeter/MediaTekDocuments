using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Windows.Forms;
using MediaTekDocuments.model;
using MediaTekDocuments.controller;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;

namespace MediaTekDocuments.view
{
    public partial class FrmAuth : Form
    {
        private readonly FrmAuthController controller;
        public Utilisateur user { get; private set; }

        public FrmAuth()
        {
            InitializeComponent();
            this.controller = new FrmAuthController();
        }

        private void FrmAuth_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string identifiant = txtIdentifiant.Text;
            string password = txtPassword.Text;

            Utilisateur user = controller.GetConnection(identifiant, password);

            if(user == null)
            {
                txtIdentifiant.Text = "";
                txtPassword.Text = "";
                lblErreur.Text = "Identifiant ou mot de passe invalide.";
                return;
            }

            if(user.LibelleService == "Culture")
            {
                MessageBox.Show("Vous n'êtes pas autorisé à accéder à cette application !", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Abort;
                this.Close();
                return;
            }

            this.user = user;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
