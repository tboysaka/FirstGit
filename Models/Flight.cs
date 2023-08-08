using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AircraftManagementApp.Models
{
    public class Flight
    {
        public int Id;
        public string Name;
        public string ReferenceNumber;
        public string TakeOffPoint;
        public string Destination;
        public DateTime TakeOfTime;
        public string PilotStaffNumber;
        public string AircraftName;
        public double Price;
        public List<string> Passengers = new List<string>();
        //public Dictionary<string, bool> PassengersMap = new Dictionary<string, bool>();

        public Flight(int id, string name, string referenceNumber, string takeOffPoint, string destination, DateTime takeOfTime, string pilotStaffNumber, string aircraftName, double price, List<string> passengers)
        {
            Id = id;
            Name = name;
            ReferenceNumber = referenceNumber;
            TakeOffPoint = takeOffPoint;
            Destination = destination;
            TakeOfTime = takeOfTime;
            PilotStaffNumber = pilotStaffNumber;
            AircraftName = aircraftName;
            Price = price;
            Passengers = passengers;
        }
    }
}