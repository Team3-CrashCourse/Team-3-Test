using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Team_3_Test.PageObject;
using Team_3_Test.Framework;
using NUnit.Framework;

namespace Team_3_Test.Tests
{
    public class BaseTest
    {
        protected IWebDriver webdriver;

        [OneTimeSetUp]
        protected void DoBeforeAllTests()
        {
            webdriver = new ChromeDriver();
        }

		[OneTimeTearDown]
		public void OneTimeTearDown() => webdriver.Quit();

		[SetUp]
        protected void DoBeforeEach()
        {
            webdriver.Manage().Window.Maximize();
            webdriver.Navigate().GoToUrl(Framework.Setting.Url);
        }
	}
}
