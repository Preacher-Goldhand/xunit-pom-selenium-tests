using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Parabank.Testing.Pages
{
    public class SignUp : BasePage
    {
        public SignUp() : base()
        {
        }

        [FindsBy(How = How.Id, Using = "customer.firstName")]
        [CacheLookup]
        private WebElement _firstName;

        [FindsBy(How = How.Id, Using = "customer.lastName")]
        [CacheLookup]
        private WebElement _lastName;

        [FindsBy(How = How.Id, Using = "customer.address.street")]
        [CacheLookup]
        private WebElement _address;

        [FindsBy(How = How.Id, Using = "customer.address.city")]
        [CacheLookup]
        private WebElement _city;

        [FindsBy(How = How.Id, Using = "customer.address.state")]
        [CacheLookup]
        private WebElement _state;

        [FindsBy(How = How.Id, Using = "customer.address.zipCode")]
        [CacheLookup]
        private WebElement _zipCode;

        [FindsBy(How = How.Id, Using = "customer.phoneNumber")]
        [CacheLookup]
        private WebElement _phoneNumber;

        [FindsBy(How = How.Id, Using = "customer.ssn")]
        [CacheLookup]
        private WebElement _ssn;

        [FindsBy(How = How.Id, Using = "customer.username")]
        [CacheLookup]
        private WebElement _userName;

        [FindsBy(How = How.Id, Using = "customer.password")]
        [CacheLookup]
        private WebElement _password;

        [FindsBy(How = How.Id, Using = "repeatedPassword")]
        [CacheLookup]
        private WebElement _confirmPassword;

        [FindsBy(How = How.CssSelector, Using = "input[value='Register']")]
        [CacheLookup]
        private WebElement _submitRegisterButton;

        private void FillInRegistrationForm()
        {
            _firstName.SendKeys("Jan");
            _lastName.SendKeys("Kowalski");
            _address.SendKeys("48702 Heaney Cliff Suite 604 Kelvinhaven1");
            _city.SendKeys("Warsaw");
            _state.SendKeys("Florida");
            _zipCode.SendKeys("CA 93556-5181");
            _phoneNumber.SendKeys("501123456");
            _ssn.SendKeys("551-27-7061");
            _userName.SendKeys("tester123");
            _password.SendKeys("mojeSilneHaslo123");
            _confirmPassword.SendKeys("mojeSilneHaslo123");
        }

        public UserProfile SubmitFormWithValidData()
        {
            FillInRegistrationForm();
            _submitRegisterButton.Click();
            return new UserProfile();
        }
    }
}