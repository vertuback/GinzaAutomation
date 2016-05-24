using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Swd.Core.WebDriver;
using Swd.Core;
using Swd.Core.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Demo.TestModel;
using Demo.TestModel.PageDeclarations;


namespace Demo.TestProject
{
    [TestClass]
    public class TestsForLoginAsUser
    {
        [TestMethod]
        public void Test0001LoginAsExistedRegularUser()
        {
            //Check possibility to login as existed regular user (dimon0000)

            //startpage
            SwdBrowser.Driver.Url = "http://www.ginza.se/";
            MyPages.StartPage.IsLoggedUserExist();
            MyPages.StartPage.WaitUntilVisible();
            //loginpage
            MyPages.LoginPopup.Invoke();
            MyPages.LoginPopup.LoginAsRegularUser();


            Assert.IsTrue(StartPage.VerifyThatUserDimonIsLoggedIn());
        }
        [TestMethod]
        public void Test0002LoginAsExistedCompanyUser()
        {
            //Check possibility to login as existed company user (comni)

            //startpage
            SwdBrowser.Driver.Url = "http://www.ginza.se/";
            MyPages.StartPage.IsLoggedUserExist();
            MyPages.StartPage.WaitUntilVisible();
            //loginpage
            MyPages.LoginPopup.Invoke();
            MyPages.LoginPopup.LoginAsCompanyUser();


            Assert.IsTrue(StartPage.VerifyThatUserOldsstIsLoggedIn());
        }
    }
    [TestClass]
    public class ChangeProfileSaving : ProfilePage
    {
        [TestMethod]
        public void Test0003OpenProfileAndSaveNewValues()
        {
            //Open profile for logged user and verify elements

            //profile page
            Invoke();   //opening profile and also check if no logged user
            WaitForAjax();
            WaitForJSLoading();
            tabUppgifter.Click();
            WaitForUppgifter();
            SaveMobilePhoneFirstValue();
            txtMobil.Clear();
            GenerateRandomValue();  //method which generates random for mobilnummer field
            btnSpara.Click();
            WaitForAjax();
            WaitForJSLoading();

            Assert.IsTrue(CompareNewAndOldMobileNumbers());
        }
    }
    [TestClass]
    public class ProductPageTests : ProductPage
    {
        [TestMethod]
        public void Test0004AddProductToBasketFromProductPageAndCheckPrice()
        {
            //Open Product page and trying to add product to basket
            //product page
            Invoke();   //opening product page
            smokeRateStars.IsDisplayedSafe();
            WaitForAjaxLoading();
            WaitForJSLoading();
            btnAddToBasket.Click();
            WaitForAjaxLoading();
            WaitForJSLoading();
            smokePrice.IsDisplayedSafe();

            Assert.IsTrue(CheckThatPriceIsTheSameInBasketAndPage());
        }
        [TestMethod]
        public void Test0005LinkOnArtistPage()
        {

            Invoke();   //opening product page
            WaitForJSLoading();
            WaitForAjaxLoading();
            lnkArtist.Click();
            WaitForJSLoading();
            WaitForAjaxLoading();

            Assert.IsTrue(lnkReleasedatumFilter.IsDisplayedSafe());

        }
        [TestMethod]
        public void Test0006LinkOnLeveransInfo()
        {

            Invoke();   //opening product page
            WaitForJSLoading();
            WaitForAjaxLoading();
            lnkMerInfo.Click();
            WaitForJSLoading();
            WaitForAjaxLoading();

            Assert.IsTrue(smokeLeveransInfoText.IsDisplayedSafe());

        }
    }
    [TestClass]
    public class QuickCartTests : QuickCart
    {
        [TestMethod]
        public void Test0007ChangeQuantityOfproductsInBasketAndCheckPrice()
        {

            MyPages.ProductPage.Invoke();   //opening product page
            MyPages.ProductPage.AddToBasket();
            MyPages.ProductPage.CheckThatPriceIsTheSameInBasketAndPage();
            


            //to be continued...

        }
    }
}

    

