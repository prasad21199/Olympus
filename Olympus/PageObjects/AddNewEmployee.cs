using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RealProject.Pom_Repository
{
    class AddNewEmployee
    {
        public AddNewEmployee(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input[@id='employee_id']")]
        private IWebElement employeenumber;
        [FindsBy(How = How.XPath, Using = "//input[@id='first_name']")]
             private IWebElement firstname;
        [FindsBy(How = How.XPath, Using = "//input[@id='middle_name']")]
        private IWebElement middlename;
        [FindsBy(How = How.XPath, Using = "//input[@id='last_name']")]
        private IWebElement lastname;
        [FindsBy(How = How.XPath, Using = "//input[@id='rc_select_1']")]
        private IWebElement nationality;
        [FindsBy(How = How.XPath, Using = "//input[@id='birthday']")]
        private IWebElement birthday;
        [FindsBy(How = How.XPath, Using = "//input[@id='rc_select_2']")]
        private IWebElement gender;
        [FindsBy(How = How.XPath, Using = "//input[@id='rc_select_3']")]
             private IWebElement martailstatus;
        [FindsBy(How = How.XPath, Using = "//span[text()='Full Time Internship']")]
        private IWebElement employmentstatus;
        [FindsBy(How = How.XPath, Using = "//div[text()='QA Team']")]
        private IWebElement department;
        [FindsBy(How = How.XPath, Using = "//div[text()='Assistant QA Engineer ']")]
        private IWebElement jobtitle;
        [FindsBy(How = How.XPath, Using = "//input[@id='joined_date']")]
        private IWebElement joineddate;
        [FindsBy(How = How.XPath, Using = "//div[@title='(GMT 00:00) Africa/Dakar']")]
        private IWebElement timezone;
        [FindsBy(How = How.XPath, Using = "//div[@title='India']")]
        private IWebElement country;
        [FindsBy(How = How.XPath, Using = "//input[@id='rc_select_5']")]
        private IWebElement immigrationstatus;
        [FindsBy(How = How.XPath, Using = "//input[@id='tax_id']")]
        private IWebElement personaltax;
        [FindsBy(How = How.XPath, Using = "//input[@id='ssn_num']")]
        private IWebElement socialinsurance;
        [FindsBy(How = How.XPath, Using = "//input[@id='nic_num']")]
        private IWebElement nationalid;
        [FindsBy(How = How.XPath, Using = "//span[text()='Next']")]
        private IWebElement next;
        [FindsBy(How = How.XPath, Using = "//span[text()='Save']")]
        private IWebElement save;


        public IWebElement Employeenumber { get => employeenumber; set => employeenumber = value; }
        public IWebElement Firstname { get => firstname; set => firstname = value; }
        public IWebElement Middlename { get => middlename; set => middlename = value; }
        public IWebElement Lastname { get => lastname; set => lastname = value; }
        public IWebElement Nationality { get => nationality; set => nationality = value; }
        public IWebElement Birthday { get => birthday; set => birthday = value; }
        public IWebElement Gender { get => gender; set => gender = value; }
        public IWebElement Martailstatus { get => martailstatus; set => martailstatus = value; }
        public IWebElement Employmentstatus { get => employmentstatus; set => employmentstatus = value; }
        public IWebElement Department { get => department; set => department = value; }
        public IWebElement Jobtitle { get => jobtitle; set => jobtitle = value; }
        public IWebElement Joineddate { get => joineddate; set => joineddate = value; }
        public IWebElement Timezone { get => timezone; set => timezone = value; }
        public IWebElement Immigrationstatus { get => immigrationstatus; set => immigrationstatus = value; }
        public IWebElement Personaltax { get => personaltax; set => personaltax = value; }
        public IWebElement Socialinsurance { get => socialinsurance; set => socialinsurance = value; }
        public IWebElement Nationalid { get => nationalid; set => nationalid = value; }
        public IWebElement Next { get => next; set => next = value; }
        public IWebElement Country { get => country; set => country = value; }
        public IWebElement Save { get => save; set => save = value; }
        public void selectNationality(string nationality)
        {
            Nationality.Click();


        }
    }
    
}
