using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Helper;
using SeleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Test
{
    class N11LoginTest
    {

        IWebDriver webDriver;

        public object TimeUnit { get; private set; }

  
        [SetUp]
        public void InitializeBrowser()

        {
            webDriver = BrowserFactory.StartBrowser("chrome", "https://www.n11.com/");

        }

        [Test]
        public void TestN11Login()
        {
            HomePage ObjHome = new HomePage(webDriver);
            LoginPage ObjLogin = new LoginPage(webDriver);
            //N11 Login  details must be change.
            ObjLogin.LoginIntoN11("changeThisUsername", "changeThisPassword");
            ObjHome.Search("Samsung");
            ObjHome.getPage();
            ObjHome.addFavorite();
            ObjHome.navigateAccount();
            ObjHome.navigateWishesList();
            ObjHome.listFavorite();
            ObjHome.deleteFavItem();
            ObjHome.confirm();
            

        }


        //[TearDown]
        //public void Close()
        //{
        //    TimeSpan s = new TimeSpan(0, 0, 4, 0);

        //    webDriver.Manage().Timeouts().ImplicitlyWait(s);
        //    webDriver.Quit();
        //}

    }
}
