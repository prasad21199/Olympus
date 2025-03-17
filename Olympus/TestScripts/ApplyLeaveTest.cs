using IceHRM.GenericUtils;
using Olympus.PageObjects.UserPageObjects.LeaveModule;

namespace Olympus.TestScripts
{
    public class Leave : BaseClass
    {
        [Test]
        public void ApplyLeave()
        {
            hp.LeaveMajorTab.Click();
            hp.LeaveMangementLink.Click();
            LeaveManagementPage leave = new LeaveManagementPage(driver);
            web.SetSelectByIndex(leave.LeaveTypeDrpDwn, 0);
            leave.StartDate("2025", "Apr", "12");
            leave.LeaveEndDate.SendKeys("2025-04-01");
            leave.ReasonTeaxArea.SendKeys("I need to take rest..");
            leave.ContinueBtn.Click();
        }
    }
}
