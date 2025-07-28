namespace MedicalCharlesWembley.Models;

public class TCoupon
    {
        public int coupon_id { get; set; }
        public string? code { get; set; }
        public char type { get; set; }
        public decimal discount { get; set; }
        public int shipping { get; set; }
        public decimal total { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_end { get; set; }
        public int uses_total { get; set; }
        public string? uses_customer { get; set; }
        public int status { get; set; }
        public DateTime date_added { get; set; }
    }