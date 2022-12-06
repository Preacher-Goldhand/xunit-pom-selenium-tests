using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using FluentAssertions;

namespace Parabank.Testing.Pages
{
    public class UserProfile : BasePage
    {
        public UserProfile() : base()
        {
        }

        [FindsBy(How = How.TagName, Using = "p")]
        [CacheLookup]
        private WebElement _profileParagraph;

        public void UserShouldBeSuccessfullyRegistered()
        {
            string profileParagraphText = _profileParagraph.Text;
            string expectedParagraphText = "Your account was created successfully. You are now logged in.";

            profileParagraphText.Should().Be(expectedParagraphText);
        }
    }
}