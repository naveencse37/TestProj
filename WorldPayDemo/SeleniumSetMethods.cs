using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace WorldPayDemo 
{
    public class SeleniumSetMethods : Util.TestBase
    {

        public static void EnterText(string element, string value, string locator)
        {   
            if (locator == "Id")
            driver.FindElement(By.Id(element)).SendKeys(value);
            if (locator == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
            if (locator == "Xpath")
                driver.FindElement(By.XPath(element)).SendKeys(value);  
        }

        public static void Click(string element, string locator)
        {

            if (locator == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (locator == "Name")
                driver.FindElement(By.Name(element)).Click();
            if (locator == "Xpath")
                driver.FindElement(By.XPath(element)).Click();
        }

        public static void SelectDropDown(string element, string value, string locator)
        {

            if (locator == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (locator == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            if (locator == "Xpath")
                new SelectElement(driver.FindElement(By.XPath(element))).SelectByText(value);
        }




    }


}
