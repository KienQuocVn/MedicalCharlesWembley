using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalCharlesWembley.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTProductCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MapAll_ID",
                columns: table => new
                {
                    MapAllID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MapID = table.Column<long>(type: "bigint", nullable: true),
                    MapProduct = table.Column<long>(type: "bigint", nullable: true),
                    KeyWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    thu_tu = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapAll_ID", x => x.MapAllID);
                });

            migrationBuilder.CreateTable(
                name: "NewLetters",
                columns: table => new
                {
                    NewLetterID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddByUserID = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserID = table.Column<long>(type: "bigint", nullable: true),
                    Opt1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opt2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opt3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_NewLetter", x => x.NewLetterID);
                });

            migrationBuilder.CreateTable(
                name: "TAreaMaps",
                columns: table => new
                {
                    TAreaMapID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TAreaID = table.Column<int>(type: "int", nullable: true),
                    TMapID = table.Column<long>(type: "bigint", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAreaMap", x => x.TAreaMapID);
                });

            migrationBuilder.CreateTable(
                name: "TAreas",
                columns: table => new
                {
                    TAreaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keyworder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TArea", x => x.TAreaID);
                });

            migrationBuilder.CreateTable(
                name: "TBannerAdvDescriptions",
                columns: table => new
                {
                    BannerID = table.Column<int>(type: "int", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Des1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Des2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Des3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBannerAdvDescription", x => new { x.BannerID, x.LanguageID });
                });

            migrationBuilder.CreateTable(
                name: "TBannerAdvs",
                columns: table => new
                {
                    BannerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileID = table.Column<long>(type: "bigint", nullable: true),
                    FileID1 = table.Column<long>(type: "bigint", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    KeyWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBannerAdv", x => x.BannerID);
                });

            migrationBuilder.CreateTable(
                name: "TComments",
                columns: table => new
                {
                    CommentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment_Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserID = table.Column<long>(type: "bigint", nullable: true),
                    ID_Ref = table.Column<long>(type: "bigint", nullable: true),
                    Ref_Type = table.Column<long>(type: "bigint", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    UniqueKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent = table.Column<long>(type: "bigint", nullable: true),
                    str01 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TComment", x => x.CommentID);
                });

            migrationBuilder.CreateTable(
                name: "TCommonFiles",
                columns: table => new
                {
                    CommonFileID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileSize = table.Column<int>(type: "int", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TCommFile__0C66AE13", x => x.CommonFileID);
                });

            migrationBuilder.CreateTable(
                name: "TConfigs",
                columns: table => new
                {
                    ConfigID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfigGroup1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigGroup2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigKeyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigValueRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_Admin = table.Column<bool>(type: "bit", nullable: true),
                    ConfigName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TConfig", x => x.ConfigID);
                });

            migrationBuilder.CreateTable(
                name: "TCountries",
                columns: table => new
                {
                    country_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iso_code_2 = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    iso_code_3 = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    address_format = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCountry", x => x.country_id);
                });

            migrationBuilder.CreateTable(
                name: "TCouponDescriptions",
                columns: table => new
                {
                    coupon_id = table.Column<int>(type: "int", nullable: false),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCouponDescription", x => new { x.coupon_id, x.language_id });
                });

            migrationBuilder.CreateTable(
                name: "TCouponProducts",
                columns: table => new
                {
                    coupon_product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coupon_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCouponProduct", x => x.coupon_product_id);
                });

            migrationBuilder.CreateTable(
                name: "TCoupons",
                columns: table => new
                {
                    coupon_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    shipping = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    date_start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_end = table.Column<DateTime>(type: "datetime2", nullable: false),
                    uses_total = table.Column<int>(type: "int", nullable: false),
                    uses_customer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCoupon", x => x.coupon_id);
                });

            migrationBuilder.CreateTable(
                name: "TCurrencies",
                columns: table => new
                {
                    CurrencyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    SymbolLeft = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SymbolRight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecimalPlace = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    Value = table.Column<float>(type: "real", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCurrency", x => x.CurrencyID);
                });

            migrationBuilder.CreateTable(
                name: "TCustomers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    fax = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    cart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    newsletter = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    address_id = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    status = table.Column<int>(type: "int", nullable: false),
                    ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_added = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCustomer", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "TDBErrLogs",
                columns: table => new
                {
                    ErrorLogID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorNumber = table.Column<int>(type: "int", nullable: false),
                    ErrorSeverity = table.Column<int>(type: "int", nullable: false),
                    ErrorState = table.Column<int>(type: "int", nullable: false),
                    ErrorProcedure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorLine = table.Column<int>(type: "int", nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TDBErrLog", x => x.ErrorLogID);
                });

            migrationBuilder.CreateTable(
                name: "TDownloads",
                columns: table => new
                {
                    DownloadID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    Mask = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    Remaining = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TDownload", x => x.DownloadID);
                });

            migrationBuilder.CreateTable(
                name: "TFileUploads",
                columns: table => new
                {
                    UploadFileID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConvertFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileUpload", x => x.UploadFileID);
                });

            migrationBuilder.CreateTable(
                name: "TLanguages",
                columns: table => new
                {
                    LanguageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<long>(type: "bigint", nullable: true),
                    Directory = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__language__66603565", x => x.LanguageID);
                });

            migrationBuilder.CreateTable(
                name: "TManufacturers",
                columns: table => new
                {
                    ManufacturerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    SortOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__manufacturer__6D0D32F4", x => x.ManufacturerID);
                });

            migrationBuilder.CreateTable(
                name: "TMapTerritoryAreas",
                columns: table => new
                {
                    MapTerriAreaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerritoryID = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TMapID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMapTerritoryArea", x => x.MapTerriAreaID);
                });

            migrationBuilder.CreateTable(
                name: "TMapTypes",
                columns: table => new
                {
                    MapTypeID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    MapID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMapType", x => x.MapTypeID);
                });

            migrationBuilder.CreateTable(
                name: "TMenuAdmins",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuType = table.Column<int>(type: "int", nullable: true),
                    Option1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option2 = table.Column<int>(type: "int", nullable: true),
                    Option3 = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMenuAdmin", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "TMenus",
                columns: table => new
                {
                    Menu_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Map_ID = table.Column<long>(type: "bigint", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Require_Login = table.Column<bool>(type: "bit", nullable: false),
                    Sort_Order = table.Column<int>(type: "int", nullable: false),
                    Parent_ID = table.Column<int>(type: "int", nullable: false),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alias_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reg_Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Reg_User = table.Column<int>(type: "int", nullable: false),
                    Modify_User = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option_5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option_6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMenu", x => x.Menu_ID);
                });

            migrationBuilder.CreateTable(
                name: "TmpProducts",
                columns: table => new
                {
                    Item_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    English_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Retail_price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status_for_ordering = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TNews",
                columns: table => new
                {
                    NewsID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsSourceID = table.Column<int>(type: "int", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsStatus = table.Column<int>(type: "int", nullable: true),
                    DefaultPic = table.Column<long>(type: "bigint", nullable: true),
                    CountView = table.Column<int>(type: "int", nullable: true),
                    DateMng = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IPAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegUser = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUser = table.Column<int>(type: "int", nullable: true),
                    NewsLike = table.Column<long>(type: "bigint", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Alias_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Old_Img_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Old_Post_Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_news", x => x.NewsID);
                });

            migrationBuilder.CreateTable(
                name: "TNewsCategories",
                columns: table => new
                {
                    NewsCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    IsView = table.Column<bool>(type: "bit", nullable: true),
                    Image = table.Column<long>(type: "bigint", nullable: true),
                    UniqueKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alias_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.NewsCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "TNewsDescriptions",
                columns: table => new
                {
                    NewsID = table.Column<long>(type: "bigint", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TNewsDescription", x => new { x.NewsID, x.LanguageID });
                });

            migrationBuilder.CreateTable(
                name: "TNewsSources",
                columns: table => new
                {
                    NewsSourceID = table.Column<int>(type: "int", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    NewsSourceName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tapchi", x => new { x.NewsSourceID, x.LanguageID });
                });

            migrationBuilder.CreateTable(
                name: "TOrderProducts",
                columns: table => new
                {
                    OrderProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    Total = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TOrderProduct", x => x.OrderProductID);
                });

            migrationBuilder.CreateTable(
                name: "TOrders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CouponID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TOrder", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "TPolls",
                columns: table => new
                {
                    PollID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TPolls", x => x.PollID);
                });

            migrationBuilder.CreateTable(
                name: "TProductCarts",
                columns: table => new
                {
                    CartID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    So_luong = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<float>(type: "real", nullable: true),
                    nguoi_muaID = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductCart", x => x.CartID);
                });

            migrationBuilder.CreateTable(
                name: "TProductCategories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SortOrder = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Alias_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Banner = table.Column<long>(type: "bigint", nullable: true),
                    Str1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__category__22AA2996", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "TProductCategoryDescriptions",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__category_descrip__29572725", x => new { x.CategoryID, x.LanguageID });
                });

            migrationBuilder.CreateTable(
                name: "TProducts",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    StockStatusID = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<long>(type: "bigint", nullable: false),
                    ManufacturerID = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Shipping = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Price = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    TaxClassID = table.Column<int>(type: "int", nullable: false),
                    DateAvailable = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    WeightClassID = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CountView = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CurrencyID = table.Column<int>(type: "int", nullable: true),
                    Price_Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price_Text_Bef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    str1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    str2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    str3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    str4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    str5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    str6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    str7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    str8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProNew = table.Column<int>(type: "int", nullable: true),
                    ProSale = table.Column<int>(type: "int", nullable: true),
                    Alias_Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__product__2EDAF651", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "TProductSizeDescriptions",
                columns: table => new
                {
                    SizeDesID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeID = table.Column<long>(type: "bigint", nullable: true),
                    LanguageID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductSizeDescription", x => x.SizeDesID);
                });

            migrationBuilder.CreateTable(
                name: "TProductSizes",
                columns: table => new
                {
                    SizeID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentID = table.Column<long>(type: "bigint", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductSize", x => x.SizeID);
                });

            migrationBuilder.CreateTable(
                name: "TRedirectUrls",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To_Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Module = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRedirectUrl", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TRegions",
                columns: table => new
                {
                    RegionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    FMID = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRegion", x => x.RegionID);
                });

            migrationBuilder.CreateTable(
                name: "TReviews",
                columns: table => new
                {
                    review_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    customer_id = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    date_added = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'"),
                    date_modified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TReview", x => x.review_id);
                });

            migrationBuilder.CreateTable(
                name: "TSeoDescriptions",
                columns: table => new
                {
                    SeoDesID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeoID = table.Column<long>(type: "bigint", nullable: true),
                    LanguageID = table.Column<int>(type: "int", nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoKeyWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTmp1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTmp2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSeoDescription", x => x.SeoDesID);
                });

            migrationBuilder.CreateTable(
                name: "TSeos",
                columns: table => new
                {
                    SeoID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeoType = table.Column<int>(type: "int", nullable: true),
                    MapID = table.Column<long>(type: "bigint", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Uniquekey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSeo", x => x.SeoID);
                });

            migrationBuilder.CreateTable(
                name: "TSettings",
                columns: table => new
                {
                    setting_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    key = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSetting", x => x.setting_id);
                });

            migrationBuilder.CreateTable(
                name: "TStockStatuses",
                columns: table => new
                {
                    StockStatusID = table.Column<int>(type: "int", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TStockStatus", x => new { x.StockStatusID, x.LanguageID });
                });

            migrationBuilder.CreateTable(
                name: "TTaxClasses",
                columns: table => new
                {
                    TaxClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTaxClass", x => x.TaxClassID);
                });

            migrationBuilder.CreateTable(
                name: "TTaxRates",
                columns: table => new
                {
                    tax_rate_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    geo_zone_id = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    tax_class_id = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    priority = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    rate = table.Column<decimal>(type: "decimal(7,4)", precision: 7, scale: 4, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    date_modified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'"),
                    date_added = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTaxRate", x => x.tax_rate_id);
                });

            migrationBuilder.CreateTable(
                name: "TTerritories",
                columns: table => new
                {
                    TerritoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerritoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerriParent = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    AreaID = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTerritory", x => x.TerritoryID);
                });

            migrationBuilder.CreateTable(
                name: "TTypes",
                columns: table => new
                {
                    TypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeParent = table.Column<int>(type: "int", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    TypeKeyword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TType", x => x.TypeID);
                });

            migrationBuilder.CreateTable(
                name: "TUserMapLinks",
                columns: table => new
                {
                    MapLinkID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    LinkID = table.Column<int>(type: "int", nullable: true),
                    Option1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Option2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TUserMapLink_1", x => x.MapLinkID);
                });

            migrationBuilder.CreateTable(
                name: "TUserMapNews",
                columns: table => new
                {
                    MapMemberNewID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberID = table.Column<long>(type: "bigint", nullable: true),
                    NewsID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TUserMapNews", x => x.MapMemberNewID);
                });

            migrationBuilder.CreateTable(
                name: "TUserMapRoles",
                columns: table => new
                {
                    UserMapRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleMemberID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TUserMapRole", x => x.UserMapRoleID);
                });

            migrationBuilder.CreateTable(
                name: "TUserRoleMembers",
                columns: table => new
                {
                    RoleMemberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartNumber = table.Column<int>(type: "int", nullable: true),
                    EndNumber = table.Column<int>(type: "int", nullable: true),
                    KeyWord = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRoleMember", x => x.RoleMemberID);
                });

            migrationBuilder.CreateTable(
                name: "TUsers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsExpire = table.Column<bool>(type: "bit", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegUser = table.Column<int>(type: "int", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUser = table.Column<int>(type: "int", nullable: true),
                    PermissionString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<int>(type: "int", nullable: true),
                    Brithday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YahooID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tilly = table.Column<int>(type: "int", nullable: true),
                    UserLike = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TGM_USR", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "TWeightClasses",
                columns: table => new
                {
                    WeightClassID = table.Column<int>(type: "int", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TWeightClass", x => new { x.WeightClassID, x.LanguageID });
                });

            migrationBuilder.CreateTable(
                name: "TWeightRules",
                columns: table => new
                {
                    from_id = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    to_id = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    rule = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TZones",
                columns: table => new
                {
                    zone_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    country_id = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: ""),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TZone", x => x.zone_id);
                });

            migrationBuilder.CreateTable(
                name: "TZoneToGeoZones",
                columns: table => new
                {
                    zone_to_geo_zone_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    country_id = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    zone_id = table.Column<int>(type: "int", nullable: true),
                    geo_zone_id = table.Column<int>(type: "int", nullable: true),
                    date_added = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'"),
                    date_modified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TZoneToGeoZone", x => x.zone_to_geo_zone_id);
                });

            migrationBuilder.CreateTable(
                name: "UrlAliases",
                columns: table => new
                {
                    url_alias_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    query = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alias = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlAlias", x => x.url_alias_id);
                });

            migrationBuilder.CreateTable(
                name: "TNewsCategoryDescriptions",
                columns: table => new
                {
                    NewsCategoryID = table.Column<int>(type: "int", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TNewsCategoryDescription", x => new { x.NewsCategoryID, x.LanguageID });
                    table.ForeignKey(
                        name: "FK_TNewsCategoryDescription_TNewsCategory",
                        column: x => x.NewsCategoryID,
                        principalTable: "TNewsCategories",
                        principalColumn: "NewsCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TNewsToCategories",
                columns: table => new
                {
                    NewsCategoryID = table.Column<int>(type: "int", nullable: false),
                    NewsID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TNewsCategoryDetail", x => new { x.NewsCategoryID, x.NewsID });
                    table.ForeignKey(
                        name: "FK_TNewsToCategory_TNewsCategory",
                        column: x => x.NewsCategoryID,
                        principalTable: "TNewsCategories",
                        principalColumn: "NewsCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TPollOptions",
                columns: table => new
                {
                    PollOptionID = table.Column<int>(type: "int", nullable: false),
                    PollID = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Votes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TPollOptions", x => new { x.PollOptionID, x.PollID });
                    table.ForeignKey(
                        name: "FK_TPollOptions_TPolls",
                        column: x => x.PollID,
                        principalTable: "TPolls",
                        principalColumn: "PollID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TProductColors",
                columns: table => new
                {
                    ProductColorID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Name_VN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_CN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ma_Mau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh_Anh = table.Column<long>(type: "bigint", nullable: false),
                    Sort_Order = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__product_color__40058253", x => x.ProductColorID);
                    table.ForeignKey(
                        name: "FK_TProductColor_TProduct",
                        column: x => x.ProductID,
                        principalTable: "TProducts",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TProductDescriptions",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Des1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Des2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Des3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Des4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Des5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Des6 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__product_descript__3B40CD36", x => new { x.ProductID, x.LanguageID });
                    table.ForeignKey(
                        name: "FK_TProductDescription_TProduct",
                        column: x => x.ProductID,
                        principalTable: "TProducts",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TProductDiscounts",
                columns: table => new
                {
                    ProductDiscountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductDiscount", x => x.ProductDiscountID);
                    table.ForeignKey(
                        name: "FK_TProductDiscount_TProduct",
                        column: x => x.ProductID,
                        principalTable: "TProducts",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TProductImages",
                columns: table => new
                {
                    ProductImageID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TempID1 = table.Column<int>(type: "int", nullable: true),
                    TempID2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__product_image__40058253", x => x.ProductImageID);
                    table.ForeignKey(
                        name: "FK_TProductImage_TProduct",
                        column: x => x.ProductID,
                        principalTable: "TProducts",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TProductOptions",
                columns: table => new
                {
                    ProductOptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SortOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Img = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductOption", x => x.ProductOptionID);
                    table.ForeignKey(
                        name: "FK_product_option_product",
                        column: x => x.ProductID,
                        principalTable: "TProducts",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TProductRelateds",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    RelatedID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductRelated", x => new { x.ProductID, x.RelatedID });
                    table.ForeignKey(
                        name: "FK_TProductRelated_TProduct",
                        column: x => x.ProductID,
                        principalTable: "TProducts",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TProductSpecials",
                columns: table => new
                {
                    ProductSpecialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductSpecial", x => x.ProductSpecialID);
                    table.ForeignKey(
                        name: "FK_TProductSpecial_TProduct",
                        column: x => x.ProductID,
                        principalTable: "TProducts",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TProductToCategories",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CategoryID = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductToCategory", x => new { x.ProductID, x.CategoryID });
                    table.ForeignKey(
                        name: "FK_TProductToCategory_TProduct",
                        column: x => x.ProductID,
                        principalTable: "TProducts",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TProductToCategory_TProductCategory",
                        column: x => x.CategoryID,
                        principalTable: "TProductCategories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TProductToDownloads",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DownloadID = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductToDownload", x => new { x.ProductID, x.DownloadID });
                    table.ForeignKey(
                        name: "FK_TProductToDownload_TDownload",
                        column: x => x.DownloadID,
                        principalTable: "TDownloads",
                        principalColumn: "DownloadID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TProductToDownload_TProduct",
                        column: x => x.ProductID,
                        principalTable: "TProducts",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TProductOptionDescriptions",
                columns: table => new
                {
                    ProductOptionID = table.Column<int>(type: "int", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tmp1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tmp2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tmp3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tmp4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductOptionDescription", x => new { x.ProductOptionID, x.LanguageID });
                    table.ForeignKey(
                        name: "FK_TProductOptionDescription_TProductOption",
                        column: x => x.ProductOptionID,
                        principalTable: "TProductOptions",
                        principalColumn: "ProductOptionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TProductOptionValues",
                columns: table => new
                {
                    ProductOptionValueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductOptionID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductOptionValue", x => x.ProductOptionValueID);
                    table.ForeignKey(
                        name: "FK_TProductOptionValue_TProduct",
                        column: x => x.ProductID,
                        principalTable: "TProducts",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TProductOptionValue_TProductOption",
                        column: x => x.ProductOptionID,
                        principalTable: "TProductOptions",
                        principalColumn: "ProductOptionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TProductOptionValueDescriptions",
                columns: table => new
                {
                    ProductOptionValueID = table.Column<int>(type: "int", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProductOptionValueDescription", x => new { x.ProductOptionValueID, x.LanguageID });
                    table.ForeignKey(
                        name: "FK_TProductOptionValueDescription_TProductOptionValue",
                        column: x => x.ProductOptionValueID,
                        principalTable: "TProductOptionValues",
                        principalColumn: "ProductOptionValueID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TPollOptions_PollID",
                table: "TPollOptions",
                column: "PollID");

            migrationBuilder.CreateIndex(
                name: "IX_TProductColors_ProductID",
                table: "TProductColors",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_TProductDiscounts_ProductID",
                table: "TProductDiscounts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_TProductImages_ProductID",
                table: "TProductImages",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_TProductOptions_ProductID",
                table: "TProductOptions",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_TProductOptionValues_ProductID",
                table: "TProductOptionValues",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_TProductOptionValues_ProductOptionID",
                table: "TProductOptionValues",
                column: "ProductOptionID");

            migrationBuilder.CreateIndex(
                name: "IX_TProductSpecials_ProductID",
                table: "TProductSpecials",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_TProductToCategories_CategoryID",
                table: "TProductToCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_TProductToDownloads_DownloadID",
                table: "TProductToDownloads",
                column: "DownloadID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MapAll_ID");

            migrationBuilder.DropTable(
                name: "NewLetters");

            migrationBuilder.DropTable(
                name: "TAreaMaps");

            migrationBuilder.DropTable(
                name: "TAreas");

            migrationBuilder.DropTable(
                name: "TBannerAdvDescriptions");

            migrationBuilder.DropTable(
                name: "TBannerAdvs");

            migrationBuilder.DropTable(
                name: "TComments");

            migrationBuilder.DropTable(
                name: "TCommonFiles");

            migrationBuilder.DropTable(
                name: "TConfigs");

            migrationBuilder.DropTable(
                name: "TCountries");

            migrationBuilder.DropTable(
                name: "TCouponDescriptions");

            migrationBuilder.DropTable(
                name: "TCouponProducts");

            migrationBuilder.DropTable(
                name: "TCoupons");

            migrationBuilder.DropTable(
                name: "TCurrencies");

            migrationBuilder.DropTable(
                name: "TCustomers");

            migrationBuilder.DropTable(
                name: "TDBErrLogs");

            migrationBuilder.DropTable(
                name: "TFileUploads");

            migrationBuilder.DropTable(
                name: "TLanguages");

            migrationBuilder.DropTable(
                name: "TManufacturers");

            migrationBuilder.DropTable(
                name: "TMapTerritoryAreas");

            migrationBuilder.DropTable(
                name: "TMapTypes");

            migrationBuilder.DropTable(
                name: "TMenuAdmins");

            migrationBuilder.DropTable(
                name: "TMenus");

            migrationBuilder.DropTable(
                name: "TmpProducts");

            migrationBuilder.DropTable(
                name: "TNews");

            migrationBuilder.DropTable(
                name: "TNewsCategoryDescriptions");

            migrationBuilder.DropTable(
                name: "TNewsDescriptions");

            migrationBuilder.DropTable(
                name: "TNewsSources");

            migrationBuilder.DropTable(
                name: "TNewsToCategories");

            migrationBuilder.DropTable(
                name: "TOrderProducts");

            migrationBuilder.DropTable(
                name: "TOrders");

            migrationBuilder.DropTable(
                name: "TPollOptions");

            migrationBuilder.DropTable(
                name: "TProductCarts");

            migrationBuilder.DropTable(
                name: "TProductCategoryDescriptions");

            migrationBuilder.DropTable(
                name: "TProductColors");

            migrationBuilder.DropTable(
                name: "TProductDescriptions");

            migrationBuilder.DropTable(
                name: "TProductDiscounts");

            migrationBuilder.DropTable(
                name: "TProductImages");

            migrationBuilder.DropTable(
                name: "TProductOptionDescriptions");

            migrationBuilder.DropTable(
                name: "TProductOptionValueDescriptions");

            migrationBuilder.DropTable(
                name: "TProductRelateds");

            migrationBuilder.DropTable(
                name: "TProductSizeDescriptions");

            migrationBuilder.DropTable(
                name: "TProductSizes");

            migrationBuilder.DropTable(
                name: "TProductSpecials");

            migrationBuilder.DropTable(
                name: "TProductToCategories");

            migrationBuilder.DropTable(
                name: "TProductToDownloads");

            migrationBuilder.DropTable(
                name: "TRedirectUrls");

            migrationBuilder.DropTable(
                name: "TRegions");

            migrationBuilder.DropTable(
                name: "TReviews");

            migrationBuilder.DropTable(
                name: "TSeoDescriptions");

            migrationBuilder.DropTable(
                name: "TSeos");

            migrationBuilder.DropTable(
                name: "TSettings");

            migrationBuilder.DropTable(
                name: "TStockStatuses");

            migrationBuilder.DropTable(
                name: "TTaxClasses");

            migrationBuilder.DropTable(
                name: "TTaxRates");

            migrationBuilder.DropTable(
                name: "TTerritories");

            migrationBuilder.DropTable(
                name: "TTypes");

            migrationBuilder.DropTable(
                name: "TUserMapLinks");

            migrationBuilder.DropTable(
                name: "TUserMapNews");

            migrationBuilder.DropTable(
                name: "TUserMapRoles");

            migrationBuilder.DropTable(
                name: "TUserRoleMembers");

            migrationBuilder.DropTable(
                name: "TUsers");

            migrationBuilder.DropTable(
                name: "TWeightClasses");

            migrationBuilder.DropTable(
                name: "TWeightRules");

            migrationBuilder.DropTable(
                name: "TZones");

            migrationBuilder.DropTable(
                name: "TZoneToGeoZones");

            migrationBuilder.DropTable(
                name: "UrlAliases");

            migrationBuilder.DropTable(
                name: "TNewsCategories");

            migrationBuilder.DropTable(
                name: "TPolls");

            migrationBuilder.DropTable(
                name: "TProductOptionValues");

            migrationBuilder.DropTable(
                name: "TProductCategories");

            migrationBuilder.DropTable(
                name: "TDownloads");

            migrationBuilder.DropTable(
                name: "TProductOptions");

            migrationBuilder.DropTable(
                name: "TProducts");
        }
    }
}
