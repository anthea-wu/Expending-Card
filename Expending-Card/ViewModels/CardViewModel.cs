using System;
using System.Collections.Generic;
using System.Linq;

namespace Expending_Card.Models
{
    public class CardViewModel
    {
        public string CatalogName { get; set; }
        public int CatalogOrder { get; set; }
        public List<CardViewModel> Cards { get; set; }
    
        public void CreateList()
        {
            Cards = new List<CardViewModel>();
        }

        public void AddCardToList(string name, int order)
        {
            Cards.Append(new CardViewModel {CatalogName = name, CatalogOrder = order});
        }
    }
}