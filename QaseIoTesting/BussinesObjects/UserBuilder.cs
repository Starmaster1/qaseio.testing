using Bogus;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObjects
{
    public class UserBuilder
    {
        static Faker Faker = new();

        public static UserModel GetStandartUser()
        {
            return new UserModel
            {
                Name = TestContext.Parameters.Get("StandartUserName"),
                Password = TestContext.Parameters.Get("StandartUserPassword"),
            };
        }

        public static UserModel GetRandomUserWithPassword(string password) => new()
        {
            Name = Faker.Name.FullName(),
            Password = TestContext.Parameters.Get("StandartUserPassword"),
        };
    }
}
