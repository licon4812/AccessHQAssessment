using AccessHQAssessment.Models;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessHQAssessment.Tests
{
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

        [TestMethod]
        public void TestMenuItemRaitings()
        {

        }
    }
}
