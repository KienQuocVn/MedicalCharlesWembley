namespace MedicalCharlesWembley.Models;

public class TUserMapLink
    {
        public long MapLinkID { get; set; }
        public int? UserID { get; set; }
        public int? LinkID { get; set; }
        public string? Option1 { get; set; }
        public string? Option2 { get; set; }
        public int? MenuID { get; set; }
    }