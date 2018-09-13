 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Core;
using HomeWork.Pages;
using HomeWork.Steps;
using NUnit.Framework;
 using NUnit.Framework.Constraints;
 using OpenQA.Selenium;

namespace HomeWork.Tests
{
    [TestFixture]
    public class TestSuite
    {
        private IWebDriver _driver;
        private const string Url = "https://www.citrus.ua/";

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = SeleniumDriver.Driver;
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void SearchProduct()
        {
            //arrange
            _driver.Url = Url;
            var homePage = new HomePageSteps(_driver);
            var searchResultsPage = new SearchResutSteps(_driver);

            //act
            homePage.Search("macbook");
            var conditionList = searchResultsPage.GetResultsText().Select(t => t.ToLower().Contains("macbook")).ToList();

            //assert
            CollectionAssert.DoesNotContain(conditionList, false);
        }

        [Test]

        public void TVSearch()
        {
            //arrange
            _driver.Url = Url;
            var homePageSteps = new HomePageSteps(_driver);
            var tvSearchResultsSteps = new TVSearchResultSteps(_driver);

            //act
            homePageSteps.SelectTelevisionSection();
            homePageSteps.SelectLGProducts();
            var conditionList = tvSearchResultsSteps.GetLGNames().Select(name => name.Contains("LG")).ToList();

           //assert
            CollectionAssert.DoesNotContain(conditionList, false);

        }

        [Test]

        public void TVPriceCheck()
        {
            //arrange
            _driver.Url = Url;
            var homePageSteps = new HomePageSteps(_driver);
            var tvSearchResultsSteps = new TVSearchResultSteps(_driver);
            var detailsOfSelectedItemSteps = new DetailsOfSelectedItemSteps(_driver);

            //act 
            homePageSteps.SelectTelevisionSection();
            var expectedResult = tvSearchResultsSteps.GetNamePriceOfItem(0);
            tvSearchResultsSteps.NavigateToDetails(0);
            var actualResult = detailsOfSelectedItemSteps.GetItemDetails();

            //assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        [Test]

        public void GetTvFiltersName()
        {
            //arrange
            _driver.Url = Url;
            var homePageSteps = new HomePageSteps(_driver);
            var tvSearchResultsSteps = new TVSearchResultSteps(_driver);
            var expectedResult = new List<string> {"Цена", "Акции и скидки", "Бренд", "Диагональ", "Разрешение", "Тип телевизора", "Smart TV", "Поддержка 3D", "Изогнутый экран", "Суммарная мощность динамиков", "Операционная система"};
             
             


            //act
            homePageSteps.SelectTelevisionSection();
            var actualResult = tvSearchResultsSteps.GetFilterNames();


            //assert
            CollectionAssert.AreEqual(expectedResult, actualResult);


        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

    }
}
