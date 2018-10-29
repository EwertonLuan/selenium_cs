using OpenQA.Selenium;
using System;

namespace PrimeService.Tests.Utils
{
    public static class WebDriverExtensions
    {
        public static void LoadPage(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void SetText(this IWebDriver driver, By by, string text)
        {
            IWebElement webElement =  driver.FindElement(by);
            webElement.SendKeys(text);
        }

        public static void ClickButtom(this IWebDriver driver,By by){
            
            IWebElement webElement = driver.FindElement(by);
            webElement.Click();

        }
        public static void DeletButtom(this IWebDriver driver, int linha ){
            int linha_ = linha;
            string cssSelector = $"#listTable > tbody:nth-child(2) > tr:nth-child({linha}) > td:nth-child(4) > button:nth-child(1)";
            
            IWebElement webElement = driver.FindElement(By.CssSelector(cssSelector));
            webElement.Click();

        }
        
    }
}