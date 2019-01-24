using System;
using PortfolioStock.Models;
using System.Diagnostics;

namespace PortfolioStock
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("------Inicializando Portafolio de Stocks------");
                Portfolio PortfolioList = new Portfolio();
                PortfolioList.StockList.Add(new Stock(100, DateTime.Now));
                PortfolioList.StockList.Add(new Stock(150, DateTime.Now.AddMonths(1)));
                PortfolioList.StockList.Add(new Stock(200, DateTime.Now.AddMonths(2)));
                PortfolioList.StockList.Add(new Stock(250, DateTime.Now.AddMonths(3)));
                PortfolioList.StockList.Add(new Stock(300, DateTime.Now.AddMonths(4)));
                PortfolioList.StockList.Add(new Stock(350, DateTime.Now.AddMonths(5)));
                PortfolioList.StockList.Add(new Stock(400, DateTime.Now.AddMonths(6)));
                PortfolioList.StockList.Add(new Stock(450, DateTime.Now.AddMonths(7)));
                Console.WriteLine("------Inicialización Completa------");

                Console.WriteLine("\n\n------Llamando a método Profit------");
                //-- Enviamos la fecha actual y la fecha actual mas 3 meses.
                var profit = PortfolioList.Profit(DateTime.Now, DateTime.Now.AddMonths(3));
                Console.WriteLine("     -Profit = " + profit.ToString());

                Console.WriteLine("\n\n------Llamando a método Bonus Track------");
                //-- Obtiene el año 2019
                var annual = PortfolioList.AnnualizedReturn(2019);
                Console.WriteLine("     -Annualized Return 2019 = " + annual.ToString() + "------");
                Console.ReadLine();
            }
            catch (Exception ex)
            {   
                //-- Vemos las innerException
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
