using System;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioStock.Models
{
    class Portfolio
    {
        public List<Stock> StockList;

        public Portfolio()
        {
            StockList = new List<Stock>();
        }

        public decimal Profit(DateTime BeginDate, DateTime EndDate)
        {
            var profit = StockList.Where(x => x.PriceDate.Date >= BeginDate.Date && x.PriceDate.Date <= EndDate.Date)
              .Sum(x => x.p_Price);
            return profit;
        }

        public decimal AnnualizedReturn(int Year)
        {
            var annual = StockList.Where(x => x.PriceDate.Date.Year == Year)
              .Sum(x => x.p_Price);
            return annual;
        }
    }
}