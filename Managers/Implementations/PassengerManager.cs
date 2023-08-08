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
    public class PassengerManager : IPassengerInterface
    {
        List<Passenger> passengerDb = Database.PassengerDb;
        List<User> userDb = Database.UserDb;
        IUserInterface userInterface = new UserManager();
        public bool Delete(string email)
        {
            var passenger = Get(email);
            if (passenger != null)
            {
                passengerDb.Remove(passenger);
                return true;
            }
            return false;
        }

        public Passenger Get(string email)
        {
            foreach (var passenger in passengerDb)
            {
                if (passenger.UserEmail == email)
                {
                    return passenger;
                }
            }
            return null;
        }

        public List<Passenger> GetAll()
        {
            return passengerDb;
        }

        public Passenger Register(string name, string userEmail, string password, string address, string phoneNumber, Gender gender)
        {
            var exists = userInterface.Get(userEmail);
            if (exists != null)
            {
                System.Console.WriteLine("email already exists");
            }
            var user = new User(userDb.Count+1,name,userEmail,password,address,phoneNumber,gender,0,"Passenger");
            userDb.Add(user);

            var passenger = new Passenger(passengerDb.Count+1,userEmail,0);
            passengerDb.Add(passenger);

            return passenger;
        }

        public Passenger Update(string email)
        {
            throw new NotImplementedException();
        }

        private bool Check(string email)
        {
            foreach (var passenger in passengerDb)
            {
                if (passenger.UserEmail == email)
                {
                    return false;
                }
            }
            return true;
        }
    }
}