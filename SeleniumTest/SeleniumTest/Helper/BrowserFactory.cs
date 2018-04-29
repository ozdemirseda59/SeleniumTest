using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Helper
{
    class BrowserFactory
    {

        static IWebDriver webdriver;


        public static IWebDriver StartBrowser(String BrowserName, string url)
        {
            if (BrowserName.Equals("firefox"))
            {
                webdriver = new FirefoxDriver();
            }
            else if (BrowserName.Equals("chrome"))
            {
                webdriver = new ChromeDriver();
            }
            else if (BrowserName.Equals("IE"))
            {
                webdriver = new InternetExplorerDriver();
            }

            webdriver.Manage().Window.Maximize();
            webdriver.Manage().Cookies.DeleteAllCookies();
            webdriver.Navigate().GoToUrl(url);
            return webdriver;
        }

    }
}
