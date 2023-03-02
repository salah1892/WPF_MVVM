using System;
using System.Collections.Generic;

namespace VendorMachine_APP.Model
{
    public class TariffTicket
    {
        private Guid IdTariffTicket;
        private DateTime DateEntree { get; set; }
        private DateTime DateSortie { get; set; }
        private readonly List<Ticket> ListTicket;

        public TariffTicket(DateTime dateEntree, DateTime dateSortie, List<Ticket> listTicket)
        {
            IdTariffTicket = new Guid();
            DateEntree = dateEntree;
            DateSortie = dateSortie;
            ListTicket = listTicket;
        }
    }
}