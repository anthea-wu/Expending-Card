using System.Collections.Generic;
using Expending_Card.Models;

namespace Expending_Card.Controllers
{
    public class Cache
    {
        public static List<DetailData> Details => new List<DetailData>();

        public static List<Card> Cards => new List<Card>();
    }
}