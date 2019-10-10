using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumJump
{
    enum PropertyType
    {
        Id,
        Name,
        Xpath,
        CssSelector,
        ClassName,
        LinkText

    }
    class PropertiesCollections
    {
        public static IWebDriver driver { get; set; }

    }

}
