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
    public static class ProfileSkillsPage
    {

        private static IWebElement SkillsTab => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));

        private static IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']"));

        private static IWebElement SkillsInput => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));

        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));


        public static void UserClickOnTheSkillsTab()
        {
            SkillsTab.Click();
        }
        public static void UserClicksTheAddNewButtonAndEntersSkillsAndSkillsLevel()
        {
            AddNewButton.Click();
            Thread.Sleep(3000);

            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelFile, "Skills");

            SkillsInput.SendKeys(ExcelLibHelper.ReadData(2, "Skills"));
            SelectElement select = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name ='level']")));
            select.SelectByValue(ExcelLibHelper.ReadData(2, "SkillsLevel"));

            AddButton.Click();
        }

        public static void SkillsDetailsAddedShouldNowBeSaved()
        {
            Thread.Sleep(3000);
            string skills = Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td[1]")).Text;
            Assert.AreEqual(ExcelLibHelper.ReadData(2, "Skills"), skills);
        }

        public static void UserEditsTheirSkillsDetailsAndClicksUpdate()
        {
            Thread.Sleep(3000);

            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelFile, "Skills");

            Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td[3]/span[1]/i")).Click();

            IWebElement skillsInput = Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td/div/div[1]/input"));
            skillsInput.Clear();
            skillsInput.SendKeys(ExcelLibHelper.ReadData(3, "Skills"));

            var skillsLevel = Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td/div/div[2]/select"));
            var selectElement = new SelectElement(skillsLevel);
            selectElement.SelectByValue(ExcelLibHelper.ReadData(3, "SkillsLevel"));

            Thread.Sleep(3000);
            Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td/div/span/input[1]")).Click();

        }

        public static void SkillsDetailsUpdatedShouldBeSaved()
        {
            Thread.Sleep(3000);
            string skills = Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td[1]")).Text;
            Assert.AreEqual(ExcelLibHelper.ReadData(3, "Skills"), skills);
        }

        public static void UserRemovesTheirSkills()
        {
            Thread.Sleep(3000);
            Driver.driver.FindElement(By.XPath("//div/table/tbody[1]/tr/td[3]/span[2]/i")).Click();
        }

        public static void SkillsShouldBeDeleted()
        {
            Thread.Sleep(3000);
            IList<IWebElement> skillsTable = Driver.driver.FindElements(By.XPath("//form/div[2]/div/div[2]/div/table/tbody/tr"));
            var rows = skillsTable.Count;
            Assert.AreEqual(0, rows);
        }
    }
}