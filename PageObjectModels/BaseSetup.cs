using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace PageObjectModels.BaseClass
{
    public class BaseSetup
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
