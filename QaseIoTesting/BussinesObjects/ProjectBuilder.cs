using Bogus;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObjects
{
    public class ProjectBuilder
    {
        static Faker Faker = new();

        public static ProjectModel GetStandartProject() => new ProjectModel
        {
            Title = TestContext.Parameters.Get("ProjectTitle"),
            Code = TestContext.Parameters.Get("ProjectCode"),
        };
        public static ProjectModel GetRandomProject() => new ProjectModel
        {
            Title = String.Join(" ", Faker.Lorem.Words(3)),
            Code = Faker.Lorem.Word(),
            Description = String.Join(" ", Faker.Lorem.Sentences(3)),
            MemberAccess = "all",
            ProjectAccessType = "private"
        };

    }
}
