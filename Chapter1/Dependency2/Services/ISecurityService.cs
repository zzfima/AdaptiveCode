namespace Services
{
    public interface ISecurityService
    {
        void ChangeUsersPassword(int userID, string newPassword);
    }
}