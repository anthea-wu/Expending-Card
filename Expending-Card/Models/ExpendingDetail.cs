namespace Expending_Card.Models
{
    public class ExpendingDetail
    {
        public string ExpendingDate { get; set; }
        public string ExpendingDetails { get; set; }
        public int ExpendingPrice { get; set; }
        public CatalogCards ExpendingCard { get; set; }
    }
}