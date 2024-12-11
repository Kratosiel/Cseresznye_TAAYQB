using System;
using System.Collections.Generic;

namespace CseresznyeWebApp.Stocks
{
    public partial class Ibmprice
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public decimal? OpenPrice { get; set; }
        public decimal? HighPrice { get; set; }
        public decimal? LowPrice { get; set; }
        public decimal? ClosePrice { get; set; }
        public long? Volume { get; set; }
    }
}
