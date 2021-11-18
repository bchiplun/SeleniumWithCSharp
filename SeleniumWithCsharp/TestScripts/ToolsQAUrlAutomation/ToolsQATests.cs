using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWithCsharp.Configuration;
using SeleniumWithCsharp.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace SeleniumWithCsharp.TestScripts.ToolsQAUrlAutomation
{
    [TestClass]
    public class ToolsQATests
    {
        [TestMethod]
        public void ClickOnAnyLink()
        {
            SeleniumMethods.GoToUrl(ObjectRepo.Config.GetBeginnerUrl());
            Thread.Sleep(1000);
            SeleniumMethods.ClickOnLinkWithText("Selectable");
            
            Thread.Sleep(2000);
            
        }


        [TestMethod]
        public void EnterTextinSearchBox()
        {
            SeleniumMethods.GoToUrl(ObjectRepo.Config.GetBeginnerUrl());
            Thread.Sleep(1000);
           // SeleniumMethods.Click(By.XPath("//form[@class='searchform']"));
            SeleniumMethods.TypeTextInTextBox(By.XPath("//form[@class='searchform']//input"), "Search Box");

            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestCheckBox()
        {
            SeleniumMethods.GoToUrl(ObjectRepo.Config.GetBeginnerUrl());
            Thread.Sleep(1000);

            SeleniumMethods.ClickOnLinkWithText("Checkboxradio");
            Thread.Sleep(1000);
            SeleniumMethods.SwitchToFrame(By.XPath("//iframe[@class='demo-frame']"));
            SeleniumMethods.Click(By.XPath("//label[@for='checkbox-1']/span[1]"));
            Assert.IsTrue(SeleniumMethods.VerifyIfCheckBoxIsChecked(By.XPath("//label[@for='checkbox-1']/span[1]"), "class", "checked"));

            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestRadioButton()
        {
            SeleniumMethods.GoToUrl(ObjectRepo.Config.GetBeginnerUrl());
            Thread.Sleep(1000);

            SeleniumMethods.ClickOnLinkWithText("Checkboxradio");
            Thread.Sleep(1000);
            SeleniumMethods.SwitchToFrame(By.XPath("//iframe[@class='demo-frame']"));
            SeleniumMethods.Click(By.XPath("//label[text()='New York']"));
            //Assert.IsTrue(SeleniumMethods.IsRadioButtonSelected(By.XPath("//label[text()='New York']/span[1]")));

            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TestSelectDropdown()
        {
            SeleniumMethods.GoToUrl(ObjectRepo.Config.GetBeginnerUrl());
            Thread.Sleep(1000);

            SeleniumMethods.ClickOnLinkWithText("Selectmenu");
            Thread.Sleep(1000);
            SeleniumMethods.SwitchToFrame(By.XPath("//iframe[@class='demo-frame']"));
            SeleniumMethods.Click(By.Id("speed-button"));
            SeleniumMethods.Click(By.Id("ui-id-5"));

            SeleniumMethods.Click(By.Id("salutation-button"));
            SeleniumMethods.SelectFromDropdown(By.Id("salutation"), "Dr.");

            IList<string> dValues = SeleniumMethods.GetAllItems(By.Id("files"));
            foreach (string text in dValues)
            {
                Console.WriteLine("Text {0} :" , text);
            }
        }
        
        [TestMethod]
        public void GetCWD()
        {
            Console.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            Console.WriteLine(Environment.CurrentDirectory);
        }
    }
}
