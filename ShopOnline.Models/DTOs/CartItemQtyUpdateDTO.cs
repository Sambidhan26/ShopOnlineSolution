﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.DTOs
{
    public class CartItemQtyUpdateDTO
    {
        public int CartItemId { get; set; }
        public int Qty { get; set; }
    }
}
