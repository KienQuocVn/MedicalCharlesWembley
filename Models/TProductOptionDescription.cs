namespace MedicalCharlesWembley.Models;

public class TProductOptionDescription
    {
        public int ProductOptionID { get; set; }
        public int LanguageID { get; set; }
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public string? Tmp1 { get; set; }
        public string? Tmp2 { get; set; }
        public string? Tmp3 { get; set; }
        public string? Tmp4 { get; set; }
        public TProductOption? TProductOption { get; set; }
    }