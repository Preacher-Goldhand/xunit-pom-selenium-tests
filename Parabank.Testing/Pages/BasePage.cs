using static Parabank.Testing.Config.WebDriverSingleton;
using static Parabank.Testing.Helpers.WaitForElementHandler;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Parabank.Testing.Pages
{
    public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(GetInstance(), this);
            WaitForVisibilityOfElement(_pageContent);
        }

        [FindsBy(How = How.Id, Using = "loginPanel")]
        [CacheLookup]
        private WebElement _pageContent;
    }
}