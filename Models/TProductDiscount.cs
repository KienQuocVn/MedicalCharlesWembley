namespace MedicalCharlesWembley.Models;

public class TProductDiscount
    {
        public int ProductDiscountID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public TProduct? TProduct { get; set; }
    }