using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AircraftManagementApp.Enums;
using AircraftManagementApp.Models;

namespace AircraftManagementApp.Data
{
    public class Database
    {
        public static List<Aircraft> AircraftDb = new List<Aircraft>();
        public static List<Airport> AirportDb = new List<Airport>();
        public static List<User> UserDb = new List<User>()
        {
            new User(1,"prosper","pro@gmail.com","1234","abeokuta","08136352828",(Gender)1,1000,"Manager"),

        };
        public static List<Pilot> PilotDb = new List<Pilot>();
        public static List<Passenger> PassengerDb = new List<Passenger>();
        public static List<Manager> ManagerDb = new List<Manager>();
        public static List<Flight> FlightDb = new List<Flight>();
        public static List<Booking> BookingDb = new List<Booking>();
    }
}