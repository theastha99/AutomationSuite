using AutomationFramework;
using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



public class TestBase : IDisposable, IClassFixture<WebDriverFixture>
{
    protected IWebDriver Driver;

    protected OrderPage OrderPage;
    protected HomePage HomePage;
    protected NewOrderPage NewOrderPage;
    protected WebDriverWait? Wait;

    // You can add more common page objects or elements here

    public TestBase(WebDriverFixture fixture)
    {

        Driver = fixture.Driver;
        Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        OrderPage = new OrderPage(Driver);
        HomePage = new HomePage(Driver);
        NewOrderPage = new NewOrderPage(Driver);
        WaitHelpers.WaitForPageLoad(Driver, 10);
        // Initialize other page objects here
    }

   
    public void Dispose()
    {
        Driver.Quit();
    }
}