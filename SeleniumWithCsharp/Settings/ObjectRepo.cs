using OpenQA.Selenium;
using SeleniumWithCsharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCsharp.Settings
{
    public class ObjectRepo
    {
        public static IConfig Config { get; set; }
        
        public static IWebDriver Driver { get; set; }
    }
}
