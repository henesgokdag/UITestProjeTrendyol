using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestProjeTrendyol.PageModels
{
    public class Trendyol : BasePage
    {
        private IWebDriver webDriver;
        public Trendyol(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }
        #region Elements

        [FindsBy(How = How.ClassName, Using = "modal-close")]
        public IWebElement btnPopup;

        [FindsBy(How = How.ClassName, Using = "account-user")]
        public IWebElement btnAccountLogin;

        [FindsBy(How = How.Id, Using = "login-email")]
        public IWebElement txtLoginEmail;

        [FindsBy(How = How.Id, Using = "login-password-input")]
        public IWebElement txtLoginPassword;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'q-primary')]")]
        public IWebElement btnLogin;

        //[FindsBy(How = How.XPath, Using = "//button[contains(@class,'add-to-bs')]")]
        //public IWebElement btnAddToBasket;

        //[FindsBy(How = How.XPath, Using = "//button[contains(@class,'add-to-basket')]")]
        //public IWebElement btnAddToBasket2;


        By addToBasket = By.ClassName("add-to-bs");
        By addToBasket2 = By.ClassName("add-to-basket");


        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'account-basket')]")]
        public IWebElement btnBasket;

        [FindsBy(How = How.XPath, Using = "//input[contains(@class,'search-box')]")]
        public IWebElement txtSearch;

        [FindsBy(How = How.XPath, Using = "//i[contains(@class,'search-icon')]")]
        public IWebElement btnSearch;

        [FindsBy(How = How.ClassName, Using = "prdct-desc-cntnr-ttl-w")]
        public IList<IWebElement> lblProductList;

        [FindsBy(How = How.ClassName, Using = "pb-item")]
        public IWebElement lblProductName;

        [FindsBy(How = How.Id, Using = "container")]
        public IWebElement lblPopup;

        [FindsBy(How = How.ClassName, Using = "i-trash")]
        public IWebElement btnDelete;
        #endregion

        string productName;
        internal void ClosePopup()
        {
            Wait(3);
            ClickElement(btnPopup);
        }

        internal void ClickLogin()
        {
            ClickElement(btnAccountLogin);
        }

        internal void EnterEmailAddress(string emailAddress)
        {
            SetText(txtLoginEmail,emailAddress);
        }

        internal void EnterPassword(string password)
        {
            SetText(txtLoginPassword,password);
        }

        internal void ClickLoginButton()
        {
            ClickElement(btnLogin);
            Wait(5);
        }

        internal void EnterSearch(string search)
        {
            SetText(txtSearch,search);
            
        }

        internal void ClickSearch()
        {
            Wait(2);
            ClickElement(btnSearch);
        }

        internal void DeleteProduct()
        {
            ClickElement(btnDelete);
        }

        internal void ClickFirstItem()
        {
            Wait(5);
            ClickVisibleElement(lblPopup);
            Wait(2);
            int productNumber = Utilities.Utilities.GetRandomNumber(lblProductList.Count);
            productName = lblProductList[productNumber].GetAttribute("value");
            ClickElement(lblProductList[productNumber]);

        }

        internal void ClickAddBasket()
        {
            Wait(5);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[1]);
            AddToBasket(webDriver ,addToBasket,addToBasket2);
        }

        internal void ClickBasket()
        {
            btnBasket.Click();
        }

        internal void CheckBasket()
        {
            Wait(2);
            string actualProductName= lblProductName.GetAttribute("value");
            Assert.AreEqual(actualProductName,productName);
        }
    }
}
