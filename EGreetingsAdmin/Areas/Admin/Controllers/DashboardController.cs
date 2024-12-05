using Microsoft.AspNetCore.Mvc;

namespace EGreetingsAdmin.Areas.Admin.Controllers {
  [Area("Admin")]
  public class DashboardController : Controller {
    public IActionResult Index() {
      return View();
    } 
  }
}
