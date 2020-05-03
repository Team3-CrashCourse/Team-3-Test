using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_3_Test.PageObject
{
	public class AddressPage: PageObjectBase
	{
		public AddressPage(IWebDriver driver) : base(driver) { }
		private static readonly By LinkCreateAccount = By.ClassName("no-account");


	}
}
