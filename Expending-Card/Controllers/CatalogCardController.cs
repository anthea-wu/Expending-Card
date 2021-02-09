﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Expending_Card.Models;
using Expending_Card.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Expending_Card.Controllers
{ public class CatalogCardController : Controller
    {
        private readonly ILogger<CatalogCardController> _logger;
        private static readonly List<CardsViewModel> _cards = new List<CardsViewModel>();
        private static readonly CardViewModel _model = new CardViewModel();
        private static readonly ErrorPageViewModel _errorPage = new ErrorPageViewModel();
            
        public CatalogCardController (ILogger<CatalogCardController> logger)
        {
            _logger = logger;
        }
        
        // GET
        public IActionResult Index()
        {
            if (_cards.Count != 0) return View(_model);
            
            _model.DefaultList();
            return View(_model);
        }

        [Route("{Controller}/{name}")]
        public IActionResult ShowOneCard(string name)
        {
            if (!IsCardExist(name))
            {
                SetErrorDetails("顯示", "卡片不存在，請利用新增功能增加該卡片");
                return RedirectToAction("CardEditError");
            }
            var showCard = _model.Cards.Single(x => x.Name == name);
            
            return View(showCard);
        }

        [HttpPost]
        public IActionResult AddCard(string name)
        {
            if (string.IsNullOrEmpty(name)) return BadRequest("欄位不得為空");
            if (IsCardExist(name)) return BadRequest("卡片已存在");
            
            _model.AddCard(_cards.Count + 1, name);
            return Ok("卡片新增成功");
        }

        [HttpPost]
        public IActionResult DeleteCard([FromForm]string name)
        {
            if (string.IsNullOrEmpty(name)) return BadRequest("欄位不得為空");
            if (!IsCardExist(name)) return BadRequest("卡片不存在");
            
            _model.DeleteCard(name);
            return Ok("卡片刪除成功");

        }

        [HttpPost]
        public IActionResult UpdateCardName([FromForm]string oldName, string newName)
        {
            if (string.IsNullOrEmpty(oldName) || string.IsNullOrEmpty(newName)) return BadRequest("欄位不得為空");
            if (!IsCardExist(oldName)) return BadRequest("要修改的卡片不存在");
            if (IsCardExist(newName)) return BadRequest("修改後的卡片名稱已存在");
            
            _model.UpdateCardName(oldName, newName);
            return Ok("卡片名稱修改成功");
        }


        public IActionResult EditCard()
        {
            return View(_cards);
        }

        public IActionResult CardEditError()
        {
            return View(_errorPage);
        }

        private static bool IsCardExist(string name)
        {
            return _model.Cards.Any(x => x.Name == name);
        }

        private void SetErrorDetails(string name, string details)
        {
            _errorPage.errorName = name;
            _errorPage.errorDetails = details;
        }
    }
}