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
        }

        public void ChangePassword(int userID, string newPassword)
        {
            _securityService.ChangeUsersPassword(userID, newPassword);
        }
    }
}