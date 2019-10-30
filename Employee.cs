using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_Humanity
{
    [TestClass]
    public class Employee
    {
        [TestMethod]
        public void TestCase1()
        {
            //Potrebne promenljive za izvestaj testa
            var methodName = "TestCase1 - Add employee with valid data:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            EmployeeTest.EmployeeStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to Add Employees page";
            driver.Navigate().GoToUrl(PageObjects.url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.CssSelector(PageObjects.btnLOGIN)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id(PageObjects.txtUsername)).SendKeys(PageObjects.paramUsername);
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.txtPassword)).SendKeys(PageObjects.paramPassword);
            Thread.Sleep(2000);
            driver.FindElement(By.Name(PageObjects.btnLogin)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnStaff)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnAddEmployee)).Click();
            Thread.Sleep(3000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos teksta u polje first name
            stepName = "3.Enter valid first name";
            driver.FindElement(By.Id(PageObjects.txtFirstname)).SendKeys(PageObjects.paramFirstname);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos teksta u polje last name
            stepName = "4.Enter valid last name";
            driver.FindElement(By.Id(PageObjects.txtLastname)).SendKeys(PageObjects.paramLastname);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos mejla u polje email
            stepName = "5.Enter valid email";
            driver.FindElement(By.Id(PageObjects.txtEmail)).SendKeys(PageObjects.paramEmail);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Kliknemo na dugme Save Employees
            stepName = "6.Click on button Save Employees";
            driver.FindElement(By.Id(PageObjects.btnSaveEmployee)).Click();
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
                var element = driver.FindElement(By.Id(PageObjects.msgEmployee));

                if (element.Text == "1 employee saved!")
                {
                    EmployeeTest.EmployeePassedTest();

                }
            }
            catch (Exception)
            {

                EmployeeTest.EmployeeFailedTest();
            }
            finally
            {
                //Logout
                driver.FindElement(By.CssSelector(PageObjects.btnlogout)).Click();
                driver.FindElement(By.CssSelector(PageObjects.btnSignout)).Click();
                Thread.Sleep(2000);

                //Kraj testa
                EmployeeTest.EmployeeEnd();
                driver.Quit();
            }

        }

        [TestMethod]
        public void TestCase2()
        {
            //Potrebne promenljive za izvestaj testa
            var methodName = "TestCase2 - Add employee without data:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            EmployeeTest.EmployeeStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to Add Employees page";
            driver.Navigate().GoToUrl(PageObjects.url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.CssSelector(PageObjects.btnLOGIN)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id(PageObjects.txtUsername)).SendKeys(PageObjects.paramUsername);
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.txtPassword)).SendKeys(PageObjects.paramPassword);
            Thread.Sleep(3000);
            driver.FindElement(By.Name(PageObjects.btnLogin)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnStaff)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnAddEmployee)).Click();
            Thread.Sleep(3000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Kliknemo na dugme Save Employees
            stepName = "3.Click on button Save Employees";
            driver.FindElement(By.Id(PageObjects.btnSaveEmployee)).Click();
            Thread.Sleep(3000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
                var element = driver.FindElement(By.Id(PageObjects.msgEmployee));

                if (element.Text == "Add at least one employee")
                {
                    EmployeeTest.EmployeePassedTest();

                }
            }
            catch (Exception)
            {

                EmployeeTest.EmployeeFailedTest();
            }
            finally
            {
                //Logout
                driver.FindElement(By.CssSelector(PageObjects.btnlogout)).Click();
                driver.FindElement(By.CssSelector(PageObjects.btnSignout)).Click();
                Thread.Sleep(2000);

                //Kraj testa
                EmployeeTest.EmployeeEnd();
                driver.Quit();
            }



        }

        [TestMethod]
        public void TestCase3()
        {
            //Potrebne promenljive za izvestaj testa
            var methodName = "TestCase3 - Add employee with invalid email:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            EmployeeTest.EmployeeStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to Add Employees page";
            driver.Navigate().GoToUrl(PageObjects.url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.CssSelector(PageObjects.btnLOGIN)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id(PageObjects.txtUsername)).SendKeys(PageObjects.paramUsername);
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.txtPassword)).SendKeys(PageObjects.paramPassword);
            Thread.Sleep(2000);
            driver.FindElement(By.Name(PageObjects.btnLogin)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnStaff)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnAddEmployee)).Click();
            Thread.Sleep(3000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos teksta u polje first name
            stepName = "3.Enter valid first name";
            driver.FindElement(By.Id(PageObjects.txtFirstname)).SendKeys(PageObjects.paramFirstname2);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            // Unos teksta u polje last name
            stepName = "4.Enter valid last name";
            driver.FindElement(By.Id(PageObjects.txtLastname)).SendKeys(PageObjects.paramLastname2);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos mejla u polje email
            stepName = "5.Enter invalid email";
            driver.FindElement(By.Id(PageObjects.txtEmail)).SendKeys(PageObjects.invalidEmail);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Kliknemo na dugme Save Employees
            stepName = "6.Click on button Save Employees";
            driver.FindElement(By.Id(PageObjects.btnSaveEmployee)).Click();
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
                var element = driver.FindElement(By.Id(PageObjects.msgEmployee));

                if (element.Text == "Invalid Email")
                {
                    EmployeeTest.EmployeePassedTest();

                }
            }
            catch (Exception)
            {

                EmployeeTest.EmployeeFailedTest();
            }
            finally
            {
                //Logout
                driver.FindElement(By.CssSelector(PageObjects.btnlogout)).Click();
                driver.FindElement(By.CssSelector(PageObjects.btnSignout)).Click();
                Thread.Sleep(2000);

                //Kraj testa
                EmployeeTest.EmployeeEnd();
                driver.Quit();
            }
        }


        [TestMethod]
        public void TestCase4()
        {
            //Potrebne promenljive za izvestaj testa
            var methodName = "TestCase4 - Add employee without email:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            EmployeeTest.EmployeeStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to Add Employees page";
            driver.Navigate().GoToUrl(PageObjects.url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.CssSelector(PageObjects.btnLOGIN)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id(PageObjects.txtUsername)).SendKeys(PageObjects.paramUsername);
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.txtPassword)).SendKeys(PageObjects.paramPassword);
            Thread.Sleep(2000);
            driver.FindElement(By.Name(PageObjects.btnLogin)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnStaff)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnAddEmployee)).Click();
            Thread.Sleep(3000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos teksta u polje first name
            stepName = "3.Enter valid first name";
            driver.FindElement(By.Id(PageObjects.txtFirstname)).SendKeys(PageObjects.paramFirstname3);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            // Unos teksta u polje last name
            stepName = "4.Enter valid last name";
            driver.FindElement(By.Id(PageObjects.txtLastname)).SendKeys(PageObjects.paramLastname3);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Kliknemo na dugme Save Employees
            stepName = "5.Click on button Save Employees";
            driver.FindElement(By.Id(PageObjects.btnSaveEmployee)).Click();
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
                var element = driver.FindElement(By.Id(PageObjects.msgEmployee));

                if (element.Text == "1 employee saved!")
                {
                    
                    EmployeeTest.EmployeeFailedTest();

                }
            }
            catch (Exception)
            {

                EmployeeTest.EmployeePassedTest();
            }
            finally
            {
                //Logout
                driver.FindElement(By.CssSelector(PageObjects.btnlogout)).Click();
                driver.FindElement(By.CssSelector(PageObjects.btnSignout)).Click();
                Thread.Sleep(2000);

                //Kraj testa
                EmployeeTest.EmployeeEnd();
                driver.Quit();
            }
        }

        [TestMethod]
        public void TestCase5()
        {
            //Potrebne promenljive za izvestaj testa
            var methodName = "TestCase5 - Add employee without first name and last name:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            EmployeeTest.EmployeeStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to Add Employees page";
            driver.Navigate().GoToUrl(PageObjects.url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.CssSelector(PageObjects.btnLOGIN)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id(PageObjects.txtUsername)).SendKeys(PageObjects.paramUsername);
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.txtPassword)).SendKeys(PageObjects.paramPassword);
            Thread.Sleep(2000);
            driver.FindElement(By.Name(PageObjects.btnLogin)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnStaff)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnAddEmployee)).Click();
            Thread.Sleep(3000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos mejla u polje email
            stepName = "3.Enter valid email";
            driver.FindElement(By.Id(PageObjects.txtEmail)).SendKeys(PageObjects.paramEmail2);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Kliknemo na dugme Save Employees
            stepName = "4.Click on button Save Employees";
            driver.FindElement(By.Id(PageObjects.btnSaveEmployee)).Click();
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
                var element = driver.FindElement(By.Id(PageObjects.msgEmployee));

                if (element.Text == "First Name cannot be left empty")
                {
                    EmployeeTest.EmployeePassedTest();

                }
            }
            catch (Exception)
            {

                EmployeeTest.EmployeeFailedTest();
            }
            finally
            {
                //Logout
                driver.FindElement(By.CssSelector(PageObjects.btnlogout)).Click();
                driver.FindElement(By.CssSelector(PageObjects.btnSignout)).Click();
                Thread.Sleep(2000);

                //Kraj testa
                EmployeeTest.EmployeeEnd();
                driver.Quit();
            }

        }

        [TestMethod]
        public void TestCase6()
        {
            //Potrebne promenljive za izvestaj testa
            var methodName = "TestCase6 - Add employee without last name:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            EmployeeTest.EmployeeStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to Add Employees page";
            driver.Navigate().GoToUrl(PageObjects.url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.CssSelector(PageObjects.btnLOGIN)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id(PageObjects.txtUsername)).SendKeys(PageObjects.paramUsername);
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.txtPassword)).SendKeys(PageObjects.paramPassword);
            Thread.Sleep(3000);
            driver.FindElement(By.Name(PageObjects.btnLogin)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id(PageObjects.btnStaff)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnAddEmployee)).Click();
            Thread.Sleep(3000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos teksta u polje first name
            stepName = "3.Enter valid first name";
            driver.FindElement(By.Id(PageObjects.txtFirstname)).SendKeys(PageObjects.paramFirstname4);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos mejla u polje email
            stepName = "4.Enter valid email";
            driver.FindElement(By.Id(PageObjects.txtEmail)).SendKeys(PageObjects.paramEmail3);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Kliknemo na dugme Save Employees
            stepName = "5.Click on button Save Employees";
            driver.FindElement(By.Id(PageObjects.btnSaveEmployee)).Click();
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
                var element = driver.FindElement(By.Id(PageObjects.msgEmployee));

                if (element.Text == "1 employee saved!")
                {

                    EmployeeTest.EmployeeFailedTest();

                }
            }
            catch (Exception)
            {

                EmployeeTest.EmployeePassedTest();
            }
            finally
            {
                //Logout
                driver.FindElement(By.CssSelector(PageObjects.btnlogout)).Click();
                driver.FindElement(By.CssSelector(PageObjects.btnSignout)).Click();
                Thread.Sleep(2000);

                //Kraj testa
                EmployeeTest.EmployeeEnd();
                driver.Quit();
            }
        }

        [TestMethod]
        public void TestCase7()
        {
            //Potrebne promenljive za izvestaj testa
            var methodName = "TestCase7 - Add employee with numeric data:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            EmployeeTest.EmployeeStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to Add Employees page";
            driver.Navigate().GoToUrl(PageObjects.url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.CssSelector(PageObjects.btnLOGIN)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id(PageObjects.txtUsername)).SendKeys(PageObjects.paramUsername);
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.txtPassword)).SendKeys(PageObjects.paramPassword);
            Thread.Sleep(2000);
            driver.FindElement(By.Name(PageObjects.btnLogin)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id(PageObjects.btnStaff)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnAddEmployee)).Click();
            Thread.Sleep(3000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos teksta u polje first name
            stepName = "3.Enter invalid first name";
            driver.FindElement(By.Id(PageObjects.txtFirstname)).SendKeys(PageObjects.numericFirstname);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos teksta u polje last name
            stepName = "4.Enter invalid last name";
            driver.FindElement(By.Id(PageObjects.txtLastname)).SendKeys(PageObjects.numericLastname);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos mejla u polje email
            stepName = "5.Enter valid email";
            driver.FindElement(By.Id(PageObjects.txtEmail)).SendKeys(PageObjects.numericEmail);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Kliknemo na dugme Save Employees
            stepName = "6.Click on button Save Employees";
            driver.FindElement(By.Id(PageObjects.btnSaveEmployee)).Click();
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
                var element = driver.FindElement(By.Id(PageObjects.msgEmployee));

                if (element.Text == "1 employee saved!")
                {
                    
                    EmployeeTest.EmployeeFailedTest();

                }
            }
            catch (Exception)
            {
                EmployeeTest.EmployeePassedTest();

            }
            finally
            {
                //Logout
                driver.FindElement(By.CssSelector(PageObjects.btnlogout)).Click();
                driver.FindElement(By.CssSelector(PageObjects.btnSignout)).Click();
                Thread.Sleep(2000);

                //Kraj testa
                EmployeeTest.EmployeeEnd();
                driver.Quit();
            }

        }

        [TestMethod]
        public void TestCase8()
        {
            //Potrebne promenljive za izvestaj testa
            var methodName = "TestCase8 - Add employee with existing email:";
            var stepName = "";

            //Inicijalizacija Chrome driver
            stepName = "1.Initialization Chrome driver";
            IWebDriver driver = new ChromeDriver();
            EmployeeTest.EmployeeStep(methodName, stepName);

            // Odlazak na stranicu
            stepName = "2.Navigate to Add Employees page";
            driver.Navigate().GoToUrl(PageObjects.url);
            driver.Manage().Window.Maximize();
            var wait = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.CssSelector(PageObjects.btnLOGIN)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id(PageObjects.txtUsername)).SendKeys(PageObjects.paramUsername);
            Thread.Sleep(3000);
            driver.FindElement(By.Id(PageObjects.txtPassword)).SendKeys(PageObjects.paramPassword);
            Thread.Sleep(2000);
            driver.FindElement(By.Name(PageObjects.btnLogin)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id(PageObjects.btnStaff)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id(PageObjects.btnAddEmployee)).Click();
            Thread.Sleep(3000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos teksta u polje first name
            stepName = "3.Enter valid first name";
            driver.FindElement(By.Id(PageObjects.txtFirstname)).SendKeys(PageObjects.paramFirstname5);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos teksta u polje last name
            stepName = "4.Enter valid last name";
            driver.FindElement(By.Id(PageObjects.txtLastname)).SendKeys(PageObjects.paramLastname4);
            Thread.Sleep(2000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Unos mejla u polje email
            stepName = "5.Enter valid email";
            driver.FindElement(By.Id(PageObjects.txtEmail)).SendKeys(PageObjects.paramEmail);
            Thread.Sleep(3000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Kliknemo na dugme Save Employees
            stepName = "6.Click on button Save Employees";
            driver.FindElement(By.Id(PageObjects.btnSaveEmployee)).Click();
            Thread.Sleep(3000);
            EmployeeTest.EmployeeStep(methodName, stepName);

            //Provera ispravnosti testa
            try
            {
                var element = driver.FindElement(By.Id(PageObjects.msgEmployee));

                if (element.Text == "Email already taken or Invalid!")
                {

                    EmployeeTest.EmployeePassedTest();

                }
            }
            catch (Exception)
            {

                EmployeeTest.EmployeeFailedTest();

            }
            finally
            {
                //Logout
                driver.FindElement(By.CssSelector(PageObjects.btnlogout)).Click();
                driver.FindElement(By.CssSelector(PageObjects.btnSignout)).Click();
                Thread.Sleep(2000);

                //Kraj testa
                EmployeeTest.EmployeeEnd();
                driver.Quit();
            }

        }
    }
}
