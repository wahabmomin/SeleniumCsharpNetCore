using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWithCSharp;

public class Tests : DriverHelper
{

    [Test]
    public void Test1()
    {
        Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

        Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
        Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

        
        CustomControl.ComboBoxControl("ContentPlaceHolder1_AllMealsCombo", "Almonds");
                    
        Console.WriteLine("Test1");
        Assert.Pass();
    }
}
