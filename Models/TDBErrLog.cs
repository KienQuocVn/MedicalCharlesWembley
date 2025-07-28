namespace MedicalCharlesWembley.Models;

public class TDBErrLog
    {
        public long ErrorLogID { get; set; }
        public string? content { get; set; }
        public int ErrorNumber { get; set; }
        public int ErrorSeverity { get; set; }
        public int ErrorState { get; set; }
        public string? ErrorProcedure { get; set; }
        public int ErrorLine { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime RegDate { get; set; }
    }