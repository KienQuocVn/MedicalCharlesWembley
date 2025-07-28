namespace MedicalCharlesWembley.Models;

public class TNewsCategory
    {
        public int NewsCategoryID { get; set; }
        public int? ParentID { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsView { get; set; }
        public long? Image { get; set; }
        public string? UniqueKey { get; set; }
        public string? Alias_Url { get; set; }
        public string? Keyword { get; set; }
    }