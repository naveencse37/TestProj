using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldPayDemo.Util
{
   public class TestBase
    {
       public static IWebDriver driver;

        public void Initialization()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.worldpay.com/uk";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
         }

        public void Close()
        {
            driver.Quit();
        }
    }
}
