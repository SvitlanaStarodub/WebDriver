using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Pages;
using OpenQA.Selenium;

namespace HomeWork.Steps
{
    class TVSearchResultSteps
    {
        private readonly TvSearchResultPage _tvSearchResultPage;

        public TVSearchResultSteps(IWebDriver driver)
        {
            _tvSearchResultPage = new TvSearchResultPage(driver);
        }

        public List<string> GetLGNames()
        {
            return _tvSearchResultPage.ItemNameList.Select(element => element.Text).ToList();
            
        }

        public Tuple<string, int> GetNamePriceOfItem(int index)
        {
            var itemName = _tvSearchResultPage.ItemNameList[index].Text;
            var priceText = _tvSearchResultPage.ItemPriceList[index].Text;
            var itemPrice = int.Parse(string.Concat(priceText.Split(' ')));
            return new Tuple<string, int>(itemName,itemPrice);
            
        }

        public void NavigateToDetails(int index)
        {
            _tvSearchResultPage.ItemNameList[index].Click();
        }

        public List<string> GetFilterNames()
        {
            return _tvSearchResultPage.FilterItems.Select(element => element.Text).ToList();
        }


    }
}
