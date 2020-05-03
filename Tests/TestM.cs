using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Team_3_Test.PageObject;
using NUnit.Framework;

namespace Team_3_Test.Tests
{
	[TestFixture]
	public class TestM : BaseTest 
	{
		[TestCase("SomeName", "someEmail6@dmail.com", "123456", "1970-05-31")]
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

	}
}
