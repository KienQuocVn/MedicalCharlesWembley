namespace MedicalCharlesWembley.Models;

public class TProductRelated
    {
        public int ProductID { get; set; }
        public int RelatedID { get; set; }
        public TProduct? TProduct { get; set; }
        public TProduct? TRelatedProduct { get; set; }
    }