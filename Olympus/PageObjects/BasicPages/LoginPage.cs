namespace Olympus.PageObjects.BasicPages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input[@id='username']")]
        private IWebElement email;
        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        private IWebElement password;
        [FindsBy(How = How.XPath, Using = "//button[text()='Log in ']")]
        private IWebElement login;

        public IWebElement Email { get => email; set => email = value; }
        public IWebElement Password { get => password; set => password = value; }
        public IWebElement Login { get => login; set => login = value; }

        public void LoginToApp(string username, string password)
        {
            Email.SendKeys(username);
            Password.SendKeys(password);
            Login.Click();

        }

    }
}
