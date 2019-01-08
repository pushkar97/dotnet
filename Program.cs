using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace myApp
{
    class Program
    {
        private static IWebDriver driver = new ChromeDriver(@"D:\Work\Advanced Selenium Libs\Drivers");

        static void Main(string[] args) 
        {
            driver.Navigate().GoToUrl("https://www.google.co.in");
            driver.FindElement(By.Name("q")).SendKeys("abc");
            driver.FindElement(By.Name("btnK")).Click();
        }
    }
}