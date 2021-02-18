using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumYoutube
{
    public class Program
    {
        public IWebDriver driver;

        static void Main(string[] args)
        {
                      
        }

        [SetUp]
        public void Initialize()
        {
            //create a reference for our browser
            driver = new ChromeDriver();

            //Navigate to Google page
            //driver.Navigate().GoToUrl("http://www.google.com");
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");
        }

        [Test]
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");

            //Click
            SeleniumSetMethods.Click(driver, "Save", "Name");
        }

        //[TearDown]
        public void Dispose()
        {
            //Dispose
            driver.Close();
        }
    }
}
