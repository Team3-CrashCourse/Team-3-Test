using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_3_Test.PageObject
{
	public class YourAccountPage: PageObjectBase
	{
		public YourAccountPage(IWebDriver driver) : base(driver) { }
		private static readonly By InformationLink = By.Id("identity-link");
		private static readonly By AddAddresLink = By.Id("address-link");
		private static readonly By OrderHistoryLink = By.Id("history-link");
		private static readonly By CreditSlipsLink = By.Id("order-slips-link");
		private static readonly By PersonalDataLink = By.XPath("/html/body/main/section/div/div/section/section/div/div/a[5]");
		private static readonly By SingOutLink = By.XPath("//*[@id='main']/footer/div/a");

		public YourAccountPage ClickInformationLink()
		{
			Driver.FindElement(by: InformationLink).Click();
			return this;
		}

		public YourAccountPage ClickAddAdressLink()
		{
			Driver.FindElement(by: AddAddresLink).Click();
			return this;
		}

		public YourAccountPage ClickOrderHistoryLink()
		{
			Driver.FindElement(by: OrderHistoryLink).Click();
			return this;
		}

		public YourAccountPage ClickCreditSlipsLink()
		{
			Driver.FindElement(by: CreditSlipsLink).Click();
			return this;
		}

		public YourAccountPage ClickPersonalDataLink()
		{
			Driver.FindElement(by: PersonalDataLink).Click();
			return this;
		}

		public YourAccountPage ClickSignOutLink()
		{
			Driver.FindElement(by: SingOutLink).Click();
			return this;
		}
	}
}
