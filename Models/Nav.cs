using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AccessHQAssessment.Models
{
    internal class Nav
    {
        private WebDriver driver;

        public Nav(WebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToContactPage()
        {
            driver.FindElement(By.CssSelector("[href='#/contact']")).Click();
        }
    }
}