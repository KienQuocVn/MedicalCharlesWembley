using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MedicalCharlesWembley.Models;

namespace MedicalCharlesWembley.Controllers;

public class ContactController: Controller
{
    [Route("lien-he")]
    public IActionResult Index()
    {
        return View(); 
    }
}

