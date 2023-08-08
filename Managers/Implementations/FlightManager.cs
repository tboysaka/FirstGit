using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AircraftManagementApp.Data;
using AircraftManagementApp.Managers.Interfaces;
using AircraftManagementApp.Models;

namespace AircraftManagementApp.Managers.Implementations
{
    public class FlightManager : IFlightInterface
    {
        List<Flight> fligthDb = Database.FlightDb;

        public bool Cancel(string referenceNumber)
        {
            var flight = Get(referenceNumber);
            if (flight != null)
            {
                fligthDb.Remove(flight);
                return true;
            }
            return false;
        }

        public Flight Get(string referenceNumber)
        {
            foreach (var flight in fligthDb)
            {
                if (flight.ReferenceNumber == referenceNumber)
                {
                    return flight;
                }
            }
            return null;
        }

        public List<Flight> GetAll()
        {
            return fligthDb;
        }

        public Flight Update(string referenceNumber)
        {
            throw new NotImplementedException();
        }

        private bool Check(string name)
        {
            foreach (var flight in fligthDb)
            {
                if (flight.Name == name)
                {
                    return false;
                }   
            }
            return true;
        }

        public Flight Create(string takeOffPoint, string destination, DateTime takeOfTime, string pilotStaffNumber, string aircraftName, double price)
        {
            string name = GenName(takeOffPoint, destination, takeOfTime);
            var exists = Check(name);
            if(exists == true)
            {
                var flight = new Flight(fligthDb.Count+1,name,GenRefNum(),takeOffPoint,destination,takeOfTime,pilotStaffNumber,aircraftName,price,null);
                fligthDb.Add(flight);
                return flight;
            }

            Console.WriteLine("flight already");
            return null;

        }

        private string GenName(string takeOffPoint, string destination, DateTime takeOfTime)
        {
            return $"CLH/{takeOffPoint.Substring(0,3)}{destination.Substring(0,3)}{takeOfTime.Day}";
        }
        private string GenRefNum()
        {
            return  $"CLH/FLY/00/{fligthDb.Count+1}";
        }
    }
}