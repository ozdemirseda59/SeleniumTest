using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    class HomePage
    {

        IWebDriver webDriver;
       
        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        #region Object
        [FindsBy(How = How.Id, Using = "searchData")]
        public IWebElement SearchData { get; set; }

        [FindsBy(How = How.ClassName, Using = "searchBtn")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contentListing']/div/div/div[2]/div[3]/a[2]")]
        public IWebElement GetPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='p-243589189']/div[2]/span")]
        public IWebElement AddFavorite { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div/div/div[2]/div[2]/div[2]/div[1]/a[1]")]
        public IWebElement Account { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='myAccount']/div[1]/div[1]/div[2]/ul/li[6]/a")]
        public IWebElement Wishes { get; set; }
        [FindsBy(How = How.XPath, Using = " //*[@id='myAccount']/div[3]/ul/li[1]/div/a")]
        public IWebElement Favorite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='p-243589189']/div[3]/span")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/span[1]")]
        public IWebElement Confirm { get; set; }
        #endregion

        #region Methods
        public void Search(string searchdata)
        {

            SearchData.SendKeys(searchdata);
            SearchButton.Click();
        }
        public void getPage()
        {
            GetPage.Click();
        }

        public void addFavorite()
        {
            AddFavorite.Click();
        }

        public void navigateAccount()
        {
            Account.Click();
        }

        public void navigateWishesList()
        {
            Wishes.Click();
        }
        public void listFavorite()
        {
            Favorite.Click();
        }

        public void deleteFavItem()
        {
            Delete.Click();
            TimeSpan s = new TimeSpan(0, 0, 0, 120);
            
            webDriver.Manage().Timeouts().ImplicitlyWait(s);

        }
        public void confirm()
        {
            Confirm.Click();
        }
        #endregion

    }
}
