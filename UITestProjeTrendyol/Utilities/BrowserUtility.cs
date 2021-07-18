using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UITestProjeTrendyol.Utilities
{
    public class BrowserUtility
    {
        IWebDriver webDriver;
        public IWebDriver ChromeDriver(string url)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("disable-popup-blocking");
            options.AddArguments("disable-popup-blocking");
            webDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            webDriver.Navigate().GoToUrl(url);
            return webDriver;
        }

        public void GoToUrl(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        public void DriverClose()
        {
            webDriver.Quit();
        }
    }
}
