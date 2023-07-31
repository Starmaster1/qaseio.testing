using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selenium.Elements
{
    public class DropDownProject : BaseElement
    {
        private string project;
        public DropDownProject(By locator) : base(locator)
        {
        }

        public DropDownProject(string project) : base($"//a[text()='{project}']/ancestor::tr//a[@data-bs-toggle='dropdown']")
        {
            this.project = project;
        }

        public void Select(string option)
        {
            WebDriver.FindElement(By.XPath($"//a[text()='{project}']/ancestor::tr//div[@class='dropdown-item']/*[text()='{option}']")).Click();
        }

    }
}
