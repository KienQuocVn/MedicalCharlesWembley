using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MedicalCharlesWembley.Models;

namespace MedicalCharlesWembley.Controllers;

public class NewsController : Controller
{
    [Route("tin-tuc-su-kien")]
    public IActionResult Index()
    {
        return View(); 
    }
}

