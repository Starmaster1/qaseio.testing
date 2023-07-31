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

        public static ProjectModel GetStandartProject()
        {
            return new ProjectModel
            {
                Title = TestContext.Parameters.Get("ProjectTitle"),
                Code = TestContext.Parameters.Get("ProjectCode"),
            };
        }

    }
}
