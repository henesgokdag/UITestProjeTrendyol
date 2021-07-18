using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UITestProjeTrendyol.PageModels
{
    public class BasePage
    {
        readonly private IWebDriver webDriver;
        private readonly WebDriverWait wait;
        private IWebElement webElement;
        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(this.webDriver, this);
            wait = new WebDriverWait(this.webDriver, TimeSpan.FromSeconds(1));
        }

        public void Wait(int second)
        {
            Thread.Sleep(1000 * second);
        }

        public void ClickElement(IWebElement element)
        {
            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

        public void ClickVisibleElement(IWebElement element)
        {
            if (element.Displayed)
            {
                ClickElement(element);
            }
        }

        public void AddToBasket(IWebDriver webDriver,By element1,By element2)
        {
           bool isExist = AddBasketElement(webDriver, element1);
            if (isExist)
            {
                webDriver.FindElement(element1).Click();
            }
            else
            {
                webDriver.FindElement(element2).Click();
            }

        }

        public bool AddBasketElement(IWebDriver webDriver,By by)
        {
            bool isExists = true;
            try
            {
                webDriver.FindElement(by);
            }
            catch (NoSuchElementException e)
            {
                isExists = false;
            }
            return isExists;
        }

        public void SetText(IWebElement element, string text)
        {
            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            element.SendKeys(text);
            element.SendKeys(Keys.Tab);
        }
    }
}
