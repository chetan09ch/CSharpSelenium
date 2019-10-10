using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumJump
{
    class AutoPageObject
    {
       
        public AutoPageObject()
        {// PageFactory Initialization
            PageFactory.InitElements(PropertiesCollections.driver, this);
        }

        //-------------Assignment1Objects-------------------------

        [FindsBy(How= How.XPath, Using= "//a[@href='/portals/industries']/span[1]")]
        public IWebElement clickOnIndustries { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='sub-nav']/li[2]/a")]
        public IWebElement clickOnBuildingAutomation { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='sub-nav']/li[1]/a")]
        public IWebElement clickOnBaArchieve { get; set; }


        //-------------Assignment2Objects-------------------------

        [FindsBy(How = How.CssSelector, Using = "#nav > li:nth-child(3) > a")]
        public IWebElement clickOnProduct { get; set; }

        [FindsBy(How = How.CssSelector, Using = "select#field_617")]
        public IWebElement selectCategory { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > div.title-block > div > div > div > h1")]
        public IWebElement clickOnAnywhere { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#field_707")]
        public IWebElement enterSearchText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#tab-filter > div:nth-child(3) > div > div > a")]
        public IWebElement clickOnSaerchBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#pagination-container > div:nth-child(1) > div.holder > div.text-holder > h2 > a")]
        public IWebElement clickOnFirstItem { get; set; }

        //-------------Assignment3Objects-------------------------
        
        [FindsBy(How = How.XPath, Using = "//*[@id='nav']/li[4]/a")]
        public IWebElement mouseHoverOnJobCenter { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='nav']/li[4]/div/div/ul/li[3]/a")]
        public IWebElement clickOn2018SalarySurveyResult { get; set; }

        //1st Assignment: Print the count and titles of all the archived News-letters displayed in list
        public void GetAllTitles()
        {       
            clickOnIndustries.Clicks();
            clickOnBuildingAutomation.Clicks();
            clickOnBaArchieve.Clicks();
           
            IList<IWebElement> all = PropertiesCollections.driver.FindElements(By.XPath("//div[@class='company-section add']/ul/li"));

            int Listsize = all.Count();

            Console.WriteLine("The count of all the archived News-letters displayed in list is : " + Listsize);

            Console.WriteLine("The Titles of all the archived News-letters displayed in list is below : ");

            foreach (IWebElement Titles in all)
            {
                Console.WriteLine(Titles.Text);
            }          
        }

        //2nd Assignment : Verify the first item earlier is still displayed as first item
        public void GetProductItems(string subCategory)
        {
            clickOnProduct.Clicks();
            selectCategory.SelectCategoryDDL("Components / Circuit Breakers");
            clickOnAnywhere.Clicks();
            enterSearchText.EnterText("Components");
            clickOnSaerchBtn.Clicks();
            clickOnFirstItem.Clicks();          

            PropertiesCollections.driver.Navigate().Back();
            // Verifying whether still first item is getting displayed after navigating back
            var firstElement = PropertiesCollections.driver.FindElement(By.CssSelector("#pagination-container > div:nth-child(1) > div.holder > div.text-holder > h2 > a"));
            Console.WriteLine("The first item listed after search is : " + firstElement.Text);

            Assert.That(firstElement.Text, Is.EqualTo("Eaton introduces PXS24 electronic circuit breaker"));

            Console.WriteLine("The first item is succssefully verified after navigating back");
        }

        // 3rd Assignment:Region of the world
        public void getAvgSalaryByRegion(string RegionOfTheWorld)
        {
            Actions action = new Actions(PropertiesCollections.driver);
            action.MoveToElement(mouseHoverOnJobCenter).Perform();
            Thread.Sleep(4000);
            clickOn2018SalarySurveyResult.Clicks();          
            IWebElement AverageSalary = PropertiesCollections.driver.FindElement(By.XPath("//table[2]/tbody/tr/td//*[contains(text(), '"+ RegionOfTheWorld + "')]/ancestor::td/following-sibling::td[1]"));            
            Console.WriteLine("Average Salary of Region of the world South Asia is =" + AverageSalary.GetText());
        }

        public void getAvgSalaryRegionOfUnitedStates(string RegionOfTheUnitedStates)
        {
            IWebElement PercentRespondents=PropertiesCollections.driver.FindElement(By.XPath("//table[3]/tbody/tr/td//*[contains(text(),'"+ RegionOfTheUnitedStates + "')]/ancestor::td/following-sibling::td[2]"));
            Console.WriteLine("Percent Respondents of Region of the United States West south central is =" + PercentRespondents.Text);
        }
    }
}
