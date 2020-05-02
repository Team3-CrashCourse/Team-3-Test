using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_3_Test.PageObject
{
	class FirstProductPage : PageObjectBase
	{
		public FirstProductPage(IWebDriver driver) : base(driver) { }

		public void AddToCart()
		{
			Driver.FindElement(By.ClassName("add-to-cart")).Submit();
		}
		public void CloseDialogCart()
		{
			Driver.SwitchTo().ActiveElement();
			//Driver.FindElement(By.Id("blockcart-modal"));
		}

	}
}
