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
    public class TestBase
    {
        protected IWebDriver driver { get; set; }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollections.driver = new ChromeDriver();
            PropertiesCollections.driver.Navigate().GoToUrl("http://www.automation.com/");
            PropertiesCollections.driver.Manage().Window.Maximize();
            Console.WriteLine("Opened URL");
            Thread.Sleep(12000);

        }
        [TearDown]
        public void CleanUp()
        {
           
            PropertiesCollections.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
