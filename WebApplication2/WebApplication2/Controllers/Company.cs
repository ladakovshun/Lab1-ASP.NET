using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class Company : Controller
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int Employees { get; set; }
    public IActionResult Index()
    {
        return View();
    }
}
