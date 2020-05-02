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
		}

		[Test]
		public void AddToCartFromModal()
		{
			MainPage mainPage = new MainPage(webdriver);
			mainPage.OpenModal();

		}

		[TestCase("art")]
		[TestCase("123")]
		public void TestSearch(string searchfor)
		{
			Header header = new Header(webdriver);
			header.SearchFor(searchfor);
		}
	}
}
