using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumJump
{

    public class CAutomation
    {

        public static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollections.driver = new ChromeDriver();
            PropertiesCollections.driver.Navigate().GoToUrl("http://www.automation.com/");
            PropertiesCollections.driver.Manage().Window.Maximize();
            Console.WriteLine("Opened URL");
            Thread.Sleep(8000);

        }
        [Test]
        public void ExecuteAssignment1()
        {
            // Initialize the page by calling its reference
            AutoPageObject page = new AutoPageObject();

            page.GetAllTitles();
                    
        }

        [Test]

        public void ExecuteAssignment2()
        {
            AutoPageObject page1 = new AutoPageObject();
            page1.GetProductItems("Components");
          
        }

        [Test]
        public void ExecuteAssignment3()
        {
            AutoPageObject page2 = new AutoPageObject();
            page2.getAvgSalaryByRegion("South Asia");
            page2.getAvgSalaryRegionOfUnitedStates("West South Central (South)");

        }
        [TearDown]
        public void CleanUp()
        {

            PropertiesCollections.driver.Close();
            Console.WriteLine("Closed the browser");
        }
        


    }
}





       
        
    

