using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class BaseClass
    {
        public static IWebDriver driver;
        
        [SetUp]
        public void Initialize()
        {

            driver = new ChromeDriver(AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin")));
            driver.Url = "https://github.com/";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
