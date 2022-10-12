using Microsoft.AspNetCore.Mvc;

namespace CSCI3110LecLab06Ajax.Controllers;

public class PetController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Details(int id)
    {
        return View();
    }
    public IActionResult Create()
    {
        return View();
    }
    public IActionResult Edit()
    {
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }
}
