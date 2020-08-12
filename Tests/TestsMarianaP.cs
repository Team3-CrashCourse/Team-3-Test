using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Team_3_Test.PageObject;
using Team_3_Test.Framework;
using NUnit.Framework;

namespace Team_3_Test.Tests
{
	[TestFixture]
	public class TestsMarianaP : BaseTest 
	{
		[TestCase("SomeName", "someEmail125@dmail.com", "123456", "1970-05-31")]
		[TestCase("Some857/.54Name", "email..@domain.com", "123DFV", "124/857/15975")]
		public void RegistrationTest(string text, string email, string passw, string date)
		{
			MainPage mainPage = new MainPage(webdriver);
			LogInPage authentication = mainPage.ClickOnSignIn();
			RegistrationPage login = authentication.ClickCreateAccount();
			login
				.ClickGenderRadioButton()
				.EnterFNameField(text)
				.EnterLNameField(text)
				.EnterEmail(email)
				.EnterPassword(passw)
				.ClickShowButton()
				.EnterBirthDay(date)
				.ClickThirdCheckBox()
				.ClickSaveButton();
		}

		[TestCase("someEmail6@dmail.com", "123456")]
		public void LogInTest(string email, string passw)
		{
			MainPage mainPage = new MainPage(webdriver);
			LogInPage authentication = mainPage.ClickOnSignIn();
			authentication
				.EnterEmail(email)
				.EnterPassword(passw)
				.ClickShowButton()
				.ClickSignIn();
		}

		[TestCase("someEmail6@dmail.com", "123456")]
		public void YorAccountTest(string email, string passw)
		{
			MainPage mainPage = new MainPage(webdriver);
			LogInPage authentication = mainPage.ClickOnSignIn();
			YourAccountPage yourAccount = authentication.lognIn(email, passw);

			yourAccount.ClickInformationLink();
			webdriver.Navigate().Back();
			yourAccount.ClickAddAdressLink();
			webdriver.Navigate().Back();
			yourAccount.ClickOrderHistoryLink();
			webdriver.Navigate().Back();
			yourAccount.ClickCreditSlipsLink();
			webdriver.Navigate().Back();
			yourAccount.ClickPersonalDataLink();
			webdriver.Navigate().Back();
			yourAccount.ClickSignOutLink();
		}
	}
}
