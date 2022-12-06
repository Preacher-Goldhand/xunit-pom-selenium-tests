using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Parabank.Testing.Pages
{
    public class Home : BasePage
    {
        public Home() : base()
        {
        }

        [FindsBy(How = How.LinkText, Using = "Register")]
        [CacheLookup]
        private WebElement _registerButton;

        public SignUp OpenRegistrationForm()
        {
            _registerButton.Click();
            return new SignUp();
        }
    }
}