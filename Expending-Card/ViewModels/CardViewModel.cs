using System;
using System.Collections.Generic;
using System.Linq;

namespace Expending_Card.Models
{
    public class Card
    {
        public int Order { get; set; }
        public string Name { get; set; }
    }

    public class CardViewModel
    {
        public List<Card> Cards { get; set; }

        public void DefaultList()
        {
            var card = new Card() {Order = 1, Name = "未分類"};
            Cards.Add(card);
        }

        public void AddList(int order, string name)
        {
            var card = new Card() {Order = order, Name = name};
            Cards.Add(card);
        }
        
        public void UpdateList(string oldName, string newName)
        {
            var updateCard = Cards.Single(x => x.Name == oldName);
            updateCard.Name = newName;
        }
        
    }
}