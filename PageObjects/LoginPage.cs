using System;
using OpenQA.Selenium;

namespace PageObjects
{
    public class LoginPage : BasePage
    {
        public LoginPage (IWebDriver driver) : base (driver)
        {

        }

        IWebElement txtUsername => driver.FindElement(By.XPath("//input[@name='user']"));
        IWebElement txtPassword => driver.FindElement(By.XPath("//input[@name='password']"));
        IWebElement txtOrganization => driver.FindElement(By.XPath("//input[@name='org_cd']"));
        IWebElement btnLogin => driver.FindElement(By.XPath("//input[@name='btnLogin']"));
        IWebElement errMessage => driver.FindElement(By.XPath("//*[text()=' Please enter a valid organization number.']"));

        public void SetUsername(string text) => txtUsername.SendKeys(text);
        public void SetPassword(string text) => txtPassword.SendKeys(text);
        public void SetOrganization(string text) => txtOrganization.SendKeys(text);
        public void ClickLogin() => btnLogin.Click();
        public string GetErrorMessage() => errMessage.Text;

    }
}
