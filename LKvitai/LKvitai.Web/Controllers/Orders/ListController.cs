using Microsoft.AspNetCore.Mvc;

namespace LKvitai.Web.Controllers.Orders
{
    public class ListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
