using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AircraftManagementApp.Enums;

namespace AircraftManagementApp.Models
{
    public class User
    {
        public int Id;
        public string Name;
        public string Email;
        public string Password;
        public string Address;
        public string PhoneNumber;
        public Gender Gender;
        public double Wallet;
        public string Role;   

        public User(int id, string name, string email,string password,string address,string phoneNumber,Gender gender,double wallet,string role)
        {
           Id = id;
           Name = name;
           Email = email;
           Password = password;
           Address = address;
           PhoneNumber = phoneNumber;
           Gender = gender;
           Wallet = wallet;
           Role = role;
        }
    }
}