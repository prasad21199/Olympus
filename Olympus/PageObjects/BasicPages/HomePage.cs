using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Olympus.PageObjects.BasicPages
{
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        //admin
        [FindsBy(How = How.XPath, Using = "//a[@id='employeeLink']")]
        private IWebElement people;
        [FindsBy(How = How.XPath, Using = "//a[@id='companyLink']")]
        private IWebElement company;
        [FindsBy(How = How.XPath, Using = "//a[@id='usersLink']")]
        private IWebElement user;
        [FindsBy(How = How.XPath, Using = "//a[@id='projectsLink']")]
        private IWebElement projects;
        [FindsBy(How = How.XPath, Using = "//span[text()='IceHrm ']")]
        private IWebElement logOutBtn;
        [FindsBy(How = How.XPath, Using = "//a[text()='Sign out']")]
        private IWebElement signOutBtn;


        //user 
        [FindsBy(How = How.XPath, Using = "//span[text()='Leave']")]
        private IWebElement leaveMajorTab;
        [FindsBy(How = How.XPath, Using = "//a/i[@class='fa fa-share-alt']")]
        private IWebElement leaveMangementLink;

        public IWebElement DynamicTextXpath(string text)
        {
            return driver.FindElement(By.XPath("//span[text()='" + text + "']"));
        }

        public IWebElement People { get => people; set => people = value; }
        public IWebElement Company { get => company; set => company = value; }
        public IWebElement User { get => user; set => user = value; }
        public IWebElement Projects { get => projects; set => projects = value; }
        public IWebElement LogOutBtn { get => logOutBtn; set => logOutBtn = value; }
        public IWebElement SignOutBtn { get => signOutBtn; set => signOutBtn = value; }
        public IWebElement LeaveMajorTab { get => leaveMajorTab; set => leaveMajorTab = value; }
        public IWebElement LeaveMangementLink { get => leaveMangementLink; set => leaveMangementLink = value; }

        public void adminLogoutApp()
        {
            logOutBtn.Click();
            signOutBtn.Click();
        }
        public void userLogoutApp(string text)
        {
            driver.FindElement(By.XPath("//span[text()='" + text + "']")).Click();
            signOutBtn.Click();
        }
    }
}
