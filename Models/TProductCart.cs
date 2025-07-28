namespace MedicalCharlesWembley.Models;

public class TProductCart
    {
        public long CartID { get; set; }
        public int? ProductID { get; set; }
        public int? So_luong { get; set; }
        public float? price { get; set; }
        public int? nguoi_muaID { get; set; }
        public int? status { get; set; }
        public DateTime? CreateDate { get; set; }
    }