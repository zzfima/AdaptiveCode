using System;

namespace Services
{
    public class User
    {
        public int Id { get; set; }
        public void ChangePassword(string newPassord)
        {
            Console.WriteLine("Password changed");
        }
    }
}