using Microsoft.EntityFrameworkCore;
using MedicalCharlesWembley.Models;

namespace MedicalCharlesWembley.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet for all tables (sử dụng tên số ít để nhất quán với tên bảng)
        public DbSet<MapAllID> MapAllID { get; set; }
        public DbSet<NewLetter> NewLetter { get; set; }
        public DbSet<TArea> TArea { get; set; }
        public DbSet<TAreaMap> TAreaMap { get; set; }
        public DbSet<TBannerAdv> TBannerAdv { get; set; }
        public DbSet<TBannerAdvDescription> TBannerAdvDescription { get; set; }
        public DbSet<TComment> TComment { get; set; }
        public DbSet<TCommonFile> TCommonFile { get; set; }
        public DbSet<TConfig> TConfig { get; set; }
        public DbSet<TCountry> TCountry { get; set; }
        public DbSet<TCoupon> TCoupon { get; set; }
        public DbSet<TCouponDescription> TCouponDescription { get; set; }
        public DbSet<TCouponProduct> TCouponProduct { get; set; }
        public DbSet<TCurrency> TCurrency { get; set; }
        public DbSet<TCustomer> TCustomer { get; set; }
        public DbSet<TDBErrLog> TDBErrLog { get; set; }
        public DbSet<TDownload> TDownload { get; set; }
        public DbSet<TFileUpload> TFileUpload { get; set; }
        public DbSet<TLanguage> TLanguage { get; set; }
        public DbSet<TManufacturer> TManufacturer { get; set; }
        public DbSet<TMapTerritoryArea> TMapTerritoryArea { get; set; }
        public DbSet<TMapType> TMapType { get; set; }
        public DbSet<TMenu> TMenu { get; set; }
        public DbSet<TMenuAdmin> TMenuAdmin { get; set; }
        public DbSet<TmpProduct> TmpProduct { get; set; }
        public DbSet<TNews> TNews { get; set; }
        public DbSet<TNewsCategory> TNewsCategory { get; set; }
        public DbSet<TNewsCategoryDescription> TNewsCategoryDescription { get; set; }
        public DbSet<TNewsDescription> TNewsDescription { get; set; }
        public DbSet<TNewsSource> TNewsSource { get; set; }
        public DbSet<TNewsToCategory> TNewsToCategory { get; set; }
        public DbSet<TOrder> TOrder { get; set; }
        public DbSet<TOrderProduct> TOrderProduct { get; set; }
        public DbSet<TPollOption> TPollOption { get; set; }
        public DbSet<TPoll> TPoll { get; set; }
        public DbSet<TProduct> TProduct { get; set; }
        public DbSet<TProductCart> TProductCart { get; set; }
        public DbSet<TProductCategory> TProductCategory { get; set; }
        public DbSet<TProductCategoryDescription> TProductCategoryDescription { get; set; }
        public DbSet<TProductColor> TProductColor { get; set; }
        public DbSet<TProductDescription> TProductDescription { get; set; }
        public DbSet<TProductDiscount> TProductDiscount { get; set; }
        public DbSet<TProductImage> TProductImage { get; set; }
        public DbSet<TProductOption> TProductOption { get; set; }
        public DbSet<TProductOptionDescription> TProductOptionDescription { get; set; }
        public DbSet<TProductOptionValue> TProductOptionValue { get; set; }
        public DbSet<TProductOptionValueDescription> TProductOptionValueDescription { get; set; }
        public DbSet<TProductRelated> TProductRelated { get; set; }
        public DbSet<TProductSize> TProductSize { get; set; }
        public DbSet<TProductSizeDescription> TProductSizeDescription { get; set; }
        public DbSet<TProductSpecial> TProductSpecial { get; set; }
        public DbSet<TProductToCategory> TProductToCategory { get; set; }
        public DbSet<TProductToDownload> TProductToDownload { get; set; }
        public DbSet<TRedirectUrl> TRedirectUrl { get; set; }
        public DbSet<TRegion> TRegion { get; set; }
        public DbSet<TReview> TReview { get; set; }
        public DbSet<TSeo> TSeo { get; set; }
        public DbSet<TSeoDescription> TSeoDescription { get; set; }
        public DbSet<TSetting> TSetting { get; set; }
        public DbSet<TStockStatus> TStockStatus { get; set; }
        public DbSet<TTaxClass> TTaxClass { get; set; }
        public DbSet<TTaxRate> TTaxRate { get; set; }
        public DbSet<TTerritory> TTerritory { get; set; }
        public DbSet<TType> TType { get; set; }
        public DbSet<TUser> TUser { get; set; }
        public DbSet<TUserMapLink> TUserMapLink { get; set; }
        public DbSet<TUserMapNews> TUserMapNews { get; set; }
        public DbSet<TUserMapRole> TUserMapRole { get; set; }
        public DbSet<TUserRoleMember> TUserRoleMember { get; set; }
        public DbSet<TWeightClass> TWeightClass { get; set; }
        public DbSet<TWeightRule> TWeightRule { get; set; }
        public DbSet<TZone> TZone { get; set; }
        public DbSet<TZoneToGeoZone> TZoneToGeoZone { get; set; }
        public DbSet<UrlAlias> UrlAlias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // MapAllID
            modelBuilder.Entity<MapAllID>()
                .ToTable("MapAll_ID")
                .HasKey(m => m.Id)
                .HasName("PK_MapAll_ID");
            modelBuilder.Entity<MapAllID>()
                .Property(m => m.Id)
                .HasColumnName("MapAllID")
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<MapAllID>()
                .Property(m => m.thu_tu)
                .HasDefaultValue(0);

            // NewLetter
            modelBuilder.Entity<NewLetter>()
                .ToTable("NewLetter")
                .HasKey(n => n.NewLetterID)
                .HasName("PK_T_NewLetter");

            // TArea
            modelBuilder.Entity<TArea>()
                .ToTable("TArea")
                .HasKey(a => a.TAreaID)
                .HasName("PK_TArea");

            // TAreaMap
            modelBuilder.Entity<TAreaMap>()
                .ToTable("TAreaMap")
                .HasKey(a => a.TAreaMapID)
                .HasName("PK_TAreaMap");

            // TBannerAdv
            modelBuilder.Entity<TBannerAdv>()
                .ToTable("TBannerAdv")
                .HasKey(b => b.BannerID)
                .HasName("PK_TBannerAdv");

            // TBannerAdvDescription
            modelBuilder.Entity<TBannerAdvDescription>()
                .ToTable("TBannerAdvDescription")
                .HasKey(b => new { b.BannerID, b.LanguageID })
                .HasName("PK_TBannerAdvDescription");

            // TComment
            modelBuilder.Entity<TComment>()
                .ToTable("TComment")
                .HasKey(c => c.CommentID)
                .HasName("PK_TComment");

            // TCommonFile
            modelBuilder.Entity<TCommonFile>()
                .ToTable("TCommonFile")
                .HasKey(c => c.CommonFileID)
                .HasName("PK__TCommFile__0C66AE13");
            modelBuilder.Entity<TCommonFile>()
                .Property(c => c.RegDate)
                .HasDefaultValueSql("GETDATE()");

            // TConfig
            modelBuilder.Entity<TConfig>()
                .ToTable("TConfig")
                .HasKey(c => c.ConfigID)
                .HasName("PK_TConfig");

            // TCountry
            modelBuilder.Entity<TCountry>()
                .ToTable("TCountry")
                .HasKey(c => c.country_id)
                .HasName("PK_TCountry");
            modelBuilder.Entity<TCountry>()
                .Property(c => c.iso_code_2)
                .HasDefaultValue("");
            modelBuilder.Entity<TCountry>()
                .Property(c => c.iso_code_3)
                .HasDefaultValue("");

            // TCoupon
            modelBuilder.Entity<TCoupon>()
                .ToTable("TCoupon")
                .HasKey(c => c.coupon_id)
                .HasName("PK_TCoupon");
            modelBuilder.Entity<TCoupon>()
                .Property(c => c.discount)
                .HasPrecision(15, 4);
            modelBuilder.Entity<TCoupon>()
                .Property(c => c.total)
                .HasPrecision(15, 4);
            modelBuilder.Entity<TCoupon>()
                .Property(c => c.date_added)
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            // TCouponDescription
            modelBuilder.Entity<TCouponDescription>()
                .ToTable("TCouponDescription")
                .HasKey(c => new { c.coupon_id, c.language_id })
                .HasName("PK_TCouponDescription");

            // TCouponProduct
            modelBuilder.Entity<TCouponProduct>()
                .ToTable("TCouponProduct")
                .HasKey(c => c.coupon_product_id)
                .HasName("PK_TCouponProduct");

            // TCurrency
            modelBuilder.Entity<TCurrency>()
                .ToTable("TCurrency")
                .HasKey(c => c.CurrencyID)
                .HasName("PK_TCurrency");
            modelBuilder.Entity<TCurrency>()
                .Property(c => c.Title)
                .HasDefaultValue("");
            modelBuilder.Entity<TCurrency>()
                .Property(c => c.Code)
                .HasDefaultValue("");
            modelBuilder.Entity<TCurrency>()
                .Property(c => c.SymbolLeft)
                .HasDefaultValue(null);
            modelBuilder.Entity<TCurrency>()
                .Property(c => c.SymbolRight)
                .HasDefaultValue(null);
            modelBuilder.Entity<TCurrency>()
                .Property(c => c.DecimalPlace)
                .HasDefaultValue(null);
            modelBuilder.Entity<TCurrency>()
                .Property(c => c.Value)
                .HasDefaultValue(null);
            modelBuilder.Entity<TCurrency>()
                .Property(c => c.ModifyDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            // TCustomer
            modelBuilder.Entity<TCustomer>()
                .ToTable("TCustomer")
                .HasKey(c => c.customer_id)
                .HasName("PK_TCustomer");
            modelBuilder.Entity<TCustomer>()
                .Property(c => c.firstname)
                .HasDefaultValue("");
            modelBuilder.Entity<TCustomer>()
                .Property(c => c.lastname)
                .HasDefaultValue("");
            modelBuilder.Entity<TCustomer>()
                .Property(c => c.email)
                .HasDefaultValue("");
            modelBuilder.Entity<TCustomer>()
                .Property(c => c.telephone)
                .HasDefaultValue("");
            modelBuilder.Entity<TCustomer>()
                .Property(c => c.fax)
                .HasDefaultValue("");
            modelBuilder.Entity<TCustomer>()
                .Property(c => c.password)
                .HasDefaultValue("");
            modelBuilder.Entity<TCustomer>()
                .Property(c => c.newsletter)
                .HasDefaultValue(0);
            modelBuilder.Entity<TCustomer>()
                .Property(c => c.address_id)
                .HasDefaultValue(0);
            modelBuilder.Entity<TCustomer>()
                .Property(c => c.ip)
                .HasDefaultValue(null);
            modelBuilder.Entity<TCustomer>()
                .Property(c => c.date_added)
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            // TDBErrLog
            modelBuilder.Entity<TDBErrLog>()
                .ToTable("TDBErrLog")
                .HasKey(e => e.ErrorLogID)
                .HasName("PK_TDBErrLog");

            // TDownload
            modelBuilder.Entity<TDownload>()
                .ToTable("TDownload")
                .HasKey(d => d.DownloadID)
                .HasName("PK_TDownload");
            modelBuilder.Entity<TDownload>()
                .Property(d => d.Filename)
                .HasDefaultValue("");
            modelBuilder.Entity<TDownload>()
                .Property(d => d.Mask)
                .HasDefaultValue("");
            modelBuilder.Entity<TDownload>()
                .Property(d => d.Remaining)
                .HasDefaultValue(0);
            modelBuilder.Entity<TDownload>()
                .Property(d => d.RegDate)
                .HasDefaultValueSql("GETDATE()");

            // TFileUpload
            modelBuilder.Entity<TFileUpload>()
                .ToTable("TFileUpload")
                .HasKey(f => f.UploadFileID)
                .HasName("PK_FileUpload");

            // TLanguage
            modelBuilder.Entity<TLanguage>()
                .ToTable("TLanguage")
                .HasKey(l => l.LanguageID)
                .HasName("PK__language__66603565");
            modelBuilder.Entity<TLanguage>()
                .Property(l => l.Name)
                .HasDefaultValue("");
            modelBuilder.Entity<TLanguage>()
                .Property(l => l.Image)
                .HasDefaultValue(null);
            modelBuilder.Entity<TLanguage>()
                .Property(l => l.Directory)
                .HasDefaultValue("");
            modelBuilder.Entity<TLanguage>()
                .Property(l => l.FileName)
                .HasDefaultValue("");
            modelBuilder.Entity<TLanguage>()
                .Property(l => l.SortOrder)
                .HasDefaultValue(null);

            // TManufacturer
            modelBuilder.Entity<TManufacturer>()
                .ToTable("TManufacturer")
                .HasKey(m => m.ManufacturerID)
                .HasName("PK__manufacturer__6D0D32F4");
            modelBuilder.Entity<TManufacturer>()
                .Property(m => m.Name)
                .HasDefaultValue("");
            modelBuilder.Entity<TManufacturer>()
                .Property(m => m.Image)
                .HasDefaultValue(0);
            modelBuilder.Entity<TManufacturer>()
                .Property(m => m.SortOrder)
                .HasDefaultValue(0);

            // TMapTerritoryArea
            modelBuilder.Entity<TMapTerritoryArea>()
                .ToTable("TMapTerritoryArea")
                .HasKey(m => m.MapTerriAreaID)
                .HasName("PK_TMapTerritoryArea");

            // TMapType
            modelBuilder.Entity<TMapType>()
                .ToTable("TMapType")
                .HasKey(m => m.MapTypeID)
                .HasName("PK_TMapType");

            // TMenu
            modelBuilder.Entity<TMenu>()
                .ToTable("TMenu")
                .HasKey(m => m.Menu_ID)
                .HasName("PK_TMenu");
            modelBuilder.Entity<TMenu>()
                .Property(m => m.Reg_Date)
                .HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<TMenu>()
                .Property(m => m.Update_Date)
                .HasDefaultValueSql("GETDATE()");

            // TMenuAdmin
            modelBuilder.Entity<TMenuAdmin>()
                .ToTable("TMenuAdmin")
                .HasKey(m => m.MenuID)
                .HasName("PK_TMenuAdmin");

            // TmpProduct
            modelBuilder.Entity<TmpProduct>()
                .ToTable("TmpProduct")
                .HasNoKey();

            // TNews
            modelBuilder.Entity<TNews>()
                .ToTable("TNews")
                .HasKey(n => n.NewsID)
                .HasName("PK_news");

            // TNewsCategory
            modelBuilder.Entity<TNewsCategory>()
                .ToTable("TNewsCategory")
                .HasKey(n => n.NewsCategoryID)
                .HasName("PK_category");

            // TNewsCategoryDescription
            modelBuilder.Entity<TNewsCategoryDescription>()
                .ToTable("TNewsCategoryDescription")
                .HasKey(n => new { n.NewsCategoryID, n.LanguageID })
                .HasName("PK_TNewsCategoryDescription");
            modelBuilder.Entity<TNewsCategoryDescription>()
                .HasOne(n => n.TNewsCategory)
                .WithMany()
                .HasForeignKey(n => n.NewsCategoryID)
                .HasConstraintName("FK_TNewsCategoryDescription_TNewsCategory");

            // TNewsDescription
            modelBuilder.Entity<TNewsDescription>()
                .ToTable("TNewsDescription")
                .HasKey(n => new { n.NewsID, n.LanguageID })
                .HasName("PK_TNewsDescription");

            // TNewsSource
            modelBuilder.Entity<TNewsSource>()
                .ToTable("TNewsSource")
                .HasKey(n => new { n.NewsSourceID, n.LanguageID })
                .HasName("PK_tapchi");

            // TNewsToCategory
            modelBuilder.Entity<TNewsToCategory>()
                .ToTable("TNewsToCategory")
                .HasKey(n => new { n.NewsCategoryID, n.NewsID })
                .HasName("PK_TNewsCategoryDetail");
            modelBuilder.Entity<TNewsToCategory>()
                .HasOne(n => n.TNewsCategory)
                .WithMany()
                .HasForeignKey(n => n.NewsCategoryID)
                .HasConstraintName("FK_TNewsToCategory_TNewsCategory");

            // TOrder
            modelBuilder.Entity<TOrder>()
                .ToTable("TOrder")
                .HasKey(o => o.OrderID)
                .HasName("PK_TOrder");
            modelBuilder.Entity<TOrder>()
                .Property(o => o.Total)
                .HasPrecision(15, 4);

            // TOrderProduct
            modelBuilder.Entity<TOrderProduct>()
                .ToTable("TOrderProduct")
                .HasKey(o => o.OrderProductID)
                .HasName("PK_TOrderProduct");
            modelBuilder.Entity<TOrderProduct>()
                .Property(o => o.Status)
                .HasDefaultValue(0);
            modelBuilder.Entity<TOrderProduct>()
                .Property(o => o.Price)
                .HasPrecision(15, 4);
            modelBuilder.Entity<TOrderProduct>()
                .Property(o => o.Total)
                .HasPrecision(15, 4);

            // TPollOption
            modelBuilder.Entity<TPollOption>()
                .ToTable("TPollOption")
                .HasKey(p => new { p.PollOptionID, p.PollID })
                .HasName("PK_TPollOptions");
            modelBuilder.Entity<TPollOption>()
                .HasOne(p => p.TPoll)
                .WithMany()
                .HasForeignKey(p => p.PollID)
                .HasConstraintName("FK_TPollOptions_TPolls");

            // TPoll
            modelBuilder.Entity<TPoll>()
                .ToTable("TPoll")
                .HasKey(p => p.PollID)
                .HasName("PK_TPolls");

            // TProduct
            modelBuilder.Entity<TProduct>()
                .ToTable("TProduct")
                .HasKey(p => p.ProductID)
                .HasName("PK__product__2EDAF651");
            modelBuilder.Entity<TProduct>()
                .Property(p => p.Quantity)
                .HasDefaultValue(0);
            modelBuilder.Entity<TProduct>()
                .Property(p => p.ManufacturerID)
                .HasDefaultValue(0);
            modelBuilder.Entity<TProduct>()
                .Property(p => p.Shipping)
                .HasDefaultValue(1);
            modelBuilder.Entity<TProduct>()
                .Property(p => p.Price)
                .HasPrecision(15, 4);
            modelBuilder.Entity<TProduct>()
                .Property(p => p.DateAvailable)
                .HasDefaultValue(null);
            modelBuilder.Entity<TProduct>()
                .Property(p => p.Weight)
                .HasPrecision(5, 2);
            modelBuilder.Entity<TProduct>()
                .Property(p => p.WeightClassID)
                .HasDefaultValue(0);
            modelBuilder.Entity<TProduct>()
                .Property(p => p.Status)
                .HasDefaultValue(0);
            modelBuilder.Entity<TProduct>()
                .Property(p => p.RegDate)
                .HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<TProduct>()
                .Property(p => p.ModifyDate)
                .HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<TProduct>()
                .Property(p => p.CountView)
                .HasDefaultValue(0);

            // TProductCart
            modelBuilder.Entity<TProductCart>()
                .ToTable("TProductCart")
                .HasKey(p => p.CartID)
                .HasName("PK_TProductCart");

           // TProductCategory
            modelBuilder.Entity<TProductCategory>(entity =>
            {
                entity.ToTable("TProductCategory");

                entity.HasKey(p => p.CategoryID)
                    .HasName("PK__category__22AA2996");

                entity.Property(e => e.Image)
                    .HasDefaultValue((long?)0); // Sửa đúng cú pháp

                entity.Property(p => p.ParentID)
                    .HasDefaultValue(0);

                entity.Property(p => p.SortOrder)
                    .HasDefaultValue(0);

                entity.Property(p => p.RegDate)
                    .HasDefaultValueSql("GETDATE()");

                entity.Property(p => p.ModifyDate)
                    .HasDefaultValueSql("GETDATE()");
            });


            // TProductCategoryDescription
            modelBuilder.Entity<TProductCategoryDescription>()
                .ToTable("TProductCategoryDescription")
                .HasKey(p => new { p.CategoryID, p.LanguageID })
                .HasName("PK__category_descrip__29572725");
            modelBuilder.Entity<TProductCategoryDescription>()
                .Property(p => p.Name)
                .HasDefaultValue("");

            // TProductColor
            modelBuilder.Entity<TProductColor>()
                .ToTable("TProductColor")
                .HasKey(p => p.ProductColorID)
                .HasName("PK__product_color__40058253");
            modelBuilder.Entity<TProductColor>()
                .HasOne(p => p.TProduct)
                .WithMany()
                .HasForeignKey(p => p.ProductID)
                .HasConstraintName("FK_TProductColor_TProduct");
            modelBuilder.Entity<TProductColor>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            // TProductDescription
            modelBuilder.Entity<TProductDescription>()
                .ToTable("TProductDescription")
                .HasKey(p => new { p.ProductID, p.LanguageID })
                .HasName("PK__product_descript__3B40CD36");
            modelBuilder.Entity<TProductDescription>()
                .Property(p => p.LanguageID)
                .HasDefaultValue(1);
            modelBuilder.Entity<TProductDescription>()
                .HasOne(p => p.TProduct)
                .WithMany()
                .HasForeignKey(p => p.ProductID)
                .HasConstraintName("FK_TProductDescription_TProduct");

            // TProductDiscount
            modelBuilder.Entity<TProductDiscount>()
                .ToTable("TProductDiscount")
                .HasKey(p => p.ProductDiscountID)
                .HasName("PK_TProductDiscount");
            modelBuilder.Entity<TProductDiscount>()
                .HasOne(p => p.TProduct)
                .WithMany()
                .HasForeignKey(p => p.ProductID)
                .HasConstraintName("FK_TProductDiscount_TProduct");
            modelBuilder.Entity<TProductDiscount>()
                .Property(p => p.Discount)
                .HasPrecision(15, 4);

            // TProductImage
            modelBuilder.Entity<TProductImage>()
                .ToTable("TProductImage")
                .HasKey(pi => pi.ProductImageID)
                .HasName("PK__product_image__40058253");
            modelBuilder.Entity<TProductImage>()
                .Property(pi => pi.ProductImageID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<TProductImage>()
                .Property(pi => pi.ImageLink)
                .HasMaxLength(255)
                .HasDefaultValue(null);
            modelBuilder.Entity<TProductImage>()
                .HasOne(pi => pi.TProduct)
                .WithMany()
                .HasForeignKey(pi => pi.ProductID)
                .HasConstraintName("FK_TProductImage_TProduct");

            // TProductOption
            modelBuilder.Entity<TProductOption>()
                .ToTable("TProductOption")
                .HasKey(p => p.ProductOptionID)
                .HasName("PK_TProductOption");
            modelBuilder.Entity<TProductOption>()
                .Property(p => p.ProductID)
                .HasDefaultValue(0);
            modelBuilder.Entity<TProductOption>()
                .Property(p => p.SortOrder)
                .HasDefaultValue(0);
            modelBuilder.Entity<TProductOption>()
                .HasOne(p => p.TProduct)
                .WithMany()
                .HasForeignKey(p => p.ProductID)
                .HasConstraintName("FK_product_option_product");

            // TProductOptionDescription
            modelBuilder.Entity<TProductOptionDescription>()
                .ToTable("TProductOptionDescription")
                .HasKey(p => new { p.ProductOptionID, p.LanguageID })
                .HasName("PK_TProductOptionDescription");
            modelBuilder.Entity<TProductOptionDescription>()
                .HasOne(p => p.TProductOption)
                .WithMany()
                .HasForeignKey(p => p.ProductOptionID)
                .HasConstraintName("FK_TProductOptionDescription_TProductOption");

            // TProductOptionValue
            modelBuilder.Entity<TProductOptionValue>()
                .ToTable("TProductOptionValue")
                .HasKey(p => p.ProductOptionValueID)
                .HasName("PK_TProductOptionValue");
            modelBuilder.Entity<TProductOptionValue>()
                .HasOne(p => p.TProduct)
                .WithMany()
                .HasForeignKey(p => p.ProductID)
                .HasConstraintName("FK_TProductOptionValue_TProduct");
            modelBuilder.Entity<TProductOptionValue>()
                .HasOne(p => p.TProductOption)
                .WithMany()
                .HasForeignKey(p => p.ProductOptionID)
                .HasConstraintName("FK_TProductOptionValue_TProductOption");
            modelBuilder.Entity<TProductOptionValue>()
                .Property(p => p.Price)
                .HasPrecision(15, 4);

            // TProductOptionValueDescription
            modelBuilder.Entity<TProductOptionValueDescription>()
                .ToTable("TProductOptionValueDescription")
                .HasKey(p => new { p.ProductOptionValueID, p.LanguageID })
                .HasName("PK_TProductOptionValueDescription");
            modelBuilder.Entity<TProductOptionValueDescription>()
                .HasOne(p => p.TProductOptionValue)
                .WithMany()
                .HasForeignKey(p => p.ProductOptionValueID)
                .HasConstraintName("FK_TProductOptionValueDescription_TProductOptionValue");

            // TProductRelated
            modelBuilder.Entity<TProductRelated>()
                .ToTable("TProductRelated")
                .HasKey(p => new { p.ProductID, p.RelatedID })
                .HasName("PK_TProductRelated");
            modelBuilder.Entity<TProductRelated>()
                .HasOne(p => p.TProduct)
                .WithMany()
                .HasForeignKey(p => p.ProductID)
                .HasConstraintName("FK_TProductRelated_TProduct");
            modelBuilder.Entity<TProductRelated>()
                .HasOne(p => p.TRelatedProduct)
                .WithMany()
                .HasForeignKey(p => p.RelatedID)
                .HasConstraintName("FK_TProductRelated_TRelatedProduct");

            // TProductSize
            modelBuilder.Entity<TProductSize>()
                .ToTable("TProductSize")
                .HasKey(p => p.SizeID)
                .HasName("PK_TProductSize");
            modelBuilder.Entity<TProductSize>()
                .Property(p => p.Price)
                .HasPrecision(18, 4);

            // TProductSizeDescription
            modelBuilder.Entity<TProductSizeDescription>()
                .ToTable("TProductSizeDescription")
                .HasKey(p => p.SizeDesID)
                .HasName("PK_TProductSizeDescription");

            // TProductSpecial
            modelBuilder.Entity<TProductSpecial>()
                .ToTable("TProductSpecial")
                .HasKey(p => p.ProductSpecialID)
                .HasName("PK_TProductSpecial");
            modelBuilder.Entity<TProductSpecial>()
                .HasOne(p => p.TProduct)
                .WithMany()
                .HasForeignKey(p => p.ProductID)
                .HasConstraintName("FK_TProductSpecial_TProduct");
            modelBuilder.Entity<TProductSpecial>()
                .Property(p => p.Price)
                .HasPrecision(15, 4);

            // TProductToCategory
            modelBuilder.Entity<TProductToCategory>()
                .ToTable("TProductToCategory")
                .HasKey(p => new { p.ProductID, p.CategoryID })
                .HasName("PK_TProductToCategory");
            modelBuilder.Entity<TProductToCategory>()
                .Property(p => p.ProductID)
                .HasDefaultValue(0);
            modelBuilder.Entity<TProductToCategory>()
                .Property(p => p.CategoryID)
                .HasDefaultValue(0);
            modelBuilder.Entity<TProductToCategory>()
                .HasOne(p => p.TProduct)
                .WithMany()
                .HasForeignKey(p => p.ProductID)
                .HasConstraintName("FK_TProductToCategory_TProduct");
            modelBuilder.Entity<TProductToCategory>()
                .HasOne(p => p.TProductCategory)
                .WithMany()
                .HasForeignKey(p => p.CategoryID)
                .HasConstraintName("FK_TProductToCategory_TProductCategory");

            // TProductToDownload
            modelBuilder.Entity<TProductToDownload>()
                .ToTable("TProductToDownload")
                .HasKey(p => new { p.ProductID, p.DownloadID })
                .HasName("PK_TProductToDownload");
            modelBuilder.Entity<TProductToDownload>()
                .Property(p => p.ProductID)
                .HasDefaultValue(0);
            modelBuilder.Entity<TProductToDownload>()
                .Property(p => p.DownloadID)
                .HasDefaultValue(0);
            modelBuilder.Entity<TProductToDownload>()
                .HasOne(p => p.TProduct)
                .WithMany()
                .HasForeignKey(p => p.ProductID)
                .HasConstraintName("FK_TProductToDownload_TProduct");
            modelBuilder.Entity<TProductToDownload>()
                .HasOne(p => p.TDownload)
                .WithMany()
                .HasForeignKey(p => p.DownloadID)
                .HasConstraintName("FK_TProductToDownload_TDownload");

            // TRedirectUrl
            modelBuilder.Entity<TRedirectUrl>()
                .ToTable("TRedirectUrl")
                .HasKey(r => r.ID)
                .HasName("PK_TRedirectUrl");
            modelBuilder.Entity<TRedirectUrl>()
                .Property(r => r.LastUpdate)
                .HasDefaultValueSql("GETDATE()");

            // TRegion
            modelBuilder.Entity<TRegion>()
                .ToTable("TRegion")
                .HasKey(r => r.RegionID)
                .HasName("PK_TRegion");

            // TReview
            modelBuilder.Entity<TReview>()
                .ToTable("TReview")
                .HasKey(r => r.review_id)
                .HasName("PK_TReview");
            modelBuilder.Entity<TReview>()
                .Property(r => r.product_id)
                .HasDefaultValue(0);
            modelBuilder.Entity<TReview>()
                .Property(r => r.customer_id)
                .HasDefaultValue(0);
            modelBuilder.Entity<TReview>()
                .Property(r => r.author)
                .HasDefaultValue("");
            modelBuilder.Entity<TReview>()
                .Property(r => r.rating)
                .HasDefaultValue(null);
            modelBuilder.Entity<TReview>()
                .Property(r => r.status)
                .HasDefaultValue(0);
            modelBuilder.Entity<TReview>()
                .Property(r => r.date_added)
                .HasDefaultValueSql("'0000-00-00 00:00:00'");
            modelBuilder.Entity<TReview>()
                .Property(r => r.date_modified)
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            // TSeo
            modelBuilder.Entity<TSeo>()
                .ToTable("TSeo")
                .HasKey(s => s.SeoID)
                .HasName("PK_TSeo");

            // TSeoDescription
            modelBuilder.Entity<TSeoDescription>()
                .ToTable("TSeoDescription")
                .HasKey(s => s.SeoDesID)
                .HasName("PK_TSeoDescription");

            // TSetting
            modelBuilder.Entity<TSetting>()
                .ToTable("TSetting")
                .HasKey(s => s.setting_id)
                .HasName("PK_TSetting");
            modelBuilder.Entity<TSetting>()
                .Property(s => s.key)
                .HasDefaultValue("");

            // TStockStatus
            modelBuilder.Entity<TStockStatus>()
                .ToTable("TStockStatus")
                .HasKey(s => new { s.StockStatusID, s.LanguageID })
                .HasName("PK_TStockStatus");

            // TTaxClass
            modelBuilder.Entity<TTaxClass>()
                .ToTable("TTaxClass")
                .HasKey(t => t.TaxClassID)
                .HasName("PK_TTaxClass");
            modelBuilder.Entity<TTaxClass>()
                .Property(t => t.Title)
                .HasDefaultValue("");
            modelBuilder.Entity<TTaxClass>()
                .Property(t => t.Description)
                .HasDefaultValue("");
            modelBuilder.Entity<TTaxClass>()
                .Property(t => t.RegDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'");
            modelBuilder.Entity<TTaxClass>()
                .Property(t => t.ModifyDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            // TTaxRate
            modelBuilder.Entity<TTaxRate>()
                .ToTable("TTaxRate")
                .HasKey(t => t.tax_rate_id)
                .HasName("PK_TTaxRate");
            modelBuilder.Entity<TTaxRate>()
                .Property(t => t.geo_zone_id)
                .HasDefaultValue(0);
            modelBuilder.Entity<TTaxRate>()
                .Property(t => t.tax_class_id)
                .HasDefaultValue(0);
            modelBuilder.Entity<TTaxRate>()
                .Property(t => t.priority)
                .HasDefaultValue(1);
            modelBuilder.Entity<TTaxRate>()
                .Property(t => t.rate)
                .HasPrecision(7, 4);
            modelBuilder.Entity<TTaxRate>()
                .Property(t => t.description)
                .HasDefaultValue("");
            modelBuilder.Entity<TTaxRate>()
                .Property(t => t.date_modified)
                .HasDefaultValueSql("'0000-00-00 00:00:00'");
            modelBuilder.Entity<TTaxRate>()
                .Property(t => t.date_added)
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            // TTerritory
            modelBuilder.Entity<TTerritory>()
                .ToTable("TTerritory")
                .HasKey(t => t.TerritoryID)
                .HasName("PK_TTerritory");

            // TType
            modelBuilder.Entity<TType>()
                .ToTable("TType")
                .HasKey(t => t.TypeID)
                .HasName("PK_TType");

            // TUser
            modelBuilder.Entity<TUser>()
                .ToTable("TUser")
                .HasKey(u => u.UserID)
                .HasName("PK_TGM_USR");

            // TUserMapLink
            modelBuilder.Entity<TUserMapLink>()
                .ToTable("TUserMapLink")
                .HasKey(u => u.MapLinkID)
                .HasName("PK_TUserMapLink_1");

            // TUserMapNews
            modelBuilder.Entity<TUserMapNews>()
                .ToTable("TUserMapNews")
                .HasKey(u => u.MapMemberNewID)
                .HasName("PK_TUserMapNews");

            // TUserMapRole
            modelBuilder.Entity<TUserMapRole>()
                .ToTable("TUserMapRole")
                .HasKey(u => u.UserMapRoleID)
                .HasName("PK_TUserMapRole");

            // TUserRoleMember
            modelBuilder.Entity<TUserRoleMember>()
                .ToTable("TUserRoleMember")
                .HasKey(u => u.RoleMemberID)
                .HasName("PK_TRoleMember");

            // TWeightClass
            modelBuilder.Entity<TWeightClass>()
                .ToTable("TWeightClass")
                .HasKey(w => new { w.WeightClassID, w.LanguageID })
                .HasName("PK_TWeightClass");
            modelBuilder.Entity<TWeightClass>()
                .Property(w => w.Unit)
                .HasDefaultValue("");

            // TWeightRule
            modelBuilder.Entity<TWeightRule>()
                .ToTable("TWeightRule")
                .HasNoKey();
            modelBuilder.Entity<TWeightRule>()
                .Property(w => w.from_id)
                .HasDefaultValue(0);
            modelBuilder.Entity<TWeightRule>()
                .Property(w => w.to_id)
                .HasDefaultValue(0);
            modelBuilder.Entity<TWeightRule>()
                .Property(w => w.rule)
                .HasPrecision(15, 4);

            // TZone
            modelBuilder.Entity<TZone>()
                .ToTable("TZone")
                .HasKey(z => z.zone_id)
                .HasName("PK_TZone");
            modelBuilder.Entity<TZone>()
                .Property(z => z.country_id)
                .HasDefaultValue(0);
            modelBuilder.Entity<TZone>()
                .Property(z => z.code)
                .HasDefaultValue("");

            // TZoneToGeoZone
            modelBuilder.Entity<TZoneToGeoZone>()
                .ToTable("TZoneToGeoZone")
                .HasKey(z => z.zone_to_geo_zone_id)
                .HasName("PK_TZoneToGeoZone");
            modelBuilder.Entity<TZoneToGeoZone>()
                .Property(z => z.country_id)
                .HasDefaultValue(0);
            modelBuilder.Entity<TZoneToGeoZone>()
                .Property(z => z.zone_id)
                .HasDefaultValue(null);
            modelBuilder.Entity<TZoneToGeoZone>()
                .Property(z => z.geo_zone_id)
                .HasDefaultValue(null);
            modelBuilder.Entity<TZoneToGeoZone>()
                .Property(z => z.date_added)
                .HasDefaultValueSql("'0000-00-00 00:00:00'");
            modelBuilder.Entity<TZoneToGeoZone>()
                .Property(z => z.date_modified)
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            // UrlAlias
            modelBuilder.Entity<UrlAlias>()
                .ToTable("UrlAlias")
                .HasKey(u => u.url_alias_id)
                .HasName("PK_UrlAlias");
        }
    }
}