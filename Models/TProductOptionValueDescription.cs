namespace MedicalCharlesWembley.Models;

public class TProductOptionValueDescription
    {
        public int ProductOptionValueID { get; set; }
        public int LanguageID { get; set; }
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public TProductOptionValue? TProductOptionValue { get; set; }
    }