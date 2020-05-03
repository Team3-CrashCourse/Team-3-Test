using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_3_Test.PageObject
{
	public class LogInPage: PageObjectBase
	{
		public LogInPage(IWebDriver driver) : base(driver) { }
		private static readonly By EmailInput = By.XPath("/html/body/main/section/div/div/section/section/section/form/section/div[1]/div[1]/input");
		private static readonly By PasswordInput = By.XPath("/html/body/main/section/div/div/section/section/section/form/section/div[2]/div[1]/div/input");
		private static readonly By ShowButton = By.XPath("/html/body/main/section/div/div/section/section/section/form/section/div[2]/div[1]/div/span/button");
		private static readonly By ForgotPasswLink = By.XPath("/html/body/main/section/div/div/section/section/section/form/section/div[2]/div[1]/div/span/button");
		private static readonly By CreateAccountLink= By.XPath("//*[@id='content']/div/a");
		private static readonly By SignInButton = By.Id("submit-login");

		public LogInPage EnterEmail(string email)
		{
			Driver.FindElement(by: EmailInput).Click();
			Driver.FindElement(by: EmailInput).Clear();
			Driver.FindElement(by: EmailInput).SendKeys(email);
			return this;
		}

		public LogInPage EnterPassword(string passw)
		{
			Driver.FindElement(by: PasswordInput).Click();
			Driver.FindElement(by: PasswordInput).Clear();
			Driver.FindElement(by: PasswordInput).SendKeys(passw);
			return this;
		}

		public LogInPage ClickShowButton()
		{
			Driver.FindElement(by: ShowButton).Click();
			return this;
		}

		public LogInPage ClickSignIn()
		{
			Driver.FindElement(by: SignInButton).Click();
			return this;
		}

		public RegistrationPage ClickCreateAccount()
		{
			Driver.FindElement(by: CreateAccountLink).Click();
			return new RegistrationPage(Driver);
		}

		public YourAccountPage lognIn(string email, string passw)
		{
			Driver.FindElement(by: EmailInput).Click();
			Driver.FindElement(by: EmailInput).SendKeys(email);
			Driver.FindElement(by: PasswordInput).Click();
			Driver.FindElement(by: PasswordInput).SendKeys(passw);
			Driver.FindElement(by: SignInButton).Click();
			return new YourAccountPage(Driver);
		}

		public LogInPage ClickForgotPasswLink()
		{
			Driver.FindElement(by: ForgotPasswLink).Click();
			return this;
		}
	}
}
