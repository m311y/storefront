using storefront.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace storefront.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var UserList = new UserListViewModel
            {
                Users = new List<UserViewModel>
                {
                    new UserViewModel { UserId = 1, UserFirstName = "Melissa", UserLastName = "Hardwick", UserEmail = "melissao@store.com" },
                    new UserViewModel { UserId = 2, UserFirstName = "Brian", UserLastName = "Fentress", UserEmail = "briann@store.com"},
                    new UserViewModel { UserId = 3, UserFirstName = "Sarah", UserLastName = "Haydon", UserEmail = "saraha@store.com" }
                }
            };
            UserList.TotalUsers = UserList.Users.Count;
            return View(UserList);
        }
    }
}