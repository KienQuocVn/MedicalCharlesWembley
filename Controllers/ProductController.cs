using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedicalCharlesWembley.Data;
using MedicalCharlesWembley.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalCharlesWembley.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [Route("san-pham")]
        public async Task<IActionResult> Index(int page = 1, string searchTerm = null)
        {
            const int pageSize = 20; 
            IQueryable<TProduct> query = _context.TProduct
                .Where(p => p.Status == 1); // Thay true bằng 1 (giả sử 1 là active)

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(p => p.Alias_Url != null && p.Alias_Url.Contains(searchTerm) || 
                                        _context.TProductDescription
                                            .Where(pd => pd.ProductID == p.ProductID && pd.LanguageID == 1)
                                            .Any(pd => pd.Name != null && pd.Name.Contains(searchTerm)));
            }

            var totalProducts = await query.CountAsync();

            var products = await (from p in query
                                  join pd in _context.TProductDescription on p.ProductID equals pd.ProductID
                                  join pi in _context.TProductImage on p.ProductID equals pi.ProductID
                                  where p.Status == 1 && pd.LanguageID == 1
                                  select new
                                  {
                                      p.ProductID,
                                      Name = pd.Name ?? "Không có tên", // Xử lý null
                                      ImageLink = pi.ImageLink ?? ""   // Xử lý null
                                  })
                                  .Skip((page - 1) * pageSize)
                                  .Take(pageSize)
                                  .ToListAsync();

            var totalPages = (int)Math.Ceiling(totalProducts / (double)pageSize);

            ViewBag.Products = products;
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.SearchTerm = searchTerm; 
            return View();
        }

        [HttpPost]
        [Route("san-pham/search")]
        public IActionResult Search(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return RedirectToAction("Index", "Product");
            }
            return RedirectToAction("Index", "Product", new { searchTerm = searchTerm, page = 1 });
        }
    }
}