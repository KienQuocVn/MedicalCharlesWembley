namespace MedicalCharlesWembley.Models;

public class TNewsCategoryDescription
    {
        public int NewsCategoryID { get; set; }
        public int LanguageID { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public string? SubDescription { get; set; }
        public TNewsCategory? TNewsCategory { get; set; }
    }