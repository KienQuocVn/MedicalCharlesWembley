namespace MedicalCharlesWembley.Models;
public class TCommonFile
    {
        public long CommonFileID { get; set; }
        public string? RealFileName { get; set; }
        public string? ServerFileName { get; set; }
        public string? ServerFilePath { get; set; }
        public int FileSize { get; set; }
        public string? MimeType { get; set; }
        public DateTime RegDate { get; set; }
    }