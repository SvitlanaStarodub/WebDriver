using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeWorkPart2.Core
{
  
        public class SeleniumDriver
        {
            private static IWebDriver _driver;

            private SeleniumDriver() { }

            public static IWebDriver Driver
            {
                get { return _driver ?? (_driver = new ChromeDriver()); }


                set => _driver = value;
            }
        }
}

