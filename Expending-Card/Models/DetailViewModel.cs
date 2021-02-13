using System;
using System.Collections.Generic;
using System.Linq;

namespace Expending_Card.Models
{
    public class DetailData
    {
        public string Detail { get; set; }
        public string Date { get; set; }
        public int Price  { get; set; }
        public Card Card  { get; set; }
        public int Order { get; set; }
    }
    
    public class DetailViewModel
    {
        public List<DetailData> Details { get; set; }

        public DetailViewModel()
        {
            Details = new List<DetailData>();
        }
        
        public void DefaultList()
        {
            Details = new List<DetailData>();
            var card = new Card() {Name = "飲料", Order = 2};
            var detail = new DetailData() {Order = 1, Detail = "冰淇淋奶茶", Card = card, Date = "2021/02/11", Price = 120};
            Details.Add(detail);
        }
        public void AddList(DetailData detail)
        {
            Details.Add(detail);
        }

        public void DeleteList(int order)
        {
            var detail = Details.Single(x => x.Order == order);
            Details.Remove(detail);
        }

        public void UpdateList(DetailData data)
        {
            var old = Details.Single(x => x.Order == data.Order);
            old.Card = data.Card;
            old.Date = data.Date;
            old.Detail = data.Detail;
            old.Price = data.Price;
        }
    }
}