using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace observer_pattern_netcore
{
    public class StockBar
    {
        private List<Stock> _stocks = new List<Stock>();
        public void AddStock(Stock stock)
        {
            if (_stocks.Contains(stock))
            {
                _stocks.Remove(stock);
            }
            _stocks.Add(stock);
        }
        public void Show()
        {
            Console.WriteLine("===== STOCK LIST =========");
            foreach (var stock in _stocks)
            {
                Console.WriteLine("STOCK BAR:" + stock);
            }
            Console.WriteLine("==========================");
        }
    }
}