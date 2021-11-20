using DnsClient.Protocol;
using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MarsQA_1.Pages
{
    public static class ProfileLanguagePage
    {

        private static IWebElement LanguageTab => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div//form//a[.='Languages']"));

        private static IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div//form/div[2]//table//div[.='Add New']"));

        private static IWebElement LanguageInput => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));

        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/section[2]/div/div//form/div[2]//input[@value='Add']"));


        public static void UserClickOnTheLanguageTab()
        {
            LanguageTab.Click();
        }
        public static void UserClicksTheAddNewButtonAndEntersLanguageAndLanguageLevel()
        {
            AddNewButton.Click();
            Thread.Sleep(3000);

            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelFile, "Language");

            LanguageInput.SendKeys(ExcelLibHelper.ReadData(2, "Language"));
            SelectElement select = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name ='level']")));
            select.SelectByValue(ExcelLibHelper.ReadData(2, "LanguageLevel"));

            AddButton.Click();
        }

        public static void LanguageDetailsAddedShouldNowBeSaved()
        {
            Thread.Sleep(3000);
            string language = Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td[1]")).Text;
            Assert.AreEqual(ExcelLibHelper.ReadData(2, "Language"), language);
        }

        public static void UserEditsTheirLanguageDetailsAndClicksUpdate()
        {
            Thread.Sleep(3000);

            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelFile, "Language");

            Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td[3]/span[1]/i")).Click();

            IWebElement languageInput = Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td/div/div[1]/input"));
            languageInput.Clear();
            languageInput.SendKeys(ExcelLibHelper.ReadData(3, "Language"));

            var languageLevel = Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td/div/div[2]/select"));
            var selectElement = new SelectElement(languageLevel);
            selectElement.SelectByValue(ExcelLibHelper.ReadData(3, "LanguageLevel"));

            Thread.Sleep(3000);
            Driver.driver.FindElement(By.XPath("//form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]")).Click();

        }

        public static void LanguageDetailsUpdatedShouldBeSaved()
        {
            Thread.Sleep(3000);
            string language = Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td[1]")).Text;
            Assert.AreEqual(ExcelLibHelper.ReadData(3, "Language"), language);
        }

        public static void UserRemovesTheirLanguage()
        {
            Thread.Sleep(3000);
            Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td[3]/span[2]/i")).Click();
        }

        public static void LanguageShouldBeDeleted()
        {
            Thread.Sleep(3000);
            IList<IWebElement> languageTable = Driver.driver.FindElements(By.XPath("//form/div[2]/div/div[2]/div/table/tbody/tr"));
            var rows = languageTable.Count;
            Assert.AreEqual(0, rows);
        }
    }
}