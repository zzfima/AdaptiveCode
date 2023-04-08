namespace ServiceInterfaces
{
    public interface ISecurityService
    {
        void ChangeUsersPassword(int userID, string newPassword);
    }
}