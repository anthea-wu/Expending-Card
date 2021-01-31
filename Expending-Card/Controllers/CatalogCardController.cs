using System;
using System.Collections.Generic;
using System.Linq;
using Expending_Card.Models;
using Microsoft.AspNetCore.Mvc;

namespace Expending_Card.Controllers
{ public class CatalogCardController : Controller
    {
        private readonly List<CatalogCards> _catalogCards = new List<CatalogCards>()
        {
            {new CatalogCards() {CatalogName = "未分類", CatalogOrder = 0}},
            {new CatalogCards() {CatalogName = "食物", CatalogOrder = 1}},
            {new CatalogCards() {CatalogName = "飲料", CatalogOrder = 2}},
            {new CatalogCards() {CatalogName = "交通", CatalogOrder = 3}},
            {new CatalogCards() {CatalogName = "美妝", CatalogOrder = 4}},
            {new CatalogCards() {CatalogName = "學習", CatalogOrder = 5}},
        };

        // GET
        public IActionResult Show()
        {
            ViewBag.list = _catalogCards;
            return View();
        }
        
        [Route("{controller}/show/{name}")]
        public IActionResult ShowOneCard(string name)
        {
            if (_catalogCards.Any(x => x.CatalogName == name))
            {
                var order = _catalogCards.FindIndex(x => x.CatalogName == name);
                ViewBag.card = _catalogCards[order];
            }
            else
            {
                ViewBag.card = _catalogCards[0];    
            }
            
            return View();
        }
    }
}