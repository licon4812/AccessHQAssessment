using OpenQA.Selenium;
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

        /*public bool VerifyErrorText()
        {
            //var forenameErrorMessage = driver.get
        }*/

        public void SubmitForm()
        {
            driver.FindElement(By.CssSelector("[aria-label='submit']")).Click();
        }
    }
}
