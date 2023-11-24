using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            // this path will be change based on your local path
            driver = new ChromeDriver("C:\\Users\\rajku\\source\\repos\\TestProject1\\bin\\Debug\\net6.0\\chromedriver.exe");
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://www.google.com/";

            // we can write code to find the elements using XPath


            driver.Quit();
        }
    }
}
