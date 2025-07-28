using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MedicalCharlesWembley.Models;

namespace MedicalCharlesWembley.Controllers;

public class AboutController : Controller
{
    [Route("gioi-thieu")]
    public IActionResult Index()
    {
        return View(); // sẽ gọi Views/About/Index.cshtml
    }
}

