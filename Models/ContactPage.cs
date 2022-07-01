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

        /*As I was unable to run tests I couldn't check the code logic.If I was able to check
        the logic I would have refacted all the messy logic into a strategy pattern that
        fires off functions from a ContactFormClass*/
        
        public bool VerifyErrorText()
        {

            /*I would have refactored this down to a couple of line by doing all the fetching
              of the error elements in a loop from a ContactFormClass wrapped inside of a wait
            function to wait for the elements to appear.
            */
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

        /*I would have refactored this down to a couple of line by doing all the fetching
              of the error elements in a loop from a ContactFormClass wrapped inside of a wait
            function to wait for the elements to appear. and check if they are empty
            */

        public bool VerifyEmptyErrorMessages()
        {
            var forename = driver.FindElement(By.Id("forename")).Text.ToLower();
            var email = driver.FindElement(By.Id("email")).Text.ToLower();
            var message = driver.FindElement(By.Id("message")).Text.ToLower();
            if (forename == "Forename is required".ToLower() &&
                email == "".ToLower() &&
                message == "".ToLower()
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*I would have refactored this down to a couple of line by waiting for the
         error elements in a loop from a ContactFormClass
            */
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
