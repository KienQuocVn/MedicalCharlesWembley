namespace MedicalCharlesWembley.Models;

public class TOrder
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string? Address { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public int PaymentMethod { get; set; }
        public string? Note { get; set; }
        public decimal Total { get; set; }
        public int Status { get; set; }
        public int CouponID { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime RegDate { get; set; }
        public string? IP { get; set; }
    }