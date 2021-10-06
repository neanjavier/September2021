using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleProject.Utilities;

namespace SampleProject.Pages
{
    class LoginPage
    {
    public void LoginActions(IWebDriver driver)
        { 
            // launch turn up portal and maximize window
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Wait.WaitForElementToExist(driver, "Id", "UserName", 2);

            try
            {
                // idetify the username textbox enter valid username
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");

                // identify password textbox enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
                passwordTextbox.SendKeys("123123");

                // identify login button and click
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id='loginForm']/form/div[3]/input[1]", 2);
                loginButton.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("Turn Up Page did not launch", ex.Message);
            }

        }
    }
}
