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

        }
    }
}
