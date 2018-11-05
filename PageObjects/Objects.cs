using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PrimeService.Utils;

namespace PrimeService.PageObjects
{
    public class Objects
    {
        private IWebDriver _driver = new ChromeDriver();
        public void CarregarPagina()
        {
            _driver.LoadPage("https://ewertonluan.github.io/curso_JavaScript/");
            
        }
        public void AddNewItem(){
            
            _driver.SetText(By.Id("desc"),"Camisa", "Description");
            _driver.SetText(By.Id("amount"),"13", "Amount");
            _driver.SetText(By.Id("value"),"12", "Value");
            _driver.ClickButton(By.Id("add"),"Add");
            _driver.ErroAdd();
        }
        public void DeleteItem(){
            _driver.DeleteButton(1);
        }
        public void Fechar()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}