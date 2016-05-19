using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Swd.Core;
using Swd.Core.Pages;
using Swd.Core.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Demo.TestModel
{
    public abstract class UsefullMethods : SelfTestingCorePage, IDisposable
    {


        // Verifies the expected WebElement to be Visible
        public virtual void VerifyElementVisible(string elementName, IWebElement webElement)
        {
            if (!webElement.Displayed)
            {
                string message = "Error: WebElement with name <" + elementName + ">\n"
                                 + "was expected to be visible," 
                                 + "but the element was not found on the page.";

                throw new Exception();
            }
        }

        // Override and implement this method, 
        // in case you want the pages to clean up
        public virtual void Dispose()
        {
            // Does nothing at the moment
        }
        public void WaitForAjaxLoading()
        {
            while (true) // Handle timeout somewhere
            {
                var ajaxIsComplete = (bool)(SwdBrowser.Driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                if (ajaxIsComplete)
                    Thread.Sleep(1000);
                    break;
            }
        }
        public void WaitForJSLoading()
        {
            IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(SwdBrowser.Driver, TimeSpan.FromSeconds(30.00));

            wait.Until(driver1 => ((IJavaScriptExecutor)SwdBrowser.Driver).ExecuteScript("return document.readyState").Equals("complete"));
            Thread.Sleep(1000);
        }
    }
}
