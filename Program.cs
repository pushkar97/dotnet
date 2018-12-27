using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace myApp
{
    class Program
    {
        private IWebDriver driver;
        public Program(IWebDriver driver)
        {
            this.driver = driver;
        }

        static void Main(string[] args) 
        {
            Program p1 = new Program(new ChromeDriver(@"D:\Work\Advanced Selenium Libs\Drivers"));
            p1.driver.Navigate().GoToUrl("https://www.joecolantonio.com/HpSupport.html");
        }
    }
}
