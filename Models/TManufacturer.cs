namespace MedicalCharlesWembley.Models;

public class TManufacturer
    {
        public int ManufacturerID { get; set; }
        public string? Name { get; set; }
        public string? Keyword { get; set; }
        public long Image { get; set; }
        public int SortOrder { get; set; }
    }