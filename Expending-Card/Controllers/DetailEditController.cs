using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Expending_Card.Models;
using Microsoft.Extensions.Logging;

namespace Expending_Card.Controllers
{
    public class DetailEditController : Controller
    {
        private ILogger<DetailEditController> _logger;
        private static readonly DetailViewModel _detail = new DetailViewModel();
        private static readonly CardViewModel _card = new CardViewModel();
        private static readonly ExpendingViewModel _expending = new ExpendingViewModel();
        
        public DetailEditController(ILogger<DetailEditController> logger)
        {
            _logger = logger;
        }

        private void InitializeModels()
        {
            _expending.CardViewModel = _card;
            _expending.DetailViewModel = _detail;
            _card.Cards = new List<Card>();
            _detail.Details = new List<DetailList>();
        }

        public ActionResult Details()
        {
            InitializeModels();
            if (_card.Cards.Count != 0 && _detail.Details.Count != 0) return View(_expending);
            
            _card.DefaultList();
            _detail.DefaultList();
            return View(_expending);
        }
    }
}