using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selenium.Elements
{
    public class MenuLink : BaseElement
    {
        public MenuLink(By locator) : base(locator)
        {
        }

        public MenuLink(string name) : base($"//a[@href='/{name}']")
        {
        }
    }
}
