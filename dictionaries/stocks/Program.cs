using System;
using System.Collections.Generic;

namespace stocks
{
    public class StockInfo
    {
        public string name { get; set; }
        public List<double> purchases { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        //Advanced Challenge: Stock Purchase Report
        //A block of publicly traded stock has a variety of attributes, we'll look at a few of them. A stock has a ticker symbol and a company name. Create a simple dictionary with ticker symbols and company names in the Main method
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("TNAH", "The Neopian Auction House");
            stocks.Add("TAG", "The Auction Genie");
            stocks.Add("HUW", "Huberts Hot Dogs");

        //Next, create a data structure to record how many stock purchases were made for each company over time. In this Dictionary, the key will be the ticker symbol, and the value will be a collection of numbers representing how much the investor paid.

            Dictionary<string, List<double>> purchases = new Dictionary<string, List<double>>();

        //Once you've determined how to define the data structure, you need to add purchases for a few companies. Start with three companies, and 1-3 purchases for each one

            purchases.Add("GM", new List<double>(){ 1214.90, 2881.95 });
            purchases.Add("CAT", new List<double>(){ 4892.12 });
            purchases.Add("TNAH", new List<double>(){ 16000.00, 15000.00 });
            purchases.Add("TAG", new List<double>(){ 15000.00, 15000.00, 15000.00 });
            purchases.Add("HUW", new List<double>(){ 64000.00 });    

        //Once you've added your stocks and purchases, produce a total ownership report that computes the total amount of money spent by the investor on each stock

            foreach (KeyValuePair<string, string> stock in stocks) 
            {
                double total = 0;
                foreach (KeyValuePair<string, List<double>> purchase in purchases)
                {
                    if (stock.Key == purchase.Key) {
                        for (var i=0; i < purchase.Value.Count; i++)
                        {
                            total = total + purchase.Value[i];
                        }
                        Console.WriteLine($"Investor has spent a total of {total} on the stock for {stock.Value}");
                    }
                }
            }
        
        // personal experimenting with building data a different way
        // created an object type 'StockInfo' to hold key value pairs with values of different types
        
            Console.WriteLine();

            Dictionary<string, StockInfo> portfolio = new Dictionary<string, StockInfo>();

            portfolio.Add("GM", new StockInfo { name = "General Motors", purchases = new List<double>() { 1214.90, 2881.95 }});
            portfolio.Add("CAT", new StockInfo { name = "Caterpillar", purchases = new List<double>() { 4892.12 }});        
            portfolio.Add("TNAH", new StockInfo { name = "The Neopian Auction House", purchases = new List<double>() { 16000.00, 15000.00 }});        
            portfolio.Add("TAG", new StockInfo { name = "The Auction Genie", purchases = new List<double>() { 15000.00, 15000.00, 15000.00 }});        
            portfolio.Add("HUW", new StockInfo { name = "Huberts Hot Dogs", purchases = new List<double>() { 64000.00 }});
        
            foreach (KeyValuePair<string, StockInfo> stock in portfolio)         
            {
                double total = 0;
                for (var i = 0; i < stock.Value.purchases.Count; i++)
                {
                    total = total + stock.Value.purchases[i];
                }
                Console.WriteLine($"Investor has spent a total of {total} on the stock for {stock.Value.name}");
            }
        }        
    }
}
