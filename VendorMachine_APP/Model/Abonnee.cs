using System;
using System.Collections.Generic;
using VMDashboard.Model;

namespace VendorMachine_APP.Model
{
    public class Abonnee
    {
        private Guid IdAbonnee { get; }
        private int NumCarte { get; }
        private string Nom { get; set; }
        private string Prenom { get; set; }
        private readonly List<Abonnement> ListAbonnements;

        public Abonnee(int numCarte, string nom, string prenom, List<Abonnement> listAbonnements)
        {
            IdAbonnee = new Guid();
            NumCarte = numCarte;
            Nom = nom;
            Prenom = prenom;
            ListAbonnements = listAbonnements;
        }
    }
}