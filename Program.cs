using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace myApp
{
    class Program
    {
        // private static IWebDriver driver = new ChromeDriver(@"D:\Work\Advanced Selenium Libs\Drivers");
        // private static IJavaScriptExecutor jsExecutor= (IJavaScriptExecutor)driver;
        static void Main(string[] args) 
        {
            using(IWebDriver driver = new ChromeDriver(@"D:\Work\Advanced Selenium Libs\Drivers")){
                //driver.Navigate().GoToUrl("https://www.google.co.in");
                driver.Url = "https://www.google.co.in";
                driver.FindElement(By.Name("q")).SendKeys("abc");
                driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

                IJavaScriptExecutor jsExecutor= (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("console.log('This is from jsExcecutor')");
            }

            // try{
            //     //driver.Navigate().GoToUrl("https://www.google.co.in");
            //     driver.Url = "https://www.google.co.in";
            //     driver.FindElement(By.Name("q")).SendKeys("abc");
            //     driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            //     jsExecutor.ExecuteScript("console.log('This is from jsExcecutor')");
            // }catch(Exception e){
            //     Console.WriteLine(e);
            // }finally{
            //     driver.Close();
            // }
        }
        [Test]
        public void NUnitTest(){
            IWebDriver driver = new ChromeDriver(@"D:\Work\Advanced Selenium Libs\Drivers");
            driver.Url = "https://www.google.co.in";
            driver.FindElement(By.Name("q")).SendKeys("abc");
            driver.FindElement(By.Name("q")).Submit();
            driver.Close();
        }
    }
}