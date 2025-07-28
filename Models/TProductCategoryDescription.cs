namespace MedicalCharlesWembley.Models;

public class TProductCategoryDescription
    {
        public int CategoryID { get; set; }
        public int LanguageID { get; set; }
        public string? Name { get; set; }
        public string? MetaDescription { get; set; }
        public string? Description { get; set; }
    }