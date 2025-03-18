using IceHRM.GenericUtils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;
using System.Net.Cache;

namespace Olympus.TestScripts
{
    public class AttedanceHardcode
    {
        [Test]
        public void Attend()
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            //string hour = DateTime.Now.ToString("HH");
            //string min = DateTime.Now.ToString("mm");
            //string sec = DateTime.Now.ToString("ss");
            //driver.FindElement(By.XPath("//td[@title='"+currentDate+"']/div")).Click();
            //driver.FindElement(By.XPath("//ul[@data-type='hour']//li[@data-value='"+hour+"']")).Click();
            //driver.FindElement(By.XPath("//ul[@data-type='minute']//li[@data-value='"+min+"']")).Click();
            //driver.FindElement(By.XPath("//ul[@data-type='second']//li[@data-value='"+sec+"']")).Click();
            //ReadOnlyCollection<IWebElement> hours = driver.FindElements(By.XPath("//ul[@data-type='hour']//li"));
            //ReadOnlyCollection<IWebElement> mins = driver.FindElements(By.XPath("//ul[@data-type='minute']//li"));
            //ReadOnlyCollection<IWebElement> secs = driver.FindElements(By.XPath("//ul[@data-type='second']//li"));

            WebDriverUtils web = new WebDriverUtils();
            IWebDriver driver = new ChromeDriver();
            web.MaximizeWindow(driver);
            web.ImplicitWait(driver, 20);
            driver.Url = "https://icehrmpro.gamonoid.com/login.php?logout=1";
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("user1");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("demouserpwd" + Keys.Enter);
            driver.FindElement(By.XPath("//a[@id='atteandanceLink']")).Click();
            driver.FindElement(By.XPath("//span[@class='anticon anticon-plus-circle']")).Click();
            By clock = By.XPath("//input[@placeholder='Select date' or @id='time']");
            web.SetElementVisible(driver, 5, clock);
            driver.FindElement(clock).Click();
            //driver.FindElement(By.XPath("//a[text()='Now']")).Click();
            driver.FindElement(By.XPath("//td[@title='2025-03-25']/div")).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement hr = driver.FindElement(By.XPath("//ul[@data-type='hour' ]/li[@data-value='" + 15 + "']"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", hr);
            hr.Click();
            IWebElement min = driver.FindElement(By.XPath("//ul[@data-type='minute' ]/li[@data-value='" + 13 + "']"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", min);
            min.Click();
            IWebElement sec = driver.FindElement(By.XPath("//ul[@data-type='second' ]/li[@data-value='" + 13 + "']"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", sec);
            sec.Click();
            driver.FindElement(By.XPath("//button[@type='button']/span[text()='OK']")).Click();
            driver.FindElement(By.XPath("//textarea[@id='note']")).SendKeys("logging in");
            driver.FindElement(By.XPath("//span[text()='Save']")).Click();
            driver.FindElement(By.XPath("//span[@class='anticon anticon-plus-circle']")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='Select date' or @id='time']")).Click();
            //driver.FindElement(By.XPath("//a[text()='Now']")).Click();
            driver.FindElement(By.XPath("//td[@title='2025-03-25']/div")).Click();
            IWebElement hr1 = driver.FindElement(By.XPath("//ul[@data-type='hour' ]/li[@data-value='"+15+"']"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", hr);
            hr1.Click();
            IWebElement min1 = driver.FindElement(By.XPath("//ul[@data-type='minute' ]/li[@data-value='" + 13+"']"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", min);
            min1.Click();
            IWebElement sec1 = driver.FindElement(By.XPath("//ul[@data-type='second' ]/li[@data-value='" + 13+"']"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", min);
            sec1.Click();
            driver.FindElement(By.XPath("//button[@type='button']/span[text()='OK']")).Click();
            driver.FindElement(By.XPath("//textarea[@id='note']")).SendKeys("log out..");
            //driver.FindElement(By.XPath("//span[text()='Save']")).Click();
            //string time = driver.FindElement(By.XPath("//span[@class='ant-progress-text']")).Text.Replace('h' , ' ');
            //int timer =int.Parse(time);
            //Console.WriteLine(timer);

        }
    }
}
