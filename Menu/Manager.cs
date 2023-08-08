using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AircraftManagementApp.Enums;
using AircraftManagementApp.Managers.Implementations;
using AircraftManagementApp.Managers.Interfaces;

namespace AircraftManagementApp.Menu
{
    public class Manager
    {
        IAirportInterface airportInterface = new AirportManager();
        public void ManagerMenu()
        {
            Console.WriteLine("enter 1 for Airport Mgt\nenter 2 for Aircraft Mgt\nenter 3 for Flight Mgt\nEnter 4 for Passenger Mgt\nEnter 5 to go to previous Menu");
            int input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
                AirPortMgtMenu();
            }
            else if(input == 2)
            {

            }
            else if(input == 3)
            {
                
            }
            else if(input == 4)
            {
                
            }
            else if(input == 5)
            {
                
            }
        }

        public void AirPortMgtMenu()
        {
            Console.WriteLine("enter 1 to register airport\nenter 2 to view all airports\nenter 3 to delete an airport");
            int opt = int.Parse(Console.ReadLine());
            if(opt == 1)
            {
                RegisterAirportMenu();
            }
        }

        public void RegisterAirportMenu()
        {
            Console.WriteLine("enter airport name");
            string name = Console.ReadLine();
            Console.WriteLine("enter airport location");
            string location = Console.ReadLine();
            Console.WriteLine("enter 1 for local and enter 2 for international");
            int airportType = int.Parse(Console.ReadLine());

            var register =  airportInterface.Register(name,location,(AirportType)airportType);


        }
    }
}