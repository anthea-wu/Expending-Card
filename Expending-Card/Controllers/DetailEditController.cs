using System.Collections.Generic;
using Expending_Card.Models;
using Microsoft.AspNetCore.Mvc;

namespace Expending_Card.Controllers
{
    public class DetailEditController : Controller
    {
        private List<ExpendingDetail> _expendingDetails = new List<ExpendingDetail>()
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
            
        // GET
        public IActionResult AllDeteails()
        {
            ViewBag.list = _expendingDetails;
            return View();
        }
    }
}