using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace storefront.Models
{
    public class UserListViewModel
    {
        public List<UserViewModel> Users { get; set; }
        public int TotalUsers { get; set; }
    }
}