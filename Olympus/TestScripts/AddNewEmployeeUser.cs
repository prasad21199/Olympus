using IceHRM.GenericUtils;
using Olympus.PageObjects.BasicPages;
using RealProject.Pom_Repository;

namespace RealProject.TestScript
{
    public class CreateNewEmployeeUser : BaseClass
    {

        LoginPage loginpage;
        HomePage homepage;
        AddNewEmployee newuser;
        PeopleManage peoplemanage;

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
            Console.WriteLine("Add new User");

        }

    }
}
