using System;
using OpenQA.Selenium;

namespace SeleniumWithCSharp.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));

        IWebElement lnkLogOff => Driver.FindElement(By.LinkText("Log Off"));

        public void clickLogin() => lnkLogin.Click();

        public bool IsLogOffExist() => lnkLogOff.Displayed;

    }
}

