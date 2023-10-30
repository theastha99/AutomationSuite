using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace AutomationFramework
{
	public class NewOrderPage 
	{
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "mrn")]
        public IWebElement? mrn;

        [FindsBy(How = How.Id, Using = "first-name")]
        public IWebElement? firstname;

        [FindsBy(How = How.Id, Using = "last-name")]
        public IWebElement? lastname;

        [FindsBy(How = How.Id, Using = "accession-number")]
        public IWebElement? accessionnumber;

        [FindsBy(How = How.Id, Using = "org-code")]
        public IWebElement? orgcode;

        [FindsBy(How = How.Id, Using = "site-id")]
        public IWebElement? siteid;

        [FindsBy(How = How.Id, Using = "modality")]
        public IWebElement? modality;

        [FindsBy(How = How.Id, Using = "study-date-time")]
        public IWebElement? studydatetime;

        [FindsBy(How = How.XPath, Using = "//app-new-order/form/div/div[2]/div/button[1]")]
        public IWebElement? submitbutton;


        [FindsBy(How = How.XPath, Using = "//app-new-order/form/div/div[2]/div/button[1]")]
        public IWebElement? firstName;

        public NewOrderPage(IWebDriver driver) 
		{
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void EnterDetailsForNewOrder()
        {
            mrn?.SendKeys("1233");
            firstname?.SendKeys("1233");
            lastname?.SendKeys("1233");
            accessionnumber?.SendKeys("");
            SelectValueFromDropDown(orgcode, "LUM");
            SelectValueFromDropDown(siteid, "102");
            SelectValueFromDropDown(modality, "CT");

        }

        public void ClickOnSubmitButton()
        {
            submitbutton?.Click();
        }
        public void SelectValueFromDropDown(IWebElement? dropdownelement,string optionvalue)
        {
            SelectElement selectElement = new SelectElement(dropdownelement);
            selectElement.SelectByValue(optionvalue);
        }
        //public void SelectValueFromDatePicker(string desiredDate)
        //{
            
        //    studydatetime?.Clear();

        //    string formattedDate = desiredDate.ToString("dd/MM/yyyy"); 

        //    studydatetime?.SendKeys(formattedDate);
        //}


    }
}

