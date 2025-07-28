namespace MedicalCharlesWembley.Models;

public class TProductCategory
{
    public int CategoryID { get; set; }
    public string? Keyword { get; set; }
    public long? Image { get; set; }        
    public int Status { get; set; }
    public int? ParentID { get; set; }
    public int? SortOrder { get; set; }
    public DateTime? RegDate { get; set; }
    public DateTime? ModifyDate { get; set; }
    public string? Alias_Url { get; set; }
    public long? Banner { get; set; }        
    public string? Str1 { get; set; }
    public string? Str2 { get; set; }
    public string? Str3 { get; set; }
    public string? Str4 { get; set; }
}
