using System.Text;

namespace Parabank.Testing.Helpers
{
    public class DataFaker
    {
        public static String GetFakeFirstName()
        {
            return Faker.Name.First();
        }

        public static String GetFakeLastName()
        {
            return Faker.Name.Last();
        }

        public static String GetFakeAddressStreetName()
        {
            return Faker.Address.StreetName();
        }

        public static String GetFakeCity()
        {
            return Faker.Address.City();
        }

        public static String GetFakeState()
        {
            return Faker.Address.UsState();
        }

        public static String GetFakeZipCode()
        {
            return Faker.Address.ZipCode();
        }

        public static String GetFakePhoneNumber()
        {
            return Faker.Phone.Number();
        }

        public static String GetFakeSocialSecurityNumber()
        {
            return Faker.Identification.SocialSecurityNumber();
        }

        public static String GetFakeUsername()
        {
            return Faker.Internet.UserName();
        }

        public static String GetFakePassword()
        {
            return DataFaker.GetRandomPassword(10);
        }

        public static String GetFakeConfirmPassword()
        {
            return DataFaker.GetRandomPassword(10);
        }

        private static string GetRandomPassword(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
    }
}