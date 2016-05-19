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
    public class TestsForLoggedCompanyUser
    {
        [TestMethod]
        public void Test0001LoginAsExistedCompanyUser()
        {
            //Check possibility to login as existed company user (dimon0000)

            //startpage
            SwdBrowser.Driver.Url = "http://www.ginza.se/";
            MyPages.StartPage.IsLoggedUserExist();
            MyPages.StartPage.WaitUntilVisible();
            //loginpage
            MyPages.LoginPage.Invoke();
            MyPages.LoginPage.LoginAsDimon();
            

            Assert.IsTrue(StartPage.VerifyThatUserDimonIsLoggedInAndLoginIfNot());
        }
    }
        [TestClass]
    public  class ChangeProfileSaving : ProfilePage
    {
        [TestMethod]
        public void Test0002OpenProfileAndSaveNewValues()
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
            [TestClass]
        public class ProductPageTests : ProductPage
        {
            [TestMethod]
            public void Test0003AddProductToBasketFromProductPageAndCheckPrice()
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

                Assert.IsTrue(CheckPrice());
            }
            [TestMethod]
            public void Test0004CheckMerAvTabSortingByAlphabet()
            {
                //Open Product page and then Mer Av "Artist" tab and click on filter by alphabet option
                Invoke();   //opening product page
                WaitForJSLoading();
                WaitForAjaxLoading();
                tabMerAv.Click();              
                lnkAOfilter.IsDisplayedSafe();
                CheckFirstProductTitleInMerAvTab();
                lnkAOfilter.Click();
                WaitForJSLoading();
                WaitForAjaxLoading();


                Assert.IsTrue(CheckFirstProductArtikelnummerInMerAvTabAfterFiltering());
            }
            [TestMethod]
            public void Test0005CheckMerAvTabSortingByPrice()
            {
                //Open Product page and then Mer Av "Artist" tab and click on filter by price option
                Invoke();   //opening product page
                WaitForJSLoading();
                WaitForAjaxLoading();
                tabMerAv.Click();
                lnkPrisFilter.IsDisplayedSafe();
                CheckFirstProductPriceInMerAvTab();
                lnkPrisFilter.Click();
                WaitForJSLoading();
                WaitForAjaxLoading(); 


                Assert.IsTrue(CheckFirstProductPriceInMerAvTabAfterFiltering());
            }
            [TestMethod]
            public void Test0006CheckMerAvTabSortingByReleaseDatum()
            {
                //Open Product page and then Mer Av "Artist" tab and click on filter by release date option
                Invoke();   //opening product page
                WaitForJSLoading();
                WaitForAjaxLoading();
                tabMerAv.Click();
                lnkReleasedatumFilter.IsDisplayedSafe();
                CheckFirstProductArtikelnummerInMerAvTab();
                lnkReleasedatumFilter.Click();
                WaitForJSLoading();
                WaitForAjaxLoading();


                Assert.IsTrue(CheckFirstProductArtikelnummerInMerAvTabAfterFiltering());
            }
            [TestMethod]
            public void Test0007CheckMerAvTabPagingByClickingNextPagebtn()
            {
                //test paging by using next page button
                Invoke();   //opening product page
                WaitForJSLoading();
                WaitForAjaxLoading();
                tabMerAv.Click();
                lnkReleasedatumFilter.IsDisplayedSafe();
                CheckFirstProductArtikelnummerInMerAvTab();
                btnPagingNextPage.Click();                
                WaitForJSLoading();
                WaitForAjaxLoading();

                Assert.IsTrue(CheckFirstProductArtikelnummerInMerAvTabAfterFiltering());              
            }
            [TestMethod]
            public void Test0008CheckMerAvTabPagingByClickingNumberOfPageBtn()
            {
                //test paging by using page number button
                Invoke();   //opening product page
                WaitForJSLoading();
                WaitForAjaxLoading();
                tabMerAv.Click();
                lnkReleasedatumFilter.IsDisplayedSafe();
                CheckFirstProductArtikelnummerInMerAvTab();
                btnPagingSecondPage.Click();

                Assert.IsTrue(CheckFirstProductArtikelnummerInMerAvTabAfterFiltering());
            }
            [TestMethod]
            public void Test0009LinkOnMerAvTab()
            {
                //test paging by using page number button
                Invoke();   //opening product page
                WaitForJSLoading();
                WaitForAjaxLoading();
                lnkArtist.Click();
                WaitForJSLoading();
                WaitForAjaxLoading();

                Assert.IsTrue(lnkReleasedatumFilter.IsDisplayedSafe());

            }
            [TestMethod]
            public void Test0010LinkOnLeveransInfo()
            {
                //test paging by using page number button
                Invoke();   //opening product page
                WaitForJSLoading();
                WaitForAjaxLoading();
                lnkMerInfo.Click();
                WaitForJSLoading();
                WaitForAjaxLoading();

                Assert.IsTrue(smokeLeveransInfoText.IsDisplayedSafe());

            }
            
                
        }
    }
}
