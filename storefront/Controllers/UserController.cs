
using storefront.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace storefront.Controllers
{
    public class UserController : Controller
    {
        public class PersonController : Controller
        {
            public static List<Person> Users = new List<User>
                {
              new User { UserId = 1, UserFirstName = "Melissa", UserLastName = "Hardwick", UserEmail = "melissao@store.com" },
              new User { UserId = 2, UserFirstName = "Brian", UserLastName = "Fentress", UserEmail = "briann@store.com"},
              new User { UserId = 3, UserFirstName = "Sarah", UserLastName = "Haydon", UserEmail = "saraha@store.com" },
              new User { UserId = 4, UserFirstName = "Tim", UserLastName = "Ellis", UserEmail = "tims@store.com" },
              new User { UserId = 5, UserFirstName = "Brian", UserLastName = "Jones", UserEmail = "brianf@store.com" },
              new User { UserId = 6, UserFirstName = "Briana", UserLastName = "Keller", UserEmail = "brianap@store.com" }
                };

            public ActionResult Index()
            {
                var UserList = new UserListViewModel
                {
                    //Convert each Person to a PersonViewModel
                    Users = Users.Select(p => new UserViewModel
                    {
                        UserId = p.PersonId,
                        UserLastName = p.LastName,
                        UserFirstName = p.FirstName
                    }).ToList()
                };

                UserList.TotalUsers = UserList.Users.Count;

                return View(personList);
            }
        }
    }
}
    
}