using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SampleProject.Pages;
using SampleProject.Utilities;

namespace SampleProject.Tests
{
    [TestFixture]
    [Parallelizable]
    class EmployeeTests : CommonDriver
    {

        [Test, Order(1), Description("Check if user is able to create Employee record with valid data")]
        public void CreateEmployeeTest()
        {
            // Employee page object initialization and definition
            EmployeesPage employeePageobj = new EmployeesPage();
            employeePageobj.CreateEmployee(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit Employee record with valid data")]
        public void EditEmployeeTest()
        {
            // Edit employee
            EmployeesPage employeePageobj = new EmployeesPage();
            employeePageobj.EditEmployee(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete Employee record with valid data")]
        public void DeleteEmployeeTest()
        {
            // Delete employee
            EmployeesPage employeePageobj = new EmployeesPage();
            employeePageobj.DeleteEmployee(driver);
        }

    }
}
