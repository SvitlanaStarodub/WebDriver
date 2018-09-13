using OpenQA.Selenium;
using SeleniumWD.Pages;

namespace SeleniumWD
{
    public class ProductPageSteps
    {
        private readonly IWebDriver _driver;
        private readonly ProductPage _productPage;

        public ProductPageSteps(IWebDriver driver)
        {
            _driver = driver;
            _productPage = new ProductPage(_driver);
        }

        public string GetTitle()
        {
            return _productPage.ProductTitle.Text;
        }
    }
}
