using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Expending_Card.Models;
using Microsoft.Extensions.Logging;

namespace Expending_Card.Controllers
{
    public class DetailsController : Controller
    {
        private ILogger<DetailsController> _logger;
        private static readonly DetailViewModel _detail = new DetailViewModel();
        private static readonly CardViewModel _card = new CardViewModel();
        private static readonly ExpendingViewModel _expending = new ExpendingViewModel();
        
        public DetailsController(ILogger<DetailsController> logger)
        {
            _logger = logger;
        }

        private static void InitializeModels()
        {
            _expending.CardViewModel = _card;
            _expending.DetailViewModel = _detail;
        }

        public IActionResult Index()
        {
            InitializeModels();
            if (_card.Cards.Count != 0 && _detail.Details.Count != 0) return View(_expending);
            
            InitializeModels();
            _card.DefaultList();
            _detail.DefaultList();
            return View(_expending);
        }


        private bool IsItemExist(string obj, string condition)
        {
            return obj == "C" ? _card.Cards.Exists(x => x.Name == condition)
                : _detail.Details.Exists(x => x.Order.ToString() == condition);
        }

        public IActionResult Edit()
        {
            InitializeModels();
            
            ViewBag.DetailNextOrder = _detail.Details.Count + 1;
            return View(_expending);
        }

        [HttpPost]
        public IActionResult Delete(string order)
        {
            if (string.IsNullOrEmpty(order) || !IsItemExist("D", order)) return BadRequest("這個明細不存在");
            _detail.DeleteList(Convert.ToInt32(order));
            return Ok("明細刪除成功");
        }
    }
}