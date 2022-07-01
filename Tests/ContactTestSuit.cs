using AccessHQAssessment.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AccessHQAssessment.Tests
{
    [TestClass]
    public class ContactTestSuit
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

        /*I was unable to run tests on my machine. From here I would ensure that all tests work
          and then I would start refactoring the test to excecute the steps from a ContactPage model
        via lambdas and then I would refactor further by creating a ContactFormClass.
        */
        [TestMethod]
        public void TestSubmitContactForm()
        {
            ContactPage contactPage = new ContactPage(driver);
            contactPage.waitForErrorMessages();
            contactPage.EmptySubmit();
            contactPage.VerifyEmptyErrorMessages();
            contactPage.SubmitForm();

            //assert that all the error messages are empty and that the form submitted successfully
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}