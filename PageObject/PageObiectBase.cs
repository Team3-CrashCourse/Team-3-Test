using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Team_3_Test.PageObject
{
    public abstract class PageObjectBase
    {
        protected readonly IWebDriver Driver;
        public PageObjectBase(IWebDriver webDriver) => Driver = webDriver;
    }
}
