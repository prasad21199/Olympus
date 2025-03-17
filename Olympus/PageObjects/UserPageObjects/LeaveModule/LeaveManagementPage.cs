using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

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
        [FindsBy(How = How.XPath, Using = "//select[@name='leave_type']")]
        private IWebElement leaveTypeDrpDwn;
        [FindsBy(How = How.XPath, Using = "//label[text()='Leave Start Date']/..//i")]
        private IWebElement leaveStratDate;
        [FindsBy(How = How.XPath, Using = "//label[text()='Leave End Date']/..//i")]
        private IWebElement leaveEndDate;
        [FindsBy(How = How.XPath, Using = "//textarea[@id='details']")]
        private IWebElement reasonTeaxArea;
        [FindsBy(How = How.XPath, Using = "Continue")]
        private IWebElement continueBtn;
        [FindsBy(How = How.XPath, Using = "//div[@class='datepicker-years']//span")]
        private IList<IWebElement> yearsPick;
        [FindsBy(How = How.XPath, Using = "//div[@class='datepicker-months']//span")]
        private IList<IWebElement> monthPick;
        [FindsBy(How = How.XPath, Using = "//div[@class='datepicker-days']//td")]
        private IList<IWebElement> dayPick;

        public IWebElement LeaveStratDate { get => leaveStratDate; set => leaveStratDate = value; }
        public IWebElement ApplyLeaveBtn { get => applyLeaveBtn; set => applyLeaveBtn = value; }
        public IWebElement LeaveEndDate { get => leaveEndDate; set => leaveEndDate = value; }
        public IList<IWebElement> YearsPick { get => yearsPick; set => yearsPick = value; }
        public IList<IWebElement> MonthPick { get => monthPick; set => monthPick = value; }
        public IList<IWebElement> DayPick { get => dayPick; set => dayPick = value; }
        public IWebElement ReasonTeaxArea { get => reasonTeaxArea; set => reasonTeaxArea = value; }
        public IWebElement ContinueBtn { get => continueBtn; set => continueBtn = value; }
        public IWebElement LeaveTypeDrpDwn { get => leaveTypeDrpDwn; set => leaveTypeDrpDwn = value; }

        public void StartDate(string year, string month, string day)
        {
            leaveStratDate.Click();
            foreach (WebElement year_ in yearsPick)
            {
                if (year_.Equals(year))
                {
                    year_.Click();
                    break;
                }
            }
            foreach (WebElement month_ in monthPick)
            {
                if (month.Equals(month_))
                {
                    month_.Click();
                    break;
                }
            }
            foreach (WebElement day_ in dayPick)
            {
                if (day.Equals(day_))
                {
                    day_.Click();
                    break;
                }
            }
        }
    }
}
