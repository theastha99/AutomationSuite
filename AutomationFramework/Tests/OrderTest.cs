using System;
using OpenQA.Selenium;
using AutomationFramework.Utils;
using Xunit.Abstractions;
using SeleniumExtras.WaitHelpers;

namespace AutomationFramework
{
    public class OrderTest : TestBase
    {

        private readonly ITestOutputHelper _output;

        public OrderTest(WebDriverFixture fixture, ITestOutputHelper output) : base(fixture)
        {
            _output = output;

        }

        [Fact]
        public void ValidateMandatoryFieldsForOrderForm()
        {
            // Navigate to the homepage.
            HomePage.LaunchApp();
            WaitHelpers.WaitForPageLoad(Driver, 5);
            WaitHelpers.WaitForElementToBeClickable(Driver, HomePage.orderbutton, 5);
            HomePage.NavigateToOrders();
            WaitHelpers.WaitForElementToBeClickable(Driver, OrderPage._createNew, 5);
            OrderPage.ClickOnCreateOrder();
            WaitHelpers.WaitForElementToBeClickable(Driver, NewOrderPage.mrn, 5);
            NewOrderPage.EnterDetailsForNewOrder();
            WaitHelpers.WaitForElementToBeClickable(Driver, NewOrderPage.submitbutton, 5);
            NewOrderPage.EnterDetailsForNewOrder();
            _output.WriteLine("Order entry test completed.");


        }
    }

    
}

