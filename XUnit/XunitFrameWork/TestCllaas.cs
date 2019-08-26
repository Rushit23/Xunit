using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace XunitFrameWork
{
   public class TestCllaas : IDisposable
    {



        IWebDriver driver;


        /*********************          Getting Output From Console  *************************/



        private readonly ITestOutputHelper output;



        public TestCllaas(ITestOutputHelper output)
        {
            this.output = output;
        }

        // output.WriteLine();




                        /************************  ATTRIBUTES ****************************/




        [Fact]
        public void VerifyTitle ()
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




        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0, 1)]
        public void Add_with_values(int first, int second, int expectedResult)
        {
            var result = Add(first, second);

            Assert.Equal(expectedResult, result);
        }

        private object Add(int first, int second)
        {
            throw new NotImplementedException();
        }





        /************************** DATA Driven Tests  ***************************/



        public static IEnumerable<object[]> LoginTestData
        {
            get
            {
                List<object[]> testData = new List<object[]>();

                testData.Add(new object[] { "abc@gmail.com", "abcd" });
                testData.Add(new object[] { ("abd@gmail.com", "bbcd") });

                return testData;
            }
        }







        [Theory]
        [MemberData(nameof(LoginTestData))]
        public void FacebookTest(String UN, String PS)
        {
            IWebDriver driver = new ChromeDriver();
            String url = "https://www.facebook.com/";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            var UserName = driver.FindElement(By.Id("email"));
            var Password = driver.FindElement(By.Id("pass"));
            IWebElement btn = driver.FindElement(By.CssSelector("#u_0_2"));



            UserName.SendKeys(UN);
            Password.SendKeys(PS);
            btn.Submit();

            Assert.Equal("Log into Facebook | Facebook", driver.Title);
        }











        public void Dispose()
        {
            driver.Quit();
        }






    }
}
