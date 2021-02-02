﻿using System;
using System.Collections.Generic;
using System.Linq;
using Expending_Card.Models;
using Microsoft.AspNetCore.Mvc;

namespace Expending_Card.Controllers
{ public class CatalogCardController : Controller
    {
        private List<CardsViewModel> _cards = new List<CardsViewModel>();

        // GET
        public IActionResult Index()
        {
            if (_cards.Count == 0)
            {
                GenerateCards("未分類", 0);
            }
            
            return View(_cards);
        }

        [Route("{Controller}/{name}")]
        public IActionResult ShowOneCard(string name)
        {
            if (_cards.All(x => x.CatalogName != name))
            {
                var cardOrder = _cards.Count + 1;
                GenerateCards(name, cardOrder);
            }

            var showCard = _cards[GetCardOrder(name)];
            return View(showCard);
        }

        private void GenerateCards(string cardName, int cardOrder)
        {
            _cards.Add(new CardsViewModel() {CatalogName = cardName, CatalogOrder = cardOrder});
        }

        private int GetCardOrder(string name)
        {
            var order = _cards.FindIndex(x => x.CatalogName == name);
            return order;
        }
    }
}