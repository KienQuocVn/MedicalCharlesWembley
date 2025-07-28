namespace MedicalCharlesWembley.Models;

public class TProductDescription
    {
        public int ProductID { get; set; }
        public int LanguageID { get; set; }
        public string? Name { get; set; }
        public string? MetaDescription { get; set; }
        public string? Description { get; set; }
        public string? Des1 { get; set; }
        public string? Des2 { get; set; }
        public string? Des3 { get; set; }
        public string? Des4 { get; set; }
        public string? Des5 { get; set; }
        public string? Des6 { get; set; }
        public TProduct? TProduct { get; set; }
    }