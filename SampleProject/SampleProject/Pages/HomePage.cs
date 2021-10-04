using System;
using System.Threading;
using OpenQA.Selenium;
using SampleProject.Utilities;

namespace SampleProject.Pages
{
    class HomePage
    {
        public void GoToTimeandMaterial(IWebDriver driver)
        {
            // click Administration dropdown
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();
            Wait.WaitForElementToBeClickable(driver, "Xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 3);

            // click Time & Materials
            IWebElement tmDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmDropdown.Click();
            Thread.Sleep(2000);
        }
    }
}
