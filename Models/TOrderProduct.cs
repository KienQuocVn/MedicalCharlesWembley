namespace MedicalCharlesWembley.Models;

public class TOrderProduct
    {
        public int OrderProductID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public string? Model { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public int Quantity { get; set; }
        public int? Status { get; set; }
    }