namespace MedicalCharlesWembley.Models;

public class TProductSpecial
    {
        public int ProductSpecialID { get; set; }
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TProduct? TProduct { get; set; }
    }