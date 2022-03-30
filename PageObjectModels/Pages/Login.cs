using System;
using System.Collections.Generic;
using System.Text;
using PageObjectModels.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectModels.Pages
{
    public class Login : BaseSetup
    {
        IWebDriver driver;
        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsernameAndPassword(string username, string password)
        {
            IWebElement txtUser = driver.FindElement(By.Id("UserName"));
            IWebElement txtPassword = driver.FindElement(By.Id("Password"));

            txtUser.SendKeys(username);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            IWebElement loginButton = driver.FindElement(By.CssSelector(".btn-default"));
            loginButton.Click();
        }
    }
}
