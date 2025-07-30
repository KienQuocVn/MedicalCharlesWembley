using Microsoft.AspNetCore.Mvc;
using MedicalCharlesWembley.Data;
using MedicalCharlesWembley.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging; 
using System.Linq;

namespace MedicalCharlesWembley.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _context.TProductCategory
                .Where(c => c.Status == 1) // Thay == 1 thay vì so sánh với bool
                .OrderBy(c => c.SortOrder ?? int.MaxValue)
                .ToListAsync();
            ViewBag.Categories = categories;

            var productsICU = await (from p in _context.TProduct
                         join pc in _context.TProductToCategory on p.ProductID equals pc.ProductID
                         join pd in _context.TProductDescription on p.ProductID equals pd.ProductID
                         join pi in _context.TProductImage on p.ProductID equals pi.ProductID into imgGroup
                         from pi in imgGroup.DefaultIfEmpty()
                         where pc.CategoryID == 112 && p.Status == 1 && pd.LanguageID == 1 // Thay true bằng 1
                         orderby p.SortOrder
                         select new
                         {
                             p.ProductID,
                             p.Alias_Url,
                             ImageLink = pi.ImageLink ?? "", // Xử lý null
                             p.str1,
                             Name = pd.Name ?? "Không có tên" // Xử lý null
                         }).Take(5).ToListAsync();
            ViewBag.ProductsICU = productsICU;

            var productsSanNhi = await (from p in _context.TProduct
                             join pc in _context.TProductToCategory on p.ProductID equals pc.ProductID
                             join pd in _context.TProductDescription on p.ProductID equals pd.ProductID
                             join pi in _context.TProductImage on p.ProductID equals pi.ProductID into imgGroup
                             from pi in imgGroup.DefaultIfEmpty()
                             where pc.CategoryID == 113 && p.Status == 1 && pd.LanguageID == 1 // Thay true bằng 1
                             orderby p.SortOrder
                             select new
                             {
                                 p.ProductID,
                                 p.Alias_Url,
                                 ImageLink = pi.ImageLink ?? "", // Xử lý null
                                 p.str1,
                                 Name = pd.Name ?? "Không có tên" // Xử lý null
                             }).Take(5).ToListAsync();
            ViewBag.ProductsSanNhi = productsSanNhi;

            var productsTimMach = await (from p in _context.TProduct
                              join pc in _context.TProductToCategory on p.ProductID equals pc.ProductID
                              join pd in _context.TProductDescription on p.ProductID equals pd.ProductID
                              join pi in _context.TProductImage on p.ProductID equals pi.ProductID into imgGroup
                              from pi in imgGroup.DefaultIfEmpty()
                              where pc.CategoryID == 117 && p.Status == 1 && pd.LanguageID == 1 // Thay true bằng 1
                              orderby p.SortOrder
                              select new
                              {
                                  p.ProductID,
                                  p.Alias_Url,
                                  ImageLink = pi.ImageLink ?? "", // Xử lý null
                                  p.str1,
                                  Name = pd.Name ?? "Không có tên" // Xử lý null
                              }).Take(5).ToListAsync();
            ViewBag.ProductsTimMach = productsTimMach;

            var productsNhanKhoa = await (from p in _context.TProduct
                               join pc in _context.TProductToCategory on p.ProductID equals pc.ProductID
                               join pd in _context.TProductDescription on p.ProductID equals pd.ProductID
                               join pi in _context.TProductImage on p.ProductID equals pi.ProductID into imgGroup
                               from pi in imgGroup.DefaultIfEmpty()
                               where pc.CategoryID == 118 && p.Status == 1 && pd.LanguageID == 1 // Thay true bằng 1
                               orderby p.SortOrder
                               select new
                               {
                                   p.ProductID,
                                   p.Alias_Url,
                                   ImageLink = pi.ImageLink ?? "", // Xử lý null
                                   p.str1,
                                   Name = pd.Name ?? "Không có tên" // Xử lý null
                               }).Take(5).ToListAsync();
            ViewBag.ProductsNhanKhoa = productsNhanKhoa;

            var productsTaiMuiHong = await (from p in _context.TProduct
                                 join pc in _context.TProductToCategory on p.ProductID equals pc.ProductID
                                 join pd in _context.TProductDescription on p.ProductID equals pd.ProductID
                                 join pi in _context.TProductImage on p.ProductID equals pi.ProductID into imgGroup
                                 from pi in imgGroup.DefaultIfEmpty()
                                 where pc.CategoryID == 119 && p.Status == 1 && pd.LanguageID == 1 // Thay true bằng 1
                                 orderby p.SortOrder
                                 select new
                                 {
                                     p.ProductID,
                                     p.Alias_Url,
                                     ImageLink = pi.ImageLink ?? "", // Xử lý null
                                     p.str1,
                                     Name = pd.Name ?? "Không có tên" // Xử lý null
                                 }).Take(5).ToListAsync();
            ViewBag.ProductsTaiMuiHong = productsTaiMuiHong;

            var productsNieuKhoaNamKhoa = await (from p in _context.TProduct
                                      join pc in _context.TProductToCategory on p.ProductID equals pc.ProductID
                                      join pd in _context.TProductDescription on p.ProductID equals pd.ProductID
                                      join pi in _context.TProductImage on p.ProductID equals pi.ProductID into imgGroup
                                      from pi in imgGroup.DefaultIfEmpty()
                                      where pc.CategoryID == 175 && p.Status == 1 && pd.LanguageID == 1 // Thay true bằng 1
                                      orderby p.SortOrder
                                      select new
                                      {
                                          p.ProductID,
                                          p.Alias_Url,
                                          ImageLink = pi.ImageLink ?? "", // Xử lý null
                                          p.str1,
                                          Name = pd.Name ?? "Không có tên" // Xử lý null
                                      }).Take(5).ToListAsync();
            ViewBag.ProductsNieuKhoaNamKhoa = productsNieuKhoaNamKhoa;

            var productsVatTuTieuHao = await (from p in _context.TProduct
                                   join pc in _context.TProductToCategory on p.ProductID equals pc.ProductID
                                   join pd in _context.TProductDescription on p.ProductID equals pd.ProductID
                                   join pi in _context.TProductImage on p.ProductID equals pi.ProductID into imgGroup
                                   from pi in imgGroup.DefaultIfEmpty()
                                   where pc.CategoryID == 176 && p.Status == 1 && pd.LanguageID == 1 // Thay true bằng 1
                                   orderby p.SortOrder
                                   select new
                                   {
                                       p.ProductID,
                                       p.Alias_Url,
                                       ImageLink = pi.ImageLink ?? "", // Xử lý null
                                       p.str1,
                                       Name = pd.Name ?? "Không có tên" // Xử lý null
                                   }).Take(5).ToListAsync();
            ViewBag.ProductsVatTuTieuHao = productsVatTuTieuHao;

            var productsTongQuat = await (from p in _context.TProduct
                               join pc in _context.TProductToCategory on p.ProductID equals pc.ProductID
                               join pd in _context.TProductDescription on p.ProductID equals pd.ProductID
                               join pi in _context.TProductImage on p.ProductID equals pi.ProductID into imgGroup
                               from pi in imgGroup.DefaultIfEmpty()
                               where pc.CategoryID == 208 && p.Status == 1 && pd.LanguageID == 1 // Thay true bằng 1
                               orderby p.SortOrder
                               select new
                               {
                                   p.ProductID,
                                   p.Alias_Url,
                                   ImageLink = pi.ImageLink ?? "", // Xử lý null
                                   p.str1,
                                   Name = pd.Name ?? "Không có tên" // Xử lý null
                               }).Take(5).ToListAsync();
            ViewBag.ProductsTongQuat = productsTongQuat;
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = HttpContext.TraceIdentifier });
        }
    }
}