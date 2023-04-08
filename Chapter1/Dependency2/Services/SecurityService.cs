using Domain;
using ServiceInterfaces;
using System;

namespace ServiceImplementations
{
    public class SecurityService : ISecurityService
    {
        private readonly IUserRepository userRepository;
        public SecurityService(IUserRepository userRepository)
        {
            if (userRepository == null) throw new ArgumentNullException("userRepository");
            this.userRepository = userRepository;
        }
        public void ChangeUsersPassword(int userID, string newPassword)
        {
            var user = userRepository.GetByID(userID);
            user.ChangePassword(newPassword);
        }
    }
}
