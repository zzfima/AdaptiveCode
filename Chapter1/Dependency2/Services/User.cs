using ServicesInterfaces;
using System;

namespace Services
{
    public class User : IUser
    {
        public int Id { get; set; }
        public void ChangePassword(string newPassord)
        {
            Console.WriteLine("Password changed");
        }
    }
}