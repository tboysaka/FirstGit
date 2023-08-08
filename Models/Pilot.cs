using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AircraftManagementApp.Models
{
    public class Pilot
    {
        public int Id;
        public string UserEmail;
        public string StaffNumber;

        public Pilot(int id, string userEmail, string staffNumber)
        {
            Id = id;
            UserEmail = userEmail;
            StaffNumber = staffNumber;
        }
    }
}