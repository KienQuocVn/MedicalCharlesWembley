namespace MedicalCharlesWembley.Models;

public class TCouponDescription
    {
        public int coupon_id { get; set; }
        public int language_id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
    }