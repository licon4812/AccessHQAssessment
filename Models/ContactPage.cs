using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessHQAssessment.Models
{
    internal class ContactPage
    {
        private WebDriver driver;

        public ContactPage(WebDriver driver)
        {
            this.driver = driver;
        }

        public bool VerifyErrorText()
        {
            var forename = driver.FindElement(By.Id("forename")).Text.ToLower();
            var email = driver.FindElement(By.Id("email")).Text.ToLower();
            var message = driver.FindElement(By.Id("message")).Text.ToLower();
            if (forename == "Forename is required".ToLower() &&
                email == "Email is Required".ToLower() &&
                message == "Message is required".ToLower()
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void waitForErrorMessages()
        {
            foreach (WebElement currentElement in driver.FindElements(By.ClassName("form-error"))
                )
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(2)).Until(d => 
                    currentElement.Displayed);
            }
        }

        public void EmptySubmit()
        {
            driver.FindElement(By.TagName("form")).Submit();
        }

        public void SubmitForm()
        {
            driver.FindElement(By.Id("forename")).SendKeys("Dan");
            driver.FindElement(By.Id("email")).SendKeys("dan@abc.com");
            driver.FindElement(By.Id("message")).SendKeys("Nice Pizza");
            driver.FindElement(By.TagName("form")).Submit();
        }
    }
}
