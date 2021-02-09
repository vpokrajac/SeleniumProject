using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.PageObject
{
    public class HomePage : BaseClass
    {
        public HomePage()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='/login']")]
        private IWebElement signIn;
        [FindsBy(How = How.XPath, Using = "//a[text()='Sign up']")]
        private IWebElement signUp;
        [FindsBy(How = How.Id, Using = "login_field")]
        private IWebElement usernameElement;
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordElement;
        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'/password_reset')]")]
        private IWebElement forgotPassword;
        [FindsBy(How = How.Id, Using = "js-flash-container")]
        public IWebElement IncorrectUsernameOrPassword;
        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        public IWebElement LogIn;


        public void TypeUsername(string username)
        {
            usernameElement.SendKeys(username);
        }
        public void TypePassword(string password)
        {
            passwordElement.SendKeys(password);
        }
        public void ForgotPassword()
        {
            forgotPassword.Click();
        }
        public void SignIn()
        {
            signIn.Click();
        }
        public void SignUp()
        {
            signUp.Click();
        }
        public void LoggingIn()
        {
            LogIn.Click();
        }

        public string GetTextFromField()
        {
            return IncorrectUsernameOrPassword.Text;
        }
    }
}
