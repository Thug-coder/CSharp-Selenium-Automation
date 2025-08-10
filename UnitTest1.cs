using Automation_Selenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net;

namespace Automation_Selenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LoginTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            driver.Manage().Window.Maximize ();

            Page_for_Login loginPage = new Page_for_Login(driver);

            loginPage.ClickLogin();
            loginPage.SendUsernamePassword("admin", "password");
            loginPage.ClickLoginBtn();

        }
    }
}