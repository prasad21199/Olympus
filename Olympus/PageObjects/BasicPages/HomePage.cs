using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Olympus.PageObjects.BasicPages
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
        [FindsBy(How = How.XPath, Using = "//span[text()='IceHrm ']")]
        private IWebElement logOutBtn ;
        [FindsBy(How = How.XPath, Using = "//a[text()='Sign out']")]
        private IWebElement signOutBtn ;
        

        public IWebElement People { get => people; set => people = value; }
        public IWebElement Company { get => company; set => company = value; }
        public IWebElement User { get => user; set => user = value; }
        public IWebElement Projects { get => projects; set => projects = value; }
        public IWebElement LogOutBtn { get => logOutBtn; set => logOutBtn = value; }
        public IWebElement SignOutBtn { get => signOutBtn; set => signOutBtn = value; }
        public void LogoutApp()
        {
            logOutBtn.Click();
            signOutBtn.Click();
        }
    }
}
