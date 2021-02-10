using System;
using System.Collections.Generic;

namespace Expending_Card.Models
{
    public class DetailList
    {
        public string Detail { get; set; }
        public DateTime Date { get; set; }
        public int Price  { get; set; }
        public Card Card  { get; set; }
    }
    
    public class DetailViewModel
    {
        public List<DetailList> Details { get; set; }
    }
}