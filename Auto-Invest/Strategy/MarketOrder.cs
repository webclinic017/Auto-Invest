﻿namespace Auto_Invest.Strategy
{
    public class MarketOrder
    {
        public string Symbol { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal Quantity { get; set; }
    }
}