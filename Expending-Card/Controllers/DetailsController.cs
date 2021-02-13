﻿using System;
using System.Collections.Generic;
using System.Linq;
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

        [HttpPost]
        public IActionResult Add(string order, string date, string detail, int price, string card)
        {
            if (string.IsNullOrEmpty(order)) return BadRequest("錯誤：Order為空");
            
            if (string.IsNullOrEmpty(date) || string.IsNullOrEmpty(detail) ||
                price==0 || string.IsNullOrEmpty(card)) return BadRequest("建立明細時不能有任何空白欄位");
            
            if (price <= 0) return BadRequest("價格不得小於等於0元");

            if (!IsItemExist("C", card))
            {
                _card.AddCard(_card.Cards.Count+1, card);
            }
            
            
            _detail.AddList(new DetailData()
            {
                Order = Convert.ToInt32(order),
                Card = _card.Cards.Single(x => x.Name == card),
                Date = date,
                Detail = detail,
                Price = price
            });
            return Ok("明細建立成功");
        }

        [HttpPost]
        public IActionResult Update(string order, string date, string detail, int price, string card)
        {
            if (string.IsNullOrEmpty(date) && string.IsNullOrEmpty(detail) &&
                price==0 && string.IsNullOrEmpty(card)) return BadRequest("至少要填寫一欄");
            
            if (price <= 0) return BadRequest("價格不得小於等於0元");
            
            var old = _detail.Details.Single(x => x.Order.ToString() == order);
            
            if (string.IsNullOrEmpty(card)) card = old.Card.Name;
            if (string.IsNullOrEmpty(detail)) detail = old.Detail;
            if (string.IsNullOrEmpty(date)) date = old.Date;
            if (string.IsNullOrEmpty(price.ToString())) price = old.Price;
            
            if (!IsItemExist("C", card)) _card.AddCard(_card.Cards.Count+1, card);
            var cardData = _card.Cards.Single(x => x.Name == card);

            var data = new DetailData()
            {
                Order = Convert.ToInt32(order), Card = cardData, Date = date, Detail = detail, Price = price
            };
            _detail.UpdateList(data);

            return Ok("明細更新成功");
        }
    }
}