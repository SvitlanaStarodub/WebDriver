using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeWork2.Core
{
    class SeleniumDriver
    {
        public static class SeleniumDriver
        {
            private static IWebDriver _driver;

            public static IWebDriver Driver
            {
                get
                {
                    if (_driver == null)
                    {
                        _driver = new ChromeDriver();
                    }
                    return _driver;
                }

                set { _driver = value; }
            }
        }
    }
}
