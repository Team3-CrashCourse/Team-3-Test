using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_3_Test.PageObject
{
	public class RegistrationPage : PageObjectBase
	{
		private static readonly By LinkCreateAccount = By.ClassName("no-account");
		private static readonly By GenderRadioButton = By.XPath("/html/body/main/section/div/div/section/section/section/form/section/div[1]/div[1]/label[1]/span/input"); 
		private static readonly By FirstNameInput = By.Name("firstname");
		private static readonly By LastNameInput = By.Name("lastname");
		private static readonly By EmailInput = By.Name("email");
		private static readonly By PasswordInput = By.Name("password");
		private static readonly By ShowButton = By.ClassName("btn");
		private static readonly By BirthdayInput = By.Name("birthday");
		private static readonly By FirstCheckBox = By.Name("optin");
		private static readonly By SecondCheckBox = By.Name("newsletter");
		private static readonly By ThirdCheckBox = By.Name("psgdpr");
		private static readonly By SaveButton = By.XPath("/html/body/main/section/div/div/section/section/section/form/footer/button");

		public RegistrationPage(IWebDriver driver) : base(driver) { }

		public RegistrationPage ClickCreateAccount()
		{
			Driver.FindElement(by: LinkCreateAccount).Click();
			return this;
		}

		public RegistrationPage ClickGenderRadioButton()
		{
			Driver.FindElement(by: GenderRadioButton).Click();
			return this;
		}

		public RegistrationPage EnterFNameField(string userFName)
		{
			Driver.FindElement(by: FirstNameInput).Click();
			Driver.FindElement(by: FirstNameInput).Clear();
			Driver.FindElement(by: FirstNameInput).SendKeys(userFName);
			return this;
		}

		public RegistrationPage EnterLNameField(string userLName)
		{
			Driver.FindElement(by: LastNameInput).Click();
			Driver.FindElement(by: LastNameInput).Clear();
			Driver.FindElement(by: LastNameInput).SendKeys(userLName);
			return this;
		}

		public RegistrationPage EnterEmail(string userEmail)
		{
			Driver.FindElement(by: EmailInput).Click();
			Driver.FindElement(by: EmailInput).Clear();
			Driver.FindElement(by: EmailInput).SendKeys(userEmail);
			return this;
		}

		public RegistrationPage EnterPassword(string passw)
		{
			Driver.FindElement(by: PasswordInput).Click();
			Driver.FindElement(by: PasswordInput).Clear();
			Driver.FindElement(by: PasswordInput).SendKeys(passw);
			return this;
		}

		public RegistrationPage ClickShowButton()
		{
			Driver.FindElement(by: ShowButton).Click();
			return this;
		}

		public RegistrationPage EnterBirthDay(string passw)
		{
			Driver.FindElement(by: BirthdayInput).Click();
			Driver.FindElement(by: BirthdayInput).Clear();
			Driver.FindElement(by: BirthdayInput).SendKeys(passw);
			return this;
		}

		public RegistrationPage ClickThirdCheckBox()
		{
			Driver.FindElement(by: ThirdCheckBox).Click();
			return this;
		}

		public RegistrationPage ClickSaveButton()
		{
			Driver.FindElement(by: SaveButton).Click();
			return this;
		}
	}
}
