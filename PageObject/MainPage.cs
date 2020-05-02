using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_3_Test.PageObject
{
	class MainPage : PageObjectBase
	{
		private static readonly By firstImage = By.XPath("//img[@alt='Hummingbird printed t-shirt']");
		public MainPage(IWebDriver driver) : base(driver) { }

		public ProductPage OpenProductPage()
		{
			Driver.FindElement(firstImage).Click();
			return new ProductPage(Driver);
		}
	}
}
