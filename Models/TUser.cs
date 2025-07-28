namespace MedicalCharlesWembley.Models;

public class TUser
    {
        public int UserID { get; set; }
        public string? LoginID { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? CompanyName { get; set; }
        public bool? IsExpire { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? Remark { get; set; }
        public DateTime? RegDate { get; set; }
        public int? RegUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyUser { get; set; }
        public string? PermissionString { get; set; }
        public int? UserType { get; set; }
        public DateTime? Brithday { get; set; }
        public string? YahooID { get; set; }
        public int? Tilly { get; set; }
        public long? UserLike { get; set; }
    }