
using Allure.Commons;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace Core.Selenium
{
    [AllureNUnit]
   // [Parallelizable(ParallelScope.All)]
    public class BaseTest
    {
        private AllureLifecycle allure;
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            allure = AllureLifecycle.Instance;
            driver = Browser.Instance.Driver;
        }

        [TearDown]
        public void TearDown()
        {
            if(TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Screenshot screenshot = ((ITakesScreenshot)Browser.Instance.Driver).GetScreenshot();
                byte[] bytes = screenshot.AsByteArray;
                allure.AddAttachment("Screenshot", "image/png", bytes);
            }

            Browser.Instance.CloseBrowser();
        }
    }
}