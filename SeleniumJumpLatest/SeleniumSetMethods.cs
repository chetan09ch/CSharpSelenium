using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumJump
{
    public static class SeleniumSetMethods
    {
        // Extended method for Click into a button, Checkbox, options
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }
        // Extended method forSearchText, EnterText
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        // Extended method for Select Category via dropdown
        public static void SelectCategoryDDL(this IWebElement element, string value)
        {
               new SelectElement(element).SelectByText(value);          
        }
       
    }
}
