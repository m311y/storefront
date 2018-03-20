using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using storefront.Models;

namespace storefront.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
        public int CartCount { get; set; }
        public int ItemCount { get; set; }
        public int DeleteId { get; set; }
        public string Message { get; set; }

    }
}