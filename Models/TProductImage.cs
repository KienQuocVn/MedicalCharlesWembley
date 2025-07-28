namespace MedicalCharlesWembley.Models
{
    public class TProductImage
    {
        public long ProductImageID { get; set; }
        public int ProductID { get; set; }
        public int? TempID1 { get; set; }
        public int? TempID2 { get; set; }
        public string? ImageLink { get; set; }
        public TProduct? TProduct { get; set; }
    }
}