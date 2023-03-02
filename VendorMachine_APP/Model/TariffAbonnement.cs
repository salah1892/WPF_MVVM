using System;
using System.Collections.Generic;

namespace VendorMachine_APP.Model
{
    public class TariffAbonnement
    {
        private Guid IdTariffAbonnement;
        private string TypeAbonnement { get; }
        private DateTime DateDebut { get; set; }
        private DateTime DateFin { get; set; }
        private readonly List<Abonnement> ListAbonnements;
        private List<Parking> ListParkings;

        public TariffAbonnement(List<Abonnement> listAbonnements, string typeAbonnement, DateTime dateDebut,
            DateTime dateFin, List<Parking> listParkings)
        {
            IdTariffAbonnement = new Guid();
            ListAbonnements = listAbonnements;
            TypeAbonnement = typeAbonnement;
            DateDebut = dateDebut;
            DateFin = dateFin;
            ListParkings = listParkings;
        }
    }
}