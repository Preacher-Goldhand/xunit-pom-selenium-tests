using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace Parabank.Testing.Config
{
    public class WebDriverSingleton
    {
        private static WebDriver _driver;

        private WebDriverSingleton()
        { }

        // Initialize only one time a browser driver
        public static WebDriver GetInstance()
        {
            if (_driver == null)
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                _driver = new ChromeDriver();
            }
            return _driver;
        }

        // Helper method to quit a browser
        public static void Quit()
        {
            if (null != _driver)
            {
                _driver.Quit();
                _driver.Dispose();
            }
            _driver = null;
        }
    }
}