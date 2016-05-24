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
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
#endregion
namespace Demo.TestModel.PageDeclarations
{
    public class QuickCart : UsefullMethods
    {
        #region WebElements

        [FindsBy(How = How.CssSelector, Using = @"td#totalPrice")]
        protected IWebElement smokeTotalPrice { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div#upCart > div:nth-of-type(3) > table > tbody > tr:nth-of-type(2) > td")]
        protected IWebElement smokeDeliveryCost { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"td#tdSumma")]
        protected IWebElement smokeSubtotal { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"a#ucProductCart_hplGoToPay1")]
        protected IWebElement btnGoToCheckout { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"a#link_delete_339504_100 > i")]
        protected IWebElement btnDeleteFirstProduct { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div#upCart > div > table > tbody > tr > td:nth-of-type(3) > span > a")]
        protected IWebElement btnIncreaseQuantityOfFirstProduct { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div#upCart > div > table > tbody > tr > td:nth-of-type(3) > span > a:nth-of-type(2)")]
        protected IWebElement btnDecreaseQuantityOfFirstProduct { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div#upCart > div > table > tbody > tr > td:nth-of-type(4)")]
        protected IWebElement smokePriceOfFirstProduct { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div#upCart > div > table > tbody > tr > th > a > span")]
        protected IWebElement lnkOpenProductPageFirstProduct { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div#upCart > div > table > tbody > tr > td:nth-of-type(2) > div:nth-of-type(2) > p:nth-of-type(2) > a")]
        protected IWebElement lnkConfirmDeletingOfProductInsidePopup { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div[id = ""cart-display""] > div:nth-of-type(2) > div:nth-of-type(3)")]
        protected IWebElement blockAndraHarKopt { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"tr#trControls > td > p > input")]
        protected IWebElement btnAddtoCartFromAndraHarKoptBlock { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"tr#trControls > td > div > span > strong")]
        protected IWebElement smokePriceForFirstProductFromAndraHarKopt { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"a#clearAll")]
        protected IWebElement lnkDeleteAllProducts { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div#upCart > div:nth-of-type(2) > ul > li:nth-of-type(2) > div > p:nth-of-type(2) > a")]
        protected IWebElement lnkConfirmDeleteAllproductsFromPopup { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div#cart > div > ul > li:nth-of-type(2)")]
        protected IWebElement smokeQuantityOfproducts { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"div#upCart > div > table > tbody > tr > td:nth-of-type(3) > span > input")]
        protected IWebElement txtChangeQuantityOfFirstProduct { get; set; }

        #endregion

        #region Invoke() and IsDisplayed()
        public override void Invoke()
        {
            SwdBrowser.Driver.Url = "http://www.ginza.se/product/scorpions/return-to-forever-2015-digi-ltd-/266516/";
            WaitForAjaxLoading();
            WaitForJSLoading();
            var btnAddToCart = SwdBrowser.Driver.FindElement(By.CssSelector("input#phMain_btnAddToCart"));
            btnAddToCart.Click();
            WaitForAjaxLoading();
            WaitForJSLoading();

            //WebDriverWait wait = new WebDriverWait(SwdBrowser.Driver, TimeSpan.FromSeconds(10));
            //var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div#cart > div")));

            //Actions action = new Actions(SwdBrowser.Driver);
            //action.MoveToElement(smokeQuantityOfproducts).Perform();
            txtChangeQuantityOfFirstProduct.Click();
            WaitForAjaxLoading();
            WaitForJSLoading();
            //SwdBrowser.Driver.SwitchTo().Frame(SwdBrowser.Driver.WindowHandles.Last());
        }
        public bool HoverOnQuickCart()
        {
            WebDriverWait wait = new WebDriverWait(SwdBrowser.Driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div#cart > div")));

            Actions action = new Actions(SwdBrowser.Driver);
            action.MoveToElement(smokeQuantityOfproducts).Perform();

            if (!smokeDeliveryCost.IsDisplayedSafe())
            {
                return false;
            }
            return true;
        }

        public override bool IsDisplayed()
        {
            throw new NotImplementedException();
            return true;
        }
        #endregion

public override void VerifyExpectedElementsAreDisplayed()
        {
            VerifyElementVisible("smokeTotalPrice", smokeTotalPrice);
            VerifyElementVisible("smokeDeliveryCost", smokeDeliveryCost);
            VerifyElementVisible("smokeSubtotal", smokeSubtotal);
            VerifyElementVisible("btnGoToCheckout", btnGoToCheckout);
            //VerifyElementVisible("btnDeleteFirstProduct", btnDeleteFirstProduct);
            VerifyElementVisible("btnIncreaseQuantityOfFirstProduct", btnIncreaseQuantityOfFirstProduct);
            VerifyElementVisible("btnDecreaseQuantityOfFirstProduct", btnDecreaseQuantityOfFirstProduct);
            VerifyElementVisible("smokePriceOfFirstProduct", smokePriceOfFirstProduct);
            VerifyElementVisible("lnkOpenProductPageFirstProduct", lnkOpenProductPageFirstProduct);
            //VerifyElementVisible("lnkConfirmDeletingOfProductInsidePopup", lnkConfirmDeletingOfProductInsidePopup);
            //VerifyElementVisible("blockAndraHarKopt", blockAndraHarKopt);
            //VerifyElementVisible("btnAddtoCartFromAndraHarKoptBlock", btnAddtoCartFromAndraHarKoptBlock);
            //VerifyElementVisible("smokePriceForFirstProductFromAndraHarKopt", smokePriceForFirstProductFromAndraHarKopt);
            //VerifyElementVisible("lnkDeleteAllProducts", lnkDeleteAllProducts);
            //VerifyElementVisible("lnkConfirmDeleteAllproductsFromPopup", lnkConfirmDeleteAllproductsFromPopup);
            VerifyElementVisible("smokeQuantityOfproducts", smokeQuantityOfproducts);
            VerifyElementVisible("txtChangeQuantityOfFirstProduct", txtChangeQuantityOfFirstProduct);
        }
    }
}
