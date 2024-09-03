using System.Threading;
using NUnit.Framework;
using PageObjects;

namespace Tests
{
    public class LoginTest : BaseTest
    {
        [Test]
        public void InvalidLogin()
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.SetUsername("Invalid_name");
            loginPage.SetPassword("Invalid_password");
            loginPage.SetOrganization("Invalid_company");
            Thread.Sleep(1000);
            loginPage.ClickLogin();
            Thread.Sleep(3000);

            var actualResult = loginPage.GetErrorMessage();
            string expectedResult = "warning Please enter a valid organization number.";
            Assert.AreEqual(expectedResult, actualResult, "User received an unexpected error message during login");
        }
    }
}
