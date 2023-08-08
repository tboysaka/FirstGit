using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AircraftManagementApp.Data;
using AircraftManagementApp.Managers.Interfaces;
using AircraftManagementApp.Models;

namespace AircraftManagementApp.Managers.Implementations
{
    public class UserManager : IUserInterface
    {
        List<User> userDb = Database.UserDb;

        public bool FundWallet(string email, double amount)
        {
            var user = Get(email);
            if (user != null)
            {
                user.Wallet+=amount;
                return true;
            }
            return false;
        }

        public User Get(string email)
        {
            foreach (var user in userDb)
            {
                if(user.Email == email)    
                {
                    return user;
                }
            }
            return null;
        }

        public List<User> GetAll()
        {
            return userDb;
        }

        public User Login(string email, string password)
        {
            foreach (var user in userDb)
            {
                if(user.Email == email && user.Password == password)    
                {
                    return user;
                }
            }
            return null;
        }
    }
}