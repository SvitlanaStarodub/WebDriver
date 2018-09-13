using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Pages;
using OpenQA.Selenium;

namespace HomeWork.Steps
{
    class DetailsOfSelectedItemSteps
    {
        private readonly DetailsOfSelectedItemPage _detailsOfSelectedItemPage;

        public DetailsOfSelectedItemSteps(IWebDriver driver)
        {
            _detailsOfSelectedItemPage = new DetailsOfSelectedItemPage(driver);
        }

        public Tuple<string,int> GetItemDetails()
        {
            var itemName = _detailsOfSelectedItemPage.ItemName.Text;
            var itemPriceText = _detailsOfSelectedItemPage.ItemPrice.Text;
            var itemPrice = int.Parse(string.Concat(itemPriceText.Split(' ')));

            return new Tuple<string, int>(itemName, itemPrice);

        }
    }
}
