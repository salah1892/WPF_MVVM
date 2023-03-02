using System;

namespace VendorMachine_APP.Model
{
    public class Payement
    {
        private Guid IdPayement;
        private DateTime DatePayement { get; set; }
        private Abonnement Abonnement{ get; set; }
        private Ticket Ticket{ get; set; }

        public Payement(DateTime datePayement, Abonnement abonnement)
        {
            IdPayement=new Guid();
            DatePayement = datePayement;
            Abonnement = abonnement;
        }

        public Payement(DateTime datePayement, Ticket ticket)
        {
            IdPayement=new Guid();
            DatePayement = datePayement;
            Ticket = ticket;
        }
    }
}