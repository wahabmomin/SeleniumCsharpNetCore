using System;
using OpenQA.Selenium;

namespace SeleniumWithCSharp.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));

        public void clickLogin() => lnkLogin.Click();

    }
}

