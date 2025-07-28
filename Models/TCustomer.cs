namespace MedicalCharlesWembley.Models;

public class TCustomer
    {
        public int customer_id { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? email { get; set; }
        public string? telephone { get; set; }
        public string? fax { get; set; }
        public string? password { get; set; }
        public string? cart { get; set; }
        public int newsletter { get; set; }
        public int address_id { get; set; }
        public int status { get; set; }
        public string? ip { get; set; }
        public DateTime date_added { get; set; }
    }