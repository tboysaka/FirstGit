using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AircraftManagementApp.Managers.Implementations;
using AircraftManagementApp.Managers.Interfaces;

namespace AircraftManagementApp.Menu
{
    public class Main
    {
        IUserInterface userManager = new UserManager();
        public void MainMenu()
        {
            Console.WriteLine("enter 1 to register\nenter 2 to login");
            int opt = int.Parse(Console.ReadLine());

            if (opt == 1)
            {

            }
            else if (opt == 2)
            {
                LoginMenu();
            }
            else
            {
                Console.WriteLine("wrong input");
                MainMenu();
            }


        }

        public void RegisterMenu()
        {

        }
        public void LoginMenu()
        {
            Console.WriteLine("enter your email");
            string email = Console.ReadLine();
            Console.WriteLine("enter your pin");
            string pin = Console.ReadLine();
            var user = userManager.Login(email, pin);
            if(user.Role == "Manager")
            {
                Manager m = new Manager();
                m.ManagerMenu();
            }
            else if(user.Role == "Passenger")
            {

            }
            else if(user.Role == "SuperAdmin")
            {
                
            }
        }

    }
}