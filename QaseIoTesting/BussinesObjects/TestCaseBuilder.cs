using Bogus;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObjects
{
    public class TestCaseBuilder
    {
        static Faker Faker = new();

        public static TestCaseModel GetRandomTestCase() => new TestCaseModel
        {
            Title = String.Join(" ", Faker.Lorem.Words(3)),
            Description = String.Join(" ", Faker.Lorem.Sentences(3)),
        };

    }
}
