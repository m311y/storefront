using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using storefront.Models;

namespace storefront.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            var ItemList = new ItemListViewModel
            {
                Items = new List<ItemViewModel>
                {
                    new ItemViewModel { ItemId = 1, ItemName = "Item 1", ItemPrice = 2.99m },
                    new ItemViewModel { ItemId = 2, ItemName = "Item 2", ItemPrice = 5.00m },
                    new ItemViewModel { ItemId = 3, ItemName = "Item 3", ItemPrice = 12.99m },
                }
            };
            ItemList.TotalItems = ItemList.Items.Count;
            return View(ItemList);
        }
    }
}