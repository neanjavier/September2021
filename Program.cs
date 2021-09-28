using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
{
            // open chrome browser
            IWebDriver driver = new ChromeDriver();

            // launch turn up portal and maximize window
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // idetify the username textbox enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // identify password textbox enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // identify login button and click
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);

            // check if user has logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
             {
              Console.WriteLine("Logged in successfully, test passed.");
             }
             else
             {
              Console.WriteLine("Login failed, test failed.");
              }
            //        {
            //            Console.ReadLine();
            //        }

            // click Administration dropdown
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();
            Thread.Sleep(2000);

            // click Time & Materials
            IWebElement tmDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmDropdown.Click();
            Thread.Sleep(2000);

            // click Create New button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // select Material in TypeCode dropdown
            IWebElement typeCodedropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typeCodedropdown.Click();
            Thread.Sleep(2000);

            // select TypeCode Material
            IWebElement typecodeMaterial = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
            typecodeMaterial.Click();

            // identify Code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("testNean");

            // identify Description
            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//*[@id='Description']"));
            descriptionTextbox.SendKeys("test");

            // click Price per unit textbox
            IWebElement pricePerUnitTextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnitTextbox.Click();

            // identify Price per unit
            IWebElement pricePerUnitValue = driver.FindElement(By.Id("Price"));
            pricePerUnitValue.SendKeys("15");

            // click Save
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            saveButton.Click();
            Thread.Sleep(3000);

            // Assert Material record
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            // Check the record
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastRecord.Text == "testNean")
            {
                Console.WriteLine("Record created successfully, test passed.");
                    }
            else
            {
                Console.WriteLine("Test Failed!");
                    }
           

        }

    }
}
