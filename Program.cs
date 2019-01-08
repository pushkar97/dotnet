using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace myApp
{
    class Program
    {
        private static IWebDriver driver = new ChromeDriver(@"D:\Work\Advanced Selenium Libs\Drivers");
        private static IJavaScriptExecutor jsExecutor= (IJavaScriptExecutor)driver;
        static void Main(string[] args) 
        {
            try{
                driver.Navigate().GoToUrl("https://www.google.co.in");
                driver.FindElement(By.Name("q")).SendKeys("abc");
                driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
                jsExecutor.ExecuteScript("console.log('This is from jsExcecutor')");
            }catch(Exception e){
                Console.WriteLine(e);
            }finally{
                //driver.Close();
            }
        }
    }
}