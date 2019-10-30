using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Project_Humanity
{
    [TestClass]
    public class Login

    {
        [TestMethod]
        public void TestCase1()
        {
            //Potrebne promenljive za Logovanje
            var methodName = "TestCase1 - Login with valid data:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            LogTest.LogStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to login page";
            driver.Navigate().GoToUrl(PageObjects.url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            LogTest.LogStep(methodName, stepName);

            //Kliknemo na dugme LOGIN
            stepName = "3.Click on button LOGIN";
            driver.FindElement(By.CssSelector(PageObjects.btnLOGIN)).Click();
            Thread.Sleep(3000);
            LogTest.LogStep(methodName, stepName);


            //Unos teksta u polje username
            stepName = "4.Enter valid username";
            driver.FindElement(By.Id(PageObjects.txtUsername)).SendKeys(PageObjects.paramUsername);
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);


            //Unos teksta u polje password
            stepName = "5.Enter valid password";
            driver.FindElement(By.Id(PageObjects.txtPassword)).SendKeys(PageObjects.paramPassword);
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Kliknemo na dugme Log in
            stepName = "6.Click on button Log in";
            driver.FindElement(By.Name(PageObjects.btnLogin)).Click();
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);


            //Provera ispravnosti testa
            try
            {
                var confirmLog = driver.FindElement(By.ClassName(PageObjects.txtTitle));
                confirmLog.GetAttribute("Welcome to Humanity!");
                if (confirmLog.Displayed)
                {
                    LogTest.LogPassedTest();

                }
            }
            catch (Exception)
            {

                LogTest.LogFailedTest();
            }
            finally
            {
                //Logout
                driver.FindElement(By.CssSelector(PageObjects.btnlogout)).Click();
                driver.FindElement(By.CssSelector(PageObjects.btnSignout)).Click();
                Thread.Sleep(2000);
                //Kraj testa
                LogTest.LogEnd();
                driver.Quit();
            }

        }

        [TestMethod]
        public void TestCase2()
        {
            //Potrebne promenljive za Logovanje
            var methodName = "TestCase2 - Login with invalid username:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            LogTest.LogStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to login page";
            driver.Navigate().GoToUrl(PageObjects.url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            LogTest.LogStep(methodName, stepName);

            //Kliknemo na dugme LOGIN
            stepName = "3.Click on button LOGIN";
            driver.FindElement(By.CssSelector(PageObjects.btnLOGIN)).Click();
            Thread.Sleep(3000);
            LogTest.LogStep(methodName, stepName);


            //Unos teksta u polje username
            stepName = "4.Enter invalid username";
            driver.FindElement(By.Id(PageObjects.txtUsername)).SendKeys(PageObjects.invalidUsername);
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);


            //Unos teksta u polje password
            stepName = "5.Enter valid password";
            driver.FindElement(By.Id(PageObjects.txtPassword)).SendKeys(PageObjects.paramPassword);
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Kliknemo na dugme Log in
            stepName = "6.Click on button Log in";
            driver.FindElement(By.Name(PageObjects.btnLogin)).Click();
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);


            //Provera ispravnosti testa
            try
            {
                var errorMsg = driver.FindElement(By.Id(PageObjects.msgError));
                errorMsg.GetAttribute("Your username/email or password is incorrect.");
                if (errorMsg.Displayed)
                {
                    LogTest.LogPassedTest();

                }
            }
            catch (Exception)
            {

                LogTest.LogFailedTest();
            }
            finally
            {

                //Kraj testa
                LogTest.LogEnd();
                driver.Quit();
            }

        }

        [TestMethod]
        public void TestCase3()
        {
            //Potrebne promenljive za Logovanje
            var methodName = "TestCase3 - Login with invalid password:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            LogTest.LogStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to login page";
            driver.Navigate().GoToUrl(PageObjects.url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            LogTest.LogStep(methodName, stepName);

            //Kliknemo na dugme LOGIN
            stepName = "3.Click on button LOGIN";
            driver.FindElement(By.CssSelector(PageObjects.btnLOGIN)).Click();
            Thread.Sleep(3000);
            LogTest.LogStep(methodName, stepName);


            //Unos teksta u polje username
            stepName = "4.Enter valid username";
            driver.FindElement(By.Id(PageObjects.txtUsername)).SendKeys(PageObjects.paramUsername);
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);


            //Unos teksta u polje password
            stepName = "5.Enter invalid password";
            driver.FindElement(By.Id(PageObjects.txtPassword)).SendKeys(PageObjects.invalidPassword);
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Kliknemo na dugme Log in
            stepName = "6.Click on button Log in";
            driver.FindElement(By.Name(PageObjects.btnLogin)).Click();
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);


            //Provera ispravnosti testa
            try
            {
                var errorMsg = driver.FindElement(By.Id(PageObjects.msgError));
                errorMsg.GetAttribute("Your username/email or password is incorrect.");
                if (errorMsg.Displayed)
                {
                    LogTest.LogPassedTest();

                }
            }
            catch (Exception)
            {

                LogTest.LogFailedTest();
            }
            finally
            {

                //Kraj testa
                LogTest.LogEnd();
                driver.Quit();
            }

        }

        [TestMethod]
        public void TestCase4()
        {
            //Potrebne promenljive za Logovanje
            var methodName = "TestCase4 - Login without data:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            LogTest.LogStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to login page";
            driver.Navigate().GoToUrl(PageObjects.url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            LogTest.LogStep(methodName, stepName);

            //Kliknemo na dugme LOGIN
            stepName = "3.Click on button LOGIN";
            driver.FindElement(By.CssSelector(PageObjects.btnLOGIN)).Click();
            Thread.Sleep(3000);
            LogTest.LogStep(methodName, stepName);

            //Kliknemo na dugme Log in
            stepName = "4.Click on button Log in";
            driver.FindElement(By.Name(PageObjects.btnLogin)).Click();
            Thread.Sleep(2000);
            LogTest.LogStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
                var errorMsg = driver.FindElement(By.Id(PageObjects.msgError));
                errorMsg.GetAttribute("Your username/email or password is incorrect.");
                if (errorMsg.Displayed)
                {
                    LogTest.LogPassedTest();

                }
            }
            catch (Exception)
            {

                LogTest.LogFailedTest();
            }
            finally
            {

                //Kraj testa
                LogTest.LogEnd();
                driver.Quit();
            }

        }

    
    }

}    
