namespace MedicalCharlesWembley.Models;

public class TType
    {
        public int TypeID { get; set; }
        public string? TypeName { get; set; }
        public int? TypeParent { get; set; }
        public string? Keyword { get; set; }
        public int? status { get; set; }
        public string? TypeKeyword { get; set; }
    }