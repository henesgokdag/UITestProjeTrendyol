using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UITestProjeTrendyol.PageModels;
using UITestProjeTrendyol.Utilities;

namespace UITestProjeTrendyol.Tests
{
    [Binding, Scope(Feature = "Trendyol2")]
    public class TrendyolTest
    {
        Trendyol trendyol;
        IWebDriver webDriver;
        readonly BrowserUtility browserUtility = new BrowserUtility();

        [StepDefinition(@"Google Chrome Tarayıcısı açılır ve '(.*)' adresine girilir")]
        public void OpenChromeDriver(string url)
        {
            webDriver = browserUtility.ChromeDriver(url);
            trendyol = new Trendyol(webDriver);
        }

        [StepDefinition(@"Popup Kapatılır")]
        public void ClosePopup()
        {
            trendyol.ClosePopup();
        }

        [StepDefinition(@"Giriş Yap butonuna tıklanır")]
        public void ClickLogin()
        {
            trendyol.ClickLogin();
        }

        [StepDefinition(@"E-Posta adresi alanı '(.*)' girilir")]
        public void EnterEmailAddress(string emailAddress)
        {
            trendyol.EnterEmailAddress(emailAddress);
        }

        [StepDefinition(@"Şifre alanı '(.*)' girilir")]
        public void EnterPassword(string password)
        {
            trendyol.EnterPassword(password);
        }

        [StepDefinition(@"Giriş Yap butonuna basılır")]
        public void ClickLoginButton()
        {
            trendyol.ClickLoginButton();
        }

        [StepDefinition(@"Arama alanına '(.*)' yazılır")]
        public void EnterSearch(string search)
        {
            trendyol.EnterSearch(search);
        }


        [StepDefinition(@"Arama butonuna tıklanır")]
        public void ClickSearch()
        {
            trendyol.ClickSearch();
        }

        [StepDefinition(@"İlk ürüne tıklanır")]
        public void ClickFirstItem()
        {
            trendyol.ClickFirstItem();
        }

        [StepDefinition(@"Ürün Sepete eklenir")]
        public void ClickAddBasket()
        {
            trendyol.ClickAddBasket();
        }

        [StepDefinition(@"Sepete Tıklanır")]
        public void ClickBasket()
        {
            trendyol.ClickBasket();
        }

        [StepDefinition(@"Ürünün Sepette Olduğu Kontrol edilir")]
        public void CheckBasket()
        {
            trendyol.CheckBasket();
        }

        [StepDefinition(@"Sepetten Ürün Silinir")]
        public void DeleteProduct()
        {
            trendyol.DeleteProduct();
        }

        [AfterScenario]
        public void DriverClose()
        {
            browserUtility.DriverClose();
        }
    }
}
