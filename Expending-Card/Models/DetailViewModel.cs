using System;
using System.Collections.Generic;

namespace Expending_Card.Models
{
    public class DetailList
    {
        public string Detail { get; set; }
        public string Date { get; set; }
        public int Price  { get; set; }
        public Card Card  { get; set; }
        public int Order { get; set; }
    }
    
    public class DetailViewModel
    {
        public List<DetailList> Details { get; set; }

        public void DefaultList()
        {
            Details = new List<DetailList>();
            var card = new Card() {Name = "飲料", Order = 2};
            var detail = new DetailList() {Order = 1, Detail = "冰淇淋奶茶", Card = card, Date = "2021/02/11", Price = 120};
            Details.Add(detail);
        }
    }
}