using SeleniumWithCsharp.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCsharp.Interfaces
{
    /// <summary>
    /// Iconfig is used to give common methods to read data from any file like app.config or any xml file or any excel file
    /// This interface will ensure that any class will have to implement below methods
    /// </summary>
    public interface IConfig
    {
        BrowserType GetBrowser();

        string GetUsername();

        string GetPassword();

        string GetIntermediateUrl();

        string GetBeginnerUrl();

        string GetRahulShettyUrl();

        int GetPageLoadTimeout();

        int GetImplicitWait();
        
    }
}
