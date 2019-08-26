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
    public class Annotations
    {

        // Ignoring Tests

        [Fact(Skip = "Thats how you ignore a test")]
        public void ToIgnore()
        {
            Assert.False(true);
        }





        /******************************* ASSERT ***********************************/

        [Fact]
        public void MyTest1()
        {
            Assert.True(true);
        }

        public void Assserts()
        {
            Assert.Equal(1, 1);

            Assert.Equal("London", "London");

            Assert.StartsWith("Lon", "London");
            Assert.EndsWith("on", "London");

            Assert.Contains("Lon", "London");
            Assert.DoesNotContain("Bern", "London");

            Assert.Empty(new List<int>());
            Assert.NotEmpty(new List<int>() { 1, 2, 3 });

            Assert.True(1 == 1);
            Assert.False(1 == 2);

            Assert.Null(null);
            Assert.NotNull("a");

            //     Exception ex = Assert.Throws<ArgumentNullException>(() => MyMethod());


            Assert.InRange(5, 1, 10);
            Assert.NotInRange(-1, 0, 10);


        }


        [Fact]
        [Trait("Category", "Parallel")]
        public void VerifyTitle()
        {
           IWebDriver driver = new ChromeDriver();
            String url = "https://www.facebook.com/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);



            System.Console.WriteLine("****************************************");
            System.Console.WriteLine("\r\n");
            Assert.Equal("Facebook - Log In or Sign Up", driver.Title);
            driver.Quit();
        }







    }
}
