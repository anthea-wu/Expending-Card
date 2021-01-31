using System.Collections.Generic;
using Expending_Card.Models;
using Microsoft.AspNetCore.Mvc;

namespace Expending_Card.Controllers
{
    public class CatalogCardController : Controller
    {
        private readonly List<CatalogCards> _catalogCards = new List<CatalogCards>()
        {
            {new CatalogCards() {CatalogName = "食物", CatalogOrder = 1}},
            {new CatalogCards() {CatalogName = "飲料", CatalogOrder = 2}},
            {new CatalogCards() {CatalogName = "交通", CatalogOrder = 3}},
        };

        // GET
        public IActionResult Show()
        {
            ViewBag.list = _catalogCards;
            return View();
        }
    }
}