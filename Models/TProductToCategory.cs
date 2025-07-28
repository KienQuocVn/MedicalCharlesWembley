namespace MedicalCharlesWembley.Models;

public class TProductToCategory
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public TProduct? TProduct { get; set; }
        public TProductCategory? TProductCategory { get; set; }
    }