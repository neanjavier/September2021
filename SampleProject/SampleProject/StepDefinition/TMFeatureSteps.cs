using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SampleProject.Pages;
using SampleProject.Utilities;
using TechTalk.SpecFlow;

namespace SampleProject.StepDefinition
{
    [Binding]
    public class TMFeatureSteps : CommonDriver
    {
        [Given(@"I have logged into turnup portal successfully")]
        public void GivenIHaveLoggedIntoTurnupPortalSuccessfully()
        {
            // open chrome browser
            driver = new ChromeDriver();

            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [Given(@"I have navigated to the time and material page")]
        public void GivenIHaveNavigatedToTheTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            HomePage homePageoObj = new HomePage();
            homePageoObj.GoToTimeandMaterial(driver);
        }

        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            // TM page object initialization and definition
            TimeandMaterial timeAndMaterialObj = new TimeandMaterial();
            timeAndMaterialObj.CreateTM(driver);
        }

        [Then(@"the result should be created successfully")]
        public void ThenTheResultShouldBeCreatedSuccessfully()
        {
            TimeandMaterial timeAndMaterialObj = new TimeandMaterial();

            string newCode = timeAndMaterialObj.GetCode(driver);
            string newTypeCode = timeAndMaterialObj.GetTypeCode(driver);
            string newDescription = timeAndMaterialObj.GetDescription(driver);
            string newPrice = timeAndMaterialObj.GetPrice(driver);

            Assert.That(newCode == "testNean1", "Actual code and expected code do not match");
            Assert.That(newTypeCode == "T", "Actual code and expected code do not match");
            Assert.That(newDescription == "test", "Actual code and expected code do not match");
            Assert.That(newPrice == "$15.00", "Actual code and expected code do not match");
        }

        [When(@"I update '(.*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string Code)
        {
            // TM page object initialization and definition
            TimeandMaterial timeAndMaterialObj = new TimeandMaterial();
            timeAndMaterialObj.EditTM(driver, Code);
        }

        [Then(@"the result should have the updated '(.*)'")]
        public void ThenTheResultShouldHaveTheUpdated(string Code)
        {
            TimeandMaterial timeandMaterialObj = new TimeandMaterial();

            string updatedCode = timeandMaterialObj.GetUpdatedCode(driver);
            string updatedTypeCode = timeandMaterialObj.GetUpdatedTypeCode(driver);
            string updatedDescription = timeandMaterialObj.GetUpdatedDescription(driver);
            string updatedPrice = timeandMaterialObj.GetUpdatedPrice(driver);

            Assert.That(updatedCode == Code, "Code do not match");
            Assert.That(updatedTypeCode == "T", "TypeCode do not match");
            Assert.That(updatedDescription == "test", "Description do not match");
            Assert.That(updatedPrice == "test", "Price do not match");

        }

    }
}