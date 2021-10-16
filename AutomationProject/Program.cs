using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AutomationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\11036379\Downloads\chromedriver_win32");
            string url = "http://localhost:5000/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(5000);

            IWebElement element1 = driver.FindElement(By.Id("1"));
            element1.Click();
            Thread.Sleep(5000);

            IWebElement element2 = driver.FindElement(By.Id("proceed"));
            element2.Click();
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}

