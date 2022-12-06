using Parabank.Testing.Pages;

namespace Parabank.Testing.Tests
{
    public class RegistrationTest
    {
        [Fact]
        public void UserShouldSuccessfullyRegister()
        {
            new Home()
                .OpenRegistrationForm()
                .SubmitFormWithValidData()
                .UserShouldBeSuccessfullyRegistered();
        }
    }
}