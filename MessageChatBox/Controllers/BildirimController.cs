using Microsoft.AspNetCore.Mvc;

namespace MessageChatBox.Controllers
{
    public class BildirimController : Controller
    {
        public IActionResult Bildirim()
        {
            return View();
        }
    }
}
