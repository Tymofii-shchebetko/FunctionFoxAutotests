using System;
using OpenQA.Selenium;

namespace PageObjects
{
    public class InitPage : BasePage
    {
        public InitPage(IWebDriver driver) : base(driver)
        {
            
        }

        LoginPage loginPage = new LoginPage(driver);
    }
}
