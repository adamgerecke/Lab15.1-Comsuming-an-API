using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consuming_an_API.Models
{
    public class CardDetail
    {
        public string image { get; set; }
        public string value { get; set; }
        public string suit { get; set; }
        public string code { get; set; }

    }

        public class Card
        {
            public string success { get; set; }
            public CardDetail[] cards { get; set; }
            public string deck_id { get; set; }
            public int remaining { get; set; }

        }
} 


