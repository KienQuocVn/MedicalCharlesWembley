using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedicalCharlesWembley.Data;
using MedicalCharlesWembley.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalCharlesWembley.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly AppDbContext _context;

        public ProductDetailController(AppDbContext context)
        {
            _context = context;
        }

        [Route("san-pham/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var productQuery = from p in _context.TProduct
                              join pd in _context.TProductDescription
                                  on p.ProductID equals pd.ProductID into descriptions
                              from pd in descriptions.Where(d => d.LanguageID == 1).DefaultIfEmpty()
                              join pi in _context.TProductImage
                                  on p.ProductID equals pi.ProductID into images
                              from pi in images.DefaultIfEmpty()
                              join ptc in _context.TProductToCategory
                                  on p.ProductID equals ptc.ProductID into productToCategories
                              from ptc in productToCategories.DefaultIfEmpty()
                              join pc in _context.TProductCategory
                                  on ptc.CategoryID equals pc.CategoryID into categories
                              from pc in categories.DefaultIfEmpty()
                              join pcd in _context.TProductCategoryDescription
                                  on pc.CategoryID equals pcd.CategoryID into categoryDescriptions
                              from pcd in categoryDescriptions.Where(d => d.LanguageID == 1).DefaultIfEmpty()
                              where p.ProductID == id && p.Status == 1 // Chỉ lấy sản phẩm active
                              select new
                              {
                                  ProductID = p.ProductID,
                                  Name = pd != null ? pd.Name : null,
                                  ImageLink = pi != null ? pi.ImageLink : null,
                                  CategoryName = pcd != null ? pcd.Name : null,
                                  SortOrder = p.SortOrder,
                                  Price = p.Price,
                                  Status = p.Status,
                                  RegDate = p.RegDate,
                                  Model = p.Model
                              };

            var product = await productQuery
                .GroupBy(p => new { p.ProductID, p.Name, p.ImageLink, p.SortOrder, p.Price, p.Status, p.RegDate, p.Model })
                .Select(g => new
                {
                    ProductID = g.Key.ProductID,
                    Name = g.Key.Name,
                    ImageLink = g.Key.ImageLink,
                    SortOrder = g.Key.SortOrder,
                    Price = g.Key.Price,
                    Status = g.Key.Status,
                    RegDate = g.Key.RegDate,
                    Model = g.Key.Model,
                    CategoryName = string.Join(", ", g.Select(x => x.CategoryName).Where(x => x != null))
                })
                .FirstOrDefaultAsync();

            if (product == null)
            {
                return NotFound();
            }

            ViewBag.Product = product;

            // Lấy sản phẩm liên quan (cùng danh mục, giới hạn 3 sản phẩm)
            var relatedProducts = await (from p in _context.TProduct
                                       join pd in _context.TProductDescription
                                           on p.ProductID equals pd.ProductID into descriptions
                                       from pd in descriptions.Where(d => d.LanguageID == 1).DefaultIfEmpty()
                                       join pi in _context.TProductImage
                                           on p.ProductID equals pi.ProductID into images
                                       from pi in images.DefaultIfEmpty()
                                       join ptc in _context.TProductToCategory
                                           on p.ProductID equals ptc.ProductID into productToCategories
                                       from ptc in productToCategories.DefaultIfEmpty()
                                       join pc in _context.TProductCategory
                                           on ptc.CategoryID equals pc.CategoryID into categories
                                       from pc in categories.DefaultIfEmpty()
                                       join pcd in _context.TProductCategoryDescription
                                           on pc.CategoryID equals pcd.CategoryID into categoryDescriptions
                                       from pcd in categoryDescriptions.Where(d => d.LanguageID == 1).DefaultIfEmpty()
                                       where pcd.Name == product.CategoryName && p.ProductID != id && p.Status == 1
                                       select new
                                       {
                                           ProductID = p.ProductID,
                                           Name = pd != null ? pd.Name : null,
                                           ImageLink = pi != null ? pi.ImageLink : null,
                                           Price = p.Price
                                       })
                                       .GroupBy(p => new { p.ProductID, p.Name, p.ImageLink, p.Price })
                                       .Select(g => new
                                       {
                                           ProductID = g.Key.ProductID,
                                           Name = g.Key.Name,
                                           ImageLink = g.Key.ImageLink,
                                           Price = g.Key.Price
                                       })
                                       .Take(3)
                                       .ToListAsync();

            ViewBag.RelatedProducts = relatedProducts;
            return View("~/Views/ProductDetail/Index.cshtml");
        }
    }
}