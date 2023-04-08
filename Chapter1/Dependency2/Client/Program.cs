using Services;
using SimpleInjector;
using System;

namespace Client
{
    internal class Program
    {
        private static Container container;

        static void Main(string[] args)
        {
            InitIoC();
            var securityService = container.GetInstance<ISecurityService>();
            securityService.ChangeUsersPassword(22, "koko");
            Console.ReadLine();
        }

        private static void InitIoC()
        {
            // 1. Create a new Simple Injector container
            container = new Container();

            // 2. Configure the container (register)
            container.Register<IUserRepository, UserRepository>(Lifestyle.Singleton);
            container.Register<ISecurityService, SecurityService>(Lifestyle.Singleton);

            // 3. Verify your configuration
            container.Verify();
        }
    }
}
