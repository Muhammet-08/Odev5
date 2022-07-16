using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    interface IDiscountService
    {
        public void AddDiscount(Discount discount);
        public void DeleteDiscount(Discount discount);
        public void UpdateDiscount(Discount discount);
        

    }
}
