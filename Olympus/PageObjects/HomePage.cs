using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RealProject.Pom_Repository
{
    class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[@id='employeeLink']")]
        private IWebElement people;
        [FindsBy(How = How.XPath, Using = "//a[@id='companyLink']")]
        private IWebElement company;
        [FindsBy(How = How.XPath, Using = "//a[@id='usersLink']")]
        private IWebElement user;
        [FindsBy(How = How.XPath, Using = "//a[@id='projectsLink']")]
        private IWebElement projects ;

        public IWebElement People { get => people; set => people = value; }
        public IWebElement Company { get => company; set => company = value; }
        public IWebElement User { get => user; set => user = value; }
        public IWebElement Projects { get => projects; set => projects = value; }
    }
}
