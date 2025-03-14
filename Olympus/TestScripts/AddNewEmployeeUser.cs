using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceHRM.GenericUtils;
using Olympus.PageObjects.BasicPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RealProject.Pom_Repository;

namespace RealProject.TestScript
{
    public class CreateNewEmployeeUser : BaseClass
    {

        LoginPage loginpage;
        HomePage homepage;
        AddNewEmployee newuser;
        PeopleManage peoplemanage;
        [Test]
        public void AddNewUser()
        {
            homepage = new HomePage(driver);
            homepage.People.Click();
            peoplemanage = new PeopleManage(driver);
            peoplemanage.Newemployees.Click();
            newuser = new AddNewEmployee(driver);
            newuser.Employeenumber.SendKeys(excel.GetExcelData("sheet1", 2, 1));
            newuser.Firstname.SendKeys(excel.GetExcelData("sheet1", 2, 2));
            newuser.Lastname.SendKeys(excel.GetExcelData("sheet1", 2, 4));
            //string nationality = excel.GetExcelData("sheet1", 2, 5);
            newuser.Nationality.SendKeys("American" + Keys.Enter);
            Thread.Sleep(10000);
           

        }

    }
}
