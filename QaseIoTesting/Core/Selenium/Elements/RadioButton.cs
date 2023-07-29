using OpenQA.Selenium;

namespace Core.Selenium.Elements
{
    public class RadioButton : BaseElement
    {
        public RadioButton(By locator) : base(locator)
        {
        }

        public RadioButton(string value) : base($"//input[@type='radio'][@value='{value}']")
        {
        }
    }
}
