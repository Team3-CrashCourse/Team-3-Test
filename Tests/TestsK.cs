using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_3_Test.PageObject;
using Team_3_Test.Framework;
using NUnit.Framework;

namespace Team_3_Test.Tests
{
	[TestFixture]
	class TestsK : BaseTest
	{
		[Test]
		public void AddToCartFromPage()
		{
			MainPage mainPage = new MainPage(webdriver);
			FirstProductPage productPage = mainPage.OpenProductPage();
			productPage.AddToCart();
			productPage.CloseDialogCart();
			productPage.CheckCart();
		}

		[Test]
		public void AddToCartFromModal()
		{
			MainPage mainPage = new MainPage(webdriver);
			mainPage.OpenModal();
			mainPage.BuyFromModalWindow();
			mainPage.CloseModalWindow();
			mainPage.CheckCart();
		}

		[TestCase(true, "art")]
		[TestCase(false, "123")]
		public void TestSearch(bool isOk, string searchfor)
		{
			Header header = new Header(webdriver);
			bool isSearchOk = header.SearchFor(searchfor).IsSearchOk();
			Assert.That(isSearchOk, Is.EqualTo(isOk), $"Search was {(isSearchOk? "successful" : "unsuccessful")}");
		}
	}
}
