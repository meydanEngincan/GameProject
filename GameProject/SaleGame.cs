using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class SaleGame
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public Gamer gamer { get; set; }
        public Campaign _Campaign { get; set; }
        public double GamePrice { get; set; }

    }
}
