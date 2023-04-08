using Domain;
using System;

namespace DomainRepository
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