using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using DocumentFormat.OpenXml.InkML;
using NUnit.Framework.Interfaces;
using Olympus.PageObjects.BasicPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IceHRM.GenericUtils
{

    public class BaseClass
    {
        public WebDriverUtils web = new WebDriverUtils();
        public JsonUtils json = new JsonUtils();
        public ExcelUtils excel = new ExcelUtils();
        public CSharpUtils csharp = new CSharpUtils();
        public IWebDriver driver;
        public string browser;

        public ExtentReports extent;
        public ExtentTest test;
        [OneTimeSetUp]
        public void OpenBrowser()
        {
            Console.WriteLine("Connecting to database ...");
            ExtentSparkReporter spark = new ExtentSparkReporter(IPathConstant.REPORT_PATH+csharp.GetCurrentDate()+".html");
            spark.Config.DocumentTitle = this.GetType().Name;
            spark.Config.ReportName = "Extent Report";
            spark.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(spark);
            extent.AddSystemInfo("windows", "stagging environment");


            switch (browser)
            {
                case "chrome": driver = new ChromeDriver(); break;
                case "firefox": driver = new FirefoxDriver(); break;
                case "edge": driver = new EdgeDriver(); break;
                default : driver = new ChromeDriver(); break;
            }
            driver.Url = json.GetJsonData("url");
            web.MaximizeWindow(driver);
            web.ImplicitWait(driver , IPathConstant.IMPLICIT_WAIT);
        }
        [SetUp]
        public void Login()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            LoginPage lp = new LoginPage(driver);
            lp.LoginToApp(json.GetJsonData("username"), json.GetJsonData("password"));
            test.Info("Logged into  the application");

        }
        [TearDown]
        public void Logout()
        {
            string methodName = TestContext.CurrentContext.Test.Name;
            test.Log(Status.Info, methodName + " started ");
            if(TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                ITakesScreenshot sc = (ITakesScreenshot)driver;
                string screenshot = sc.GetScreenshot().AsBase64EncodedString;
                test.AddScreenCaptureFromBase64String(screenshot);
            }
            else if(TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                test.Log(Status.Info, methodName + " passed ");
            }
                HomePage hp = new HomePage(driver);
            hp.LogoutApp();
        }
        [OneTimeTearDown]
        public void CloseBrowser()
        {
            extent.Flush();
            web.MinimizeWindow(driver);
            driver.Quit();
            driver.Dispose();
            Console.WriteLine("DisConnected from data base...");
        }

    }
}
