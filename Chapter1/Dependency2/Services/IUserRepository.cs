namespace Services
{
    public interface IUserRepository
    {
        User GetByID(int userID);
    }
}