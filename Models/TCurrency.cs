namespace MedicalCharlesWembley.Models;

public class TCurrency
    {
        public int CurrencyID { get; set; }
        public string? Title { get; set; }
        public string? Code { get; set; }
        public string? SymbolLeft { get; set; }
        public string? SymbolRight { get; set; }
        public char? DecimalPlace { get; set; }
        public float? Value { get; set; }
        public int Status { get; set; }
        public DateTime ModifyDate { get; set; }
    }