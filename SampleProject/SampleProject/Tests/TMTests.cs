using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleProject.Pages;
using SampleProject.Utilities;

namespace SampleProject
{
    [TestFixture]
    [Parallelizable]
    class TMTests : CommonDriver
    {

        [Test, Order (1), Description("Check if user is able to create Time record with valid data")]
        public void CreateTMTest()
        {

            // Home page object initialization and definition
            HomePage homePageoObj = new HomePage();
            homePageoObj.GoToTimeandMaterial(driver);


            // TM page object initialization and definition
            TimeandMaterial timeAndMaterialObj = new TimeandMaterial();
            timeAndMaterialObj.CreateTM(driver);
        }

        [Test, Order (2), Description("Check if user is able to edit Time record with valid data")]
        public void EditTMTest(string Code, string TypeCode)
        {

            // Home page object initialization and definition
            HomePage homePageoObj = new HomePage();
            homePageoObj.GoToTimeandMaterial(driver);

            // Edit time
            TimeandMaterial timeAndMaterialObj = new TimeandMaterial();
            timeAndMaterialObj.EditTM(driver, Code, TypeCode);
        }

        [Test, Order (3), Description("Check if user is able to delete Material record with valid data")]
        public void DeleteTMTest()
        {
            // Home page object initialization and definition
            HomePage homePageoObj = new HomePage();
            homePageoObj.GoToTimeandMaterial(driver);

            // Delete time
            TimeandMaterial timeAndMaterialObj = new TimeandMaterial();
            timeAndMaterialObj.DeleteTM(driver);
        }

    }
}
