using Microsoft.AspNetCore.Mvc;

namespace AriTechno.Web.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Card() { 
            return View(); 
        }
        public IActionResult CheckOut() {
            return View();
        }
        public IActionResult MyAccount() { 
            return View();
        }
        public IActionResult WishList() { 
        return View();
        }
        public IActionResult ShopDetail() { 
        return View();
        }

    }
}
