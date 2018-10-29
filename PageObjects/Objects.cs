using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using PrimeService.Tests.Utils;

namespace PrimeService.Tests.PageObjects
{
    public class Objects
    {
        private IWebDriver _driver;
        private Browser _browser;
        private IConfiguration _configuration;

        public Objects(
            IConfiguration configuration, Browser browser)
        {
            _configuration = configuration;
            _browser = browser;

            string caminhoDriver = null;
            if (browser == Browser.Firefox)
            {
                caminhoDriver =
                    _configuration.GetSection("Selenium:CaminhoDriverFirefox").Value;
            }
            else if (browser == Browser.Chrome)
            {
                caminhoDriver =
                    _configuration.GetSection("Selenium:CaminhoDriverChrome").Value;
            }

            _driver = WebDriverFactory.CreateWebDriver(
                browser, caminhoDriver, true);
        }
        public void CarregarPagina()
        {
            _driver.LoadPage(_configuration.GetSection("Selenium:UrlTelaConversaoDistancias").Value);
        }

        public void AddNewItem(){
            
            _driver.SetText(By.Id("desc"),"Camisa");
            _driver.SetText(By.Id("amount"),"13");
            _driver.SetText(By.Id("value"),"12");
            _driver.ClickButtom(By.Id("add"));
        }

        public void DeletItem(){
            _driver.DeletButtom(1);
        }
        public void Fechar()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}