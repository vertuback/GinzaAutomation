#region Usings - System
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
    public class LoginPage : UsefullMethods
    {
        #region WebElements

        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_loginControl_UserName"")")]
        protected IWebElement txtUserName { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_loginControl_Password"")")]
        protected IWebElement txtUserPassword { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_loginControl_RememberMe"")")]
        protected IWebElement chkRememberMe { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_loginControl_pnlLoginBox"")/ul[1]/li[5]/p[1]/a[1]")]
        protected IWebElement lnkForgotPassword { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_loginControl_hlRegLink"")")]
        protected IWebElement lnkRegisterNewUser { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_loginControl_Login"")")]
        protected IWebElement btnLoggaIn { get; set; }

        #endregion

        #region Invoke() and IsDisplayed()
        public override void Invoke()
        {
            SwdBrowser.Driver.Url = "http://www.ginza.se/login/login3.aspx";
            //MyPages.StartPage.IsDisplayed();
            //var btnLoggaIn = SwdBrowser.Driver.FindElement(By.ClassName("login-link"));
            //btnLoggaIn.Click();
            
        }

        public override bool IsDisplayed()
        {
            return true;
        }
        #endregion

        public override void VerifyExpectedElementsAreDisplayed()
        {
            VerifyElementVisible("txtUserPassword", txtUserPassword);
            VerifyElementVisible("btnLoggaIn", btnLoggaIn);
            VerifyElementVisible("txtUserName", txtUserName);
            VerifyElementVisible("chkRememberMe", chkRememberMe);
            VerifyElementVisible("lnkForgotPassword", lnkForgotPassword);
            VerifyElementVisible("lnkRegisterNewUser", lnkRegisterNewUser);
        }
        //internal void LoginAsDimon()
        //{
        //    SwdBrowser.Driver.Url = @"http://www.ginza.se/";          
        //    var btnLoggaIn = SwdBrowser.Driver.FindElement(By.ClassName("login-link"));
        //    btnLoggaIn.Click();


        //}

        public void LoginAsDimon()
        {
            txtUserName.SendKeys("dimon0000");
            txtUserPassword.SendKeys("232233");
            btnLoggaIn.Click();
        }
    }
}