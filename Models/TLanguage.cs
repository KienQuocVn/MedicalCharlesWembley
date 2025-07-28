namespace MedicalCharlesWembley.Models;

public class TLanguage
    {
        public int LanguageID { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Locale { get; set; }
        public long? Image { get; set; }
        public string? Directory { get; set; }
        public string? FileName { get; set; }
        public int? SortOrder { get; set; }
        public int Status { get; set; }
    }