using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideWebPage.Hooks;

namespace TideWebPage.POM
{
    public class ContactOption
    {
        public void OpenUrl()
        {
            BasicClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BasicClass.driver.Manage().Window.Maximize();
        }
        public void ClickOnContactUs()
        {
            Thread.Sleep(6000);
            BasicClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BasicClass.driver.FindElement(By.XPath("//a[text()='Contact Us']")).Click();
        }
        public void DisplayOptions()
        {
            ((ITakesScreenshot)BasicClass.driver).GetScreenshot().SaveAsFile
                (@"E:\TideWebPage\TideWebPage\ScreenShorts\contactus.png");
        }
    }
}
