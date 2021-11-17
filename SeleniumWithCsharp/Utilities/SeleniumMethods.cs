using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWithCsharp.Configuration;
using SeleniumWithCsharp.CustomExcetption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWithCsharp.Utilities
{
    public class SeleniumMethods
    {
        public static void GoToUrl(string url)
        {
            ObjectRepo.Driver.Navigate().GoToUrl(url);
        }

        public static bool IsElementPresent(By locator)
        {
            try
            {
                Thread.Sleep(1000);
                return ObjectRepo.Driver.FindElements(locator).Count >= 1;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public static IWebElement GetElement(By locator)
        {
            if(IsElementPresent(locator))
            {
                return ObjectRepo.Driver.FindElement(locator);
            }
            else
            {
                throw new NoSuchElementException("Element not found with locator : " + locator.ToString());
            }
        }

        public static void Click(By locator)
        {
            GetElement(locator).Click();
        }

        public static void JSClick(By locator)
        {
            IWebElement eleToClick = GetElement(locator);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)ObjectRepo.Driver;
            ex.ExecuteScript("arguments[0].click();", eleToClick);
        }

        public static void ClickOnLinkWithText(string text)
        {
            try
            {
                GetElement(By.LinkText(text)).Click();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to click on link with linktext " + ex);
            }
        }

        public static void TypeTextInTextBox(By locator, string text)
        {
            try
            {
                GetElement(locator).SendKeys(text);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in executin " + ex);
            }
        }

        public static bool VerifyIfCheckBoxIsChecked(By locator, string attr, string value)
        {
            return GetElement(locator).GetAttribute(attr).Contains(value);
        }

        public static void SwitchToFrame(By locator)
        {
            ObjectRepo.Driver.SwitchTo().Frame(GetElement(locator));
        }

        public static bool IsRadioButtonSelected(By locator)
        {
            return GetElement(locator).Selected;
        }

        public static bool IsButtonEnabled(By locator)
        {
            return GetElement(locator).Enabled;
        }

        public static void ClickOnButton(By locator)
        {
            if(IsButtonEnabled(locator))
            {
                GetElement(locator).Click();
            }
            else
            {
                throw new ButtonNotEnabled("Button is not enabled with locator : " + locator.ToString());
            }
        }

        public static void SelectFromDropdown(By selectLocator, int index)
        {
            SelectElement select = new SelectElement(GetElement(selectLocator));
            select.SelectByIndex(index);
        }

        public static void SelectFromDropdown(By selectLocator, string selectText)
        {
            SelectElement select = new SelectElement(GetElement(selectLocator));
            select.SelectByText(selectText);
        }

        public static void SelectFromDropdownByValue(By selectLocator, string selectTagValue)
        {
            SelectElement select = new SelectElement(GetElement(selectLocator));
            select.SelectByValue(selectTagValue);
        }

        public static IList<string> GetAllItems(By selectLocator)
        {
            SelectElement select = new SelectElement(GetElement(selectLocator));
            return select.Options.Select((x) => x.Text).ToList();
        }

        public static void TakeScreenShot(string filename = "Screen")
        {
            string currentPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\..\..\Screenshot";
            if (filename.Equals("Screen"))
            {
                filename = filename + DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm-ss") + ".jpeg";
                string path = currentPath + "\\" + filename;
                ((ITakesScreenshot)ObjectRepo.Driver).GetScreenshot().SaveAsFile(currentPath + "\\" + filename, ScreenshotImageFormat.Jpeg);
            }
            else
            {
                ((ITakesScreenshot)ObjectRepo.Driver).GetScreenshot().SaveAsFile(currentPath + "\\" + filename+".jpeg", ScreenshotImageFormat.Jpeg);
            }
            
        }

    }
}
