using SeleniumWithCsharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCsharp.Configuration
{
    /// <summary>
    /// This class is used to get data from app.cofig file
    /// </summary>
    public class AppConfigReader : IConfig
    {
        public string GetBeginnerUrl()
        {
            return ConfigurationManager.AppSettings.Get("BeginnerUrl");
        }

        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get("Browser");
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public int GetImplicitWait()
        {
            var timeout = ConfigurationManager.AppSettings.Get("ImplicitWait");
            if (timeout == null)
                return 30;
            return Convert.ToInt32(timeout);
        }

        public string GetIntermediateUrl()
        {
            return ConfigurationManager.AppSettings.Get("IntermediateUrl");
        }

        public int GetPageLoadTimeout()
        {
            var timeout =  ConfigurationManager.AppSettings.Get("PageLoadTimeout");
            if (timeout == null)
                return 30;
            return Convert.ToInt32(timeout);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get("Username");
        }

        public string GetRahulShettyUrl()
        {
            return ConfigurationManager.AppSettings.Get("RahulShettyUrl");
        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get("Password");
        }
    }
}
