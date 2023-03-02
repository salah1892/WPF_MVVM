using System;
using System.Collections.Generic;
using VendorMachine_APP.Model;

namespace VendorMachine_APP.Model
{
    public class Abonnement
    {
        private Guid IdAbonnement { get; }
        private DateTime DateCreation { get; set; }
        private DateTime DateActivation { get; set; }
        private DateTime DateDesActivation { get; set; }
        private Abonnee Abonnees { get; }
        private TariffAbonnement TariffAbonnement { get; }

        public Abonnement(DateTime dateCreation, DateTime dateActivation,
            DateTime dateDesActivation, Abonnee abonnees, TariffAbonnement tariffAbonnement)
        {
            IdAbonnement = new Guid();
            DateCreation = dateCreation;
            DateActivation = dateActivation;
            DateDesActivation = dateDesActivation;
            Abonnees = abonnees;
            TariffAbonnement = tariffAbonnement;
        }
    }
}