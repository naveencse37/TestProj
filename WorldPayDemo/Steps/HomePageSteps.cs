using System;
using TechTalk.SpecFlow;
using WorldPayDemo.Pages;
using WorldPayDemo.Util;
using TechTalk.SpecFlow.Assist;


namespace WorldPayDemo.Steps
{
    [Binding]
    public class HomePageSteps :Util.TestBase
    {
        HomePage homepage = new HomePage();
        TestBase testbase = new TestBase();


        [Given(@"I navigate to worldpay website")]
        public void GivenINavigateToWorldpayWebsite()
        {
            testbase.Initialization();
        }
        
        [Given(@"I click Company link")]
        public void GivenIClickCompanyLink()
        {
           // XPath("//a[contains(text(),'Company')]");
            homepage.ClickLink();
            //SeleniumSetMethods.Click("//a[contains(text(),'Company')]", "Xpath");
        }
        
        [Given(@"I verify About Worldpay text")]
        public void GivenIVerifyAboutWorldpayText()
        {
            homepage.VerifyText();

        }
        [Given(@"I click Contact us link")]
        public void GivenIClickContactUsLink()
        {
            homepage.ClickContactus();
        }

        [Given(@"I click Arrange a free call button")]
        public void GivenIClickArrangeAFreeCallButton()
        {
            homepage.ClickArrangeAFreeCall();
        }

        [Then(@"I fill form (.*), (.*), (.*)")]
        public void ThenIFillFormTestTestTest_Com(string name, string telephone, string email)
        {
            Console.WriteLine("name is " + name);
            homepage.FillForm(name, telephone, email);
        }

        [Then(@"I fill in form")]
        public void ThenIFillInForm(Table table)
        {
            //foreach (var row in table.Rows)
            //{
            //    homepage.SendKeys(row["name"], row["telephone"], row["email"]);
            //}
            var fill = table.CreateInstance<Form>();
            homepage.SendKeys(fill.name, fill.telephone, fill.email);
         }

        //test

        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            testbase.Close();
        }
    }
}
