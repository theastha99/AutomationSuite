using System;
using OpenQA.Selenium;
using AutomationFramework.Utils;

namespace AutomationFramework
{
    public class OrderTest : IClassFixture<WebDriverFixture>
    {
 
        private HomePage homePage;
        private OrderPage orderPage;
        public OrderTest(WebDriverFixture fixture)
        {

            homePage = new HomePage(fixture.Driver);
            orderPage = new OrderPage(fixture.Driver);
        }

        [Fact]
        public void CreateOrderTest()
        {
            // Navigate to the homepage.
            homePage.NavigateToOrders();

            // Perform actions on the homepage.
            // E.g., click buttons or links to navigate to the order page.

            // Initialize the OrderPage and perform order creation actions.
            //var orderPage = new OrderPage(driver);
            //orderPage.CreateOrder("Product1", 2, "John Doe", "johndoe@example.com");

            //// Assert order creation success or any other validation.
            //Assert.True(orderPage.IsOrderCreatedSuccessfully);
        }
    }
}

