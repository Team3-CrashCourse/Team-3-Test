using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Team_3_Test.Framework;

namespace Team_3_Test.PageObject
{
	public class MainPage : PageObjectBase
	{
		private static readonly By firstImage = By.XPath("//img[@alt='Hummingbird printed t-shirt']");
		private static readonly By firstImageModal = By.XPath("//article[@data-id-product='1']//a[@class='quick-view']");
		private static readonly By SignInButton = By.ClassName("user-info");

		public MainPage(IWebDriver driver) : base(driver) { }

		public FirstProductPage OpenProductPage()
		{
			Driver.FindElement(firstImage).Click();
			return new FirstProductPage(Driver);
		}

		public void OpenModal()
		{
			Actions action = new Actions(Driver);
			action.MoveToElement(Driver.FindElement(firstImageModal)).Perform();
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
			Wait.WaitFor(() => Driver.FindElements(firstImageModal).Any());
			Driver.FindElement(firstImageModal).Click();
		}

		public void BuyFromModalWindow()
		{
			Thread.Sleep(3000);
			Driver.FindElement(By.ClassName("add-to-cart")).Submit();
		}

		public void CloseModalWindow()
		{
			Thread.Sleep(3000);
			Driver.FindElement(By.ClassName("close")).Click();
		}

		public bool IsSearchOk()
		{
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
			bool isOk = Wait.WaitFor(() => Driver.FindElements(By.ClassName("select-title")).Any());
			return isOk;
		}

		public void CheckCart()
		{
			Thread.Sleep(3000);
			Driver.FindElement(By.ClassName("blockcart")).Click();
		}

		public LogInPage ClickOnSignIn()
		{
			Driver.FindElement(by: SignInButton).Click();
			return new LogInPage(Driver); 
		}
	}
}
