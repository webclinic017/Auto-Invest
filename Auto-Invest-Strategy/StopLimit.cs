namespace Auto_Invest_Strategy
{
    public class StopLimit
    {
        public int OrderId { get; set; }
        public string Symbol { get; set; }
        public decimal Quantity { get; set; }
        public decimal StopPrice { get; set; }
        public ActionSide Side { get; set; }
    }
}