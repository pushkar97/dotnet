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
            //Program p1 = new Program();
            driver.Navigate().GoToUrl("https://www.google.co.in");
            driver.FindElement(By.Name("q")).SendKeys("abc");
        }
    }
}