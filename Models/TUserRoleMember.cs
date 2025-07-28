namespace MedicalCharlesWembley.Models;

public class TUserRoleMember
    {
        public int RoleMemberID { get; set; }
        public string? RoleName { get; set; }
        public int? StartNumber { get; set; }
        public int? EndNumber { get; set; }
        public string? KeyWord { get; set; }
    }