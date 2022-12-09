using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Model.PartialClass
{
    class ServicePartial
    {
        public string DiscountText
        {
            get
            {
                if (Discount == 0) || Discount == null)
                    return "";
                else
                    return $"* скидка {Discount * 100} %";
            }
        }

        public double CostWithDiscount
        {
            get
            {
                if (Discount == 0 || Discount == null)
                {
                    return (double)CostWithDiscount;
                }
                else
                {
                    var CostWithDiscount = (double)Cost * 1.00 - Discount);
                    return CostWithDiscount.Value;
                }
            }
        }
    }
}
