using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AircraftManagementApp.Models
{
    public class Passenger
    {
        public int Id;
        public string UserEmail;
        public double Wallet;

        public Passenger(int id, string userEmail, double wallet)
        {
            Id = id;
            UserEmail = userEmail;
            Wallet = wallet;
        }

    }
}