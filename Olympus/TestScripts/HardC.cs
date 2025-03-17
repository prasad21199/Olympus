using IceHRM.GenericUtils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;

namespace Olympus.TestScripts
{
   public class HardC
    {
        [Test]
        public void TestCheck()
        {
            WebDriverUtils web = new WebDriverUtils();
            IWebDriver driver = new ChromeDriver();
            web.MaximizeWindow(driver);
            web.ImplicitWait(driver, 10);
            driver.Url = "https://icehrmpro.gamonoid.com/login.php?logout=1";
            driver.FindElement(By.Id("username")).SendKeys("user1");
            driver.FindElement(By.Id("password")).SendKeys("demouserpwd" + Keys.Enter);
            driver.FindElement(By.XPath("//span[text()='Leave']")).Click();
            driver.FindElement(By.XPath("//a/i[@class='fa fa-share-alt']")).Click();
            driver.FindElement(By.XPath("//button[text()='Apply Leave ']")).Click();
            //IWebElement lt = driver.FindElement(By.XPath("//select[@id='leave_type']"));
            //lt.Click();
            //SelectElement se = new SelectElement(lt);
            //se.DeselectByIndex(1);
            driver.FindElement(By.XPath("//div[@id='date_start_date']/span")).Click();
            driver.FindElement(By.XPath("//input[@id='date_start']")).SendKeys("2025-04-12");
            driver.FindElement(By.XPath("//input[@id='date_end']")).SendKeys("2025-04-14"+Keys.Enter);
            driver.FindElement(By.XPath("//textarea[@id='details']")).SendKeys("marriage...");
            //driver.FindElement(By.XPath("//button[text()='Continue']")).Click(); 
            //driver.FindElement(By.XPath("//div[@class='datepicker-years']//span[@class='year active']")).Click();
            //ReadOnlyCollection<IWebElement> months = driver.FindElements(By.XPath("//div[@class='datepicker-months']//span"));
            //foreach(IWebElement month in months)
            //{
            //    if(month.Equals("Apr"))
            //    {
            //        month.Click();
            //        break;
            //    }
            //}
            //ReadOnlyCollection<IWebElement> days = driver.FindElements(By.XPath("//div[@class='datepicker-days']//td[not (@class='day old')]"));
            //foreach(IWebElement day in days)
            //{
            //    if(day.Equals("12"))
            //    {
            //        day.Click();
            //        break;
            //    }
            //}
        }
    }
}
