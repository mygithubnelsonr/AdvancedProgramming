﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //  where is a constraint witch is a limit or restriction
    //  (Grenze , Einschränkung)
    //
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            // calculate and return
            product.Price = 12.45F;
            return 12.45F;
        }
    }
}