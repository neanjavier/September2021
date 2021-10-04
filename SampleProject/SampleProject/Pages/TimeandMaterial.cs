using System;
using System.Threading;
using OpenQA.Selenium;

namespace SampleProject.Pages
{
    class TimeandMaterial
    {
        public void CreateTM(IWebDriver driver)
        {
            // click Create New button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // select Time in TypeCode dropdown
            IWebElement typeCodedropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typeCodedropdown.Click();
            Thread.Sleep(2000);

            // select TypeCode Time
            IWebElement typecodeTime = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            typecodeTime.Click();

            // identify Code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("testNean1");

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

            // Assert Time record
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
        public void EditTM(IWebDriver driver)
        {
            // Click on the Edit Button
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(3000);

            // select Time in TypeCode dropdown
            IWebElement typeCodedropdown1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typeCodedropdown1.Click();
            Thread.Sleep(2000);

            // select TypeCode Time
            IWebElement typecodeTime1 = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            typecodeTime1.Click();

            // identify Code
            IWebElement codeTextbox1 = driver.FindElement(By.Id("Code"));
            codeTextbox1.SendKeys("testNean1");

            // identify Description
            IWebElement descriptionTextbox1 = driver.FindElement(By.XPath("//*[@id='Description']"));
            descriptionTextbox1.SendKeys("editedDescription");

            // click Price per unit textbox
            IWebElement pricePerUnitTextbox1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnitTextbox1.Click();

            // identify Price per unit
            IWebElement pricePerUnitValue1 = driver.FindElement(By.Id("Price"));
            pricePerUnitValue1.SendKeys("15");

            // click Save
            IWebElement saveButton1 = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            saveButton1.Click();
            Thread.Sleep(3000);

            // Assert Time record
            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton1.Click();

            // Check the record
            IWebElement lastRecord1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastRecord1.Text == "testNean1")
            {
                Console.WriteLine("Record created successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Test Failed!");
            }
        }
        public void DeleteTM(IWebDriver driver)
        {
            // Click on the Delete Button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(3000);

            driver.SwitchTo().Alert().Accept();

            // Assert that time record has been deleted
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            // Check last record
            IWebElement lastRecord2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastRecord2.Text == "")
            {
                Console.WriteLine("Deleted successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }
        }

    }
}
