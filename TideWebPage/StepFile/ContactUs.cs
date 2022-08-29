using System;
using TechTalk.SpecFlow;
using TideWebPage.POM;

namespace TideWebPage.StepFile
{
    [Binding]
    public class ContactUs
    {
        ContactOption Co = new ContactOption();
        [Given(@"browse Url")]
        public void GivenBrowseUrl()
        {
            Co.OpenUrl();
        }
        
        [When(@"click on contact us")]
        public void WhenClickOnContactUs()
        {
            Co.ClickOnContactUs();
        }
        
        [Then(@"it should display user contact us options")]
        public void ThenItShouldDisplayUserContactUsOptions()
        {
            Co.DisplayOptions();
        }
    }
}
