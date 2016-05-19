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
#endregion
namespace Demo.TestModel.PageDeclarations
{
    public class ProductPage : UsefullMethods
    {
        #region WebElements
        public string PriceBeforeFiltering { get; set; }
        public string ArtNummerBeforeFiltering { get; set; }
        public string TitleBeforeFiltering { get; set; }

        [FindsBy(How = How.XPath, Using = @"id(""cart"")/div[1]/ul[1]/li[3]")]
        protected IWebElement basketPrice { get; set; }

        [FindsBy(How = How.XPath, Using = @"id(""phMain_imgPhoto"")")]
        protected IWebElement imgMainImage { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_aArtist"")/h2[1]")]
        protected IWebElement lnkArtist { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[2]/h1[1]")]
        protected IWebElement smokeTitle { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""prod-nav"")/li[1]/a[1]")]
        protected IWebElement btnPreviousProduct { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""prod-nav"")/li[2]/a[1]")]
        protected IWebElement btnNextProduct { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_pPrice"")/span[1]")]
        protected IWebElement smokePrice { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[2]/p[2]")]
        protected IWebElement smokeMediaType { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[2]/p[3]/a[1]")]
        protected IWebElement lnkMerInfo { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_btnAddToCart"")")]
        protected IWebElement btnAddToBasket { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[2]/div[2]/ul[1]/li[1]/a[1]")]
        protected IWebElement lnkAddToWishlist { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[2]/div[2]/ul[1]/li[3]/a[1]")]
        protected IWebElement lnkTipsAFriend { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[2]/div[2]/ul[1]/li[5]/a[1]")]
        protected IWebElement lnkBloggaOmProdukten { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[2]/div[2]/ul[1]/li[6]/a[1]")]
        protected IWebElement lnkSkrivUt { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[2]/div[3]/p[1]/span[1]")]
        protected IWebElement smokeRateStars { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[2]/div[3]/p[1]/strong[1]")]
        protected IWebElement smokeNumberOfUsers { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[2]/div[3]/p[1]/strong[2]/a[1]")]
        protected IWebElement lnkRecensioner { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[6]/ul[1]/li[1]/a[1]/span[1]")]
        protected IWebElement tabProductInfo { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""artistTab"")/span[1]")]
        protected IWebElement tabMerAv { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""relatedTab"")/span[1]")]
        protected IWebElement tabRelaterade { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""leveransinfoTab"")/span[1]")]
        protected IWebElement tabLeveransInfo { get; set; }

        [FindsBy(How = How.XPath, Using = @"id(""leveransinfo"")/strong[1]")]
        protected IWebElement smokeLeveransInfoText { get; set; }

        //Here Values From PRODUCT INFO TEXT BLOCK
        //
        //


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucProductDetails_trArtistGroup"")/th[1]")]
        protected IWebElement smokeArtistGrupp { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucProductDetails_trTitel"")/th[1]")]
        protected IWebElement smokeTitel { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucProductDetails_trType"")/th[1]")]
        protected IWebElement smokeTyp { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucProductDetails_trCategory"")/th[1]")]
        protected IWebElement smokeKategori { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucProductDetails_trArticleNumber"")/th[1]")]
        protected IWebElement smokeArtikelnummer { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucProductDetails_trReleaseDate"")/th[1]")]
        protected IWebElement smokeReleaseDatum { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucProductDetails_trStockStatus"")/th[1]")]
        protected IWebElement smokeLagerStatus { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucProductDetails_trEAN"")/th[1]")]
        protected IWebElement smokeEAN { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucProductDetails_trDistributor"")/th[1]")]
        protected IWebElement smokeDistributor { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucProductDetails_trNumberOfDiscs"")/th[1]")]
        protected IWebElement smokeAntalSkivor { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucProductDetails_trLabel"")/th[1]")]
        protected IWebElement smokeLabel { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucProductDetails_trProduction"")/th[1]")]
        protected IWebElement smokePructionsar { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""main"")/div[4]/div[1]/div[2]")]
        protected IWebElement lnkRss { get; set; }

        //Here Values From TIPS A FRIEND BLOCK
        //
        //


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucTipForm_tbxName"")")]
        protected IWebElement txtDitNamn { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucTipForm_tbxEmail"")")]
        protected IWebElement txtEmail { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucTipForm_tbxFriendName"")")]
        protected IWebElement txtNameOfSender { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucTipForm_tbxFriendEmail"")")]
        protected IWebElement txtEmailOfSender { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucTipForm_btnSubmit"")")]
        protected IWebElement btnSand { get; set; }

        //Here Values From ADD TO WISHLISTBLOCK
        //
        //


        [FindsBy(How = How.XPath, Using = @"id(""phMain_m_editWishListCtrl_m_wishListName"")")]
        protected IWebElement txtWishlistName { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""phMain_m_editWishListCtrl_m_wishListAddButton"")")]
        protected IWebElement btnLagTill { get; set; }

        //Here Values From BLOGGA TEXT
        //
        //

        [FindsBy(How = How.XPath, Using = @"id(""phMain_tbxCopyToBlog"")")]
        protected IWebElement smokeBloggatextBox { get; set; }

        //Here Values From MER AV TAB
        //
        //
        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[6]/ul[2]/li[2]/div[1]/span[1]")]
        protected IWebElement lnkFirstProductAritkelnr { get; set; }

        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[6]/ul[2]/li[2]/div[1]/h3[1]/a[2]")]
        protected IWebElement lnkFirstProductTitle { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""sort-name"")")]
        protected IWebElement lnkAOfilter { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""sort-date"")")]
        protected IWebElement lnkReleasedatumFilter { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""sort-price"")")]
        protected IWebElement lnkPrisFilter { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""liBottomPagerArtist"")/div[1]/a[1]")]
        protected IWebElement btnPagingPreviousPage { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""liBottomPagerArtist"")/div[1]/a[2]")]
        protected IWebElement btnPagingSecondPage { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""liBottomPagerArtist"")/div[1]/a[4]")]
        protected IWebElement btnPagingNextPage { get; set; }

        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[6]/ul[2]/li[2]/div[2]/p[1]")]
        protected IWebElement smokePriceOfFirstElement { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product"")/div[5]/ul[2]/li[2]/div[1]/span[1]")]
        protected IWebElement smokeArtikelnrOfFirstElement { get; set; }

        //Here Values From LEFT BLOCKS REKOMENDERAS AND ANDRA TITTADE
        //
        //


        [FindsBy(How = How.XPath, Using = @"id(""phMain_ucColumnRecommendationProducts2_divProductBanner"")/div[1]/div[1]/div[1]/div[2]/div[1]/p[1]/input[1]")]
        protected IWebElement addProductFromRecommenderasBlock { get; set; }


        [FindsBy(How = How.XPath, Using = @"id(""product-banner"")/div[1]/div[1]/div[2]/div[1]/p[1]/input[1]")]
        protected IWebElement addProductFromAndraTittadePaBlock { get; set; }

        #endregion

        #region Invoke() and IsDisplayed()
        public override void Invoke()
        {
            SwdBrowser.Driver.Url = "http://www.ginza.se/product/scorpions/return-to-forever-2015-digi-ltd-/266516/";
            Thread.Sleep(3000);
        }

        public override bool IsDisplayed()
        {
            throw new NotImplementedException();
            return true;
        }
        #endregion

        public override void VerifyExpectedElementsAreDisplayed()
        {
            smokeRateStars.WaitUntilVisible(TimeSpan.FromSeconds(10));
            VerifyElementVisible("imgMainImage", imgMainImage);
            VerifyElementVisible("lnkArtist", lnkArtist);
            VerifyElementVisible("smokeTitle", smokeTitle);
            VerifyElementVisible("btnPreviousProduct", btnPreviousProduct);
            VerifyElementVisible("btnNextProduct", btnNextProduct);
            VerifyElementVisible("smokePrice", smokePrice);
            VerifyElementVisible("smokeMediaType", smokeMediaType);
            VerifyElementVisible("lnkMerInfo", lnkMerInfo);
            VerifyElementVisible("btnAddToBasket", btnAddToBasket);
            VerifyElementVisible("lnkAddToWishlist", lnkAddToWishlist);
            VerifyElementVisible("lnkTipsAFriend", lnkTipsAFriend);
            VerifyElementVisible("lnkBloggaOmProdukten", lnkBloggaOmProdukten);
            VerifyElementVisible("lnkSkrivUt", lnkSkrivUt);
            WaitForAjaxLoading();
            VerifyElementVisible("smokeRateStars", smokeRateStars);
            VerifyElementVisible("smokeNumberOfUsers", smokeNumberOfUsers);
            VerifyElementVisible("lnkRecensioner", lnkRecensioner);
            VerifyElementVisible("tabProductInfo", tabProductInfo);
            VerifyElementVisible("tabMerAv", tabMerAv);
            VerifyElementVisible("tabRelaterade", tabRelaterade);
            VerifyElementVisible("tabLeveransInfo", tabLeveransInfo);
            VerifyElementVisible("smokeArtistGrupp", smokeArtistGrupp);
            VerifyElementVisible("smokeTitel", smokeTitel);
            VerifyElementVisible("smokeTyp", smokeTyp);
            VerifyElementVisible("smokeKategori", smokeKategori);
            VerifyElementVisible("smokeArtikelnummer", smokeArtikelnummer);
            VerifyElementVisible("smokeReleaseDatum", smokeReleaseDatum);
            VerifyElementVisible("smokeLagerStatus", smokeLagerStatus);
            VerifyElementVisible("smokeEAN", smokeEAN);
            VerifyElementVisible("smokeDistributor", smokeDistributor);
            VerifyElementVisible("smokeAntalSkivor", smokeAntalSkivor);
            VerifyElementVisible("smokeLabel", smokeLabel);
            VerifyElementVisible("smokePructionsar", smokePructionsar);
            WaitForAjaxLoading();
            VerifyElementVisible("lnkRss", lnkRss);
            lnkTipsAFriend.Click();
            VerifyElementVisible("txtDitNamn", txtDitNamn);
            VerifyElementVisible("txtEmail", txtEmail);
            VerifyElementVisible("txtNameOfSender", txtNameOfSender);
            VerifyElementVisible("txtEmailOfSender", txtEmailOfSender);
            VerifyElementVisible("btnSand", btnSand);
            //lnkAddToWishlist.Click();
            //if (StartPage.VerifyThatUserDimonIsLoggedIn())
            //VerifyElementVisible("txtWishlistName", txtWishlistName);
            //VerifyElementVisible("btnLagTill", btnLagTill);
            lnkBloggaOmProdukten.Click();
            VerifyElementVisible("smokeBloggatextBox", smokeBloggatextBox);
            tabMerAv.Click();
            VerifyElementVisible("lnkAOfilter", lnkAOfilter);
            VerifyElementVisible("lnkReleasedatumFilter", lnkReleasedatumFilter);
            VerifyElementVisible("lnkPrisFilter", lnkPrisFilter);
            VerifyElementVisible("btnPagingPreviousPage", btnPagingPreviousPage);
            VerifyElementVisible("btnPagingSecondPage", btnPagingSecondPage);
            VerifyElementVisible("btnPagingNextPage", btnPagingNextPage);
            VerifyElementVisible("addProductFromRecommenderasBlock", addProductFromRecommenderasBlock);
            VerifyElementVisible("addProductFromAndraTittadePaBlock", addProductFromAndraTittadePaBlock);
        }

        public bool CheckPrice()
        {
            var a = basketPrice.GetElementText();
            var b = smokePrice.GetElementText();
            int c = 29;
            //var t = string.Format(b);
            
                if (a == b + c)
                {
                    return true;
                }
            
            return false;
        }
        public void CheckFirstProductPriceInMerAvTab()
        {
            var value = smokePriceOfFirstElement.GetElementText();
            string PriceOfFirstElement = value.ToString();
            PriceBeforeFiltering = PriceOfFirstElement;
        }
        public bool CheckFirstProductPriceInMerAvTabAfterFiltering()
        {
            for (int i = 0; i < 6; i++)
            {
                string b = smokePriceOfFirstElement.GetElementText();
                if (PriceBeforeFiltering == b)
                {
                    Thread.Sleep(2000);
                }
            }
            return true;
        }
        public void CheckFirstProductTitleInMerAvTab()
        {
            var value = lnkFirstProductTitle.GetElementText();
            string FirstProductTitle = value.ToString();
            TitleBeforeFiltering = FirstProductTitle;
        }
        public bool CheckFirstProductTitleInMerAvTabAfterFiltering()
        {
            for (int i = 0; i < 6; i++)
            {
                string b = lnkFirstProductTitle.GetElementText();
                if (TitleBeforeFiltering == b)
                {
                    Thread.Sleep(2000);
                }
                
            }
            return true;
        }
        public void CheckFirstProductArtikelnummerInMerAvTab()
        {
            var value = lnkFirstProductAritkelnr.GetElementText();
            string FirstProductAritkelnr = value.ToString();
            ArtNummerBeforeFiltering = FirstProductAritkelnr;
        }
        public bool CheckFirstProductArtikelnummerInMerAvTabAfterFiltering()
        {
            for (int i = 0; i < 2; i++)
            {
                string b = lnkFirstProductAritkelnr.GetElementText();
                if (ArtNummerBeforeFiltering == b)
                {
                    Thread.Sleep(2000);
                }

            }
            return true;
        }
    }
}
