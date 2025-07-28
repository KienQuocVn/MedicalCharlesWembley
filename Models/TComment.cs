namespace MedicalCharlesWembley.Models;
public class TComment
    {
        public long CommentID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Title { get; set; }
        public string? Comment_Content { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? UserID { get; set; }
        public long? ID_Ref { get; set; }
        public long? Ref_Type { get; set; }
        public int? Status { get; set; }
        public string? UniqueKey { get; set; }
        public long? Parent { get; set; }
        public string? str01 { get; set; }
    }