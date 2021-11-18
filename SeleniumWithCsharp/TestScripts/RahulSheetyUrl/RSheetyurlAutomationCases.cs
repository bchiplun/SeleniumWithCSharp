using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWithCsharp.Configuration;
using SeleniumWithCsharp.Utilities;
using System;
using System.Threading;

namespace SeleniumWithCsharp.TestScripts.RahulSheetyUrl
{
    [TestClass]
    public class RSheetyurlAutomationCases
    {
        [TestMethod]
        public void SwitchToTabTest()
        {
            SeleniumMethods.GoToUrl(ObjectRepo.Config.GetRahulShettyUrl());
            SeleniumMethods.WaitTillElementIsClickable(By.Id("opentab"), 10);
            SeleniumMethods.Click(By.Id("opentab"));
            SeleniumMethods.SwitchToWindow(1);

            SeleniumMethods.GoToUrl(ObjectRepo.Config.GetRahulShettyUrl());
            SeleniumMethods.WaitTillElementIsClickable(By.Id("opentab"), 10);
            SeleniumMethods.Click(By.Id("opentab"));
            SeleniumMethods.SwitchToWindow(2);
            SeleniumMethods.WaitTillElementIsPresent(By.XPath("//strong[text() = ' Learn Earn & Shine']"), 10);
            Assert.IsTrue(SeleniumMethods.IsElementPresent(By.XPath("//strong[text() = ' Learn Earn & Shine']")));
            Thread.Sleep(2000);
            SeleniumMethods.SwitchToParentWindow();
        }

        [TestMethod]
        public void SwitchToiWindowTest1()
        {
            SeleniumMethods.GoToUrl(ObjectRepo.Config.GetRahulShettyUrl());
            SeleniumMethods.WaitTillElementIsClickable(By.Id("openwindow"), 10);
            SeleniumMethods.Click(By.Id("openwindow"));
            SeleniumMethods.SwitchToWindow(1);
            SeleniumMethods.SwitchToParentWindow();
        }
    }
}
