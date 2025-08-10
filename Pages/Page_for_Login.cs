using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Selenium.Pages
{   
    public class Page_for_Login
    {
        private readonly IWebDriver driver;
        public Page_for_Login(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement LoginLink => driver.FindElement(By.Id("loginLink"));
        IWebElement TxtUsername => driver.FindElement(By.Id("UserName"));
        IWebElement TxtPassword => driver.FindElement(By.Id("Password"));
        IWebElement BtnLogin => driver.FindElement(By.Id("loginIn"));

        public void ClickLogin()
        {
            LoginLink.Click();
        }

        public void SendUsernamePassword(string Username, string Password)
        {
            TxtUsername.SendKeys(Username);
            TxtPassword.SendKeys(Password);
        }

        public void ClickLoginBtn()
        {
            BtnLogin.Click();
        }
    }
}
