using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumProject.PageObject;

namespace SeleniumProject
{
    class BasicTests : BaseClass
    {
        [Test]
        public void LoginToGitHub()
        {
            HomePage homepage = new HomePage();
            homepage.SignIn();
            homepage.TypeUsername("vpokrajac");
            homepage.TypePassword("Partizanesku_222");
            Assert.AreEqual("GitHub", driver.Title);
        }
        [Test]
        public void UnsuccessfullyLogin()
        {
            HomePage homepage = new HomePage();
            homepage.SignIn();
            homepage.TypeUsername("vpokrajac");
            homepage.TypePassword("Partizaner");
            homepage.LoggingIn();
            Utility.WaitUntilElementClickable(homepage.IncorrectUsernameOrPassword);
            Assert.AreEqual("Incorrect username or password.", homepage.GetTextFromField());
        }
    }
}
