namespace Cenium.Pos.Test
{
    //[Serializable, XmlRoot("WebTransactionLine")]
    public class WebTransactionLine
    {
        public string ExternalItemId { get; set; }
        public string ExternalItemName { get; set; }
        public string ExternalItemDescription { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public string UnitOfMeasureName { get; set; }
        public decimal UnitPriceExcludingTax { get; set; }
        public decimal TaxAmount { get; set; }
        public string TaxCode { get; set; }
        public decimal TaxPercentage { get; set; }
    }
}