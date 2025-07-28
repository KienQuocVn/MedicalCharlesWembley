namespace MedicalCharlesWembley.Models;

public class TNewsDescription
    {
        public long NewsID { get; set; }
        public int LanguageID { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? SubTitle { get; set; }
        public string? SubContent { get; set; }
        public string? Comment { get; set; }
    }