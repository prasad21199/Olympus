using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RealProject.Pom_Repository
{
    class ManageUsers
    {
        public void Manageuser(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How=How.XPath,Using = "//button[@class='ant-btn css-dev-only-do-not-override-240cud ant-btn-primary ant-btn-color-primary ant-btn-variant-solid']")]
        private IWebElement addnewuser;
            [FindsBy(How = How.XPath, Using = "//input[@id='username']")]
        private IWebElement useername;
            [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        private IWebElement email;
            [FindsBy(How = How.XPath, Using = "//input[@id='rc_select_1']")]
        private IWebElement userlevel;
            [FindsBy(How = How.XPath, Using = "//span[text()='Save']")]
        private IWebElement save;

        public IWebElement Addnewuser { get => addnewuser; set => addnewuser = value; }
        public IWebElement Useername { get => useername; set => useername = value; }
        public IWebElement Email { get => email; set => email = value; }
        public IWebElement Userlevel { get => userlevel; set => userlevel = value; }
        public IWebElement Save { get => save; set => save = value; }
    }
}
