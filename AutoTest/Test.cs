using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using System.Threading;
using AutoTest.pages;
using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace AutoTest
{
    [TestFixture]
    public class Test
    {
        DateTime CurentMoment = DateTime.Now;
        public static string igWorkDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location); 
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");
            driver = new ChromeDriver(igWorkDir, options);
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown] 
        public void OneTimeTearDown()
        {
            driver.Quit();
        }

        [SetUp] 
        public void SetUp()
        {
          
        }

        [TearDown] 
        public void TearDown()
        {
         
        }

        [Test]
        public void Test_1()
        {
            driver.Navigate().GoToUrl("https://www.google.ru");
            Test_1_info pageHome = new Test_1_info();
            PageFactory.InitElements(driver, pageHome);
            pageHome.SearchField.Click();
            pageHome.SearchField.SendKeys("Вікіпедія");
            Thread.Sleep(2000);
            pageHome.SearchButton.Click();
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl(pageHome.WikiLink.GetAttribute("href"));
            Thread.Sleep(2000);
            Assert.AreEqual(driver.Title, "Вікіпедія");
            File.WriteAllText(igWorkDir + "TestsReports/Test1.txt", "Тест_1 пройден. \r\nВремя: " + CurentMoment);
            Thread.Sleep(2000);
        }

        [Test]
        public void Test_2()
        {
            DateTime Today = DateTime.Today;
            driver.Navigate().GoToUrl("https://uk.wikipedia.org");
            Thread.Sleep(2000);
            Test_2_info pageHome = new Test_2_info();
            PageFactory.InitElements(driver, pageHome);
            string WikiYear = pageHome.WikiYear.Text;
            string WikiDayMonth = pageHome.WikiDayMonth.Text;
            string WikiDate = WikiDayMonth + " " + WikiYear; 
            string RealDate = DateTime.Now.ToString("d MMMM yyyy", CultureInfo.GetCultureInfo("uk-UA"));
            Assert.AreEqual(RealDate, WikiDate);
            Thread.Sleep(2000);
            File.WriteAllText(igWorkDir + "TestsReports/Test2.txt", "Тест_2 пройден. \r\nВремя: " + CurentMoment);
        }

        [Test]
        public void Test_3()
        {
            driver.Navigate().GoToUrl("https://uk.wikipedia.org");
            Thread.Sleep(2000);
            Test_3_4_info pageHome = new Test_3_4_info();
            PageFactory.InitElements(driver, pageHome);
            pageHome.LinkEvents.Click();
            Thread.Sleep(2000);
            Assert.AreEqual(driver.Title, "Вікіпедія:Поточні події — Вікіпедія");
            File.WriteAllText(igWorkDir + "TestsReports/Test3.txt", "Тест_3 пройден. \r\nВремя: " + CurentMoment);
            Thread.Sleep(2000);
        }

        [Test]
        public void Test_4()
        {
            driver.Navigate().GoToUrl("https://uk.wikipedia.org");
            Thread.Sleep(2000);
            Test_3_4_info pageHome = new Test_3_4_info();
            PageFactory.InitElements(driver, pageHome);
            pageHome.LinkEvents.Click();
            Thread.Sleep(2000);
            Assert.AreEqual(pageHome.CurentMonth.Text, "жовтень", "The month of event is not current!");
        }

        [Test]
        public void Test_5()
        {
            driver.Navigate().GoToUrl("https://uk.wikipedia.org");
            Thread.Sleep(2000);
            Test_5_info pageHome = new Test_5_info();
            PageFactory.InitElements(driver, pageHome);
            pageHome.SearchField.SendKeys("Test case");
            Thread.Sleep(1000);
            pageHome.SearchButton.Click();
            pageHome.ArticleLink.Click();
            Thread.Sleep(2000);
            File.WriteAllText(igWorkDir + "TestsReports/Test5.txt", "Тест_5 пройден. \r\nВремя: " + CurentMoment);
            Assert.AreEqual(driver.Title, "Тестовий випадок — Вікіпедія");
            Thread.Sleep(2000);
        }
    }
}
