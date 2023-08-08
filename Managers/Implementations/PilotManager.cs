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
    public class PilotManager : IPilotInterface
    {
        List<Pilot> pilotDb = Database.PilotDb;
        public bool Delete(string useremail)
        {
            var pilot = Get(useremail);
            if (pilot != null)
            {
                pilotDb.Remove(pilot);
                return true;
            }
            return false;
        }

        public Pilot Get(string useremail)
        {
            foreach (var pilot in pilotDb)
            {
                if (pilot.UserEmail == useremail)
                {
                    return pilot;
                }
            }
            return null;
        }

        public List<Pilot> GetAll()
        {
            return pilotDb;
        }

        public Pilot Register(string name, string email, string password, string address, string phoneNumber, Gender gender)
        {
            throw new NotImplementedException();
        }

        public Pilot Update(string useremail)
        {
            throw new NotImplementedException();
        }

        private bool Check(string useremail)
        {
            foreach (var pilot in pilotDb)
            {
                if (pilot.UserEmail == useremail)
                {
                    return false;
                }
            }
            return true;
        }
    }
}