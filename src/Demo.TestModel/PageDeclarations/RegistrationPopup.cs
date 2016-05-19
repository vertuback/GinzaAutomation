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
    public class RegistrationPopup : UsefullMethods
    {
        #region WebElements

        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxPersonNumber"")")]
        protected IWebElement txtPersonnumer { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxName"")")]
        protected IWebElement txtFornamn { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxSecondName"")")]
        protected IWebElement txtEfternamn { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxLogin"")")]
        protected IWebElement txtAnvandarnamn { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxEmail"")")]
        protected IWebElement txtEmail { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxPhone"")")]
        protected IWebElement txtMobilnr { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxPass"")")]
        protected IWebElement txtLosenord { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxPassRepeat"")")]
        protected IWebElement txtRepeatLosenord { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxCO"")")]
        protected IWebElement txtco { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxAddress"")")]
        protected IWebElement txtLeveransadress { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxPostNumber"")")]
        protected IWebElement txtPostnr { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_tbxCity"")")]
        protected IWebElement txtPostort { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_ddlCountry"")")]
        protected IWebElement comboLand { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_chkCatalogue"")")]
        protected IWebElement chkKatalog { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_chkNews"")")]
        protected IWebElement chkNewsletter { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ctl00_lnkbSubmit"")")]
        protected IWebElement btnSkapaKonto { get; set; }
        
        #endregion    
         
        #region Invoke() and IsDisplayed()
        public override void Invoke()
        {
            SwdBrowser.Driver.Url = @"http://www.ginza.se/login/Registration3.aspx";
            //var btnSkapakonto = SwdBrowser.Driver.FindElement(By.Id("registration"));
            //btnSkapakonto.Click();
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
            VerifyElementVisible("txtco", txtco);
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