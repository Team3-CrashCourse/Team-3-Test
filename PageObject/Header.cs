using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Team_3_Test.PageObject
{
    public class Header: PageObjectBase
    {
        private static readonly By SignInButton = By.ClassName("user-info");
		private static readonly By SearchField = By.ClassName("ui-autocomplete-input");


		public Header(IWebDriver driver) : base(driver){ }

        public void ClickOnSignIn()
        {
            Driver.FindElement(by: SignInButton).Click();
        }

		public void SearchFor(string input)
		{
			Driver.FindElement(by: SearchField).SendKeys(input);
			Driver.FindElement(By.XPath("//div[@id='search_widget']//i[@class='material-icons search']")).Click();
		}
	}
}
