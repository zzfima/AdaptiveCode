namespace Domain
{
    public interface IUserRepository
    {
        IUser GetByID(int userID);
    }
}