using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AircraftManagementApp.Data;
using AircraftManagementApp.Enums;
using AircraftManagementApp.Managers.Interfaces;
using AircraftManagementApp.Models;

namespace AircraftManagementApp.Managers.Implementations
{
    public class AirportManager : IAirportInterface
    {
        List<Airport> airportDb = Database.AirportDb;
        public bool Delete(string name)
        {
            var airport = Get(name);
            if (airport != null)
            {
                airportDb.Remove(airport);
                return true;
            }
            return false;
        }

        public Airport Get(string name)
        {
            foreach (var airport in airportDb)
            {
                if (airport.Name == name)
                {
                    return airport;
                }
            }
            return null;
        }

        public List<Airport> GetAll()
        {
            return airportDb;
        }

        
        private bool Check(string name)
        {
            foreach (var airport in airportDb)
            {
                if (airport.Name==name)
                {
                    return false;
                }
            }
            return true;
        }

        public Airport Update(string name)
        {
            throw new NotImplementedException();
        }

        public Airport Register(string name, string location, AirportType airportType)
        {
            var airportExists= Check(name);
            if (airportExists==false)
            {
                Console.WriteLine("Airport already exists");
                return null;
            } 
            Airport airport= new Airport(airportDb.Count+1,name,location,airportType);
            airportDb.Add(airport);
            return airport;
        }
    }
}