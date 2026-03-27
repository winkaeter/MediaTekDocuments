using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;
using System;

namespace MediaTekDocuments.controller
{
    class FrmAuthController
    {
        private readonly Access access;

        public FrmAuthController()
        {
            access = Access.GetInstance();
        }

        public Utilisateur GetConnection(string login, string pwd)
        {
            return access.GetConnection(login, pwd);
        }
    }
}
