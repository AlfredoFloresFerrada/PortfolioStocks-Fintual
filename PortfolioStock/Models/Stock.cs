using System;

namespace PortfolioStock.Models
{
    class Stock
    {
        public readonly decimal p_Price;
        public readonly DateTime PriceDate;

        public Stock(decimal price, DateTime priceDate)
        {
            p_Price = price;
            PriceDate = priceDate;
        }

        public decimal Price(DateTime priceDate)
        {
            return p_Price;
        }
    }
}
