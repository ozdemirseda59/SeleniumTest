using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    class LoginPage
    {
        IWebDriver webDriver;

        public LoginPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);

        }

        #region Object
        [FindsBy(How = How.ClassName, Using = "btnSignIn")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordBox { get; set; }

        [FindsBy(How = How.Id, Using = "loginButton")]
        public IWebElement LoginButton { get; set; }

        #endregion

        #region Methods
        public void LoginIntoN11(string username, string password)
        {
            SignInButton.Click();
            EmailTextBox.SendKeys(username);
            PasswordBox.SendKeys(password);
            LoginButton.Click();
        }
        #endregion

    }
}
