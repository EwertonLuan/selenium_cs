using System;
using System.IO;
using System.Globalization;
using Xunit;
using Microsoft.Extensions.Configuration;
using PrimeService.Tests.PageObjects;
using PrimeService.Tests.Utils;

namespace PrimeService.Tests
{
    public class ShopTest
    {
        private IConfiguration _configuration;
        
        public ShopTest(){
             var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");
            _configuration = builder.Build();
        }
        
        [Theory]
        [InlineData(Browser.Chrome)]
        [InlineData(Browser.Firefox)]
        public void Test1(Browser browser)
        {
            Objects tela =
                new Objects(_configuration, browser);

            tela.CarregarPagina();
            tela.AddNewItem();
            tela.DeletItem();
            
            tela.Fechar();

            
        }
    }
}
