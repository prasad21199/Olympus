
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Olympus.PageObjects.BasicPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using RealProject.Pom_Repository;
using TestProject1.Json;

namespace RealProject.TestScript
{
    class LoginPageTestScript
    {
         
    LoginPage loginpage;
    HomePage homepage;
    AddNewEmployee personaldetails;
    CompanyDetails companydetails;
        ReadDataFromJson json;
        ReadTheDataFromExcel excel;

        [Test]
   public void Login()
        {
         IWebDriver   driver = new ChromeDriver();
            loginpage = new LoginPage(driver);
            json = new ReadDataFromJson();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            driver.Url =json.ReadTheDataFromJsonMethod("url"); ;
           string Email = json.ReadTheDataFromJsonMethod("username");
           string Password = json.ReadTheDataFromJsonMethod("password");
            loginpage.LoginToApp (Email, Password);
        }
    }
}
