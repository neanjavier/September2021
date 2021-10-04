using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleProject.Pages;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
{
            // open chrome browser
            IWebDriver driver = new ChromeDriver();

            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            // Home page object initialization and definition
            HomePage homePageoObj = new HomePage();
            homePageoObj.GoToTimeandMaterial(driver);

            // TM page object initialization and definition
            TimeandMaterial timeAndMaterialObj = new TimeandMaterial();
            timeAndMaterialObj.CreateTM(driver);

            // Edit time
            timeAndMaterialObj.EditTM(driver);

            // Delete time
            timeAndMaterialObj.DeleteTM(driver);

        }

    }
}
