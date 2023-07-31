using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selenium.Elements
{
    public class TextArea : BaseElement
    {
        public TextArea(By locator) : base(locator)
        {
        }

        public TextArea(string name) : base($"//textarea[@name='{name}']")
        {
        }
    }
}
