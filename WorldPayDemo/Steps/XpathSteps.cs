using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WorldPayDemo.Pages;
using WorldPayDemo.Util;

namespace WorldPayDemo.Steps
{
    [Binding]

    public class XpathSteps : Util.TestBase
    {

        TestBase testBase = new TestBase();
        XpathPage xpath = new XpathPage();

        [Given(@"I have navigate to website")]
        public void GivenIHaveNavigateToWebsite()
        {
            testBase.Initialization();
            
        }

        [Given(@"I use xpath for to enter TextField")]
        public void GivenIUseXpathForToEnterTextField()
        {
            xpath.ClickFillOutFormLink();
            xpath.InputNameandMessage();

        }

        [Given(@"I use xpath to click button")]
        public void GivenIUseXpathToClickButton()
        {
            xpath.clickSubmit();
        }

        [Given(@"I user xpath to click checkbox")]
        public void GivenIUserXpathToClickCheckbox()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I user xpath to click hyperlink")]
        public void GivenIUserXpathToClickHyperlink()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
