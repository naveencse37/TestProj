using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldPayDemo.Util;

namespace WorldPayDemo.Pages
{
    public class XpathPage : Util.TestBase
    {
        By filloutFormLink = By.XPath("//a[contains(text(),'Fill out forms')]");
        By nameText = By.XPath("//p[@class='et_pb_contact_field et_pb_contact_field_0 et_pb_contact_field_half']/input");
        By messageText = By.XPath("//p[@class='et_pb_contact_field et_pb_contact_field_1 et_pb_contact_field_last']//textarea[@name='et_pb_contact_message_1']");
        By submitButton1 = By.XPath("//*[@id='et_pb_contact_form_0']/div[2]/form/div/button");
        





        public void ClickFillOutFormLink()
        {
            driver.FindElement(filloutFormLink).Click();
            
        }

        public void InputNameandMessage()
        {
            driver.FindElement(nameText).SendKeys("This is Name");
            //WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((messageText)));
            driver.FindElement(messageText).SendKeys("This is Message");

        }

        public void clickSubmit()
        {
            driver.FindElement(submitButton1).Click();
        }

        public void verifyText()
        {
            var text = driver.PageSource.Contains("Form filled out successfully");
            Assert.AreEqual(text, "Form filled out successfully");
        }


        
    }
}
