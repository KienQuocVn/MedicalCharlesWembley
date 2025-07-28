using Microsoft.AspNetCore.Mvc;
using MedicalCharlesWembley.Data;
using MedicalCharlesWembley.Models;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Newsletter()
        {
            return View("~/Views/Admin/Newsletter/Index.cshtml");
        }

        [Route("admin/products/productlist")]
        public IActionResult ProductList()
        {
            return View("~/Views/Admin/Products/ProductList.cshtml");
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