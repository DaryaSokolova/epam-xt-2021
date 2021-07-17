using startWithThreeLayers.Dependencies;
using startWithThreeLayers.Entities;
using System;

namespace startWithThreeLayers.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var bll = DependencyResolver.Instance.UsersLogic;

            Award a1 = new Award(Guid.NewGuid(), "Music");
            Award a2 = new Award(Guid.NewGuid(), "Sport");
            Award a3 = new Award(Guid.NewGuid(), "My love");
            User u1 = new User(Guid.NewGuid(), "Nastya", Convert.ToDateTime("10.05.2001"), 20);
            User u2 = new User(Guid.NewGuid(), "Darya", Convert.ToDateTime("03.11.2001"), 19);

            u1.AddAward(a1);

            bll.AddUser(u1);
            bll.AddAward(Guid.Parse("22a1938d-e7d8-4001-b2fd-7e8eafaaf28e"), a3);

            bll.ViewAll();
        }
    }
}
