using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumJump
{
   public static class SeleniumGetMethods
    {
        //Extended method for geting text
        public static string GetText(this IWebElement element)
        {
            return element.Text;   //.GetAttribute("value")
        }
        public static string GetTextFromDDL(this IWebElement element)
        {       
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;            
        }
    }
}
