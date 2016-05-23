#region Usings - System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
#endregion
#region Usings - SWD
using Swd.Core;
using Swd.Core.Pages;
using Swd.Core.WebDriver;
#endregion
#region Usings - WebDriver
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
#endregion
namespace Demo.TestModel.PageDeclarations
{
    public class ProfilePage : UsefullMethods
    {
        #region WebElements
        public string OldPhoneNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"div#profile > div")]
        protected IWebElement smokeMobilnummer { get; set; }

        //[FindsBy(How = How.XPath, Using = @"id(""cart"")/div[1]/ul[1]/li[3]")]
        //protected IWebElement smokePrice { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"a#orderTab > span")]
        protected IWebElement tabOrder { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"a#wishListTab > span")]
        protected IWebElement tabWishlist { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"a#uppgifterTab > span")]
        protected IWebElement tabUppgifter { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"a#losenordTab > span")]
        protected IWebElement tabLosenord { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"a#recensionsTab > span")]
        protected IWebElement tabRecensioner { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"a#phMain_lnbLogout")]
        protected IWebElement btnLoggaUt { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div#profile > div:nth-of-type(3) > a:nth-of-type(2)")]
        protected IWebElement btnRedigera { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div#profile > div:nth-of-type(3) > span > a")]
        protected IWebElement btnKundkorgen { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"p#breadcrumbs > a:nth-of-type(2)")]
        protected IWebElement lnkMinProfilBreadcrumb { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#phMain_ctl00_tbxPersonNumber")]
        protected IWebElement txtPersonnumer { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#phMain_ctl00_tbxName")]
        protected IWebElement txtFornamn { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#phMain_ctl00_tbxSecondName")]
        protected IWebElement txtEfternamn { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"input#phMain_ctl00_tbxLogin")]
        protected IWebElement txtAnvardarnamn { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"select#phMain_ctl00_ddlCountry")]
        protected IWebElement comboLand { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#phMain_ctl00_tbxMobile")]
        protected IWebElement txtMobil { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#phMain_ctl00_tbxPhone")]
        protected IWebElement txtTelefon { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div#product > div > div:nth-of-type(4) > div > div:nth-of-type(3) > a")]
        protected IWebElement btnSpara { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#phMain_ctl01_tbxNewPass")]
        protected IWebElement txtChangePassword { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"input#phMain_ctl01_tbxRepeatPass")]
        protected IWebElement txtChangePassword2 { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"a#phMain_ctl01_lnkbSent")]
        protected IWebElement btnSand { get; set; }

        #endregion

        #region Invoke() and IsDisplayed()
        public override void Invoke()
        {
            SwdBrowser.Driver.Url = "http://www.ginza.se/";
            WaitForAjaxLoading();
            WaitForJSLoading();
            //MyPages.StartPage.IsDisplayed();
            MyPages.StartPage.LoggaUtIfNeeded();
            WaitForAjaxLoading();
            WaitForJSLoading();
            var btnLoggaIn = SwdBrowser.Driver.FindElement(By.ClassName("login-link"));
            btnLoggaIn.Click();
            MyPages.LoginPopup.LoginAsRegularUser();
            WaitForAjaxLoading();
            WaitForJSLoading();           
            SwdBrowser.Driver.Url = "http://www.ginza.se/profile";
            WaitForAjaxLoading();
            WaitForJSLoading();
        }

        public override bool IsDisplayed()
        {
            for (int i = 0; i < 6; i++)
            {
                if (!btnSpara.IsDisplayedSafe())
                {
                    tabUppgifter.Click();
                    Thread.Sleep(2000);
                    
                }
            }
            return true;
        }
        public void SaveMobilePhoneFirstValue()
        {
            var value = smokeMobilnummer.GetElementText();
            string profilePhoneNumber = value.ToString();
            OldPhoneNumber = profilePhoneNumber;
        }

        public bool CompareNewAndOldMobileNumbers() 
        {                      
            for (int i = 0; i < 6; i++)
            {              
                string b = smokeMobilnummer.GetElementText();
                if (OldPhoneNumber == b)
                {
                    Thread.Sleep(2000);
                }
            }
            return true;
        }
        public void GenerateRandomValue()
        {
            Random rnd = new Random();
            int dice = rnd.Next(300000000, 500000000); // creates a number between 1 and 2
            var query = txtMobil;
            //DateTime y = DateTime.Today;
            query.SendKeys(dice.ToString());
        }
        public void WaitForUppgifter()
        {
            for (int i = 0; i < 5; i++)
            {
                if (!txtTelefon.IsDisplayedSafe())
                {
                    tabUppgifter.Click();
                    Thread.Sleep(2000);
                }
            }
        }
        public void WaitForLosenord()
        {
            for (int i = 0; i < 5; i++)
            {
                if (!txtChangePassword.IsDisplayedSafe())
                {
                    tabLosenord.Click();
                    Thread.Sleep(2000);
                }
            }
        }
        public void WaitForAjax()
        {
            while (true) // Handle timeout somewhere
            {
                var ajaxIsComplete = (bool)(SwdBrowser.Driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                if (ajaxIsComplete)
                    break;
                Thread.Sleep(100);
            }
        }
        public bool CheckThatUserIsLoggedIn()
        {
            WaitForAjaxLoading();
            WaitForJSLoading();
            if (tabUppgifter.IsDisplayedSafe())
            {
                tabUppgifter.Click();
            }
            string b = txtAnvardarnamn.GetElementText();
            const string a = "oldsst";
            if (b != a)
            {
                return false;
            }
            return true;
        }
        #endregion

        public override void VerifyExpectedElementsAreDisplayed()
        {
            
            WaitForAjaxLoading();
            WaitForJSLoading();
            VerifyElementVisible("tabOrder", tabOrder);
            VerifyElementVisible("tabWishlist", tabWishlist);
            VerifyElementVisible("tabUppgifter", tabUppgifter);
            VerifyElementVisible("tabLosenord", tabLosenord);
            VerifyElementVisible("tabRecensioner", tabRecensioner);
            VerifyElementVisible("btnLoggaUt", btnLoggaUt);
            VerifyElementVisible("btnRedigera", btnRedigera);
            VerifyElementVisible("btnKundkorgen", btnKundkorgen);
            VerifyElementVisible("lnkMinProfilBreadcrumb", lnkMinProfilBreadcrumb);
            WaitForUppgifter();
            VerifyElementVisible("txtPersonnumer", txtPersonnumer);
            VerifyElementVisible("txtFornamn", txtFornamn);
            VerifyElementVisible("txtEfternamn", txtEfternamn);
            VerifyElementVisible("comboLand", comboLand);
            VerifyElementVisible("txtMobil", txtMobil);
            VerifyElementVisible("txtTelefon", txtTelefon);
            VerifyElementVisible("btnSpara", btnSpara);
            WaitForLosenord();
            VerifyElementVisible("txtChangePassword", txtChangePassword);
            VerifyElementVisible("txtChangePassword2", txtChangePassword2);
            VerifyElementVisible("btnSand", btnSand);
        }
    }
}