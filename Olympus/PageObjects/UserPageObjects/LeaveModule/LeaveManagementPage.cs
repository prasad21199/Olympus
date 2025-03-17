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
        [FindsBy(How = How.XPath, Using = "//label[text()='Leave Start Date']/..//i")]
        private IWebElement leaveStratDate;
        [FindsBy(How = How.XPath, Using = "//label[text()='Leave End Date']/..//i")]
        private IWebElement leaveEndDate;
        [FindsBy(How = How.XPath, Using = "//div[@class='datepicker-years']//span")]
        private IReadOnlyCollection<IWebElement> yearsPick;
        [FindsBy(How = How.XPath, Using = "//div[@class='datepicker-months']//span")]
        private IReadOnlyCollection<IWebElement> monthPick;
        [FindsBy(How = How.XPath, Using = "//div[@class='datepicker-days']//td")]
        private IReadOnlyCollection<IWebElement> dayPick;

        public IWebElement LeaveStratDate { get => leaveStratDate; set => leaveStratDate = value; }
        public IWebElement ApplyLeaveBtn { get => applyLeaveBtn; set => applyLeaveBtn = value; }
        public IWebElement LeaveTypeDrpDwn { get => leaveTypeDrpDwn; set => leaveTypeDrpDwn = value; }
        public IWebElement LeaveEndDate { get => leaveEndDate; set => leaveEndDate = value; }
        public IReadOnlyCollection<IWebElement> YearsPick { get => yearsPick; set => yearsPick = value; }
        public IReadOnlyCollection<IWebElement> MonthPick { get => monthPick; set => monthPick = value; }
        public IReadOnlyCollection<IWebElement> DayPick { get => dayPick; set => dayPick = value; }

        public void StartDate(string year , string month , string day)
        {
            leaveStratDate.Click();
            foreach(WebElement year_ in yearsPick)
            {
                if(year_.Equals(year))
                {
                    year_.Click();
                    break;
                }
            }
            foreach(WebElement month_ in monthPick)
            {
                if(month_.Equals(month))
                {
                    month_.Click();
                    break;
                }
            }
            foreach(WebElement day_ in dayPick)
            {
                if(day_.Equals(month))
                {
                    day_.Click();
                    break;
                }
            }

        }
    }
}
