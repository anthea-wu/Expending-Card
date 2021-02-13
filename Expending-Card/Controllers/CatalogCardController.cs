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
        private static readonly CardViewModel _card = new CardViewModel();
        private static readonly DetailViewModel _detail = new DetailViewModel();
        private static readonly ExpendingViewModel _expending = new ExpendingViewModel();
            
        public CatalogCardController (ILogger<CatalogCardController> logger)
        {
            _logger = logger;
        }
        
        // GET

        private static void InitializeModels()
        {
            _expending.CardViewModel = _card;
            _expending.DetailViewModel = _detail;
        }

        public IActionResult Index()
        {
            InitializeModels();
            if (_card.Cards.Count != 0) return View(_card);
            
            _card.DefaultList();
            return View(_card);
        }

        public IActionResult Card(string name)
        {
            if (!IsCardExist(name)) return BadRequest("卡片不存在，請利用新增功能增加該卡片");
            
            var showCard = _card.Cards.Single(x => x.Name == name);
            return View(showCard);

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

        private static bool IsCardExist(string name)
        {
            return _card.Cards.Any(x => x.Name == name);
        }
    }
}