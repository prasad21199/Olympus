using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympus.PageObjects.UserPageObjects.LeaveModule
{
    public class LeaveManagementPage
    {
        public LeaveManagementPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[text()='Apply Leave ']")]
        private IWebElement applyLeaveBtn;
        [FindsBy(How = How.XPath, Using = "//select[@id='leave_type']")]
        private IWebElement leaveTypeDrpDwn;
        [FindsBy(How = How.XPath, Using = "//input[@id='date_start']")]
        private IWebElement leaveStratDate;

        public IWebElement LeaveStratDate { get => leaveStratDate; set => leaveStratDate = value; }
    }
}
