using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Team_3_Test.PageObject;
using NUnit.Framework;

namespace Team_3_Test.Tests
{
    [TestFixture]
    public class TestM: BaseTest
    {
        [Test]
        public void TestingImage()
        {

            Header header = new Header(webdriver);
            header.ClickOnSignIn();
        }

    }
}
