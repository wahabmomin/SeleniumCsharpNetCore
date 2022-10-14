using System;
using OpenQA.Selenium;

namespace SeleniumWithCSharp.Pages
{
    public class LoginPage : DriverHelper
    {
        IWebElement txtuserName => Driver.FindElement(By.Id("UserName"));
        IWebElement txtpassword => Driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => Driver.FindElement(By.CssSelector(".btn-default"));

       

        public void EnterUserNamePassword(string userName, string password) {

            txtuserName.SendKeys(userName);
            txtpassword.SendKeys(password);

        }

        public void ClickLoginbtn() {

            btnLogin.Click();
        }
    }
}

