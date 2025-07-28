namespace MedicalCharlesWembley.Models;

public class MapAllID
{
    public long Id { get; set; } // Thuộc tính khóa chính
    public long? MapID { get; set; }
    public long? MapProduct { get; set; }
    public string? KeyWord { get; set; }
    public int thu_tu { get; set; }
}