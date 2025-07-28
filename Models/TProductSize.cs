namespace MedicalCharlesWembley.Models;

public class TProductSize
    {
        public long SizeID { get; set; }
        public int? ProductID { get; set; }
        public string? Keyword { get; set; }
        public long? ParentID { get; set; }
        public int? SortOrder { get; set; }
        public decimal? Price { get; set; }
    }