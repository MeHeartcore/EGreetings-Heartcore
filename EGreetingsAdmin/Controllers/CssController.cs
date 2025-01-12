using Microsoft.AspNetCore.Mvc;

namespace EGreetingsAdmin.Controllers
{
    public class CssController : Controller
    {
        private readonly string BASE_PATH = "Areas/Admin/Views/Shared";
        private readonly string SUB_PATH = "Areas/Admin/Views";

        // Serve custom css file: _AdminLayout.css
        public IActionResult AdminCss()
        {
            // Build path
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), BASE_PATH, "_AdminLayout.css");
            // Return file with appropriate MIME type for CSS
            return PhysicalFile(filePath, "text/css");
        }

        public IActionResult CategoryCss()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), SUB_PATH, "Category/Category.css");
            return PhysicalFile(filePath, "text/css");
        }
    }
}
