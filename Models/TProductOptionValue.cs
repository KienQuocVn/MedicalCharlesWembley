namespace MedicalCharlesWembley.Models;

public class TProductOptionValue
    {
        public int ProductOptionValueID { get; set; }
        public int ProductOptionID { get; set; }
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public char Prefix { get; set; }
        public int SortOrder { get; set; }
        public TProduct? TProduct { get; set; }
        public TProductOption? TProductOption { get; set; }
    }