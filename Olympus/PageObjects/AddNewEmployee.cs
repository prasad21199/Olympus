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
        private IWebElement emplNoTf;
        [FindsBy(How = How.XPath, Using = "//input[@id='first_name']")]
        private IWebElement fnTf;
        [FindsBy(How = How.XPath, Using = "//input[@id='middle_name']")]
        private IWebElement mnTf;
        [FindsBy(How = How.XPath, Using = "//input[@id='last_name']")]
        private IWebElement lnTf;
        [FindsBy(How = How.XPath, Using = "//div[@class='ant-select-selector']//input[@id='rc_select_1']")]
        private IWebElement nationalityDrp;
        [FindsBy(How = How.XPath, Using = "//input[@id='birthday']")]
        private IWebElement bdayCalender;
        [FindsBy(How = How.XPath, Using = "//input[@id='rc_select_2']")]
        private IWebElement genderDrp;
        [FindsBy(How = How.XPath, Using = "//input[@id='rc_select_3']")]
        private IWebElement martailstatusDrp;
        [FindsBy(How = How.XPath, Using = "//span[text()='Full Time Internship']")]
        private IWebElement employmentstatusDrp;
        [FindsBy(How = How.XPath, Using = "//div[text()='QA Team']")]
        private IWebElement departmentDrp;
        [FindsBy(How = How.XPath, Using = "//div[text()='Assistant QA Engineer ']")]
        private IWebElement jobtitleDrp;
        [FindsBy(How = How.XPath, Using = "//input[@id='joined_date']")]
        private IWebElement joineddateCalender;
        [FindsBy(How = How.XPath, Using = "//div[@title='(GMT 00:00) Africa/Dakar']")]
        private IWebElement timezoneDrp;
        [FindsBy(How = How.XPath, Using = "//div[@title='India']")]
        private IWebElement countryDrp;
        [FindsBy(How = How.XPath, Using = "//input[@id='rc_select_5']")]
        private IWebElement immigrationstatus;
        [FindsBy(How = How.XPath, Using = "//input[@id='tax_id']")]
        private IWebElement personaltax;
        [FindsBy(How = How.XPath, Using = "//input[@id='ssn_num']")]
        private IWebElement socialinsurance;
        [FindsBy(How = How.XPath, Using = "//input[@id='nic_num']")]
        private IWebElement national_id;
        [FindsBy(How = How.XPath, Using = "//span[text()='Next']")]
        private IWebElement next;
        [FindsBy(How = How.XPath, Using = "//span[text()='Save']")]
        private IWebElement save;


        public IWebElement Employeenumber { get => Employeenumber; set => Employeenumber = value; }
        public IWebElement Firstname { get => Firstname; set => Firstname = value; }
        public IWebElement Middlename { get => Employeenumber; set => Employeenumber = value; }
        public IWebElement Lastname { get => Employeenumber; set => Employeenumber = value; }
        public IWebElement Nationality { get => Employeenumber; set => Employeenumber = value; }
        public IWebElement Birthday { get => Employeenumber; set => Employeenumber = value; }
        public IWebElement Gender { get => Employeenumber; set => Employeenumber = value; }
        public IWebElement Martailstatus { get => Employeenumber; set => Employeenumber = value; }
        public IWebElement Employmentstatus { get => Employeenumber; set => Employeenumber = value; }
        public IWebElement Department { get => Employeenumber; set => Employeenumber = value; }
        public IWebElement Jobtitle { get => Employeenumber; set => Employeenumber = value; }
        public IWebElement Joineddate { get => Employeenumber; set => Employeenumber = value; }
        public IWebElement Timezone { get => Employeenumber; set => Employeenumber = value; }
        public IWebElement Immigrationstatus { get => immigrationstatus; set => immigrationstatus = value; }
        public IWebElement Socialinsurance { get => socialinsurance; set => socialinsurance = value; }
        public IWebElement Nationalid { get => national_id; set => national_id = value; }
        public IWebElement Next { get => next; set => next = value; }
        public IWebElement Save { get => save; set => save = value; }
        public IWebElement Personaltax { get => personaltax; set => personaltax = value; }
    }

}
