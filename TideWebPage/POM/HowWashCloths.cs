using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideWebPage.Hooks;

namespace TideWebPage.POM
{
    public class HowWashCloths
    {
        public void BrowseUrl()
        {
            BasicClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BasicClass.driver.Manage().Window.Maximize();
            Thread.Sleep(6000);
            BasicClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
        }
        public void Hover()
        {
            IWebElement element = BasicClass.driver.FindElement(By.XPath("//a[@data-action-detail='How to Wash Clothes']"));
            Actions act = new Actions(BasicClass.driver);
            act.MoveToElement(element);
            act.Perform();
            Thread.Sleep(3000);
        }
        public void ChooseOption()
        {
            //Thread.Sleep(4000);
            //BasicClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BasicClass.driver.FindElement(By.XPath("//*[@id='site-header']/div[3]/div/div/div/div[3]/div/div[1]/a/span")).Click();
        }
        public void Readmore()
        {
            BasicClass.driver.FindElement(By.XPath("//a[text()='Acne Cream']")).Click();
        }
        public void VerifyInfo()
        {
            string value = BasicClass.driver.FindElement(By.XPath("//h1[text()='How to Remove Acne Cream Stains']")).Text;
            string expected = "How to Remove Acne Cream Stains";
            if (value == expected)
            {
                Console.WriteLine("Text is Present");
            }
            else
            {
                Console.WriteLine("Text is Not Present");
            }
            ((ITakesScreenshot)BasicClass.driver).GetScreenshot().SaveAsFile
                (@"E:\TideWebPage\TideWebPage\ScreenShorts\HowToWashCloths.png");

        }
    }
}
