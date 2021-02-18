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
            var card = new Card() {Name = "飲料", Order = 1};
            var detail1 = new DetailData() {Order = 1, Detail = "牛奶", Card = card, Date = "2021/02/13", Price = 89};
            Details.Add(detail1);
            var detail2 = new DetailData() {Order = 2, Detail = "花生", Card = new Card() {Name = "食物", Order = 2}, Date = "2021/02/14", Price = 200};
            Details.Add(detail2);
            var detail3 = new DetailData() {Order = 3, Detail = "火車", Card = new Card() {Name = "交通", Order = 3}, Date = "2021/02/14", Price = 100};
            Details.Add(detail3);
            var detail4 = new DetailData() {Order = 4, Detail = "奶茶", Card = card, Date = "2021/02/15", Price = 66};
            Details.Add(detail4);
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
        
        public void AscOrder(string orderBasic)
        {
            switch (orderBasic)
            {
                case "order":
                    Details = Details.OrderBy(x => x.Order).ToList();
                    break;
                case "card":
                    Details = Details.OrderBy(x => x.Card.Order).ToList();
                    break;
                case "price":
                    Details = Details.OrderBy(x => x.Price).ToList();
                    break;
                case "date":
                    Details = Details.OrderBy(x => x.Date).ToList();
                    break;
            }
        }

        public void DescOrder(string orderBasic)
        {
            switch (orderBasic)
            {
                case "order":
                    Details = Details.OrderByDescending(x => x.Order).ToList();
                    break;
                case "card":
                    Details = Details.OrderByDescending(x => x.Card.Order).ToList();
                    break;
                case "price":
                    Details = Details.OrderByDescending(x => x.Price).ToList();
                    break;
                case "date":
                    Details = Details.OrderByDescending(x => x.Date).ToList();
                    break;
            }
        }
    }
}