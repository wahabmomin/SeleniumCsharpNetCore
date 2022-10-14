using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithCSharp.Pages;

namespace SeleniumWithCSharp;

public class Tests : DriverHelper
{

    [Test]
    public void Test1()
    {
        Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

        //CustomControl.EnterText(Driver.FindElement(By.Id("ContentPlaceHolder1_AllMealsCombo")), "Mango");
        //Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

        CustomControl.SelectByText(Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Cauliflower");

        CustomControl.ComboBoxControl("ContentPlaceHolder1_AllMealsCombo", "Almonds");

        Assert.Pass();
    }

    public void LoginTest() {

        Driver.Navigate().GoToUrl("https://eaapp.somee.com");

        HomePage homePage = new HomePage();
        LoginPage loginPage = new LoginPage();


        homePage.clickLogin();
        loginPage.EnterUserNamePassword();



    }
}