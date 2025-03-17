using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RealProject.Pom_Repository
{
    class PeopleManage
    {
        public PeopleManage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//span[text()='Add a New Employee']")]
        private IWebElement newemployees;

        public IWebElement Newemployees { get => newemployees; set => newemployees = value; }
    }
}
