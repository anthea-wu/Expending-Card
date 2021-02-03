using System;
using System.Collections.Generic;
using System.Linq;
using Expending_Card.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Expending_Card.Controllers
{ public class CatalogCardController : Controller
    {
        private readonly ILogger<CatalogCardController> _logger;
        private static readonly List<CardsViewModel> _cards = new List<CardsViewModel>();

        public CatalogCardController (ILogger<CatalogCardController> logger) 
        {
            _logger = logger;
        }

        // GET
        public IActionResult Index()
        {
            if (_cards.Count == 0)
            {
                CreateCards("未分類", 1);
            }
            
            return View(_cards);
        }

        [Route("{Controller}/{name}")]
        public IActionResult ShowOneCard(string name)
        {
            if (_cards.All(x => x.CatalogName != name))
            {
                CreateCards(name);
            }

            var showCard = _cards[GetCardOrder(name)];
            return View(showCard);
        }

        [HttpPost]
        public IActionResult AddCards(string name)
        {
            if (_cards.All(x => x.CatalogName != name))
            {
                CreateCards(name);
            }
            else
            {
                var details = "卡片已存在！";
                return RedirectToAction("CardEditError", new {details=details});
            }

            return RedirectToAction("Index");
        }

        public IActionResult CardEditError(string details)
        {
            ViewBag.error = details;
            return View();
        }

        private void CreateCards(string cardName, int cardOrder = -1)
        {
            cardOrder = cardOrder switch
            {
                -1 => _cards.Count + 1,
                _ => cardOrder
            };
            _cards.Add(new CardsViewModel() {CatalogName = cardName, CatalogOrder = cardOrder});
        }

        private int GetCardOrder(string name)
        {
            var order = _cards.FindIndex(x => x.CatalogName == name);
            return order;
        }
    }
}