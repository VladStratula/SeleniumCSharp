using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModels.Pages;
using PageObjectModels.BaseClass;

namespace PageObjectModels
{
    public class UnitTest1 : BaseSetup
    {
        [Test]
        public void LogIntoApp()
        {
            Homepage homePage = new Homepage(driver);
            Login loginPage = new Login(driver);

            homePage.ClickLogin();
            loginPage.EnterUsernameAndPassword("admin", "password");
            loginPage.ClickLogin();
            Assert.That(homePage.IsLogOffExist(), Is.True, "Log off button did not display");
        }

        public void LogOut()
        {

        }
    }
}