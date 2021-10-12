using System;
using System.Threading;
using NUnit.Framework;
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


            // if (lastRecord.Text == "testNean")
            // {
            //    Console.WriteLine("Record created successfully, test passed.");
            // }
            // else
            // {
            //    Console.WriteLine("Test Failed!");
            // }
        }


        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }

        public string GetTypeCode(IWebDriver driver)
        {
            IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return newTypeCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

        public void EditTM(IWebDriver driver, string Code)
        {
            // Go to last page
            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton1.Click();

            // Check the record
            IWebElement lastRecord1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastRecord1.Text == Code)
            {
                // Click on the Edit Button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
                Thread.Sleep(3000);

                // Click on TypeCode dropdown
                IWebElement typeCodedropdown1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
                typeCodedropdown1.Click();
                Thread.Sleep(2000);

                // select TypeCode Material
                IWebElement typecodeMaterial = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
                typecodeMaterial.Click();

                // identify Code
                IWebElement codeTextbox1 = driver.FindElement(By.Id("Code"));
                codeTextbox1.Clear();
                codeTextbox1.SendKeys(Code);

                // identify Description
                IWebElement descriptionTextbox1 = driver.FindElement(By.XPath("//*[@id='Description']"));
                descriptionTextbox1.Clear();
                descriptionTextbox1.SendKeys("test");

                // click Price per unit textbox
                IWebElement pricePerUnitTextbox1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
                pricePerUnitTextbox1.Click();

                // identify Price per unit
                IWebElement pricePerUnitValue1 = driver.FindElement(By.Id("Price"));
                pricePerUnitValue1.Clear();
                Thread.Sleep(3000);

                pricePerUnitTextbox1.Click();
                Thread.Sleep(1000);

                pricePerUnitValue1.SendKeys("15.00");
                Thread.Sleep(1000);

                // click Save
                IWebElement saveButton1 = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
                saveButton1.Click();
                Thread.Sleep(3000);

                // Assert to last page
                IWebElement goToLastPageButton11 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                goToLastPageButton11.Click();


            }

            //else
            //{
            //   Assert.Fail("The record to be edited hasn't been found. Record is not edited.");
            //{
          
        }

        public string GetUpdatedCode(IWebDriver driver)
        {
            IWebElement updatedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return updatedCode.Text;
        }

        public string GetUpdatedTypeCode(IWebDriver driver)
        {
            IWebElement updatedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return updatedTypeCode.Text;
        }

        public string GetUpdatedDescription(IWebDriver driver)
        {
            IWebElement updatedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return updatedDescription.Text;
        }

        public string GetUpdatedPrice(IWebDriver driver)
        {
            IWebElement updatedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return updatedPrice.Text;
        }
        public void DeleteTM(IWebDriver driver)
        {

            // Go to the last page where edited record
            IWebElement goToLastPageButton2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton2.Click();

            // Check last record
            IWebElement lastRecord2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastRecord2.Text == "testNean_Updated")
            {
                // Click on the Delete Button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(3000);

                driver.SwitchTo().Alert().Accept();

                // Assert the record has been deleted
                IWebElement goToLastPageButton22 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                goToLastPageButton22.Click();
                Thread.Sleep(2000);

                IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement editedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
                IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

                // Assertion
                Assert.That(editedCode.Text != "testNean_Updated", "Code record hasn't been deleted.");
                Assert.That(editedTypeCode.Text != "M", "TypeCode record hasn't been deleted.");
                Assert.That(editedDescription.Text != "editedDescription", "Description record hasn't been deleted.");
                Assert.That(editedPrice.Text != "$30.00", "Price record hasn't been deleted.");

            }
            else
            {
                Assert.Fail("The record to be deleted hasn't been found. Record has not been deleted.");
            }

        }

    }
}
