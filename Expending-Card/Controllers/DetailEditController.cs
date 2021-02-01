using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Expending_Card.Controllers;
using Expending_Card.Models;

namespace Expending_Card.Controllers
{
    public class DetailEditController : Controller
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
        
        private static readonly List<ExpendingDetail> _expendingDetails = new List<ExpendingDetail>()
        {
            new ExpendingDetail()
            {
                ExpendingDate = "2021/02/01",
                ExpendingDetails = "冰淇淋奶茶",
                ExpendingCard = new CatalogCards() {CatalogName = "飲料", CatalogOrder = 1},
                ExpendingPrice = 120
            },
            new ExpendingDetail()
            {
                ExpendingDate = "2021/02/01",
                ExpendingDetails = "口紅膠",
                ExpendingCard = new CatalogCards() {CatalogName = "學習", CatalogOrder = 2},
                ExpendingPrice = 12
            }
        };
        
        public ActionResult AllDetails()
        {
            ViewBag.list = _expendingDetails;
            return View();
        }

        [Route("{card}/{detail}/{price}/{date}")]
        public IActionResult AddDetails(string card, string detail, int price, string date)
        {
            CatalogCards catalogCard = null;
            var findIndex = _catalogCards.FindIndex(x => x.CatalogName == card);
            catalogCard = findIndex != -1 ? _catalogCards[findIndex] : _catalogCards[0];

            var newItem = new ExpendingDetail()
            {
                ExpendingCard = catalogCard,
                ExpendingDate = date,
                ExpendingDetails = detail,
                ExpendingPrice = price
            };
            
            _expendingDetails.Add(newItem);

            ViewBag.list = newItem;
            return View();
        }
    }
}