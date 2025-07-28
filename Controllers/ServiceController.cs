using Microsoft.AspNetCore.Mvc;

namespace MedicalCharlesWembley.Controllers
{
    public class ServiceController : Controller
    {
        [Route("/bao-tri-va-sua-chua")]
        public IActionResult BaoTriVaSuaChua()
        {
            return View(); 
        }

        [Route("/dich-vu-bao-hanh")]
        public IActionResult DichVuBaoHanh()
        {
            return View(); 
        }
    }
}
