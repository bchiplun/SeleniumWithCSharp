using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithCsharp.BaseClasses;
using SeleniumWithCsharp.Configuration;
using SeleniumWithCsharp.Interfaces;
using System;

namespace SeleniumWithCsharp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://yahoo.com");
            //driver.Close();
            //driver.Quit();


            //IConfig config = new AppConfigReader();
            //Console.WriteLine("Browser : {0}", config.GetBrowser()); 
            //Console.WriteLine("Username : {0}", config.GetUsername());
            //Console.WriteLine("Password : {0}", config.GetPassword());

            Console.WriteLine("Hello World!");
        }
    }
}
