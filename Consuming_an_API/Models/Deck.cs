using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consuming_an_API.Models
{
    public class Deck
    {
        public string success { get; set; }
        public string deck_id { get; set; }
        public string shuffled { get; set; }
        public int remaining { get; set; }

    }
}
