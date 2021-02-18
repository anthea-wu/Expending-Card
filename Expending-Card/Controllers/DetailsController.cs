using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Expending_Card.Models;
using Microsoft.Extensions.Logging;

namespace Expending_Card.Controllers
{
    public class DetailsController : Controller
    {
        private readonly ILogger<DetailsController> _logger;
        public static DetailViewModel _detail = new DetailViewModel();
        public static CardViewModel _card = new CardViewModel();
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
            if (_detail.Details.Count != 0 && _card.Cards.Count != 0)
            {
                GetCurrentModels();
                return View(_expending);
            }
            
            InitializeModels();
            GetCurrentModels();
            
            if (_card.Cards.Count == 0) _card.DefaultList();
            return View(_expending);
        }

        private void GetCurrentModels()
        {
            _detail = CatalogCardController._detail;
            _card = CatalogCardController._card;
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
        public IActionResult Add([FromBody]DetailRequest request)
        {
            if (string.IsNullOrEmpty(request.Order.ToString())) return BadRequest("錯誤：Order為空");
            
            if (string.IsNullOrEmpty(request.Date) || string.IsNullOrEmpty(request.Detail) ||
                request.Price==0 || string.IsNullOrEmpty(request.Card)) return BadRequest("建立明細時不能有任何空白欄位");
            
            if (request.Price <= 0) return BadRequest("價格不得小於等於0元");

            if (!IsItemExist("C", request.Card)) _card.AddCard(_card.Cards.Count+1, request.Card);
            
            _detail.AddList(new DetailData()
            {
                Order = request.Order,
                Card = _card.Cards.Single(x => x.Name == request.Card),
                Date = request.Date,
                Detail = request.Detail,
                Price = request.Price
            });
            return Ok("明細建立成功");
        }

        [HttpPost]
        public IActionResult Update([FromBody]DetailRequest request)
        {
            if (string.IsNullOrEmpty(request.Date) && string.IsNullOrEmpty(request.Detail) &&
                request.Price==0 && string.IsNullOrEmpty(request.Card)) return BadRequest("至少要填寫一欄");
            
            if (request.Price <= 0) return BadRequest("價格不得小於等於0元");
            
            var old = _detail.Details.Single(x => x.Order == request.Order);
            
            if (string.IsNullOrEmpty(request.Card)) request.Card = old.Card.Name;
            if (string.IsNullOrEmpty(request.Detail)) request.Detail = old.Detail;
            if (string.IsNullOrEmpty(request.Date)) request.Date = old.Date;
            if (string.IsNullOrEmpty(request.Price.ToString())) request.Price = old.Price;

            //_card = DetailsController._card;
            if (!IsItemExist("C", request.Card)) _card.AddCard(_card.Cards.Count+1, request.Card);
            var cardData = _card.Cards.Single(x => x.Name == request.Card);

            var data = new DetailData()
            {
                Order = request.Order, Card = cardData, Date = request.Date, Detail = request.Detail, Price = request.Price
            };
            _detail.UpdateList(data);

            return Ok("明細更新成功");
        }

        [HttpPost]
        public IActionResult SortDetails(string data)
        {
            _logger.LogInformation(data);
            switch (data) {
                case "order-asc":
                    _detail.Details = _detail.Details.OrderBy(x => x.Order).ToList();
                    break;
                case "card-asc":
                    _detail.Details = _detail.Details.OrderBy(x => x.Card.Order).ToList();
                    break;
                case "price-asc":
                    _detail.Details = _detail.Details.OrderBy(x => x.Price).ToList();
                    break;
                case "date-asc":
                    _detail.Details = _detail.Details.OrderBy(x => x.Date).ToList();
                    break;
                case "order-desc":
                    _detail.Details = _detail.Details.OrderByDescending(x => x.Order).ToList();
                    break;
                case "card-desc":
                    _detail.Details = _detail.Details.OrderByDescending(x => x.Card.Order).ToList();
                    break;
                case "price-desc":
                    _detail.Details = _detail.Details.OrderByDescending(x => x.Price).ToList();
                    break;
                case "date-desc":
                    _detail.Details = _detail.Details.OrderByDescending(x => x.Date).ToList();
                    break;
                default:
                    return BadRequest("請選擇一種明細排列方式");
            }

            InitializeModels();
            return Ok();
        }

        private bool IsItemExist(string obj, string condition)
        {
            return obj == "C" ? _card.Cards.Exists(x => x.Name == condition)
                : _detail.Details.Exists(x => x.Order.ToString() == condition);
        }
    }
}