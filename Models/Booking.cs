using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AircraftManagementApp.Models
{
    public class Booking
    {
        public int Id;
        public string ReferenceNumber;
        public int SeatNumber;
        public string PassengerEmail;
        public string FlightReferenceNumber;

        public Booking(int id,string referenceNumber, int seatNumber, string passengerEmail, string flightReferenceNumber)
        {
            Id = id;
            ReferenceNumber = referenceNumber;
            SeatNumber = seatNumber;
            PassengerEmail = passengerEmail;
            FlightReferenceNumber = flightReferenceNumber;
        }

    }
}