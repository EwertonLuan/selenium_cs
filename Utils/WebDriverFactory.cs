using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace PrimeService.Tests.Utils
{
    public class WebDriverFactory
    {
         public static IWebDriver CreateWebDriver(
            Browser browser, string pathDriver, bool headless)
        {
            IWebDriver webDriver = null;

            switch (browser)
            {
                case Browser.Firefox:
                    FirefoxOptions optionsFF = new FirefoxOptions();
                    if (headless)
                        optionsFF.AddArgument("--headless");
                    
                    webDriver = new FirefoxDriver(pathDriver, optionsFF);

                    break;
                case Browser.Chrome:
                    ChromeOptions options = new ChromeOptions();
                    
                    webDriver = new ChromeDriver(pathDriver);
                    
                    break;
            }

            return webDriver;
        }
        
    }
}