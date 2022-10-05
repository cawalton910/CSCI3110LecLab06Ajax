using Microsoft.AspNetCore.Mvc;

namespace CSCI3110LecLab06Ajax.Controllers;

public class PetController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
