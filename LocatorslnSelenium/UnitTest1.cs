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
            driver.FindElement(By.Id("pass")).SendKeys("1687hy");
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
        public void TagSelect()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.lipsum.com/");
            driver.Manage().Window.Maximize();

            
           var paragraph = driver.FindElements(By.TagName("p"));
            string paraText = driver.FindElement(By.TagName("p")).Text;
            Console.WriteLine(paraText);
            System.Console.WriteLine(paragraph.Count);
            Thread.Sleep(2000);
            foreach (var item in paragraph)
            { 
                System.Console.WriteLine(item.Text);
            }
            driver.Quit();
          
        }
        [TestMethod]
         public void TechWintec()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.wintec.ac.nz/study-at-wintec";
            IWebElement elem = driver.FindElement(By.Name("q"));
            elem.SendKeys("Informmation");
            driver.FindElement(By.XPath("//*[@id='topbarContentPlaceholder_T581BED3A034_Col01']/div/div/form/button/span")).Click();
            Thread.Sleep(2000);
            driver.Quit();


        }
        [TestMethod]
        public void LinkNextLocator()
        {
            IWebDriver driver = new ChromeDriver();

            // driver.Navigate().GoToUrl("http://uitestpractice.com/Students/Contact");
            driver.Navigate().GoToUrl("http://uitestpractice.com/Students/Switchto");
            driver.Manage().Window.Maximize();
           var text= driver.FindElement(By.PartialLinkText("a new window"));
            text.Click();
            
           


            Thread.Sleep(2000);
            driver.Quit();


        }
       [TestMethod]
       public void AbsoluteXpathLocators()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div/div/div[2]/div/div[2]/div/div/div/div[1]/form/div[1]/div[1]/div[1]/div[1]/div/div[1]/input"))
                .SendKeys("Amandeep");
           ;
            Thread.Sleep(2000);
            driver.Quit();
        }


    }

}
