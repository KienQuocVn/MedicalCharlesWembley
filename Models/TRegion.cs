namespace MedicalCharlesWembley.Models;

public class TRegion
    {
        public int RegionID { get; set; }
        public string? RegionName { get; set; }
        public int? ParentID { get; set; }
        public int? FMID { get; set; }
        public int? SortOrder { get; set; }
        public int? Status { get; set; }
    }