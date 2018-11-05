using OpenQA.Selenium;
using System;

namespace PrimeService.Utils
{
    public static class WebDriverExtensions
    {
        public static void LoadPage(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void SetText(this IWebDriver driver, By by, string text, string name)
        {
            try
            {
                IWebElement webElement =  driver.FindElement(by);
                webElement.SendKeys(text);
            }catch(NoSuchElementException)
            {
                RedMessage($"Field {name} not found");
            }
        }

        public static void ClickButton(this IWebDriver driver,By by, string name)
        {
            
            try
            {
                IWebElement webElement = driver.FindElement(by);
                webElement.Click();
                GreenMessage($"✓ {name} Button ");
            } catch(NoSuchElementException)
            {
                RedMessage($"Button not found {name}");
            }           
        }

        public static void ErroAdd(this IWebDriver driver)
        {
            try
            {

                string cssSelector = "#erro >h3";
                IWebElement webElement = driver.FindElement(By.CssSelector(cssSelector));
                if(webElement.Displayed)
                {
                    webElement = driver.FindElement(By.Id("erro"));
                    RedMessage(webElement.Text);
                }

            } catch(NoSuchElementException)
            {
                GreenMessage($"✓ Add Success ");
            }

        }
        public static void DeleteButton(this IWebDriver driver, int linha )
        {
            int linha_ = linha;
            string cssSelector = $"#listTable > tbody:nth-child(2) > tr:nth-child({linha}) > td:nth-child(4) > button:nth-child(1)";
            
            try
            {                
                IWebElement webElement = driver.FindElement(By.CssSelector(cssSelector));
                webElement.Click();
                GreenMessage("✓ Delete Button");

            }catch(NoSuchElementException)
            {
                RedMessage("X Delete button");
            }


        }
        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;

        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
 