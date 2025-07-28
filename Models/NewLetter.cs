namespace MedicalCharlesWembley.Models;

public class NewLetter
{
    public long NewLetterID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Gender { get; set; }
    public int? Status { get; set; }
    public string? Content { get; set; }
    public DateTime? AddDate { get; set; }
    public long? AddByUserID { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public long? ModifiedByUserID { get; set; }
    public string? Opt1 { get; set; }
    public string? Opt2 { get; set; }
    public string? Opt3 { get; set; }
}