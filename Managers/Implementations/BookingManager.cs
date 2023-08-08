using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AircraftManagementApp.Data;
using AircraftManagementApp.Managers.Interfaces;
using AircraftManagementApp.Models;

namespace AircraftManagementApp.Managers.Implementations
{
    public class BookingManager : IBookingInterface
    {
        List<Booking> bookingDb = Database.BookingDb;
        IUserInterface userInterface = new UserManager();
        IFlightInterface flightInterface = new FlightManager();
        IAircraftInterface aircraftInterface = new AircraftManager();
        public bool Delete(string referenceNumber)
        {
           var booking = Get(referenceNumber);
           if (booking != null)
           {
                bookingDb.Remove(booking);
                return true;
           }
           return false;
        }

        public Booking Get(string referenceNumber)
        {
            foreach (var booking in bookingDb)
            {
                if (booking.ReferenceNumber == referenceNumber)
                {
                    return booking;
                }
            }
            return null;
        }

        public List<Booking> GetAll()
        {
            return bookingDb;
        }

        public Booking Make(string passengerEmail, string flightReferenceNumber)
        {
            var passenger = userInterface.Get(passengerEmail);
            var flight = flightInterface.Get(flightReferenceNumber);
            var aircraft = aircraftInterface.Get(flight.AircraftName);
            if(flight.Passengers.Count < aircraft.Capacity)
            {
                if(flight.Price <= passenger.Wallet)
                {
                    flight.Passengers.Add(passengerEmail);
                    var booking = new Booking(bookingDb.Count+1,"reghhu",flight.Passengers.Count,passengerEmail,flightReferenceNumber);
                    bookingDb.Add(booking);
                    Console.WriteLine($"booking with ref {booking.ReferenceNumber} is successful, your seat number is {booking.SeatNumber}, you are going with aircrat {aircraft.Name}");
                    return booking;
                }
                Console.WriteLine("insufficient balance");
                return null;

            }
            Console.WriteLine("flight not available");
            return null;
        }
    }
}