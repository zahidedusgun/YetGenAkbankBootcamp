using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Productify.MVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult GetAll()
        {
            return View();
        }

        // GET: AddProductController
        public ActionResult AddProduct()
        {
            return View();
        }
    }
}