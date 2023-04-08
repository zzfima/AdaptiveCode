using Services;
using System;

namespace Controllers
{
    public class AccountController
    {
        private readonly ISecurityService _securityService;

        public AccountController(ISecurityService securityService)
        {
            if (securityService == null) throw new ArgumentNullException("securityService");
            _securityService = securityService;

            //Problem! Nothing stops user from creating specific classes! Becouse i have Services reference
            var x = new SecurityService(new UserRepository());
        }

        public void ChangePassword(int userID, string newPassword)
        {
            _securityService.ChangeUsersPassword(userID, newPassword);
        }
    }
}