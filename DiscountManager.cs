using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class DiscountManager : IDiscountService
    {
        public void AddDiscount(Discount discount)
        {
            Console.WriteLine(discount.DiscountName+" Kampanya eklendi!");
        }

        public void DeleteDiscount(Discount discount)
        {
            Console.WriteLine(discount.DiscountName + " Kampanya silindi!");
        }

        public void UpdateDiscount(Discount discount)
        {
            Console.WriteLine(discount.DiscountName + " Kampanya güncellendi!");
        }
    }
}
