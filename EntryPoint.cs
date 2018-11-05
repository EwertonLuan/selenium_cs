using System;
using System.IO;
using System.Globalization;
using Microsoft.Extensions.Configuration;
using PrimeService.PageObjects;
using PrimeService.Utils;

namespace PrimeService
{
    class EntryPoint
    {

        static void Main(){
            
            automation_selenium();
            
        }

        public static void  automation_selenium()
        {
            Objects tela = new Objects();

            tela.CarregarPagina();
            tela.AddNewItem();
            tela.DeleteItem();            
            tela.Fechar();            
        }
    }
}
