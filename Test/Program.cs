﻿using IC_TimeMaterial.Helpers;
using IC_TimeMaterial.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IC_TimeMaterial
{
    
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    class Program
    {
        IWebDriver driver;
        static void Main(string[] args)
        {
            
      
        }
        [SetUp]
        public void Login()
        {
            //define driver
            //CommonDriver.driver = new ChromeDriver();
            //define driver
            driver = new ChromeDriver();

            //Login action
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);

            //Navigate to TM
            HomePage homeObj = new HomePage();
            homeObj.NavigateTM(driver);

        }
        [Test]
        public void CreateTM()
        {
            TMPage tmObj = new TMPage();
            tmObj.CrtTM(driver);

        }

        [Test]
        public void EditTM()
        {
            TMPage tmObj = new TMPage();
            tmObj.EdtTM(driver);

        }

        [Test]
        public void DeleteTM()
        {

            TMPage tmObj = new TMPage();
            tmObj.DelTM(driver);
        }
        [TearDown]
        public void Finish()
        {
            driver.Quit();
        }
    }
}