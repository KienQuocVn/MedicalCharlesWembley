namespace MedicalCharlesWembley.Models;

public class TMenu
    {
        public int Menu_ID { get; set; }
        public string? Name { get; set; }
        public int Type { get; set; }
        public long? Map_ID { get; set; }
        public int Status { get; set; }
        public bool Require_Login { get; set; }
        public int Sort_Order { get; set; }
        public int Parent_ID { get; set; }
        public string? Keyword { get; set; }
        public string? Alias_Url { get; set; }
        public DateTime Reg_Date { get; set; }
        public DateTime Update_Date { get; set; }
        public int Reg_User { get; set; }
        public int Modify_User { get; set; }
        public string? Image { get; set; }
        public string? Option_1 { get; set; }
        public string? Option_2 { get; set; }
        public string? Option_3 { get; set; }
        public string? Option_4 { get; set; }
        public string? Option_5 { get; set; }
        public string? Option_6 { get; set; }
        public string? Name_2 { get; set; }
        public string? Name_3 { get; set; }
    }