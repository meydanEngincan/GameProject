using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class SaleGameManager : ISaleGameService
    {
        public void SaleGame(SaleGame game)
        {
            Console.WriteLine("You have successfully purchased the game.");
        }
    }
}
