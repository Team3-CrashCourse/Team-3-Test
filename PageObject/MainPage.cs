using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Team_3_Test.PageObject
{
    public class Header: PageObjectBase
    {
        private static readonly By SignInButton = By.ClassName("user-info");

        public Header(IWebDriver driver) : base(driver){ }

        public void ClickOnSignIn()
        {
            Driver.FindElement(by: SignInButton).Click();
        }
    }
}
