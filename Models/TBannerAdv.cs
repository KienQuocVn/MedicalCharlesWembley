namespace MedicalCharlesWembley.Models;

public class TBannerAdv
    {
        public int BannerID { get; set; }
        public string? Url { get; set; }
        public long? FileID { get; set; }
        public long? FileID1 { get; set; }
        public int? Position { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegDate { get; set; }
        public int? SortOrder { get; set; }
        public string? KeyWord { get; set; }
        public string? Str1 { get; set; }
        public string? Str2 { get; set; }
        public string? Str3 { get; set; }
    }