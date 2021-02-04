using System;
using System.Collections.Generic;
using System.Linq;
using Expending_Card.Models;
using Expending_Card.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Expending_Card.Controllers
{ public class CatalogCardController : Controller
    {
        private readonly ILogger<CatalogCardController> _logger;
        private static readonly List<CardsViewModel> _cards = new List<CardsViewModel>();
        private ErrorPageViewModel _errorPage = new ErrorPageViewModel();
            
        public CatalogCardController (ILogger<CatalogCardController> logger) 
        {
            _logger = logger;
        }

        // GET
        public IActionResult Index()
        {
            if (_cards.Count == 0)
            {
                CreateCards("未分類");
            }
            
            return View(_cards);
        }

        [Route("{Controller}/{name}")]
        public IActionResult ShowOneCard(string name)
        {
            if (!IsCardExist(name))
            {
                SetErrorDetails("顯示", "卡片不存在，請利用新增功能增加該卡片");
                return RedirectToAction("CardEditError", _errorPage);
            }
            var showCard = _cards.Single(x => x.CatalogName == name);
            return View(showCard);
        }

        [HttpPost]
        public IActionResult AddCard(string name)
        {
            switch (IsCardExist(name))
            {
                case false:
                    CreateCards(name);
                    return RedirectToAction("UpdateCard");
                case true:
                    SetErrorDetails("新增", "卡片已存在，請點選上面列表瀏覽");
                    return RedirectToAction("CardEditError", _errorPage);
            }
        }

        [HttpPost]
        public IActionResult DeleteCard(string name)
        {
            if (!IsCardExist(name))
            {
                SetErrorDetails("刪除", "卡片不存在，請確認是否存在錯字");
                return RedirectToAction("CardEditError", _errorPage);
            }
            else
            {
                var deleteCard = _cards.Single(x => x.CatalogName == name);
                _cards.Remove(deleteCard);
                return RedirectToAction("UpdateCard");
            }
        }

        public IActionResult UpdateCard()
        {
            return View(_cards);
        }

        public IActionResult CardEditError(ErrorPageViewModel error)
        {
            return View(error);
        }

        private void CreateCards(string cardName)
        {
            var cardOrder = _cards.Count + 1;
            _cards.Add(new CardsViewModel() {CatalogName = cardName, CatalogOrder = cardOrder});
        }

        private static bool IsCardExist(string name)
        {
            return _cards.Any(x => x.CatalogName == name);
        }

        private void SetErrorDetails(string name, string details)
        {
            _errorPage.errorName = name;
            _errorPage.errorDetails = details;
        }
    }
}