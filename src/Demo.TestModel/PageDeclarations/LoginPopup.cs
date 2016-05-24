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
    public class LoginPopup : UsefullMethods
    {
        #region WebElements

        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_LoginForm1_loginControl_UserName")]
        protected IWebElement txtUserName { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_LoginForm1_loginControl_Password")]
        protected IWebElement txtUserPassword { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_LoginForm1_loginControl_RememberMe")]
        protected IWebElement chkRememberMe { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"a#rememberPass")]
        protected IWebElement lnkForgotPassword { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"a#ucLogin_LoginForm1_loginControl_hlRegLink")]
        protected IWebElement lnkRegisterNewUser { get; set; }


        [FindsBy(How=How.CssSelector, Using = @"a#ucLogin_LoginForm1_loginControl_Login")]
        protected IWebElement btnLoggaIn { get; set; }

        #endregion

        #region Invoke() and IsDisplayed()
        public override void Invoke()
        {
            SwdBrowser.Driver.Url = "http://www.ginza.se/";
            WaitForAjaxLoading();
            WaitForJSLoading();
            //MyPages.StartPage.IsDisplayed();
            MyPages.StartPage.LoggaUtIfNeeded();
            var btnLoggaIn = SwdBrowser.Driver.FindElement(By.ClassName("login-link"));
            btnLoggaIn.Click();
            WaitForAjaxLoading();
            WaitForJSLoading();
            SwdBrowser.Driver.SwitchTo().Window(SwdBrowser.Driver.WindowHandles.Last());
           
            
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

        public void LoginAsRegularUser()
        {
            txtUserName.SendKeys("dimon0000");
            txtUserPassword.SendKeys("232233");
            btnLoggaIn.Click();
        }
        public void LoginAsCompanyUser()
        {
            txtUserName.SendKeys("oldsst");
            txtUserPassword.SendKeys("myrslok");
            btnLoggaIn.Click();
            WaitForAjaxLoading();
            WaitForJSLoading();
        }
    }
}