namespace MedicalCharlesWembley.Models;

public class TTaxClass
    {
        public int TaxClassID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }