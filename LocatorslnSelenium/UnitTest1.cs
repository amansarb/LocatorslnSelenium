using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            driver.FindElement(By.Name("firstname")).SendKeys("Aman");
            driver.FindElement(By.Id("lastname")).SendKeys("deep");
            driver.FindElement(By.Id("lastname")).SendKeys("deep");
            driver.FindElement(By.Id("lastname")).SendKeys("deep");
            driver.FindElement(By.Id("lastname")).SendKeys("deep");


            Thread.Sleep(2000);
            driver.Quit();


        }
    }
}
