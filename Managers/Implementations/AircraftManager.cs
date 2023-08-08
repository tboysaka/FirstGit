using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AircraftManagementApp.Data;
using AircraftManagementApp.Managers.Interfaces;
using AircraftManagementApp.Models;

namespace AircraftManagementApp.Managers.Implementations
{
    public class AircraftManager : IAircraftInterface
    {
        List<Aircraft> aircraftDb = Database.AircraftDb;
        public bool Delete(string name)
        {
            var aircraft = Get(name);
            if(aircraft != null)
            {
                aircraftDb.Remove(aircraft);
                return true;
            }
            return false;
        }

        public Aircraft Get(string name)
        {
            foreach (var aircraft in aircraftDb)
            {
                if(aircraft.Name == name)
                {
                    return aircraft;
                }
            }
            return null;
        }

        public List<Aircraft> GetAll()
        {
            return aircraftDb;
        }

        public Aircraft Register(string name, string engineNumber, int capacity)
        {
            var exists = Check(name);
            if(exists == false)
            {
                System.Console.WriteLine("aircraft already exist");
                return null;
            }
            Aircraft aircraft = new Aircraft(aircraftDb.Count + 1, name, engineNumber, capacity);
            aircraftDb.Add(aircraft);
            return aircraft;

        }

        private bool Check(string name)
        {
            foreach (var aircraft in aircraftDb)
            {
                if (aircraft.Name == name)
                {
                    return false;
                }
            }
            return true;
        }

        public Aircraft Update(string name)
        {
            throw new NotImplementedException();
        }
    }
}