using System;
using OpenQA.Selenium;

namespace AutomationFramework
{
    public class OrderPage : BasePage
    {
        private IWebDriver driver;

        public OrderPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public void ClickOnCreateOrder(string baseUrl)
        {
            Driver.Navigate().GoToUrl(baseUrl + "/orders");
        }
        public bool IsOrderItemDisplayed()
        {
            IWebElement orderItem = Driver.FindElement(By.XPath("//div[@class='order-item']"));
            return orderItem != null;
        }
        public void CreateOrder(string productName, int quantity, string customerName, string customerEmail)
        {
            // Implement your order creation logic here.
        }

        public bool IsOrderCreatedSuccessfully()
        {
            // Implement the order creation success check here.
            return true;
        }


    }
}

