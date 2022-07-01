using AccessHQAssessment.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AccessHQAssessment.Tests
{
    [TestClass]
    public class PizzaTestSuit
    {
        public ChromeDriver driver;
        [TestInitialize]
        public void SetUp()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://d2tjwct0w5ff76.cloudfront.net/#/";
            var nav = new Nav(driver);
            nav.NavigateToContactPage();
            
        }
        [TestMethod]
        public void TestSubmitContactForm()
        {
            ContactPage contactPage = new(driver);
            contactPage.SubmitForm();
            contactPage.waitForErrorMessages();
            contactPage.EmptySubmit();
            

        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}