using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumWithCsharp.Configuration;
using SeleniumWithCsharp.CustomExcetption;
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
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return options;
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
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

            //ObjectRepo.Driver.Manage().Window.Maximize();
            ObjectRepo.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepo.Config.GetPageLoadTimeout());
            ObjectRepo.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepo.Config.GetImplicitWait()); 

        }

        [AssemblyCleanup]
        public static void TearDown()
        {
            if(ObjectRepo.Driver != null)
            {
                ObjectRepo.Driver.Close();
                ObjectRepo.Driver.Quit();
            }
            
        }
    }
}
