namespace MedicalCharlesWembley.Models;

public class TFileUpload
    {
        public long UploadFileID { get; set; }
        public string? FileName { get; set; }
        public string? ConvertFileName { get; set; }
        public string? ServerFilePath { get; set; }
        public string? KeyWord { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Title { get; set; }
    }