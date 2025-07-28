namespace MedicalCharlesWembley.Models
{
    public class TProduct
    {
        public int ProductID { get; set; }
        public string? Model { get; set; }
        public string? Keyword { get; set; }
        public int Quantity { get; set; }
        public int? StockStatusID { get; set; }
        public long? Image { get; set; } 
        public int ManufacturerID { get; set; }
        public bool Shipping { get; set; }
        public decimal Price { get; set; }
        public int? TaxClassID { get; set; }
        public DateTime? DateAvailable { get; set; }
        public decimal Weight { get; set; }
        public int WeightClassID { get; set; }
        public int? SortOrder { get; set; }
        public bool Status { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int CountView { get; set; }
        public int? CurrencyID { get; set; }
        public string? Price_Text { get; set; }
        public string? Price_Text_Bef { get; set; }
        public string? str1 { get; set; }
        public string? str2 { get; set; }
        public string? str3 { get; set; }
        public string? str4 { get; set; }
        public string? str5 { get; set; }
        public string? str6 { get; set; }
        public string? str7 { get; set; }
        public string? str8 { get; set; }
        public bool? ProNew { get; set; }
        public bool? ProSale { get; set; }
        public string? Alias_Url { get; set; }
    }
}