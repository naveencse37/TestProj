using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldPayDemo.Pages
{
    public class HomePage : Util.TestBase
    {
        By companyLink = By.XPath("//a[contains(text(),'Company')]");
        By text = By.XPath("//h2[contains(text(),'About Worldpay')]");
        By textMultiple = By.XPath("//span[contains(text(),'Products')]");
        By contactUsLink = By.Id("enquire");
        By arrangeAFreeCall = By.LinkText("Arrange a free call");
        By nameText = By.Name("submitted[LMS_ContactName]");
        By telephoneNumber = By.Name("submitted[LMS_ContactTelephone]");
        By emailAddress = By.Id("edit-submitted-lms-emailaddress");




    public void ClickLink()
        {
            driver.FindElement(companyLink).Click();
        }

        public String PageTitle()
        {
            return driver.Title;
        }

        public void SendKeys(string name, string telephone, string email)
        {
            driver.FindElement(nameText).SendKeys(name);
           driver.FindElement(telephoneNumber).SendKeys(telephone);
            driver.FindElement(emailAddress).SendKeys(email);

        }
        public void VerifyText()
        {
            driver.FindElement(text);
            Console.WriteLine(text);
            }

    public void ClickContactus()
        { 
            driver.FindElement(contactUsLink).Click();
            //driver.FindElement(arrangeAFreeCall).Click();
        }


        public void ClickArrangeAFreeCall()
        {
            driver.FindElement(arrangeAFreeCall).Click();
        }

        public void FillForm(string name, string telephone, string email)
        {
            driver.FindElement(nameText).SendKeys(name);
            driver.FindElement(telephoneNumber).SendKeys(telephone);
            driver.FindElement(emailAddress).SendKeys(email);
         }
    }
}
