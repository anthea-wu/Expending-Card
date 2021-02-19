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
            if (string.IsNullOrEmpty(order) || !_detail.Details.Exists(x => x.Order.ToString() == order))
            {
                return BadRequest("這個明細不存在");
            }
            
            _detail.DeleteList(Convert.ToInt32(order));
            return Ok("明細刪除成功");
        }

        [HttpPost]
        public IActionResult Add([FromBody]DetailRequestTest request)
        {
            if (string.IsNullOrEmpty(request.Order.ToString())) return BadRequest("錯誤：Order為空");

            /*if (!_card.Cards.Exists(x => x.Name == request.Card.Name))
            {
                _card.AddCard(_card.Cards.Count+1, request.Card.Name);
            }*/
            
            _detail.AddList(request);
            return Ok("明細建立成功");
        }

        [HttpPost]
        public IActionResult Update([FromBody]DetailRequest request)
        {
            if (string.IsNullOrEmpty(request.Date) && string.IsNullOrEmpty(request.Detail) &&
                request.Price==0 && string.IsNullOrEmpty(request.Card)) return BadRequest("至少要填寫一欄");
            
            if (request.Price < 0) return BadRequest("價格不得小於0元");
            
            var old = _detail.Details.Single(x => x.Order == request.Order);
            
            if (string.IsNullOrEmpty(request.Card)) request.Card = old.Card.Name;
            if (string.IsNullOrEmpty(request.Detail)) request.Detail = old.Detail;
            if (string.IsNullOrEmpty(request.Date)) request.Date = old.Date;
            if (string.IsNullOrEmpty(request.Price.ToString())) request.Price = old.Price;

            if (!_card.Cards.Exists(x => x.Name == request.Card))
            {
                _card.AddCard(_card.Cards.Count + 1, request.Card);
            }
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
            // rename
            var orderBasic = data.Split('-')[0];
            var AscOrBsc = data.Split('-')[1];
            
            switch (AscOrBsc)
            {
                case "asc":
                    _detail.AscOrder(orderBasic);
                    break;
                case "desc":
                    _detail.DescOrder(orderBasic);
                    break;
                default:
                    return BadRequest("請選擇一種明細排列方式");
            }

            InitializeModels();
            return Ok();
        }
        
        
    }

    public class DetailRequestTest : DetailData
    {
        public string Detail { get; set; }
        public string Date { get; set; }
        public int Price  { get; set; }
        public Card Card  { get; set; }
        public int Order { get; set; }
    }
}