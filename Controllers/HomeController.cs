using FluentApiPB303.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentApiPB303.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(ProductCreateDto product)
    {
        if (!ModelState.IsValid)
            return View();


        return Ok("OK");
    }
}
