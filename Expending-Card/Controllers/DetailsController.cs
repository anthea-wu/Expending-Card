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
            _card.Cards = new List<Card>();
            _detail.Details = new List<DetailList>();
        }

        public IActionResult Index()
        {
            InitializeModels();
            if (_card.Cards.Count != 0 && _detail.Details.Count != 0) return View(_expending);
            
            _card.DefaultList();
            _detail.DefaultList();
            return View(_expending);
        }

        public IActionResult Edit()
        {
            var card = new Card() {Name = "食物", Order = 3};
            var detail = new DetailList() {Order = 2, Detail = "泡芙", Card = card, Date = "2021/02/11", Price = 120};
            
            if (!IsItemExist("C", card.Name)) _card.AddCard(card);
            _detail.AddList(detail);
            return View(_expending);
        }

        private bool IsItemExist(string obj, string name)
        {
            return obj == "C" ? _card.Cards.Exists(x => x.Name == name)
                : _detail.Details.Exists(x => x.Detail == name);
        }
    }
}