using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olympus.PageObjects.BasicPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RealProject.GenericUtility;
using RealProject.Pom_Repository;
using TestProject1.Json;

namespace RealProject.TestScript
{
    class CreateNewEmployeeUser
    {
        
        LoginPage loginpage;
        HomePage homepage;
        AddNewEmployee newuser;
        ReadDataFromJson json;
        ReadTheDataFromExcel excel;
        PeopleManage peoplemanage;
        [Test]
        public void AddNewUser()
        {
            IWebDriver driver = new ChromeDriver();
            loginpage = new LoginPage(driver);
             
            json = new ReadDataFromJson();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            driver.Url = json.ReadTheDataFromJsonMethod("url"); ;
            string Email = json.ReadTheDataFromJsonMethod("username");
            string Password = json.ReadTheDataFromJsonMethod("password");
            loginpage.LoginToApp(Email, Password);
            homepage = new HomePage(driver);
            homepage.People.Click();
            peoplemanage=new PeopleManage(driver);
            peoplemanage.Newemployees.Click();
           newuser = new  AddNewEmployee(driver);
            excel = new ReadTheDataFromExcel();
            string EMP_NO = excel.ReadExcel("sheet1", 2, 1);
            newuser.Employeenumber.SendKeys(EMP_NO);
            string firstname = excel.ReadExcel("sheet1", 2, 2);
            newuser.Firstname.SendKeys(firstname);
            string lastname = excel.ReadExcel("sheet1", 2, 4);
            newuser.Lastname.SendKeys(lastname);
            string nationality= excel.ReadExcel("sheet1", 2, 5);
            newuser.Nationality.SendKeys(nationality);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("argument[0].scrollInToView()", newuser.Nationality);
            newuser.Nationality.Click();
            string dateofbirth = excel.ReadExcel("sheet1", 2, 6);
            newuser.Birthday.SendKeys(dateofbirth);
            string gender = excel.ReadExcel("sheet1", 2, 7);
            newuser.Gender.SendKeys(gender);
            string martialstatus = excel.ReadExcel("sheet1", 2, 8);
            newuser.Martailstatus.SendKeys(martialstatus);
            newuser.Next.Click();

        }
        
    }
}
