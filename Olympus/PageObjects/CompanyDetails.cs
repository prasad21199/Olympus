using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RealProject.Pom_Repository
{
    class CompanyDetails
    {
        public CompanyDetails(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//span[text()=' Add New']")]
        private IWebElement addnewcompany;
        [FindsBy(How = How.XPath, Using = "//input[@id='title']")]
        private IWebElement name;
        [FindsBy(How = How.XPath, Using = "//textarea[@id='description']")]
        private IWebElement description;
        [FindsBy(How = How.XPath, Using = "//span[text()='Regional Office']")]
        private IWebElement type;
        [FindsBy(How = How.XPath, Using = "//span[@title='India']")]
        private IWebElement country;
        [FindsBy(How = How.XPath, Using = "//span[@title='(GMT+06:00) Indian/Chagos']")]
        private IWebElement timezone;

        public IWebElement Addnewcompany { get => addnewcompany; set => addnewcompany = value; }
        public IWebElement Name { get => name; set => name = value; }
        public IWebElement Description { get => description; set => description = value; }
        public IWebElement Type { get => type; set => type = value; }
        public IWebElement Country { get => country; set => country = value; }
        public IWebElement Timezone { get => timezone; set => timezone = value; }
    }
}
