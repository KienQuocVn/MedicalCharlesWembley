namespace MedicalCharlesWembley.Models;

public class TTaxRate
    {
        public int tax_rate_id { get; set; }
        public int geo_zone_id { get; set; }
        public int tax_class_id { get; set; }
        public int? priority { get; set; }
        public decimal rate { get; set; }
        public string? description { get; set; }
        public DateTime date_modified { get; set; }
        public DateTime date_added { get; set; }
    }