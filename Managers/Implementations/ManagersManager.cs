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
    public class ManagersManager : IManagerInterface
    {
        List<Manager> managerDb = Database.ManagerDb;
        List<User> userDb = Database.UserDb;
        IUserInterface userInterface = new UserManager();
        public bool Delete(string staffNumber)
        {
            var manager = Get(staffNumber);
           if (manager != null)
           {
                managerDb.Remove(manager);
                return true;
           }
           return false;
        }

        public List<Manager> GetAll()
        {
            return managerDb;
        }

        public Manager Get(string staffNumber)
        {
            foreach (var manager in managerDb)
            {
                if (manager.StaffNumber == staffNumber)
                {
                    return manager;
                }
            }
            return null;
        }

        public Manager Register(string name, string email, string password, string address, string phoneNumber, Gender gender)
        {
            var exists = userInterface.Get(email);
            if (exists != null)
            {
                System.Console.WriteLine("email already exists");
            }
            var user = new User(userDb.Count+1,name,email,password,address,phoneNumber,gender,0,"Manager");
            userDb.Add(user);

            var manager = new Manager(managerDb.Count+1,email,"Clh/09");
            managerDb.Add(manager);

            return manager;
        }

        public Manager Update(string staffNumber)
        {
            throw new NotImplementedException();
        }

        private bool Check(string staffNumber)
        {
            foreach (var manager in managerDb)
            {
                if (manager.StaffNumber == staffNumber)
                {
                    return false;
                }
            }
            return true;
        }
    }
}