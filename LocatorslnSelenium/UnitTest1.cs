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
            driver.FindElement(By.ClassName("email")).SendKeys("aman.lotey@gmail.com");
            driver.FindElement(By.ClassName("pass")).SendKeys("aman.lotey@gmail.com");
            Thread.Sleep(2000);
            driver.Quit();


        }
    }
}
