namespace Services
{
    public class UserRepository : IUserRepository
    {
        public User GetByID(int userID)
        {
            return new User() { Id = 456 };
        }
    }
}
