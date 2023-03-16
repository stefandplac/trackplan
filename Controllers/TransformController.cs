using Microsoft.AspNetCore.Mvc;
using trackplan.Models;

namespace trackplan.Controllers
{
    public class TransformController : Controller
    {
        
        public IActionResult Display(IFormCollection collection)
        {
            try
            {
                var model = new Word();
                var task=TryUpdateModelAsync(model);
                task.Wait();
                if (task.Result)
                {
                    return View(model);
                }
            }
            catch
            {
                return RedirectToAction("Index","Home");
            }
            return View(collection);
        }
    }
}
