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
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
#endregion
namespace Demo.TestModel.PageDeclarations
{
    public class RegistrationPopup : UsefullMethods
    {
        #region WebElements

        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_ucRegistraion_tbxPersonNumber")]
        protected IWebElement txtPersonnumer { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_ucRegistraion_tbxName")]
        protected IWebElement txtFornamn { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_ucRegistraion_tbxSecondName")]
        protected IWebElement txtEfternamn { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_ucRegistraion_tbxLogin")]
        protected IWebElement txtAnvandarnamn { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_ucRegistraion_tbxEmail")]
        protected IWebElement txtEmail { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_ucRegistraion_tbxPhone")]
        protected IWebElement txtMobilnr { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_ucRegistraion_tbxPass")]
        protected IWebElement txtLosenord { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_ucRegistraion_tbxPassRepeat")]
        protected IWebElement txtRepeatLosenord { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxCO"")")]
        protected IWebElement txtco { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_ucRegistraion_tbxAddress")]
        protected IWebElement txtLeveransadress { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_ucRegistraion_tbxPostNumber")]
        protected IWebElement txtPostnr { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_ucRegistraion_tbxCity")]
        protected IWebElement txtPostort { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"select#ucLogin_ucRegistraion_ddlCountry")]
        protected IWebElement comboLand { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#ucLogin_ucRegistraion_chkCatalogue")]
        protected IWebElement chkKatalog { get; set; }


        [FindsBy(How= How.CssSelector, Using = @"input#ucLogin_ucRegistraion_chkNews")]
        protected IWebElement chkNewsletter { get; set; }


        [FindsBy(How= How.CssSelector, Using = @"a#ucLogin_ucRegistraion_lnkbSubmit")]
        protected IWebElement btnSkapaKonto { get; set; }
        
        #endregion    
         
        #region Invoke() and IsDisplayed()
        public override void Invoke()
        {
            //SwdBrowser.Driver.Url = @"http://www.ginza.se/login/Registration3.aspx";
            //var btnSkapakonto = SwdBrowser.Driver.FindElement(By.Id("registration"));
            //btnSkapakonto.Click();
            
            SwdBrowser.Driver.Url = @"https://www.ginza.se/";
            WaitForAjaxLoading();
            WaitForJSLoading();

            //// Get the current window handle so you can switch back later.
            //string currentHandle = SwdBrowser.Driver.CurrentWindowHandle;
            MyPages.StartPage.LoggaUtIfNeeded();
            WaitForAjaxLoading();
            WaitForJSLoading();
            //// Find the element that triggers the popup when clicked on.
            var btnLogin = SwdBrowser.Driver.FindElement(By.ClassName("login-link"));
            //if (btnLogin == null)
            //{
            //    MyPages.StartPage.LoggaUt();
            //}
            WaitForAjaxLoading();
            WaitForJSLoading();
            btnLogin.Click();

            SwdBrowser.Driver.SwitchTo().Window(SwdBrowser.Driver.WindowHandles.Last());
            var btnRegisterNewUserInsidePopup = SwdBrowser.Driver.FindElement(By.CssSelector("a#ucLogin_LoginForm1_loginControl_hlRegLink"));
            btnRegisterNewUserInsidePopup.Click();
            WaitForAjaxLoading();
            WaitForJSLoading();
            SwdBrowser.Driver.SwitchTo().Window(SwdBrowser.Driver.WindowHandles.Last());

            // The Click method of the PopupWindowFinder class will click
            // the desired element, wait for the popup to appear, and return
            // the window handle to the popped-up browser window. Note that
            // you still need to switch to the window to manipulate the page
            // displayed by the popup window.

            //var btnRegisterNewUserInsidePopup = SwdBrowser.Driver.FindElement(By.CssSelector("a#ucLogin_LoginForm1_loginControl_hlRegLink"));

            //PopupWindowFinder finder = new PopupWindowFinder(SwdBrowser.Driver);
            //string popupWindowHandle = finder.Click(btnRegisterNewUserInsidePopup);

            //SwdBrowser.Driver.SwitchTo().Window(popupWindowHandle);

            // Do whatever you need to on the popup browser, then...




        }


        public override bool IsDisplayed()
        {
            return SwdBrowser.Driver.Url.Contains("ginza.se");
        }
        #endregion    
 
        public override void VerifyExpectedElementsAreDisplayed()
        {
            VerifyElementVisible("txtPersonnumer", txtPersonnumer);
            VerifyElementVisible("txtFornamn", txtFornamn);
            VerifyElementVisible("txtEfternamn", txtEfternamn);
            VerifyElementVisible("txtAnvandarnamn", txtAnvandarnamn);
            VerifyElementVisible("txtEmail", txtEmail);
            VerifyElementVisible("txtMobilnr", txtMobilnr);
            VerifyElementVisible("txtLosenord", txtLosenord);
            VerifyElementVisible("txtRepeatLosenord", txtRepeatLosenord);
            //VerifyElementVisible("txtco", txtco);
            VerifyElementVisible("txtLeveransadress", txtLeveransadress);
            VerifyElementVisible("txtPostnr", txtPostnr);
            VerifyElementVisible("txtPostort", txtPostort);
            VerifyElementVisible("comboLand", comboLand);
            VerifyElementVisible("chkKatalog", chkKatalog);
            VerifyElementVisible("chkNewsletter", chkNewsletter);
            VerifyElementVisible("btnSkapaKonto", btnSkapaKonto);
        }            
    }
}