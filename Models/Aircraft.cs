using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AircraftManagementApp.Models
{
    public class Aircraft
    {
        public int Id;
        public string Name;
        public string EngineNumber;
        public int Capacity;

        public Aircraft(int id, string name, string engineNumber, int capacity)
        {
            Id = id;
            Name = name;
            EngineNumber = engineNumber;
            Capacity = capacity;
        }
    }
}