using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Team_3_Test.PageObject
{
	class MainPage : PageObjectBase
	{
		private static readonly By firstImage = By.XPath("//img[@alt='Hummingbird printed t-shirt']");
		private static readonly By firstImageModal = By.XPath("//article[@data-id-product='1']//a[@class='quick-view']");

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
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
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
	}
}
