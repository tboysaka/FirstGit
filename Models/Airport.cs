using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AircraftManagementApp.Enums;

namespace AircraftManagementApp.Models
{
    public class Airport
    {
        public int Id;
        public string Name;
        public string Location;
        public AirportType AirportType;
        public Airport(int id, string name, string location, AirportType airportType)
        {
            Id = id;
            Name = name;
            Location = location;
            AirportType = airportType;
        }
    }
}