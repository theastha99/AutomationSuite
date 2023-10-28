using System;
using OpenQA.Selenium;

namespace AutomationFramework
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}

