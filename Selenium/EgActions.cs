﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class EgActions
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            driver = new ChromeDriver();
            // launch the forefox browser

            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

            IWebElement TdyDeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));
            
            new Actions(driver).DoubleClick(TdyDeal).Perform();
            Thread.Sleep(1000);

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
