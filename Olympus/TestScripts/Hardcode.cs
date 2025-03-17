using IceHRM.GenericUtils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Olympus.TestScripts
{
    public class Hardcode
    {

        public void CheckProfile()
        {
            IWebDriver driver = new ChromeDriver();
            WebDriverUtils web = new WebDriverUtils();
            web.MaximizeWindow(driver);
            web.ImplicitWait(driver, IPathConstant.IMPLICIT_WAIT);
            driver.Url = "https://icehrmpro.gamonoid.com/login.php?logout=1";
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("admin" + Keys.Enter);
            driver.FindElement(By.XPath("//a[@id='employeeLink']")).Click();
            driver.FindElement(By.XPath("//span[text()='Add a New Employee']")).Click();
            By nation = By.XPath("//div[@class='ant-select-selector']//input[@id='rc_select_3']");
            web.SetScrollToElement(driver, driver.FindElement(nation));

            Thread.Sleep(1000);
            driver.FindElement(nation).Click();
            Thread.Sleep(1000);
            driver.FindElement(nation).SendKeys("Other" + Keys.Enter);
            Thread.Sleep(1000);
        }
    }
}
