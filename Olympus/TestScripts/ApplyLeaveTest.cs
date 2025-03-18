using IceHRM.GenericUtils;
using Olympus.PageObjects.UserPageObjects.LeaveModule;

namespace Olympus.TestScripts
{
    public class Leave : BaseClass
    {
        //[Test]
        public void ApplyLeave()
        {
            hp.LeaveMajorTab.Click();
            hp.LeaveMangementLink.Click();
            LeaveManagementPage leave = new LeaveManagementPage(driver);
            leave.ApplyLeaveBtn.Click();
            //leave.LeaveTypeDrpDwn.Click();
            //    web.SetSelectByText(leave.LeaveTypeDrpDwn, excel.GetExcelData("user", 1, 2));
            leave.StartDate("2026", "Jun", "12");
            leave.LeaveEndDate.SendKeys("2025-04-01");
            leave.ReasonTeaxArea.SendKeys("I need to take rest..");
            leave.ContinueBtn.Click();
        }
    }
}
