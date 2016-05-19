﻿#region Usings - System
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
#endregion
#region Usings - SWD
    using Swd.Core;
    using Swd.Core.Pages;
    using Swd.Core.WebDriver;
#endregion
#region Usings - WebDriver
    using OpenQA.Selenium.Support.PageObjects;
    using OpenQA.Selenium;
#endregion
namespace Demo.TestModel.PageDeclarations
{
    public class StartPage : UsefullMethods
    {
        #region WebElements

        [FindsBy(How = How.XPath, Using = @"id(""ctl00_ucLogin_lnbLogout"")")]
        protected IWebElement btnLogOut { get; set; }

        [FindsBy(How = How.ClassName, Using = @"login-link")]
        protected IWebElement btnLogin { get; set; }
        

        [FindsBy(How = How.PartialLinkText, Using = @"Anna-Lena")]
        protected IWebElement btnProfileForDimon0000 { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""stSearch4_tbSearch"")")]
        protected IWebElement txtSearch { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""stSearch4_btnSearch"")")]
        protected IWebElement btnSearch { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_TopMenuCtrl1_rptMainMenu_hplCategory_0"")/span[1]")]
        protected IWebElement MusicCategory { get; set; }

        #endregion

        #region Invoke() and IsDisplayed()
        public override void Invoke()
        {
            SwdBrowser.Driver.Url = @"http://www.ginza.se/";
            if (!IsDisplayed())
            {
            }
        }

        public override bool IsDisplayed()
        {
            return SwdBrowser.Driver.Title.Contains(@"och");
        }
        #endregion

        public override void VerifyExpectedElementsAreDisplayed()
        {
            
            VerifyElementVisible("txtSearch", txtSearch);
            VerifyElementVisible("btnSearch", btnSearch);
            VerifyElementVisible("MusicCategory", MusicCategory);
        }

        internal void Login()
        {

        }

        public void IsLoggedUserExist()
        {
            if (btnLogOut.IsDisplayedSafe())
            {
                btnLogOut.Click();
            }
        }

        public static bool VerifyThatUserDimonIsLoggedIn()
        {   
            if (SwdBrowser.Driver.FindElements(By.PartialLinkText("Anna-Lena")).Count > 0)
            {
                return true;
            }
            return false;
        }

        public static bool VerifyThatUserDimonIsLoggedInAndLoginIfNot()
        {
            if (SwdBrowser.Driver.FindElements(By.PartialLinkText("Anna-Lena")).Count > 0)
            {
                return true;
            }
            var btnLoggaIn = SwdBrowser.Driver.FindElement(By.ClassName("login-link"));
            btnLoggaIn.Click();
            
            return true;
        }

        public void WaitUntilVisible()
        {
            MusicCategory.WaitUntilVisible(TimeSpan.FromSeconds(10));
        }
    }
}