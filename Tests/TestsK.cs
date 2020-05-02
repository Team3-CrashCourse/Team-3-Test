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
		}
		[Test]
		public void AddToCartFromFrame()
		{
			MainPage mainPage = new MainPage(webdriver);
		}
		[TestCase("art")]
		[TestCase("123")]
		public void TestSearch(string searchfor)
		{
			Header pageObject = new Header(webdriver);

		}
	}
}
