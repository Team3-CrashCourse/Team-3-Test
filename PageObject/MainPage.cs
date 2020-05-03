using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 

namespace Team_3_Test.PageObject
{
    public class MainPage: PageObjectBase
    {
        public MainPage(IWebDriver driver) : base(driver){ }

		private static readonly By SignInButton = By.ClassName("user-info");

		public LogInPage ClickOnSignIn()
		{
			Driver.FindElement(by: SignInButton).Click();
			return new LogInPage(Driver); 
		}
	}
}
