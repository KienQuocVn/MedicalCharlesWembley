using Microsoft.AspNetCore.Mvc;
using MedicalCharlesWembley.Data;
using MedicalCharlesWembley.Models;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
namespace MedicalCharlesWembley.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        [Route("admin")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("admin/home/header")]
        public async Task<IActionResult> Header(string searchTerm = null)
        {
            IQueryable<TConfig> query = _context.TConfig
                .Where(c => c.ConfigGroup2 == "Header");

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(c => c.ConfigName != null && c.ConfigName.Contains(searchTerm));
            }

            var headerConfigs = await query.ToListAsync();
            ViewData["CurrentSearchTerm"] = searchTerm;
            return View("~/Views/Admin/Home/Header/Header.cshtml", headerConfigs);
        }

        // Chức năng Insert
        [Route("admin/home/create")]
        public IActionResult Create()
        {
            return View("~/Views/Admin/Home/Header/Create.cshtml");
        }

        [HttpPost]
        [Route("admin/home/create")]
        public async Task<IActionResult> Create(TConfig config)
        {
            if (ModelState.IsValid)
            {
                config.ConfigGroup2 = "Header";
                _context.TConfig.Add(config);
                await _context.SaveChangesAsync();
                return RedirectToAction("Header");
            }
            return View("~/Views/Admin/Home/Header/Create.cshtml", config);
        }

        // Chức năng Edit
        [Route("admin/home/edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var config = await _context.TConfig.FindAsync(id);
            if (config == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/Home/Header/Edit.cshtml", config);
        }

        [HttpPost]
        [Route("admin/home/edit")]
        public async Task<IActionResult> Edit(int id, TConfig config)
        {
            if (id != config.ConfigID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(config);
                await _context.SaveChangesAsync();
                return RedirectToAction("Header");
            }
            return View("~/Views/Admin/Home/Header/Edit.cshtml", config);
        }

        // Chức năng Delete
        [Route("admin/home/delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var config = await _context.TConfig.FindAsync(id);
            if (config == null)
            {
                return NotFound();
            }

            _context.TConfig.Remove(config);
            await _context.SaveChangesAsync();
            return RedirectToAction("Header");
        }

        [Route("admin/home/slider")]
        public IActionResult Slider()
        {
            return View("~/Views/Admin/Home/Slider.cshtml");
        }

        [Route("admin/home/about")]
        public IActionResult HomeAbout()
        {
            return View("~/Views/Admin/Home/About.cshtml");
        }

        [Route("admin/home/services")]
        public IActionResult HomeServices()
        {
            return View("~/Views/Admin/Home/Services.cshtml");
        }

        [Route("admin/home/partnerlogo")]
        public IActionResult PartnerLogo()
        {
            return View("~/Views/Admin/Home/PartnerLogo.cshtml");
        }

        [Route("admin/home/customerlogo")]
        public IActionResult CustomerLogo()
        {
            return View("~/Views/Admin/Home/CustomerLogo.cshtml");
        }

        [Route("admin/home/footerinfo")]
        public IActionResult FooterInfo()
        {
            return View("~/Views/Admin/Home/FooterInfo.cshtml");
        }

        [Route("admin/home/sociallinks")]
        public IActionResult SocialLinks()
        {
            return View("~/Views/Admin/Home/SocialLinks.cshtml");
        }

        [Route("admin/about")]
        public IActionResult About()
        {
            return View("~/Views/Admin/About/Index.cshtml");
        }

        [Route("admin/services")]
        public IActionResult Services()
        {
            return View("~/Views/Admin/Services/Index.cshtml");
        }

        [Route("admin/innerbanner")]
        public IActionResult InnerBanner()
        {
            return View("~/Views/Admin/InnerBanner/Index.cshtml");
        }

        [Route("admin/news")]
        public IActionResult News()
        {
            return View("~/Views/Admin/News/Index.cshtml");
        }

        [Route("admin/newsletter")]
        public async Task<IActionResult> Newsletter(int page = 1, string searchTerm = null)
        {
            const int pageSize = 10; 
            IQueryable<NewLetter> query = _context.NewLetter;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(n => n.Email != null && n.Email.Contains(searchTerm));
            }

            var totalRecords = await query.CountAsync(); 
            var totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize); 

            var newsletters = await query
                .Select(n => new NewLetter 
                { 
                    NewLetterID = n.NewLetterID, 
                    Email = n.Email, 
                    AddDate = n.AddDate 
                })
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            ViewBag.SearchTerm = searchTerm; 
            return View("~/Views/Admin/Newsletter/Index.cshtml", newsletters);
        }

        [HttpPost]
        [Route("admin/newsletter/deleteselected")]
        public async Task<IActionResult> DeleteSelectedNewsletters(List<long> ids)
        {
            if (ids == null || !ids.Any())
            {
                return Json(new { success = false, message = "No records selected." });
            }

            var newsletters = await _context.NewLetter.Where(n => ids.Contains(n.NewLetterID)).ToListAsync();
            if (newsletters.Any())
            {
                _context.NewLetter.RemoveRange(newsletters);
                await _context.SaveChangesAsync();
            }

            return Json(new { success = true });
        }

        [HttpPost]
        [Route("admin/newsletter/delete/{id}")]
        public async Task<IActionResult> DeleteNewsletter(long id)
        {
            var newsletter = await _context.NewLetter.FindAsync(id);
            if (newsletter == null)
            {
                return NotFound();
            }

            _context.NewLetter.Remove(newsletter);
            await _context.SaveChangesAsync();
            return RedirectToAction("Newsletter");
        }

        [HttpGet]
        [Route("admin/newsletter/export")]
        public async Task<IActionResult> ExportToExcel(string searchTerm = null)
        {
            // Lấy tất cả dữ liệu dựa trên searchTerm (nếu có)
            IQueryable<NewLetter> query = _context.NewLetter;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(n => n.Email != null && n.Email.Contains(searchTerm));
            }

            var newsletters = await query
                .Select(n => new NewLetter 
                { 
                    NewLetterID = n.NewLetterID, 
                    Email = n.Email, 
                    AddDate = n.AddDate 
                })
                .ToListAsync();

            // Cấu hình EPPlus
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Sử dụng cho mục đích không thương mại
            using var package = new ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("Newsletters");
            worksheet.Cells[1, 1].Value = "NewLetterID";
            worksheet.Cells[1, 2].Value = "Email";
            worksheet.Cells[1, 3].Value = "AddDate";

            // Đổ dữ liệu vào Excel
            for (int i = 0; i < newsletters.Count; i++)
            {
                worksheet.Cells[i + 2, 1].Value = newsletters[i].NewLetterID;
                worksheet.Cells[i + 2, 2].Value = newsletters[i].Email;
                worksheet.Cells[i + 2, 3].Value = newsletters[i].AddDate?.ToString("dd/MM/yyyy");
            }

            // Tự động điều chỉnh kích thước cột
            worksheet.Cells.AutoFitColumns();

            // Chuyển đổi thành byte array và trả về file
            var excelData = package.GetAsByteArray();
            return File(excelData, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Newsletters.xlsx");
        }

        [Route("admin/products/productlist")]
        public async Task<IActionResult> ProductList(int page = 1, string searchTerm = null, int? categoryId = null)
        {
            const int pageSize = 10;
            IQueryable<TProduct> query = _context.TProduct
                .Include(p => p.TProductDescription)
                .Include(p => p.TProductToCategory)
                .ThenInclude(pc => pc.TProductCategory)
                .Include(p => p.TProductImage);

            // Lọc theo từ khóa tìm kiếm
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(p => p.TProductDescription.Any(d => d.Name != null && d.Name.Contains(searchTerm)) ||
                                        p.Model != null && p.Model.Contains(searchTerm));
            }

            // Lọc theo danh mục
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.TProductToCategory.Any(pc => pc.CategoryID == categoryId));
            }

            var totalRecords = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

            var products = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // Xử lý logic null trong bộ nhớ
            var result = products.Select(p => new
            {
                p.ProductID,
                ProductName = p.TProductDescription.FirstOrDefault(d => d.LanguageID == 1)?.Name ?? "No Name",
                CategoryName = p.TProductToCategory.Select(pc => pc.TProductCategory).FirstOrDefault()?.Keyword ?? "No Category",
                p.SortOrder,
                p.Price,
                p.Status,
                p.RegDate,
                ImageLink = p.TProductImage.FirstOrDefault()?.ImageLink ?? "https://via.placeholder.com/48x48"
            }).ToList();

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            ViewBag.SearchTerm = searchTerm;
            ViewBag.CategoryId = categoryId;
            ViewBag.TotalRecords = totalRecords;

            ViewBag.Categories = await _context.TProductCategory
                .Select(c => new { c.CategoryID, c.Keyword })
                .ToListAsync();

            return View("~/Views/Admin/Products/ProductList.cshtml", result);
        }

        [Route("admin/products/produccategory")]
        public IActionResult ProducCategory()
        {
            return View("~/Views/Admin/Products/ProducCategory.cshtml");
        }

        [Route("admin/products/brands")]
        public IActionResult Brands()
        {
            return View("~/Views/Admin/Products/Brands.cshtml");
        }

        [Route("admin/products/ordermanagement")]
        public IActionResult OrderManagement()
        {
            return View("~/Views/Admin/Products/OrderManagement.cshtml");
        }

        [Route("admin/products/productcommitment")]
        public IActionResult ProductCommitment()
        {
            return View("~/Views/Admin/Products/ProductCommitment.cshtml");
        }

        [Route("admin/products/categorybanner")]
        public IActionResult CategoryBanner()
        {
            return View("~/Views/Admin/Products/CategoryBanner.cshtml");
        }

        [Route("admin/products/orderbutton")]
        public IActionResult OrderButton()
        {
            return View("~/Views/Admin/Products/OrderButton.cshtml");
        }

        [Route("admin/payment/cashondelivery")]
        public IActionResult CashOnDelivery()
        {
            return View("~/Views/Admin/Payment/CashOnDelivery.cshtml");
        }

        [Route("admin/payment/banktransfer")]
        public IActionResult BankTransfer()
        {
            return View("~/Views/Admin/Payment/BankTransfer.cshtml");
        }

        [Route("admin/contact/contactinfo")]
        public IActionResult ContactInfo()
        {
            return View("~/Views/Admin/Contact/ContactInfo.cshtml");
        }

        [Route("admin/contact/hotline")]
        public IActionResult Hotline()
        {
            return View("~/Views/Admin/Contact/Hotline.cshtml");
        }

        [Route("admin/contact/map")]
        public IActionResult Map()
        {
            return View("~/Views/Admin/Contact/Map.cshtml");
        }

        [Route("admin/contact/adminemail")]
        public IActionResult AdminEmail()
        {
            return View("~/Views/Admin/Contact/AdminEmail.cshtml");
        }

        [Route("admin/othermanagement/otherconfig")]
        public IActionResult OtherConfig()
        {
            return View("~/Views/Admin/OtherManagement/OtherConfig.cshtml");
        }

        [Route("admin/othermanagement/filemanagement")]
        public IActionResult FileManagement()
        {
            return View("~/Views/Admin/OtherManagement/FileManagement.cshtml");
        }

        [Route("admin/othermanagement/admininfo")]
        public IActionResult AdminInfo()
        {
            return View("~/Views/Admin/OtherManagement/AdminInfo.cshtml");
        }

        [Route("admin/seo/homeseo")]
        public IActionResult HomeSEO()
        {
            return View("~/Views/Admin/SEO/HomeSEO.cshtml");
        }

        [Route("admin/seo/googlemanager")]
        public IActionResult GoogleManager()
        {
            return View("~/Views/Admin/SEO/GoogleManager.cshtml");
        }

        [Route("admin/seo/sitemap")]
        public IActionResult Sitemap()
        {
            return View("~/Views/Admin/SEO/Sitemap.cshtml");
        }

        [Route("admin/seo/linknavigation")]
        public IActionResult LinkNavigation()
        {
            return View("~/Views/Admin/SEO/LinkNavigation.cshtml");
        }

        [Route("admin/logout")]
        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}