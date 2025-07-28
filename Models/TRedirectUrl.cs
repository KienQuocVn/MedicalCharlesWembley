namespace MedicalCharlesWembley.Models;

public class TRedirectUrl
    {
        public int ID { get; set; }
        public string? From_Link { get; set; }
        public string? To_Link { get; set; }
        public string? Type { get; set; }
        public DateTime LastUpdate { get; set; }
        public string? Module { get; set; }
    }