using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace storefront.Models
{
    public class UserViewModel
    {
        public int? UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
    }
}