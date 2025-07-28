namespace MedicalCharlesWembley.Models;

public class TMenuAdmin
    {
        public int MenuID { get; set; }
        public string? MenuName { get; set; }
        public string? Link { get; set; }
        public int? MenuType { get; set; }
        public string? Option1 { get; set; }
        public int? Option2 { get; set; }
        public bool? Option3 { get; set; }
    }