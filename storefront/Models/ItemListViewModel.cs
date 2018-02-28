using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace storefront.Models
{
    public class ItemListViewModel
    {
        public List<ItemViewModel> Items { get; set; }
        public int TotalItems { get; set; }
    }
}