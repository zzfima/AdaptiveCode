﻿namespace ServicesInterfaces
{
    public interface IUserRepository
    {
        IUser GetByID(int userID);
    }
}