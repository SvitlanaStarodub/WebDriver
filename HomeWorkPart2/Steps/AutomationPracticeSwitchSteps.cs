using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkPart2.Helpers;
using HomeWorkPart2.Pages;
using OpenQA.Selenium;

namespace HomeWorkPart2.Steps
{
    class AutomationPracticeSwitchSteps
    {
        private readonly AutomationPracticeSwitchPage _automationPracticeSwitchPage;
        
        public AutomationPracticeSwitchSteps(IWebDriver driver)
        {
            _automationPracticeSwitchPage = new AutomationPracticeSwitchPage(driver);
        }
        
        public void NavigationToAutoPracticeSwitch()
        {
            _automationPracticeSwitchPage.ItemDropDown.WaitForDisplayed();
            _automationPracticeSwitchPage.ItemDropDown.Click();

        }

        public void NavigateToBrowserWindow()
        {
            _automationPracticeSwitchPage.BrowserWindowButton.Click();
        }

        public void GenerateTimingAlert()
        {
            _automationPracticeSwitchPage.TimingAlertButton.Click();
        }
    }
}
