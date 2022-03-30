using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using PageObjectModels.BaseClass;

namespace PageObjectModels.Pages
{
    public class Homepage : BaseSetup
    {
        IWebDriver driver;
        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickLogin()
        {
            driver.FindElement(By.LinkText("Login")).Click();
        }

        public void ClickLogout()
        {
            driver.FindElement(By.LinkText("Log off")).Click();
        }

        public bool IsLogOffExist()
        {
            IWebElement logOffButton = driver.FindElement(By.LinkText("Log off"));
            if (logOffButton.Displayed)
                return true;
            else
                return false;
        }
    }
}
