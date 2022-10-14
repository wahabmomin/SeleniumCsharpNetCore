﻿using System;
using OpenQA.Selenium;

namespace SeleniumWithCSharp.Pages
{
    public class LoginPage : DriverHelper
    {
        IWebElement txtuserName => Driver.FindElement(By.Id("UserName"));
        IWebElement txtpassword => Driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => Driver.FindElement(By.Name("Login"));

       

        public void EnterUserNamePassword(string userName, string password) {

            txtuserName.SendKeys(userName);
            txtpassword.SendKeys(password);

        }

        public void ClickLogin() {

            btnLogin.Click();
        }

        internal void EnterUserNamePassword()
        {
            throw new NotImplementedException();
        }
    }
}

