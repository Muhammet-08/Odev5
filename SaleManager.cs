using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class SaleManager : ISaleService
    {
        public void Sale(Game game, Gamer gamer, Discount discount)
        {
            Console.WriteLine(game.GameName+" oyunu "+gamer.FirstName+" kişisine "+discount.DiscountName+" türünde satılmıştır!");

        }
    }
}
