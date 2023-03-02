using System;
using System.Collections.Generic;

namespace VendorMachine_APP.Model
{
    public class Parking
    {
        private Guid IdParking;
        private string NomParking { get; set; }
        private string TypeParking { get; set; }
        private string AdressParking { get; set; }
        private List<TariffAbonnement> ListTariffAbonnement;

        public Parking(List<TariffAbonnement> listTariffAbonnement, string nomParking, string typeParking,
            string adressParking)
        {
            IdParking = new Guid();
            ListTariffAbonnement = listTariffAbonnement;
            NomParking = nomParking;
            TypeParking = typeParking;
            AdressParking = adressParking;
        }
    }
}