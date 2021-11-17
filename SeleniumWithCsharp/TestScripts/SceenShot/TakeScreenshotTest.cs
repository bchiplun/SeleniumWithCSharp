using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWithCsharp.Configuration;
using SeleniumWithCsharp.Utilities;
using System;
using System.Threading;

namespace SeleniumWithCsharp.TestScripts.SceenShot
{
    [TestClass]
    public class TakeScreenshotTest
    {
        [TestMethod]
        public void TestScreenShotTest()
        {
            SeleniumMethods.GoToUrl(ObjectRepo.Config.GetBeginnerUrl());
            Thread.Sleep(1000);
            SeleniumMethods.TakeScreenShot();
            SeleniumMethods.TakeScreenShot("FIle1");
        }
    }
}
