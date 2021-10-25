using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWithCsharp.Configuration;
using SeleniumWithCsharp.Utilities;
using System;
using System.Threading;

namespace SeleniumWithCsharp.TestScripts.ToolsQAUrlAutomation
{
    [TestClass]
    public class LaunchToolsQAUrl
    {
        [TestMethod]
        public void LaunchToolsQAUrlTest()
        {
            SeleniumMethods.GoToUrl(ObjectRepo.Config.GetBeginnerUrl());
            Thread.Sleep(2000);
        }
    }
}
