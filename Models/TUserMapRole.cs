namespace MedicalCharlesWembley.Models;

public class TUserMapRole
    {
        public int UserMapRoleID { get; set; }
        public int? RoleMemberID { get; set; }
        public int? UserID { get; set; }
    }