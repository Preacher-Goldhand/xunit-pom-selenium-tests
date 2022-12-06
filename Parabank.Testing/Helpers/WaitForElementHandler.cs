using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static Parabank.Testing.Config.WebDriverSingleton;

namespace Parabank.Testing.Helpers
{
    // Wait for a specific web element during tests execution
    public class WaitForElementHandler
    {
        private static WebDriverWait wait = new WebDriverWait(GetInstance(), TimeSpan.FromSeconds(10));

        public static void WaitForVisibilityOfElement(WebElement webElement)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webElement));
        }
    }
}