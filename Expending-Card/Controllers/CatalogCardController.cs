using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Expending_Card.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Expending_Card.Controllers
{ public class CatalogCardController : Controller
    {
        private readonly ILogger<CatalogCardController> _logger;
        public static CardViewModel _card = new CardViewModel();
        public static DetailViewModel _detail = new DetailViewModel();
        private static readonly ExpendingViewModel _expending = new ExpendingViewModel();
            
        public CatalogCardController (ILogger<CatalogCardController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (_card.Cards.Count != 0)
            {
                GetCurrentModels();
                return View(_card);
            }
            
            InitializeModels();
            GetCurrentModels();
            _card.DefaultList();
            return View(_card);
        }

        public IActionResult Card(string name)
        {
            if (!IsCardExist(name)) return BadRequest("卡片不存在，請利用新增功能增加該卡片");
            
            InitializeModels();
            GetCurrentModels();
            ViewBag.ShowCard = _card.Cards.Single(x => x.Name == name);
            return View(_expending);

        }

        public IActionResult EditCard()
        {
            return View(_card);
        }

        [HttpPost]
        public IActionResult AddCard([FromForm]string name)
        {
            if (string.IsNullOrEmpty(name)) return BadRequest("欄位不得為空");
            if (IsCardExist(name)) return BadRequest("卡片已存在");
            
            _card.AddCard(_card.Cards.Count + 1, name);
            return Ok("卡片新增成功");
        }

        [HttpPost]
        public IActionResult DeleteCard([FromForm]string name)
        {
            if (string.IsNullOrEmpty(name)) return BadRequest("欄位不得為空");
            if (!IsCardExist(name)) return BadRequest("卡片不存在");
            
            _card.DeleteCard(name);
            return Ok("卡片刪除成功");

        }

        [HttpPost]
        public IActionResult UpdateCardName([FromForm]string oldName, string newName)
        {
            if (string.IsNullOrEmpty(oldName) || string.IsNullOrEmpty(newName)) return BadRequest("欄位不得為空");
            if (!IsCardExist(oldName)) return BadRequest("要修改的卡片不存在");
            if (IsCardExist(newName)) return BadRequest("修改後的卡片名稱已存在");
            
            _card.UpdateCardName(oldName, newName);
            return Ok("卡片名稱修改成功");
        }

        [HttpPost]
        public IActionResult AddCardForDetail(string name)
        {
            _card.AddCard(_card.Cards.Count + 1, name);
            return Ok();
        }

        [HttpPost]
        public IActionResult GetCardsOrder()
        {
            return Ok(_card.Cards.Count + 1);
        }

        private static void InitializeModels()
        {
            _expending.CardViewModel = _card;
            _expending.DetailViewModel = _detail;
        }

        private void GetCurrentModels()
        {
            _detail = DetailsController._detail;
            _card = DetailsController._card;
        }

        private static bool IsCardExist(string name)
        {
            return _card.Cards.Any(x => x.Name == name);
        }
    }
}