namespace MedicalCharlesWembley.Models;

public class TProductOption
    {
        public int ProductOptionID { get; set; }
        public int ProductID { get; set; }
        public int SortOrder { get; set; }
        public long? Img { get; set; }
        public TProduct? TProduct { get; set; }
    }