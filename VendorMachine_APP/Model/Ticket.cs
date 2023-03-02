using System;

namespace VendorMachine_APP.Model
{
    public class Ticket
    {
        private Guid IdTicket;
        private bool Statut { get; set; }
        private DateTime DateEntree { get; }
        private DateTime DateSortie { get; set; }
        private float PrixTicket { get; set; }
        private TariffTicket TariffTicket { get; set; }
        private Payement Payement { get; set; }

        public Ticket(bool statut, DateTime dateEntree, DateTime dateSortie, float prixTicket,
            TariffTicket tariffTicket, Payement payement)
        {
            IdTicket = new Guid();
            Statut = statut;
            DateEntree = dateEntree;
            DateSortie = dateSortie;
            PrixTicket = prixTicket;
            TariffTicket = tariffTicket;
            Payement = payement;
        }
    }
}