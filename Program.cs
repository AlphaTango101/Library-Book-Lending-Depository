using System;
using System.Collections.Generic;

namespace BookDepository
{
    public class Book
    {
        enum Status
        {
            OnLoan,
            OnShelf,
            CheckedOut,
            InTransit
        }

        public enum Period
        {
            Week,
            Month
        }

        public string ShelfPosition { get; set; }
        public string Condition { get; set; }
        Status BookStatus { get; set; }
        Period LoanPeriod { get; set; }
        public List<Reservation> Reservations { get; private set; }

        public Book()
        {
            BookStatus = Status.InTransit;
            LoanPeriod = Period.Week;
        }

        public void AddToReservations(Reservation newReservation)
        {
            Reservations.Add(newReservation);
        }

        public Period GetLoanPeriod()
        {
            return LoanPeriod;
        }



    }
}
