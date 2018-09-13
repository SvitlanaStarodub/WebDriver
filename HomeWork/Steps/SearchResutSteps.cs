using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Pages;
using OpenQA.Selenium;

namespace HomeWork.Steps
{
    class SearchResutSteps
    {
        private readonly SearchResultsPage _searchResutsPage;

        public SearchResutSteps(IWebDriver driver)
        {
            _searchResutsPage = new SearchResultsPage(driver);
        }

        public List<string> GetResultsText()
        {
            return _searchResutsPage.SearchResults.Select(element => element.Text).ToList();
        }

        

    }
}
