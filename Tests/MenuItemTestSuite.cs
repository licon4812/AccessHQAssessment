using AccessHQAssessment.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessHQAssessment.Tests
{
    [TestClass]
    internal class MenuItemTestSuite
    {
        public ChromeDriver driver;
        [TestInitialize]
        public void SetUp()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://d2tjwct0w5ff76.cloudfront.net/#/";
            var nav = new Nav(driver);
            nav.NavigateToMenuPage();
        }


        /*I was unable to run tests on my machine. From here I would ensure that all tests work
          and then I would start refactoring the test to excecute the steps from a MenuItemPage model
        via lambdas and then I would refactor further by creating a MenuItemClass.
        */
        [TestMethod]
        public void TestMenuItemRaitings()
        {
            var tabs = driver.FindElements(By.ClassName("v-tab"));
            foreach(WebElement tab in tabs)
            {
                if(tab.Text.ToLower() == "drinks")
                {
                    tab.Click();
                }
            }
            var drink = driver.FindElement(By.ClassName("rating-0"));
            drink.FindElement(By.CssSelector("aria-label='Rating 3 of 5'")).Click();
            //verify if drink is still zero
            //if the drink is still zero then login
            driver.FindElement(By.ClassName("nav-login-signup")).Click();
            driver.FindElement(By.Name("gen-20220701-username")).SendKeys("bob");
            driver.FindElement(By.Name("gen-20220701-password")).SendKeys("ilovepizza");
            driver.FindElement(By.CssSelector("button[aria-label='login']")).Click();

            drink = driver.FindElement(By.ClassName("rating-0"));
            drink.FindElement(By.CssSelector("aria-label='Rating 3 of 5'")).Click();

            //make an assertion that the drink that had a 0 star rating now has a 3 star rating

        }
    }
}
