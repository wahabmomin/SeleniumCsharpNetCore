using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWithCSharp
{
   
    public class DriverHelper
    {
        [SetUp]
        public void Setup()
        {

            Driver = new ChromeDriver();
        }
        public static IWebDriver Driver { get; set; }
        
    }
}