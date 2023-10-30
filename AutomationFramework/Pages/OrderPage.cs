
using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;



namespace AutomationFramework
{
    public class OrderPage 
    {
        private IWebDriver _driver;
        protected WebDriverWait? Wait;

        [FindsBy(How = How.CssSelector , Using = "button[ng-reflect-router-link^='/new-order']")]
        public IWebElement? _createNew;

        [FindsBy(How = How.Name, Using = "Accession Number")]
        private IWebElement? _accessionNumber;



        public OrderPage(IWebDriver driver) 
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);


        }
        public void ClickOnCreateOrder()

        {
           
            _createNew?.Click();
        }
        public bool IsOrderItemDisplayed()
        {
            IWebElement orderItem = _driver.FindElement(By.XPath("//div[@class='order-item']"));
            return orderItem != null;
        }
        public void EnterOrderDetails(string productName, int quantity, string customerName, string customerEmail)
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

