using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class Utility
    {
		public static void WaitUntilElementVisible(By element)
		{
			WebDriverWait wait = new WebDriverWait(BaseClass.driver, TimeSpan.FromSeconds(10));
			wait.Until(ExpectedConditions.ElementExists(element));
		}

		public static void WaitUntilElementClickable(IWebElement element)
		{
			WebDriverWait wait = new WebDriverWait(BaseClass.driver, TimeSpan.FromSeconds(10));
			wait.Until(ExpectedConditions.ElementToBeClickable(element));
		}
	}
}
