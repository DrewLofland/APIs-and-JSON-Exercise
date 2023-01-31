using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 5; i++)
            {
                GetQuotes.KanyeQuote();

                GetQuotes.RonQuote();
            }
        }

    }
            
}
