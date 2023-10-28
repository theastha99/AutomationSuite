using OpenQA.Selenium;

namespace AutomationFramework
{
    public class HomePage : BasePage
    {
  
        private string homePageUrl = "https://localhost:44449/";

        public HomePage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
        public void NavigateToOrders()
        {
            Driver.Navigate().GoToUrl(homePageUrl + "/orders");
        }
      

    }
}
