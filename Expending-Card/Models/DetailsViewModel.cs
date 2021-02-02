namespace Expending_Card.Models
{
    public class DetailsViewModel
    {
        public string ExpendingDate { get; set; }
        public string ExpendingDetails { get; set; }
        public int ExpendingPrice { get; set; }
        public CardsViewModel ExpendingCard { get; set; }
    }
}