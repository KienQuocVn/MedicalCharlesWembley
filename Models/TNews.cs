namespace MedicalCharlesWembley.Models;

public class TNews
    {
        public long NewsID { get; set; }
        public int? NewsSourceID { get; set; }
        public string? Author { get; set; }
        public int? NewsStatus { get; set; }
        public long? DefaultPic { get; set; }
        public int? CountView { get; set; }
        public DateTime? DateMng { get; set; }
        public string? IPAdd { get; set; }
        public DateTime? RegDate { get; set; }
        public int? RegUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyUser { get; set; }
        public long? NewsLike { get; set; }
        public int? SortOrder { get; set; }
        public string? Alias_Url { get; set; }
        public string? Str1 { get; set; }
        public string? Str2 { get; set; }
        public string? Str3 { get; set; }
        public string? Str4 { get; set; }
        public string? Str5 { get; set; }
        public string? Str6 { get; set; }
        public string? Old_Img_Url { get; set; }
        public string? Old_Post_Type { get; set; }
    }