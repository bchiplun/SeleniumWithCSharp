using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumWithCsharp.Configuration;
using SeleniumWithCsharp.CustomExcetption;
using SeleniumWithCsharp.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCsharp.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc)
        {
            ObjectRepo.Config = new AppConfigReader();

            switch (ObjectRepo.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepo.Driver = GetChromeDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRepo.Driver = GetFirefoxDriver();
                    break;

                default:
                    throw new NoSuitableDriverFound("Unable to find driver for browser : " + ObjectRepo.Config.GetBrowser().ToString());
            }

        }

        [AssemblyCleanup]
        public static void TearDown()
        {
            ObjectRepo.Driver.Close();
            ObjectRepo.Driver.Quit();
        }
    }
}
