using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldPayDemo
{
    class GetMethods : Util.TestBase
    {
        public static string GetText(string element, string value, string locator)
        {
            if (locator == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if (locator == "Name")
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            if (locator == "Xpath")
                return driver.FindElement(By.XPath(element)).GetAttribute("value");
            else return String.Empty;
        }

        public static string GetTextDDL(string element, string value, string locator)
        {
            if (locator == "Id")
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (locator == "Name")
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (locator == "Xpath")
                return new SelectElement(driver.FindElement(By.XPath(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }
    }
}
