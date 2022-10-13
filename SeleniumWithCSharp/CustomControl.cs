using System;
using OpenQA.Selenium;

namespace SeleniumWithCSharp
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBoxControl(string controlName, string value) {

            IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboControl.Clear();
            comboControl.SendKeys(value);
            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();


        }
    }
}

