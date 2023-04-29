using Domain;
using DomainRepository;

namespace ServiceImplementations
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
            
        }
        public IUser GetByID(int userID)
        {
            return new User() { Id = 456 };
        }
    }
}
