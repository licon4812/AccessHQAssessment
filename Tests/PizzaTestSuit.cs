using AccessHQAssessment.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AccessHQAssessment.Tests
{
    [TestClass]
    public class PizzaTestSuit
    {
        public ChromeDriver? driver;
        [TestInitialize]
        public void SetUp()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://d2dx8jn5qmn998.cloudfront.net/#/";
            var nav = new Nav(driver);
            nav.NavigateToContactPage();
            
        }
        [TestMethod]
        public void TestSubmitContactForm()
        {
            ContactPage contactPage = new ContactPage(driver);
            contactPage.SubmitForm();

        }

        [TestCleanup]
        public void CleanUp()
        {
            driver?.Quit();
        }
    }
}