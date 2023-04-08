using Domain;

namespace DomainRepository
{
    public class UserRepository : IUserRepository
    {
        public IUser GetByID(int userID)
        {
            return new User() { Id = 456 };
        }
    }
}
