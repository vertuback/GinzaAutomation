using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Demo.TestModel;
using Swd.Core.Pages;
using Swd.Core.WebDriver;

namespace Demo.TestProject.Smoke
{
    
    [TestClass]
    public class Smoke_test_for_each_pageobject : TestBase
    {

        public void PageTest(UsefullMethods page)
        {
            // Implement Dispose inside page object in order to do cleanup
            using (page)
            {
                //SwdBrowser.HandleJavaScriptErrors();
                
                page.Invoke();

                // SwdBrowser.HandleJavaScriptErrors();
                
                page.VerifyExpectedElementsAreDisplayed();
                
                // SwdBrowser.HandleJavaScriptErrors();
            }
        }

        
        // Add testMethods for your new pages here:
        // *PageName*_VerifyExpectedElements()
        
        [TestMethod]
        public void RegistrationPopup_VerifyExpectedElements()
        {
            PageTest(MyPages.RegistrationPopup);
        }

        [TestMethod]
        public void LoginPage_VerifyExpectedElements()
        {
            PageTest(MyPages.LoginPage);
        }
        [TestMethod]
        public void StartPage_VerifyExpectedElements()
        {
            PageTest(MyPages.StartPage);
        }
        [TestMethod]
        public void ProfilePage_VerifyExpectedElements()
        {
            PageTest(MyPages.ProfilePage);
        }
        [TestMethod]
        public void ProductPage_VerifyExpectedElements()
        {
            PageTest(MyPages.ProductPage);
        }
    }
}