using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstConnection.Models;

namespace FirstConnection.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private PetContext _context;
    public HomeController(ILogger<HomeController> logger, PetContext context)
    {
        _logger = logger;

        _context = context;
    }

    public IActionResult Index()
    {
        List<Pet> MostrarMascotas = _context.Pets.ToList();
        ViewBag.ListaMascota = MostrarMascotas;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
