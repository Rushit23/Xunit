using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace XunitFrameWork
{
    public class ParallelTest2 : IDisposable
    {
        IWebDriver driver;

        [Fact]
        [Trait("Category", "Parallel")]
        public void VerifyTitle()
        {
            driver = new ChromeDriver();
            String url = "https://www.facebook.com/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);



            System.Console.WriteLine("****************************************");
            System.Console.WriteLine("\r\n");
            Assert.Equal("Facebook - Log In or Sign Up", driver.Title);
            driver.Quit();
        }


        [Fact]
        [Trait("Category", "Parallel")]
        public void VerifyTitle2()
        {
            driver = new ChromeDriver();
            String url = "https://www.facebook.com/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);



            System.Console.WriteLine("****************************************");
            System.Console.WriteLine("\r\n");
            Assert.Equal("Facebook - Log In or Sign Up", driver.Title);
            driver.Quit();
        }


        [Fact]
        [Trait("Category", "Parallel")]
        public void VerifyTitle3()
        {
            driver = new ChromeDriver();
            String url = "https://www.facebook.com/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);



            System.Console.WriteLine("****************************************");
            System.Console.WriteLine("\r\n");
            Assert.Equal("Facebook - Log In or Sign Up", driver.Title);
            driver.Quit();
        }


        public void Dispose()
        {
            driver.Quit();
        }

    }
}
