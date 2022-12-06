using OpenQA.Selenium;
using static Parabank.Testing.Config.WebDriverSingleton;
using static System.Net.WebRequestMethods;

namespace Parabank.Testing.Config
{
    public class TestConfig : IDisposable
    {
        private readonly string _url = "https://parabank.parasoft.com/parabank/index.htm";
        private WebDriver _driver;

        // Setup
        public TestConfig()
        {
            _driver = GetInstance();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _driver.Url = _url;
        }

        // Cleaning
        public void Dispose()
        {
            Quit();
        }
    }
}