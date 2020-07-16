using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.Threading;
namespace LocatorslnSelenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("email")).SendKeys("aman.lotey@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("aman.lotey@gmail.com");
            Thread.Sleep(2000);
            driver.Quit();


        }
        [TestMethod]
        public void FacebookSignup()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            IWebElement firstName = driver.FindElement(By.Name("firstname"));
            firstName.SendKeys("Aman");
            driver.FindElement(By.Name("lastname")).SendKeys("deep");
            driver.FindElement(By.Name("reg_email__")).SendKeys("aman.lotey@gmail.com");
            driver.FindElement(By.Name("reg_passwd__")).SendKeys("1257244");
           


            Thread.Sleep(2000);
            driver.Quit();


        }
        [TestMethod]
        public void ClassNameLocator()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            string text=driver.FindElement(By.ClassName("_5iyx")).Text;
            Console.WriteLine(text);
            Thread.Sleep(2000);
            driver.Quit();


        }
        [TestMethod]
        public void tagSelect()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.lipsum.com/");
            driver.Manage().Window.Maximize();

            var paragraph = driver.FindElements(By.TagName("p"));
            System.Console.WriteLine(paragraph.Count);
            Thread.Sleep(2000);
            foreach (var item in paragraph)
            { System.Console.WriteLine(item.Text);
            }
            driver.Quit();


        }
    }
}
