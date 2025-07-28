namespace MedicalCharlesWembley.Models;
public class TProductColor
{
    public int ProductColorID { get; set; }
    public int ProductID { get; set; }
    public string? Name_VN { get; set; }
    public string? Name_EN { get; set; }
    public string? Name_CN { get; set; }
    public string? Ma_Mau { get; set; }
    public string? Hinh_Anh { get; set; }
    public int? Sort_Order { get; set; }
    public decimal Price { get; set; }
    public TProduct? TProduct { get; set; }
}